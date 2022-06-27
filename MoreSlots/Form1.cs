using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MoreSlots
{
    public partial class MainWin : Form
    {
        Dictionary<string, string> games = new Dictionary<string, string>();
        Button lastClickedSlot = null;
        const string gamesFile = "existing_games.txt";
        const int maxSlotCount = 10;

        public MainWin()
        {
            InitializeComponent();
        }

        private void MainWin_Load(object sender, EventArgs e)
        {
            if (File.Exists(gamesFile) == false)
                File.Create(gamesFile).Close();

            using (StreamReader file = new StreamReader(gamesFile))
            {
                int index = 0;
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    string gameName = line.Split(',')[0];
                    string gamePath = line.Split(',')[1];

                    selectGameComboBox.Items.Add(gameName);
                    games.Add(gameName, gamePath);
                    index++;
                }
            }
        }

        private void addGameButton_Click(object sender, EventArgs e)
        {
            string gameName = nameTextBox.Text;
            string gamePath = pathTextBox.Text;
            
            //If either one of the textboxes are empty, return.
            if (gameName == string.Empty || gamePath == string.Empty)
            {
                Warn("Either one of the textboxes are empty!");
                return;
            }

            //Add the game to combobox and dictionary.
            selectGameComboBox.Items.Add(gameName);
            games.Add(gameName, gamePath);
            if (File.ReadAllLines(gamesFile).Contains(gameName) == false)
                File.AppendAllText(gamesFile, gameName + "," + gamePath);

            //Create a folder for the game slots if not already exists.
            if (Directory.Exists(gameName) == false)
                Directory.CreateDirectory(gameName);

            //Clear textboxes.
            nameTextBox.Text = string.Empty;
            pathTextBox.Text = string.Empty;
        }

        private void deleteGameButton_Click(object sender, EventArgs e)
        {
            string gameName = nameTextBox.Text;

            //If the name textbox is empty or the name doesn't exist in combobox, return.
            if (gameName == string.Empty || selectGameComboBox.Items.Contains(gameName) == false)
            {
                Warn("Name textbox is empty or the name doesn't exist in combobox!");
                return;
            }

            //Remove the game from combobox and the dictionary.
            selectGameComboBox.Items.Remove(gameName);
            games.Remove(gameName);

            string tempFile = Path.GetTempFileName();

            using (var sr = new StreamReader(gamesFile))
            using (var sw = new StreamWriter(tempFile))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains(gameName) == false)
                        sw.WriteLine(line);
                }
            }

            File.Delete(gamesFile);
            File.Move(tempFile, gamesFile);

            //Clear the name textbox and combobox.
            nameTextBox.Text = string.Empty;
            selectGameComboBox.Text = string.Empty;

            //Delete the game folder and it's slots.
            ClearSlots();
            DeleteDirectory(gameName);
        }

        private void selectGameComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //Clear old previous game's slots first.
            ClearSlots();

            //Create slots for the game.
            CreateSlots(maxSlotCount);
        }

        private void slotButton_Click(object sender, EventArgs e)
        {
            //Store the last clicked button.
            lastClickedSlot = (Button) sender;
        }

        private void saveSlotButton_Click(object sender, EventArgs e)
        {
            //If no game selected or the game doesn't exist in dictionary, return.
            if (selectGameComboBox.Text == string.Empty || games.ContainsKey(selectGameComboBox.Text) == false)
            {
                Warn("No game selected or the game doesn't exist in dictionary!");
                return;
            }

            //Store the game name and it's path.
            string selectedGame = selectGameComboBox.Text;
            string selectedGamePath = games[selectedGame];

            //If no slot is clicked, return.
            if (lastClickedSlot == null)
            {
                Warn("You didn't clicked a slot!");
                return;
            }

            //If selected game's directory is empty, return.
            if (Directory.GetFiles(selectedGamePath) == null)
            {
                Warn("Selected game's directory is empty!");
                return;
            }

            //Move current save files to the last clicked slot.
            foreach (string file in Directory.GetFiles(selectedGamePath))
            {
                if (!File.Exists(selectedGame + "\\" + lastClickedSlot.Text + "\\" + Path.GetFileName(file)))
                    File.Move(file, selectedGame + "\\" + lastClickedSlot.Text + "\\" + Path.GetFileName(file));
                else
                    File.Delete(file);
            }
        }

        private void loadSlotButton_Click(object sender, EventArgs e)
        {
            //If no game selected or the game doesn't exist in dictionary, return.
            if (selectGameComboBox.Text == string.Empty || games.ContainsKey(selectGameComboBox.Text) == false)
            {
                Warn("No game selected or the game doesn't exist in dictionary!");
                return;
            }

            //Store the game name and slot's path.
            string selectedGame = selectGameComboBox.Text;
            string selectedGamePath = games[selectedGame];
            string slotPath = selectedGame + "\\" + lastClickedSlot.Text;

            //If no slot is clicked, return.
            if (lastClickedSlot == null)
            {
                Warn("You didn't clicked a slot!");
                return;
            }

            //If slot is empty, return.
            if (Directory.GetFiles(slotPath) == null)
            {
                Warn("Selected game's directory is empty!");
                return;
            }

            //Copy the files in last clicked slot to selected game's directory.
            foreach (string file in Directory.GetFiles(slotPath))
            {
                if (!File.Exists(selectedGamePath + "\\" + Path.GetFileName(file)))
                    File.Copy(file, selectedGamePath + "\\" + Path.GetFileName(file));
            }
        }
        
        private void clearSlotButton_Click(object sender, EventArgs e)
        {
            //Store the game name and slot's path.
            string selectedGame = selectGameComboBox.Text;
            string slotPath = selectedGame + "\\" + lastClickedSlot.Text;

            //If the slot is empty, return.
            if (Directory.GetFiles(slotPath) == null)
            {
                Warn("Slot is empty!");
                return;
            }

            //Delete all files in the slot.
            foreach (string file in Directory.GetFiles(slotPath))
            {
                File.Delete(file);
            }
        }

        private void ClearSlots()
        {
            //Clear slots.
            slotSelectionPanel.Controls.Clear();
        }

        private void CreateSlots(int maxSize)
        {
            string gameName = (string) selectGameComboBox.SelectedItem;
            string gamePath = games[gameName];

            //Create slots with the size of maxSize.
            for (int i = 0; i < maxSize; i++)
            {
                Button slot = new Button();
                slot.Width = slotSelectionPanel.Width - 30;
                slot.FlatStyle = FlatStyle.Flat;
                slot.Text = "Slot" + (i + 1);
                slot.Click += slotButton_Click;
                slotSelectionPanel.Controls.Add(slot);

                string slotPath = gameName + "\\" + slot.Text;

                //Create slot folders in the game folder if they don't already exist.
                if (Directory.Exists(slotPath) == false)
                    Directory.CreateDirectory(slotPath);
            }
        }

        private void FindExistingGames()
        {
            //If there are no existing games, return.
            if (Directory.GetFiles(Directory.GetCurrentDirectory()) == null)
            {
                Warn("Couldn't find any existing game folders!");
                return;
            }

            //Add existing games to the list.
            foreach (string game in Directory.GetFiles(Directory.GetCurrentDirectory()))
            {
                
            }
        }

        private void DeleteDirectory(string path)
        {
            string[] files = Directory.GetFiles(path);
            string[] dirs = Directory.GetDirectories(path);

            foreach (string file in files)
            {
                File.SetAttributes(file, FileAttributes.Normal);
                File.Delete(file);
            }

            foreach (string dir in dirs)
            {
                DeleteDirectory(dir);
            }

            Directory.Delete(path, false);
        }

        private void Warn(string warning)
        {
            Console.WriteLine("Warning: " + warning);
        }
    }
}