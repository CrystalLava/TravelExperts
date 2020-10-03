namespace TravelExperts
{
    partial class AddEditPackage
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
            this.PkgStartDate = new System.Windows.Forms.DateTimePicker();
            this.startDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.endDate = new System.Windows.Forms.Label();
            this.PkgEndDate = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.travelExpertsDataSet1 = new TravelExperts.TravelExpertsDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PkgBasicPrice = new System.Windows.Forms.NumericUpDown();
            this.PkgAgencyCommision = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.travelExpertsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PkgBasicPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PkgAgencyCommision)).BeginInit();
            this.SuspendLayout();
            // 
            // PkgStartDate
            // 
            this.PkgStartDate.Location = new System.Drawing.Point(163, 233);
            this.PkgStartDate.Name = "PkgStartDate";
            this.PkgStartDate.Size = new System.Drawing.Size(200, 20);
            this.PkgStartDate.TabIndex = 0;
            // 
            // startDate
            // 
            this.startDate.AutoSize = true;
            this.startDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.startDate.Location = new System.Drawing.Point(88, 239);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(55, 13);
            this.startDate.TabIndex = 1;
            this.startDate.Text = "Start Date";
            this.startDate.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(62, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Package Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(58, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pkg. Description";
            // 
            // endDate
            // 
            this.endDate.AutoSize = true;
            this.endDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.endDate.Location = new System.Drawing.Point(88, 279);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(52, 13);
            this.endDate.TabIndex = 4;
            this.endDate.Text = "End Date";
            this.endDate.UseWaitCursor = true;
            // 
            // PkgEndDate
            // 
            this.PkgEndDate.Location = new System.Drawing.Point(163, 273);
            this.PkgEndDate.Name = "PkgEndDate";
            this.PkgEndDate.Size = new System.Drawing.Size(200, 20);
            this.PkgEndDate.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(163, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 6;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(163, 77);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(200, 136);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // travelExpertsDataSet1
            // 
            this.travelExpertsDataSet1.DataSetName = "TravelExpertsDataSet";
            this.travelExpertsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(55, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Pkg. Basic Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(27, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Pkg. Agnc. Commision";
            // 
            // PkgBasicPrice
            // 
            this.PkgBasicPrice.Location = new System.Drawing.Point(163, 314);
            this.PkgBasicPrice.Name = "PkgBasicPrice";
            this.PkgBasicPrice.Size = new System.Drawing.Size(120, 20);
            this.PkgBasicPrice.TabIndex = 10;
            // 
            // PkgAgencyCommision
            // 
            this.PkgAgencyCommision.Location = new System.Drawing.Point(163, 355);
            this.PkgAgencyCommision.Name = "PkgAgencyCommision";
            this.PkgAgencyCommision.Size = new System.Drawing.Size(120, 20);
            this.PkgAgencyCommision.TabIndex = 11;
            // 
            // AddEditPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 392);
            this.Controls.Add(this.PkgAgencyCommision);
            this.Controls.Add(this.PkgBasicPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PkgEndDate);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.PkgStartDate);
            this.Name = "AddEditPackage";
            this.Text = "AddEditPackage";
            ((System.ComponentModel.ISupportInitialize)(this.travelExpertsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PkgBasicPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PkgAgencyCommision)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker PkgStartDate;
        private System.Windows.Forms.Label startDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label endDate;
        private System.Windows.Forms.DateTimePicker PkgEndDate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private TravelExpertsDataSet travelExpertsDataSet1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown PkgBasicPrice;
        private System.Windows.Forms.NumericUpDown PkgAgencyCommision;
    }
}