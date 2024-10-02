namespace Hello_World
{
    partial class Hello
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
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("標楷體", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(45, 133);
            label1.Name = "label1";
            label1.Size = new Size(0, 24);
            label1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(60, 53);
            button1.Name = "button1";
            button1.Size = new Size(122, 43);
            button1.TabIndex = 1;
            button1.Text = "Say Hello!!!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Hello
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(245, 214);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Hello";
            Text = "Hello";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
    }
}