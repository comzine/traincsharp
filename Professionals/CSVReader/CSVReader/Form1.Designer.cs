namespace CSVReader
{
    partial class Form1
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
            tbxFilepath = new TextBox();
            btnOpen = new Button();
            btnAnalyze = new Button();
            btnExit = new Button();
            openFileDialog1 = new OpenFileDialog();
            tbxContent = new TextBox();
            tbxMeasurements = new TextBox();
            tbxAverageDuration = new TextBox();
            SuspendLayout();
            // 
            // tbxFilepath
            // 
            tbxFilepath.Location = new Point(12, 12);
            tbxFilepath.Name = "tbxFilepath";
            tbxFilepath.Size = new Size(786, 39);
            tbxFilepath.TabIndex = 0;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(12, 57);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(258, 88);
            btnOpen.TabIndex = 1;
            btnOpen.Text = "Oeffnen";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnAnalyze
            // 
            btnAnalyze.Location = new Point(276, 57);
            btnAnalyze.Name = "btnAnalyze";
            btnAnalyze.Size = new Size(258, 88);
            btnAnalyze.TabIndex = 2;
            btnAnalyze.Text = "Auswerten";
            btnAnalyze.UseVisualStyleBackColor = true;
            btnAnalyze.Click += btnAnalyze_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(540, 57);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(258, 88);
            btnExit.TabIndex = 3;
            btnExit.Text = "Beenden";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // tbxContent
            // 
            tbxContent.Location = new Point(12, 168);
            tbxContent.Multiline = true;
            tbxContent.Name = "tbxContent";
            tbxContent.Size = new Size(745, 448);
            tbxContent.TabIndex = 4;
            // 
            // tbxMeasurements
            // 
            tbxMeasurements.Location = new Point(38, 686);
            tbxMeasurements.Name = "tbxMeasurements";
            tbxMeasurements.Size = new Size(200, 39);
            tbxMeasurements.TabIndex = 5;
            // 
            // tbxAverageDuration
            // 
            tbxAverageDuration.Location = new Point(380, 686);
            tbxAverageDuration.Name = "tbxAverageDuration";
            tbxAverageDuration.Size = new Size(200, 39);
            tbxAverageDuration.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 776);
            Controls.Add(tbxAverageDuration);
            Controls.Add(tbxMeasurements);
            Controls.Add(tbxContent);
            Controls.Add(btnExit);
            Controls.Add(btnAnalyze);
            Controls.Add(btnOpen);
            Controls.Add(tbxFilepath);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxFilepath;
        private Button btnOpen;
        private Button btnAnalyze;
        private Button btnExit;
        private OpenFileDialog openFileDialog1;
        private TextBox tbxContent;
        private TextBox tbxMeasurements;
        private TextBox tbxAverageDuration;
    }
}
