namespace SnookerRanglista
{
    partial class FormNyito
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
            this.dataGridViewVersenyzo = new System.Windows.Forms.DataGridView();
            this.groupBoxAdatok = new System.Windows.Forms.GroupBox();
            this.btModosit = new System.Windows.Forms.Button();
            this.lbNyeremeny = new System.Windows.Forms.Label();
            this.numericUpDownNyeremeny = new System.Windows.Forms.NumericUpDown();
            this.tbOrszag = new System.Windows.Forms.TextBox();
            this.lbOrszag = new System.Windows.Forms.Label();
            this.tbNev = new System.Windows.Forms.TextBox();
            this.lbNev = new System.Windows.Forms.Label();
            this.tbHelyezes = new System.Windows.Forms.TextBox();
            this.lbHelyezes = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVersenyzo)).BeginInit();
            this.groupBoxAdatok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNyeremeny)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewVersenyzo
            // 
            this.dataGridViewVersenyzo.AllowUserToAddRows = false;
            this.dataGridViewVersenyzo.AllowUserToDeleteRows = false;
            this.dataGridViewVersenyzo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVersenyzo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewVersenyzo.Location = new System.Drawing.Point(0, 156);
            this.dataGridViewVersenyzo.Name = "dataGridViewVersenyzo";
            this.dataGridViewVersenyzo.ReadOnly = true;
            this.dataGridViewVersenyzo.Size = new System.Drawing.Size(1200, 536);
            this.dataGridViewVersenyzo.TabIndex = 0;
            this.dataGridViewVersenyzo.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewVersenyzo_ColumnHeaderMouseClick);
            this.dataGridViewVersenyzo.SelectionChanged += new System.EventHandler(this.dataGridViewVersenyzo_SelectionChanged);
            // 
            // groupBoxAdatok
            // 
            this.groupBoxAdatok.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxAdatok.Controls.Add(this.tbID);
            this.groupBoxAdatok.Controls.Add(this.btModosit);
            this.groupBoxAdatok.Controls.Add(this.lbNyeremeny);
            this.groupBoxAdatok.Controls.Add(this.numericUpDownNyeremeny);
            this.groupBoxAdatok.Controls.Add(this.tbOrszag);
            this.groupBoxAdatok.Controls.Add(this.lbOrszag);
            this.groupBoxAdatok.Controls.Add(this.tbNev);
            this.groupBoxAdatok.Controls.Add(this.lbNev);
            this.groupBoxAdatok.Controls.Add(this.tbHelyezes);
            this.groupBoxAdatok.Controls.Add(this.lbHelyezes);
            this.groupBoxAdatok.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxAdatok.Location = new System.Drawing.Point(0, 0);
            this.groupBoxAdatok.Name = "groupBoxAdatok";
            this.groupBoxAdatok.Size = new System.Drawing.Size(1200, 150);
            this.groupBoxAdatok.TabIndex = 1;
            this.groupBoxAdatok.TabStop = false;
            this.groupBoxAdatok.Text = "Versenyzők adatai";
            // 
            // btModosit
            // 
            this.btModosit.Location = new System.Drawing.Point(1002, 84);
            this.btModosit.Name = "btModosit";
            this.btModosit.Size = new System.Drawing.Size(125, 26);
            this.btModosit.TabIndex = 8;
            this.btModosit.Text = "Módosít";
            this.btModosit.UseVisualStyleBackColor = true;
            this.btModosit.Click += new System.EventHandler(this.btModosit_Click);
            // 
            // lbNyeremeny
            // 
            this.lbNyeremeny.AutoSize = true;
            this.lbNyeremeny.Location = new System.Drawing.Point(769, 34);
            this.lbNyeremeny.Name = "lbNyeremeny";
            this.lbNyeremeny.Size = new System.Drawing.Size(88, 20);
            this.lbNyeremeny.TabIndex = 7;
            this.lbNyeremeny.Text = "Nyeremeny";
            // 
            // numericUpDownNyeremeny
            // 
            this.numericUpDownNyeremeny.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownNyeremeny.Location = new System.Drawing.Point(773, 84);
            this.numericUpDownNyeremeny.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numericUpDownNyeremeny.Name = "numericUpDownNyeremeny";
            this.numericUpDownNyeremeny.Size = new System.Drawing.Size(177, 26);
            this.numericUpDownNyeremeny.TabIndex = 6;
            this.numericUpDownNyeremeny.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownNyeremeny.ThousandsSeparator = true;
            // 
            // tbOrszag
            // 
            this.tbOrszag.Location = new System.Drawing.Point(514, 84);
            this.tbOrszag.Name = "tbOrszag";
            this.tbOrszag.ReadOnly = true;
            this.tbOrszag.Size = new System.Drawing.Size(165, 26);
            this.tbOrszag.TabIndex = 5;
            // 
            // lbOrszag
            // 
            this.lbOrszag.AutoSize = true;
            this.lbOrszag.Location = new System.Drawing.Point(510, 34);
            this.lbOrszag.Name = "lbOrszag";
            this.lbOrszag.Size = new System.Drawing.Size(60, 20);
            this.lbOrszag.TabIndex = 4;
            this.lbOrszag.Text = "Ország";
            // 
            // tbNev
            // 
            this.tbNev.Location = new System.Drawing.Point(273, 84);
            this.tbNev.Name = "tbNev";
            this.tbNev.ReadOnly = true;
            this.tbNev.Size = new System.Drawing.Size(165, 26);
            this.tbNev.TabIndex = 3;
            // 
            // lbNev
            // 
            this.lbNev.AutoSize = true;
            this.lbNev.Location = new System.Drawing.Point(269, 34);
            this.lbNev.Name = "lbNev";
            this.lbNev.Size = new System.Drawing.Size(36, 20);
            this.lbNev.TabIndex = 2;
            this.lbNev.Text = "Név";
            // 
            // tbHelyezes
            // 
            this.tbHelyezes.Location = new System.Drawing.Point(34, 84);
            this.tbHelyezes.Name = "tbHelyezes";
            this.tbHelyezes.ReadOnly = true;
            this.tbHelyezes.Size = new System.Drawing.Size(165, 26);
            this.tbHelyezes.TabIndex = 1;
            // 
            // lbHelyezes
            // 
            this.lbHelyezes.AutoSize = true;
            this.lbHelyezes.Location = new System.Drawing.Point(30, 34);
            this.lbHelyezes.Name = "lbHelyezes";
            this.lbHelyezes.Size = new System.Drawing.Size(74, 20);
            this.lbHelyezes.TabIndex = 0;
            this.lbHelyezes.Text = "Helyezés";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(1002, 31);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(18, 26);
            this.tbID.TabIndex = 9;
            this.tbID.Visible = false;
            // 
            // FormNyito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.groupBoxAdatok);
            this.Controls.Add(this.dataGridViewVersenyzo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormNyito";
            this.Text = "Snooker világranglista";
            this.Load += new System.EventHandler(this.FormNyito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVersenyzo)).EndInit();
            this.groupBoxAdatok.ResumeLayout(false);
            this.groupBoxAdatok.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNyeremeny)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewVersenyzo;
        private System.Windows.Forms.GroupBox groupBoxAdatok;
        private System.Windows.Forms.Button btModosit;
        private System.Windows.Forms.Label lbNyeremeny;
        private System.Windows.Forms.Label lbOrszag;
        private System.Windows.Forms.Label lbNev;
        private System.Windows.Forms.Label lbHelyezes;
        public System.Windows.Forms.NumericUpDown numericUpDownNyeremeny;
        public System.Windows.Forms.TextBox tbOrszag;
        public System.Windows.Forms.TextBox tbNev;
        public System.Windows.Forms.TextBox tbHelyezes;
        public System.Windows.Forms.TextBox tbID;
    }
}

