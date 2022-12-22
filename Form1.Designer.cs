namespace Quadratic_Solver
{
    partial class FrmQuadraticSolver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuadraticSolver));
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblSteps = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblQuadratic = new System.Windows.Forms.Label();
            this.lblEquation = new System.Windows.Forms.Label();
            this.lblroot1 = new System.Windows.Forms.Label();
            this.lblroot2 = new System.Windows.Forms.Label();
            this.lblRoots = new System.Windows.Forms.Label();
            this.lblSol = new System.Windows.Forms.Label();
            this.lblfactor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtA
            // 
            this.txtA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtA.Location = new System.Drawing.Point(42, 252);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(150, 13);
            this.txtA.TabIndex = 0;
            // 
            // txtB
            // 
            this.txtB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtB.Location = new System.Drawing.Point(232, 252);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(150, 13);
            this.txtB.TabIndex = 1;
            // 
            // txtC
            // 
            this.txtC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtC.Location = new System.Drawing.Point(422, 252);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(150, 13);
            this.txtC.TabIndex = 2;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblA.Location = new System.Drawing.Point(38, 203);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(113, 24);
            this.lblA.TabIndex = 3;
            this.lblA.Text = "Value of A:";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblB.Location = new System.Drawing.Point(228, 203);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(112, 24);
            this.lblB.TabIndex = 4;
            this.lblB.Text = "Value of B:";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblC.Location = new System.Drawing.Point(418, 203);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(113, 24);
            this.lblC.TabIndex = 5;
            this.lblC.Text = "Value of C:";
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblInstructions.Location = new System.Drawing.Point(38, 103);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(160, 24);
            this.lblInstructions.TabIndex = 6;
            this.lblInstructions.Text = "INSTRUCTIONS";
            // 
            // lblSteps
            // 
            this.lblSteps.AutoSize = true;
            this.lblSteps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSteps.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblSteps.Location = new System.Drawing.Point(38, 145);
            this.lblSteps.Name = "lblSteps";
            this.lblSteps.Size = new System.Drawing.Size(397, 40);
            this.lblSteps.TabIndex = 7;
            this.lblSteps.Text = "1) Set the a, b, and c values of your quadratic equation.\r\n2) Hit the confirm but" +
    "ton to find the roots.";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnConfirm.Location = new System.Drawing.Point(42, 296);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(530, 48);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.Text = "CONFIRM";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblQuadratic
            // 
            this.lblQuadratic.AutoSize = true;
            this.lblQuadratic.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuadratic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblQuadratic.Location = new System.Drawing.Point(249, 366);
            this.lblQuadratic.Name = "lblQuadratic";
            this.lblQuadratic.Size = new System.Drawing.Size(224, 25);
            this.lblQuadratic.TabIndex = 9;
            this.lblQuadratic.Text = "(a)x² + (b)x + (c) = 0\r\n";
            // 
            // lblEquation
            // 
            this.lblEquation.AutoSize = true;
            this.lblEquation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblEquation.Location = new System.Drawing.Point(36, 366);
            this.lblEquation.Name = "lblEquation";
            this.lblEquation.Size = new System.Drawing.Size(207, 25);
            this.lblEquation.TabIndex = 10;
            this.lblEquation.Text = "YOUR EQUATION:";
            // 
            // lblroot1
            // 
            this.lblroot1.AutoSize = true;
            this.lblroot1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblroot1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblroot1.Location = new System.Drawing.Point(598, 145);
            this.lblroot1.Name = "lblroot1";
            this.lblroot1.Size = new System.Drawing.Size(59, 31);
            this.lblroot1.TabIndex = 11;
            this.lblroot1.Text = "x₁ =";
            // 
            // lblroot2
            // 
            this.lblroot2.AutoSize = true;
            this.lblroot2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblroot2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblroot2.Location = new System.Drawing.Point(598, 196);
            this.lblroot2.Name = "lblroot2";
            this.lblroot2.Size = new System.Drawing.Size(59, 31);
            this.lblroot2.TabIndex = 12;
            this.lblroot2.Text = "x₂ =";
            // 
            // lblRoots
            // 
            this.lblRoots.AutoSize = true;
            this.lblRoots.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoots.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblRoots.Location = new System.Drawing.Point(600, 103);
            this.lblRoots.Name = "lblRoots";
            this.lblRoots.Size = new System.Drawing.Size(82, 24);
            this.lblRoots.TabIndex = 13;
            this.lblRoots.Text = "ROOTS";
            // 
            // lblSol
            // 
            this.lblSol.AutoSize = true;
            this.lblSol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblSol.Location = new System.Drawing.Point(600, 310);
            this.lblSol.Name = "lblSol";
            this.lblSol.Size = new System.Drawing.Size(260, 24);
            this.lblSol.TabIndex = 14;
            this.lblSol.Text = "NUMBER OF SOLUTIONS:";
            // 
            // lblfactor
            // 
            this.lblfactor.AutoSize = true;
            this.lblfactor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfactor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblfactor.Location = new System.Drawing.Point(600, 367);
            this.lblfactor.Name = "lblfactor";
            this.lblfactor.Size = new System.Drawing.Size(152, 24);
            this.lblfactor.TabIndex = 15;
            this.lblfactor.Text = "FACTORABLE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(600, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "OTHER INFO";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Press Start 2P", 23.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblTitle.Location = new System.Drawing.Point(33, 33);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1011, 43);
            this.lblTitle.TabIndex = 17;
            this.lblTitle.Text = "Q U A D R A T I C   S O L V E R";
            // 
            // FrmQuadraticSolver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1075, 437);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblfactor);
            this.Controls.Add(this.lblSol);
            this.Controls.Add(this.lblRoots);
            this.Controls.Add(this.lblroot2);
            this.Controls.Add(this.lblroot1);
            this.Controls.Add(this.lblEquation);
            this.Controls.Add(this.lblQuadratic);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblSteps);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmQuadraticSolver";
            this.Text = "Quadratic Solver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblSteps;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblQuadratic;
        private System.Windows.Forms.Label lblEquation;
        private System.Windows.Forms.Label lblroot1;
        private System.Windows.Forms.Label lblroot2;
        private System.Windows.Forms.Label lblRoots;
        private System.Windows.Forms.Label lblSol;
        private System.Windows.Forms.Label lblfactor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTitle;
    }
}

