namespace Hello_World
{
    partial class Counter
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("標楷體", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(109, 149);
            label1.Name = "label1";
            label1.Size = new Size(36, 37);
            label1.TabIndex = 3;
            label1.Text = "0";
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button1.Location = new Point(81, 78);
            button1.Name = "button1";
            button1.Size = new Size(111, 42);
            button1.TabIndex = 2;
            button1.Text = "Count";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // timer1
            // 
            // 
            // Howtodemo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 276);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "HowToDemo";
            Text = "HowToDemo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}