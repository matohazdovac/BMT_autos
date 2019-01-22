namespace WindowsFormsApp8
{
    partial class Form4
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.marka_auta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model_auta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.godina_proizvodnje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kilometri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.marka_auta,
            this.model_auta,
            this.godina_proizvodnje,
            this.kilometri,
            this.cijena});
            this.dataGridView1.Location = new System.Drawing.Point(85, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(542, 387);
            this.dataGridView1.TabIndex = 0;
            // 
            // marka_auta
            // 
            this.marka_auta.HeaderText = "Proizvođač";
            this.marka_auta.Name = "marka_auta";
            this.marka_auta.ReadOnly = true;
            // 
            // model_auta
            // 
            this.model_auta.HeaderText = "Model";
            this.model_auta.Name = "model_auta";
            this.model_auta.ReadOnly = true;
            // 
            // godina_proizvodnje
            // 
            this.godina_proizvodnje.HeaderText = "Godina proizvodnje";
            this.godina_proizvodnje.Name = "godina_proizvodnje";
            this.godina_proizvodnje.ReadOnly = true;
            // 
            // kilometri
            // 
            this.kilometri.HeaderText = "Kilometraža";
            this.kilometri.Name = "kilometri";
            this.kilometri.ReadOnly = true;
            // 
            // cijena
            // 
            this.cijena.HeaderText = "Cijena";
            this.cijena.Name = "cijena";
            this.cijena.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 487);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn marka_auta;
        private System.Windows.Forms.DataGridViewTextBoxColumn model_auta;
        private System.Windows.Forms.DataGridViewTextBoxColumn godina_proizvodnje;
        private System.Windows.Forms.DataGridViewTextBoxColumn kilometri;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijena;
        private System.Windows.Forms.Button button1;
    }
}