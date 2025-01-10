namespace BarlangokGUI
{
    partial class FrmMain
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
            label1 = new Label();
            textBox1 = new TextBox();
            nameLbl = new Label();
            label3 = new Label();
            idTbx = new TextBox();
            lengthTbx = new TextBox();
            label4 = new Label();
            depthTbx = new TextBox();
            searchBtn = new Button();
            saveBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Azonosító:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(81, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // nameLbl
            // 
            nameLbl.AutoSize = true;
            nameLbl.Location = new Point(12, 50);
            nameLbl.Name = "nameLbl";
            nameLbl.Size = new Size(81, 15);
            nameLbl.TabIndex = 0;
            nameLbl.Text = "Barlang neve: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 86);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 0;
            label3.Text = "Hosszúság:";
            // 
            // idTbx
            // 
            idTbx.Location = new Point(81, 12);
            idTbx.Name = "idTbx";
            idTbx.Size = new Size(100, 23);
            idTbx.TabIndex = 1;
            // 
            // lengthTbx
            // 
            lengthTbx.Enabled = false;
            lengthTbx.Location = new Point(81, 83);
            lengthTbx.Name = "lengthTbx";
            lengthTbx.Size = new Size(100, 23);
            lengthTbx.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 115);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 0;
            label4.Text = "Mélység";
            // 
            // depthTbx
            // 
            depthTbx.Enabled = false;
            depthTbx.Location = new Point(81, 112);
            depthTbx.Name = "depthTbx";
            depthTbx.Size = new Size(100, 23);
            depthTbx.TabIndex = 1;
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(201, 12);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(106, 23);
            searchBtn.TabIndex = 2;
            searchBtn.Text = "Barlang keresés";
            searchBtn.UseVisualStyleBackColor = true;
            // 
            // saveBtn
            // 
            saveBtn.Enabled = false;
            saveBtn.Location = new Point(201, 96);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(106, 23);
            saveBtn.TabIndex = 2;
            saveBtn.Text = "Adatok mentése";
            saveBtn.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 156);
            Controls.Add(saveBtn);
            Controls.Add(searchBtn);
            Controls.Add(depthTbx);
            Controls.Add(lengthTbx);
            Controls.Add(idTbx);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(nameLbl);
            Controls.Add(label1);
            Name = "FrmMain";
            Text = "Barlangok";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label nameLbl;
        private Label label3;
        private TextBox idTbx;
        private TextBox lengthTbx;
        private Label label4;
        private TextBox depthTbx;
        private Button searchBtn;
        private Button saveBtn;
    }
}
