namespace Sql_Database_app
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
            this.label5 = new System.Windows.Forms.Label();
            this.dtMachines = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.dtMagazine = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dtInfo = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtToolName = new System.Windows.Forms.TextBox();
            this.txtToolNo = new System.Windows.Forms.TextBox();
            this.btLoadAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtMachines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtMagazine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 438);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Machine Tool Offset:";
            // 
            // dtMachines
            // 
            this.dtMachines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtMachines.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtMachines.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtMachines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtMachines.Location = new System.Drawing.Point(-8, 457);
            this.dtMachines.Name = "dtMachines";
            this.dtMachines.Size = new System.Drawing.Size(800, 82);
            this.dtMachines.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Magazine Tool Offset:";
            // 
            // dtMagazine
            // 
            this.dtMagazine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtMagazine.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtMagazine.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtMagazine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtMagazine.Location = new System.Drawing.Point(-8, 342);
            this.dtMagazine.Name = "dtMagazine";
            this.dtMagazine.Size = new System.Drawing.Size(800, 82);
            this.dtMagazine.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tool Info:";
            // 
            // dtInfo
            // 
            this.dtInfo.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtInfo.Location = new System.Drawing.Point(-8, 125);
            this.dtInfo.Name = "dtInfo";
            this.dtInfo.Size = new System.Drawing.Size(800, 178);
            this.dtInfo.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tool Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tool Number";
            // 
            // txtToolName
            // 
            this.txtToolName.Location = new System.Drawing.Point(251, 84);
            this.txtToolName.Name = "txtToolName";
            this.txtToolName.Size = new System.Drawing.Size(154, 20);
            this.txtToolName.TabIndex = 13;
            this.txtToolName.TextChanged += new System.EventHandler(this.txtToolName_TextChanged);
            this.txtToolName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtToolName_KeyPress);
            // 
            // txtToolNo
            // 
            this.txtToolNo.Location = new System.Drawing.Point(104, 84);
            this.txtToolNo.Name = "txtToolNo";
            this.txtToolNo.Size = new System.Drawing.Size(100, 20);
            this.txtToolNo.TabIndex = 12;
            this.txtToolNo.TextChanged += new System.EventHandler(this.txtToolNo_TextChanged);
            this.txtToolNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtToolNo_KeyPress);
            // 
            // btLoadAll
            // 
            this.btLoadAll.Location = new System.Drawing.Point(481, 80);
            this.btLoadAll.Name = "btLoadAll";
            this.btLoadAll.Size = new System.Drawing.Size(75, 23);
            this.btLoadAll.TabIndex = 23;
            this.btLoadAll.Text = "Load All";
            this.btLoadAll.UseVisualStyleBackColor = true;
            this.btLoadAll.Click += new System.EventHandler(this.btLoadAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 601);
            this.Controls.Add(this.btLoadAll);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtMachines);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtMagazine);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtToolName);
            this.Controls.Add(this.txtToolNo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtMachines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtMagazine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtMachines;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtMagazine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtToolName;
        private System.Windows.Forms.TextBox txtToolNo;
        private System.Windows.Forms.Button btLoadAll;
    }
}

