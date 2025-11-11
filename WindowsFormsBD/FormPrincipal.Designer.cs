namespace WindowsFormsBD
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.butOpen = new System.Windows.Forms.Button();
            this.labMessage = new System.Windows.Forms.Label();
            this.butClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.butInsertV4 = new System.Windows.Forms.Button();
            this.buttonGetJobs = new System.Windows.Forms.Button();
            this.listBoxJobs = new System.Windows.Forms.ListBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // butOpen
            // 
            this.butOpen.Location = new System.Drawing.Point(12, 71);
            this.butOpen.Name = "butOpen";
            this.butOpen.Size = new System.Drawing.Size(95, 41);
            this.butOpen.TabIndex = 0;
            this.butOpen.Text = "Connect";
            this.butOpen.UseVisualStyleBackColor = true;
            this.butOpen.Click += new System.EventHandler(this.butOpen_Click);
            // 
            // labMessage
            // 
            this.labMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labMessage.Location = new System.Drawing.Point(12, 9);
            this.labMessage.Name = "labMessage";
            this.labMessage.Size = new System.Drawing.Size(237, 34);
            this.labMessage.TabIndex = 1;
            // 
            // butClose
            // 
            this.butClose.Enabled = false;
            this.butClose.Location = new System.Drawing.Point(154, 71);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(95, 41);
            this.butClose.TabIndex = 2;
            this.butClose.Text = "Disconnect";
            this.butClose.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMax);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(286, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 126);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INFO Insertar Job";
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(88, 86);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(145, 22);
            this.txtMax.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Max:";
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(88, 61);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(145, 22);
            this.txtMin.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Min:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(88, 33);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(235, 22);
            this.txtTitle.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title:";
            // 
            // butInsertV4
            // 
            this.butInsertV4.Location = new System.Drawing.Point(12, 131);
            this.butInsertV4.Name = "butInsertV4";
            this.butInsertV4.Size = new System.Drawing.Size(237, 28);
            this.butInsertV4.TabIndex = 3;
            this.butInsertV4.Text = "Insertar Job";
            this.butInsertV4.UseVisualStyleBackColor = true;
            this.butInsertV4.Click += new System.EventHandler(this.butInsertV4_Click);
            // 
            // buttonGetJobs
            // 
            this.buttonGetJobs.Location = new System.Drawing.Point(72, 183);
            this.buttonGetJobs.Name = "buttonGetJobs";
            this.buttonGetJobs.Size = new System.Drawing.Size(120, 48);
            this.buttonGetJobs.TabIndex = 5;
            this.buttonGetJobs.Text = "Cargar Jobs";
            this.buttonGetJobs.UseVisualStyleBackColor = true;
            this.buttonGetJobs.Click += new System.EventHandler(this.buttonGetJobs_Click);
            // 
            // listBoxJobs
            // 
            this.listBoxJobs.FormattingEnabled = true;
            this.listBoxJobs.ItemHeight = 16;
            this.listBoxJobs.Location = new System.Drawing.Point(286, 147);
            this.listBoxJobs.Name = "listBoxJobs";
            this.listBoxJobs.Size = new System.Drawing.Size(353, 84);
            this.listBoxJobs.TabIndex = 6;
            this.listBoxJobs.SelectedIndexChanged += new System.EventHandler(this.listBoxJobs_SelectedIndexChanged);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(523, 248);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(116, 25);
            this.buttonUpdate.TabIndex = 7;
            this.buttonUpdate.Text = "Actualizar Job";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click_1);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 285);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.listBoxJobs);
            this.Controls.Add(this.buttonGetJobs);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.butInsertV4);
            this.Controls.Add(this.butClose);
            this.Controls.Add(this.labMessage);
            this.Controls.Add(this.butOpen);
            this.Name = "FormPrincipal";
            this.Text = "Forma Principal";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butOpen;
        private System.Windows.Forms.Label labMessage;
        private System.Windows.Forms.Button butClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butInsertV4;
        private System.Windows.Forms.Button buttonGetJobs;
        private System.Windows.Forms.ListBox listBoxJobs;
        private System.Windows.Forms.Button buttonUpdate;
    }
}

