namespace SistemaReservasLaboratorios
{
    partial class FrmReservas
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
            this.Fecha = new System.Windows.Forms.Label();
            this.dtpDatestart = new System.Windows.Forms.DateTimePicker();
            this.Horafin = new System.Windows.Forms.Label();
            this.dtpDateEnd = new System.Windows.Forms.DateTimePicker();
            this.btnReserve = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dgvReservations = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtb_laboratory = new System.Windows.Forms.TextBox();
            this.btlist = new System.Windows.Forms.Button();
            this.txtb_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Laboratory";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Location = new System.Drawing.Point(197, 198);
            this.Fecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(66, 16);
            this.Fecha.TabIndex = 2;
            this.Fecha.Text = "Date Start";
            this.Fecha.Click += new System.EventHandler(this.Fecha_Click);
            // 
            // dtpDatestart
            // 
            this.dtpDatestart.Location = new System.Drawing.Point(288, 198);
            this.dtpDatestart.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDatestart.Name = "dtpDatestart";
            this.dtpDatestart.Size = new System.Drawing.Size(265, 22);
            this.dtpDatestart.TabIndex = 3;
            // 
            // Horafin
            // 
            this.Horafin.AutoSize = true;
            this.Horafin.Location = new System.Drawing.Point(197, 314);
            this.Horafin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Horafin.Name = "Horafin";
            this.Horafin.Size = new System.Drawing.Size(63, 16);
            this.Horafin.TabIndex = 4;
            this.Horafin.Text = "Date End";
            // 
            // dtpDateEnd
            // 
            this.dtpDateEnd.Location = new System.Drawing.Point(288, 306);
            this.dtpDateEnd.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDateEnd.Name = "dtpDateEnd";
            this.dtpDateEnd.Size = new System.Drawing.Size(265, 22);
            this.dtpDateEnd.TabIndex = 5;
            // 
            // btnReserve
            // 
            this.btnReserve.Location = new System.Drawing.Point(181, 385);
            this.btnReserve.Margin = new System.Windows.Forms.Padding(4);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(100, 28);
            this.btnReserve.TabIndex = 6;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(355, 385);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // dgvReservations
            // 
            this.dgvReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservations.Location = new System.Drawing.Point(201, 427);
            this.dgvReservations.Margin = new System.Windows.Forms.Padding(4);
            this.dgvReservations.Name = "dgvReservations";
            this.dgvReservations.RowHeadersWidth = 51;
            this.dgvReservations.Size = new System.Drawing.Size(385, 112);
            this.dgvReservations.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(455, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sistem of reserve of laboratory";
            // 
            // txtb_laboratory
            // 
            this.txtb_laboratory.Location = new System.Drawing.Point(329, 127);
            this.txtb_laboratory.Name = "txtb_laboratory";
            this.txtb_laboratory.Size = new System.Drawing.Size(100, 22);
            this.txtb_laboratory.TabIndex = 10;
            // 
            // btlist
            // 
            this.btlist.Location = new System.Drawing.Point(486, 385);
            this.btlist.Margin = new System.Windows.Forms.Padding(4);
            this.btlist.Name = "btlist";
            this.btlist.Size = new System.Drawing.Size(100, 28);
            this.btlist.TabIndex = 11;
            this.btlist.TabStop = false;
            this.btlist.Text = "list";
            this.btlist.UseVisualStyleBackColor = true;
            this.btlist.Click += new System.EventHandler(this.btlist_Click);
            // 
            // txtb_name
            // 
            this.txtb_name.Location = new System.Drawing.Point(808, 124);
            this.txtb_name.Name = "txtb_name";
            this.txtb_name.Size = new System.Drawing.Size(100, 22);
            this.txtb_name.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(688, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Name ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(688, 175);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(297, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Note: Name of the person making the reservation";
            // 
            // FrmReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtb_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btlist);
            this.Controls.Add(this.txtb_laboratory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvReservations);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.dtpDateEnd);
            this.Controls.Add(this.Horafin);
            this.Controls.Add(this.dtpDatestart);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmReservas";
            this.Text = "FrmReservas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Fecha;
        private System.Windows.Forms.DateTimePicker dtpDatestart;
        private System.Windows.Forms.Label Horafin;
        private System.Windows.Forms.DateTimePicker dtpDateEnd;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgvReservations;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtb_laboratory;
        private System.Windows.Forms.Button btlist;
        private System.Windows.Forms.TextBox txtb_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}