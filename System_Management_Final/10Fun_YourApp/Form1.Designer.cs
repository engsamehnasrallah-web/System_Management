namespace _10Fun_YourApp
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
            btnBrws = new Button();
            lblPath = new Label();
            btnCrtDir = new Button();
            txtDirName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lblFileName = new TextBox();
            btnCrtFile = new Button();
            btnOpen = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnDltDir = new Button();
            btnDltFile = new Button();
            btnMove = new Button();
            btnCopy = new Button();
            btnBrsDst = new Button();
            lblDst = new Label();
            btnRead = new Button();
            btnApnd = new Button();
            textApnd = new TextBox();
            label4 = new Label();
            btnWrte = new Button();
            textWrte = new TextBox();
            label3 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // btnBrws
            // 
            btnBrws.Location = new Point(508, 17);
            btnBrws.Name = "btnBrws";
            btnBrws.Size = new Size(218, 34);
            btnBrws.TabIndex = 0;
            btnBrws.Text = "Browse";
            btnBrws.UseVisualStyleBackColor = true;
            btnBrws.Click += button1_Click;
            // 
            // lblPath
            // 
            lblPath.AutoSize = true;
            lblPath.Location = new Point(15, 22);
            lblPath.Name = "lblPath";
            lblPath.Size = new Size(0, 25);
            lblPath.TabIndex = 1;
            // 
            // btnCrtDir
            // 
            btnCrtDir.Location = new Point(746, 67);
            btnCrtDir.Name = "btnCrtDir";
            btnCrtDir.Size = new Size(218, 34);
            btnCrtDir.TabIndex = 2;
            btnCrtDir.Text = "Create Dir Here";
            btnCrtDir.UseVisualStyleBackColor = true;
            btnCrtDir.Click += btnCrtDir_Click;
            // 
            // txtDirName
            // 
            txtDirName.Location = new Point(162, 70);
            txtDirName.Name = "txtDirName";
            txtDirName.Size = new Size(271, 31);
            txtDirName.TabIndex = 3;
            txtDirName.TextChanged += txtDirName_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 72);
            label1.Name = "label1";
            label1.Size = new Size(141, 25);
            label1.TabIndex = 4;
            label1.Text = "Enter Dir Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 126);
            label2.Name = "label2";
            label2.Size = new Size(139, 25);
            label2.TabIndex = 5;
            label2.Text = "Enter File Name:";
            // 
            // lblFileName
            // 
            lblFileName.Location = new Point(162, 120);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new Size(271, 31);
            lblFileName.TabIndex = 6;
            // 
            // btnCrtFile
            // 
            btnCrtFile.Location = new Point(746, 118);
            btnCrtFile.Name = "btnCrtFile";
            btnCrtFile.Size = new Size(218, 34);
            btnCrtFile.TabIndex = 7;
            btnCrtFile.Text = "Create File Here";
            btnCrtFile.UseVisualStyleBackColor = true;
            btnCrtFile.Click += btnCrtFile_Click;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(746, 17);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(218, 34);
            btnOpen.TabIndex = 10;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // tabControl1
            // 
            tabControl1.AccessibleName = "";
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(0, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1048, 812);
            tabControl1.TabIndex = 11;
            tabControl1.Tag = "";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnDltDir);
            tabPage1.Controls.Add(btnDltFile);
            tabPage1.Controls.Add(btnMove);
            tabPage1.Controls.Add(btnCopy);
            tabPage1.Controls.Add(btnBrsDst);
            tabPage1.Controls.Add(lblDst);
            tabPage1.Controls.Add(btnRead);
            tabPage1.Controls.Add(btnApnd);
            tabPage1.Controls.Add(textApnd);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(btnWrte);
            tabPage1.Controls.Add(textWrte);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(btnBrws);
            tabPage1.Controls.Add(btnOpen);
            tabPage1.Controls.Add(lblPath);
            tabPage1.Controls.Add(btnCrtFile);
            tabPage1.Controls.Add(btnCrtDir);
            tabPage1.Controls.Add(lblFileName);
            tabPage1.Controls.Add(txtDirName);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1040, 774);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Quick Acts";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // btnDltDir
            // 
            btnDltDir.Location = new Point(15, 405);
            btnDltDir.Name = "btnDltDir";
            btnDltDir.Size = new Size(456, 34);
            btnDltDir.TabIndex = 24;
            btnDltDir.Text = "Delete Dir";
            btnDltDir.UseVisualStyleBackColor = true;
            btnDltDir.Click += btnDltDir_Click;
            // 
            // btnDltFile
            // 
            btnDltFile.Location = new Point(508, 405);
            btnDltFile.Name = "btnDltFile";
            btnDltFile.Size = new Size(456, 34);
            btnDltFile.TabIndex = 23;
            btnDltFile.Text = "Delete File";
            btnDltFile.UseVisualStyleBackColor = true;
            btnDltFile.Click += btnDltFile_Click;
            // 
            // btnMove
            // 
            btnMove.Location = new Point(864, 344);
            btnMove.Name = "btnMove";
            btnMove.Size = new Size(100, 34);
            btnMove.TabIndex = 21;
            btnMove.Text = "Move";
            btnMove.UseVisualStyleBackColor = true;
            btnMove.Click += btnMove_Click;
            // 
            // btnCopy
            // 
            btnCopy.Location = new Point(746, 344);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(98, 34);
            btnCopy.TabIndex = 20;
            btnCopy.Text = "Copy";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // btnBrsDst
            // 
            btnBrsDst.Location = new Point(508, 344);
            btnBrsDst.Name = "btnBrsDst";
            btnBrsDst.Size = new Size(218, 34);
            btnBrsDst.TabIndex = 19;
            btnBrsDst.Text = "Browse";
            btnBrsDst.UseVisualStyleBackColor = true;
            btnBrsDst.Click += button1_Click_1;
            // 
            // lblDst
            // 
            lblDst.AutoSize = true;
            lblDst.Location = new Point(15, 353);
            lblDst.Name = "lblDst";
            lblDst.Size = new Size(0, 25);
            lblDst.TabIndex = 18;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(15, 291);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(949, 34);
            btnRead.TabIndex = 17;
            btnRead.Text = "Read File Content";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // btnApnd
            // 
            btnApnd.Location = new Point(746, 224);
            btnApnd.Name = "btnApnd";
            btnApnd.Size = new Size(218, 34);
            btnApnd.TabIndex = 16;
            btnApnd.Text = "Append";
            btnApnd.UseVisualStyleBackColor = true;
            btnApnd.Click += btnApnd_Click;
            // 
            // textApnd
            // 
            textApnd.Location = new Point(162, 226);
            textApnd.Name = "textApnd";
            textApnd.Size = new Size(271, 31);
            textApnd.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 229);
            label4.Name = "label4";
            label4.Size = new Size(122, 25);
            label4.TabIndex = 14;
            label4.Text = "Append Here:";
            // 
            // btnWrte
            // 
            btnWrte.Location = new Point(746, 170);
            btnWrte.Name = "btnWrte";
            btnWrte.Size = new Size(218, 34);
            btnWrte.TabIndex = 13;
            btnWrte.Text = "Clear Then Write";
            btnWrte.UseVisualStyleBackColor = true;
            btnWrte.Click += btnWrte_Click;
            // 
            // textWrte
            // 
            textWrte.Location = new Point(162, 172);
            textWrte.Name = "textWrte";
            textWrte.Size = new Size(271, 31);
            textWrte.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 176);
            label3.Name = "label3";
            label3.Size = new Size(100, 25);
            label3.TabIndex = 11;
            label3.Text = "Write Here:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1057, 825);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "System Manager";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnBrws;
        private Label lblPath;
        private Button btnCrtDir;
        private TextBox txtDirName;
        private Label label1;
        private Label label2;
        private TextBox lblFileName;
        private Button btnCrtFile;
        private Button btnOpen;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button btnWrte;
        private TextBox textWrte;
        private Label label3;
        private TextBox textApnd;
        private Label label4;
        private Button btnApnd;
        private Button btnRead;
        private Button btnBrsDst;
        private Label lblDst;
        private Button btnMove;
        private Button btnCopy;
        private Button btnDltFile;
        private Button btnDltDir;
    }
}
