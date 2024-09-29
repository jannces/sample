namespace IntroToControlEvents2
{
    partial class frm_event
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
            btn_hello = new Button();
            btn_exit = new Button();
            SuspendLayout();
            // 
            // btn_hello
            // 
            btn_hello.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_hello.Location = new Point(240, 245);
            btn_hello.Name = "btn_hello";
            btn_hello.Size = new Size(144, 58);
            btn_hello.TabIndex = 0;
            btn_hello.Text = "Hello";
            btn_hello.UseVisualStyleBackColor = true;
            btn_hello.Click += btn_hello_Click;
            // 
            // btn_exit
            // 
            btn_exit.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_exit.Location = new Point(404, 245);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(144, 58);
            btn_exit.TabIndex = 1;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // frm_event
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_exit);
            Controls.Add(btn_hello);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frm_event";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Working With Events";
            Load += frm_event_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_hello;
        private Button btn_exit;
    }
}
