namespace SkladUI
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
            dataGridView = new DataGridView();
            Disconnection = new Button();
            button1 = new Button();
            Execute = new Button();
            queryBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 68);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(586, 370);
            dataGridView.TabIndex = 0;
            // 
            // Disconnection
            // 
            Disconnection.Location = new Point(646, 393);
            Disconnection.Name = "Disconnection";
            Disconnection.Size = new Size(94, 29);
            Disconnection.TabIndex = 1;
            Disconnection.Text = "Disconnect";
            Disconnection.UseVisualStyleBackColor = true;
            Disconnection.Click += Disconnection_Click;
            // 
            // button1
            // 
            button1.Location = new Point(646, 358);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Connect";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Connection_Click;
            // 
            // Execute
            // 
            Execute.Location = new Point(646, 21);
            Execute.Name = "Execute";
            Execute.Size = new Size(94, 29);
            Execute.TabIndex = 4;
            Execute.Text = "Execute";
            Execute.UseVisualStyleBackColor = true;
            Execute.Click += Execute_Click;
            // 
            // queryBox
            // 
            queryBox.FormattingEnabled = true;
            queryBox.Location = new Point(12, 22);
            queryBox.Name = "queryBox";
            queryBox.Size = new Size(586, 28);
            queryBox.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(queryBox);
            Controls.Add(Execute);
            Controls.Add(button1);
            Controls.Add(Disconnection);
            Controls.Add(dataGridView);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView;
        private Button Disconnection;
        private Button button1;
        private Button Execute;
        private ComboBox queryBox;
    }
}
