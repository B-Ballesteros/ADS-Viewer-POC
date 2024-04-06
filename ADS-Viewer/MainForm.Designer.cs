namespace ADS_Viewer
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            fileGroupBox = new GroupBox();
            fileSelectButton = new Button();
            fileSelectTextBox = new TextBox();
            logGroupBox = new GroupBox();
            logTextBox = new TextBox();
            processButton = new Button();
            fileGroupBox.SuspendLayout();
            logGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // fileGroupBox
            // 
            fileGroupBox.Controls.Add(fileSelectButton);
            fileGroupBox.Controls.Add(fileSelectTextBox);
            fileGroupBox.Location = new Point(12, 12);
            fileGroupBox.Name = "fileGroupBox";
            fileGroupBox.Size = new Size(760, 64);
            fileGroupBox.TabIndex = 0;
            fileGroupBox.TabStop = false;
            fileGroupBox.Text = "SelectFile";
            // 
            // fileSelectButton
            // 
            fileSelectButton.Location = new Point(679, 22);
            fileSelectButton.Name = "fileSelectButton";
            fileSelectButton.Size = new Size(75, 23);
            fileSelectButton.TabIndex = 1;
            fileSelectButton.Text = "...";
            fileSelectButton.UseVisualStyleBackColor = true;
            fileSelectButton.Click += SelectButton_Clic;
            // 
            // fileSelectTextBox
            // 
            fileSelectTextBox.Location = new Point(6, 22);
            fileSelectTextBox.Name = "fileSelectTextBox";
            fileSelectTextBox.ReadOnly = true;
            fileSelectTextBox.Size = new Size(667, 23);
            fileSelectTextBox.TabIndex = 0;
            // 
            // logGroupBox
            // 
            logGroupBox.Controls.Add(logTextBox);
            logGroupBox.Location = new Point(12, 111);
            logGroupBox.Name = "logGroupBox";
            logGroupBox.Size = new Size(760, 438);
            logGroupBox.TabIndex = 1;
            logGroupBox.TabStop = false;
            logGroupBox.Text = "Log";
            // 
            // logTextBox
            // 
            logTextBox.Dock = DockStyle.Fill;
            logTextBox.Location = new Point(3, 19);
            logTextBox.Multiline = true;
            logTextBox.Name = "logTextBox";
            logTextBox.ReadOnly = true;
            logTextBox.Size = new Size(754, 416);
            logTextBox.TabIndex = 0;
            // 
            // processButton
            // 
            processButton.Location = new Point(691, 82);
            processButton.Name = "processButton";
            processButton.Size = new Size(75, 23);
            processButton.TabIndex = 2;
            processButton.Text = "Process";
            processButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(processButton);
            Controls.Add(logGroupBox);
            Controls.Add(fileGroupBox);
            Name = "MainForm";
            Text = "ADS-Viewer";
            fileGroupBox.ResumeLayout(false);
            fileGroupBox.PerformLayout();
            logGroupBox.ResumeLayout(false);
            logGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox fileGroupBox;
        private Button fileSelectButton;
        private TextBox fileSelectTextBox;
        private GroupBox logGroupBox;
        private TextBox logTextBox;
        private Button processButton;
    }
}
