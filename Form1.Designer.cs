namespace Employee
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.idLbl = new System.Windows.Forms.Label();
            this.deptLbl = new System.Windows.Forms.Label();
            this.positionLbl = new System.Windows.Forms.Label();
            this.emp1Btn = new System.Windows.Forms.Button();
            this.emp2Btn = new System.Windows.Forms.Button();
            this.emp3Btn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(409, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Department";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(602, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Position";
            // 
            // nameLbl
            // 
            this.nameLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nameLbl.Location = new System.Drawing.Point(23, 93);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(132, 36);
            this.nameLbl.TabIndex = 4;
            // 
            // idLbl
            // 
            this.idLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.idLbl.Location = new System.Drawing.Point(189, 93);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(133, 36);
            this.idLbl.TabIndex = 5;
            // 
            // deptLbl
            // 
            this.deptLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.deptLbl.Location = new System.Drawing.Point(375, 93);
            this.deptLbl.Name = "deptLbl";
            this.deptLbl.Size = new System.Drawing.Size(139, 36);
            this.deptLbl.TabIndex = 6;
            // 
            // positionLbl
            // 
            this.positionLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.positionLbl.Location = new System.Drawing.Point(571, 93);
            this.positionLbl.Name = "positionLbl";
            this.positionLbl.Size = new System.Drawing.Size(139, 36);
            this.positionLbl.TabIndex = 7;
            // 
            // emp1Btn
            // 
            this.emp1Btn.Location = new System.Drawing.Point(23, 247);
            this.emp1Btn.Name = "emp1Btn";
            this.emp1Btn.Size = new System.Drawing.Size(145, 50);
            this.emp1Btn.TabIndex = 8;
            this.emp1Btn.Text = "Employee 1";
            this.emp1Btn.UseVisualStyleBackColor = true;
            this.emp1Btn.Click += new System.EventHandler(this.emp1Btn_Click);
            // 
            // emp2Btn
            // 
            this.emp2Btn.Location = new System.Drawing.Point(241, 247);
            this.emp2Btn.Name = "emp2Btn";
            this.emp2Btn.Size = new System.Drawing.Size(145, 50);
            this.emp2Btn.TabIndex = 9;
            this.emp2Btn.Text = "Employee 2";
            this.emp2Btn.UseVisualStyleBackColor = true;
            this.emp2Btn.Click += new System.EventHandler(this.emp2Btn_Click);
            // 
            // emp3Btn
            // 
            this.emp3Btn.Location = new System.Drawing.Point(469, 247);
            this.emp3Btn.Name = "emp3Btn";
            this.emp3Btn.Size = new System.Drawing.Size(147, 50);
            this.emp3Btn.TabIndex = 10;
            this.emp3Btn.Text = "Employee 3";
            this.emp3Btn.UseVisualStyleBackColor = true;
            this.emp3Btn.Click += new System.EventHandler(this.emp3Btn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(189, 405);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(118, 43);
            this.exitBtn.TabIndex = 11;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(349, 404);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(117, 43);
            this.clearBtn.TabIndex = 12;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 459);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.emp3Btn);
            this.Controls.Add(this.emp2Btn);
            this.Controls.Add(this.emp1Btn);
            this.Controls.Add(this.positionLbl);
            this.Controls.Add(this.deptLbl);
            this.Controls.Add(this.idLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.Label deptLbl;
        private System.Windows.Forms.Label positionLbl;
        private System.Windows.Forms.Button emp1Btn;
        private System.Windows.Forms.Button emp2Btn;
        private System.Windows.Forms.Button emp3Btn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button clearBtn;
    }
}

