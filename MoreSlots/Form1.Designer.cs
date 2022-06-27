namespace MoreSlots
{
    partial class MainWin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.selectGameComboBox = new System.Windows.Forms.ComboBox();
            this.deleteGameButton = new System.Windows.Forms.Button();
            this.gameControlPanel = new System.Windows.Forms.Panel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.pathLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.addGameButton = new System.Windows.Forms.Button();
            this.slotControlPanel = new System.Windows.Forms.Panel();
            this.loadSlotButton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.saveSlotButton = new System.Windows.Forms.Button();
            this.slotSelectionPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.clearSlotButton = new System.Windows.Forms.Button();
            this.gameControlPanel.SuspendLayout();
            this.slotControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectGameComboBox
            // 
            this.selectGameComboBox.FormattingEnabled = true;
            this.selectGameComboBox.Location = new System.Drawing.Point(9, 3);
            this.selectGameComboBox.Name = "selectGameComboBox";
            this.selectGameComboBox.Size = new System.Drawing.Size(242, 21);
            this.selectGameComboBox.TabIndex = 0;
            this.selectGameComboBox.SelectionChangeCommitted += new System.EventHandler(this.selectGameComboBox_SelectionChangeCommitted);
            // 
            // deleteGameButton
            // 
            this.deleteGameButton.Location = new System.Drawing.Point(197, 61);
            this.deleteGameButton.Name = "deleteGameButton";
            this.deleteGameButton.Size = new System.Drawing.Size(54, 21);
            this.deleteGameButton.TabIndex = 1;
            this.deleteGameButton.Text = "Delete";
            this.deleteGameButton.UseVisualStyleBackColor = true;
            this.deleteGameButton.Click += new System.EventHandler(this.deleteGameButton_Click);
            // 
            // gameControlPanel
            // 
            this.gameControlPanel.Controls.Add(this.nameLabel);
            this.gameControlPanel.Controls.Add(this.pathLabel);
            this.gameControlPanel.Controls.Add(this.nameTextBox);
            this.gameControlPanel.Controls.Add(this.pathTextBox);
            this.gameControlPanel.Controls.Add(this.deleteGameButton);
            this.gameControlPanel.Controls.Add(this.addGameButton);
            this.gameControlPanel.Location = new System.Drawing.Point(3, 6);
            this.gameControlPanel.Name = "gameControlPanel";
            this.gameControlPanel.Size = new System.Drawing.Size(258, 90);
            this.gameControlPanel.TabIndex = 2;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(3, 12);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Name:";
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(9, 38);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(32, 13);
            this.pathLabel.TabIndex = 3;
            this.pathLabel.Text = "Path:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(44, 9);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(207, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(44, 35);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(207, 20);
            this.pathTextBox.TabIndex = 2;
            // 
            // addGameButton
            // 
            this.addGameButton.Location = new System.Drawing.Point(137, 61);
            this.addGameButton.Name = "addGameButton";
            this.addGameButton.Size = new System.Drawing.Size(54, 21);
            this.addGameButton.TabIndex = 1;
            this.addGameButton.Text = "Add";
            this.addGameButton.UseVisualStyleBackColor = true;
            this.addGameButton.Click += new System.EventHandler(this.addGameButton_Click);
            // 
            // slotControlPanel
            // 
            this.slotControlPanel.Controls.Add(this.clearSlotButton);
            this.slotControlPanel.Controls.Add(this.loadSlotButton);
            this.slotControlPanel.Controls.Add(this.infoLabel);
            this.slotControlPanel.Controls.Add(this.saveSlotButton);
            this.slotControlPanel.Controls.Add(this.selectGameComboBox);
            this.slotControlPanel.Controls.Add(this.slotSelectionPanel);
            this.slotControlPanel.Location = new System.Drawing.Point(3, 102);
            this.slotControlPanel.Name = "slotControlPanel";
            this.slotControlPanel.Size = new System.Drawing.Size(258, 236);
            this.slotControlPanel.TabIndex = 3;
            // 
            // loadSlotButton
            // 
            this.loadSlotButton.Location = new System.Drawing.Point(197, 180);
            this.loadSlotButton.Name = "loadSlotButton";
            this.loadSlotButton.Size = new System.Drawing.Size(54, 21);
            this.loadSlotButton.TabIndex = 1;
            this.loadSlotButton.Text = "Load";
            this.loadSlotButton.UseVisualStyleBackColor = true;
            this.loadSlotButton.Click += new System.EventHandler(this.loadSlotButton_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoLabel.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.infoLabel.Location = new System.Drawing.Point(197, 30);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(54, 120);
            this.infoLabel.TabIndex = 2;
            this.infoLabel.Text = "Select a game and then select a save you want to load.";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saveSlotButton
            // 
            this.saveSlotButton.Location = new System.Drawing.Point(197, 153);
            this.saveSlotButton.Name = "saveSlotButton";
            this.saveSlotButton.Size = new System.Drawing.Size(54, 21);
            this.saveSlotButton.TabIndex = 1;
            this.saveSlotButton.Text = "Save";
            this.saveSlotButton.UseVisualStyleBackColor = true;
            this.saveSlotButton.Click += new System.EventHandler(this.saveSlotButton_Click);
            // 
            // slotSelectionPanel
            // 
            this.slotSelectionPanel.AutoScroll = true;
            this.slotSelectionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.slotSelectionPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.slotSelectionPanel.Location = new System.Drawing.Point(9, 30);
            this.slotSelectionPanel.Name = "slotSelectionPanel";
            this.slotSelectionPanel.Size = new System.Drawing.Size(182, 198);
            this.slotSelectionPanel.TabIndex = 0;
            this.slotSelectionPanel.WrapContents = false;
            // 
            // clearSlotButton
            // 
            this.clearSlotButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.clearSlotButton.Location = new System.Drawing.Point(197, 207);
            this.clearSlotButton.Name = "clearSlotButton";
            this.clearSlotButton.Size = new System.Drawing.Size(54, 21);
            this.clearSlotButton.TabIndex = 1;
            this.clearSlotButton.Text = "Clear";
            this.clearSlotButton.UseVisualStyleBackColor = true;
            this.clearSlotButton.Click += new System.EventHandler(this.clearSlotButton_Click);
            // 
            // MainWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 345);
            this.Controls.Add(this.slotControlPanel);
            this.Controls.Add(this.gameControlPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainWin";
            this.Text = "MoreSlots";
            this.Load += new System.EventHandler(this.MainWin_Load);
            this.gameControlPanel.ResumeLayout(false);
            this.gameControlPanel.PerformLayout();
            this.slotControlPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox selectGameComboBox;
        private System.Windows.Forms.Button deleteGameButton;
        private System.Windows.Forms.Panel gameControlPanel;
        private System.Windows.Forms.Panel slotControlPanel;
        private System.Windows.Forms.Button addGameButton;
        private System.Windows.Forms.Button saveSlotButton;
        private System.Windows.Forms.FlowLayoutPanel slotSelectionPanel;
        private System.Windows.Forms.Button loadSlotButton;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button clearSlotButton;
    }
}

