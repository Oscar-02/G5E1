
namespace G5E1
{
    partial class Form2
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
            this.name_Label = new System.Windows.Forms.Label();
            this.name_Box = new System.Windows.Forms.TextBox();
            this.salary_base_Box = new System.Windows.Forms.TextBox();
            this.salary_base_Label = new System.Windows.Forms.Label();
            this.discount_Box = new System.Windows.Forms.TextBox();
            this.discount_Label = new System.Windows.Forms.Label();
            this.salary_Box = new System.Windows.Forms.TextBox();
            this.salary_Label = new System.Windows.Forms.Label();
            this.usd_Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.job_Box = new System.Windows.Forms.TextBox();
            this.job_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name_Label
            // 
            this.name_Label.AutoSize = true;
            this.name_Label.Font = new System.Drawing.Font("Roboto", 15.75F);
            this.name_Label.Location = new System.Drawing.Point(116, 26);
            this.name_Label.Name = "name_Label";
            this.name_Label.Size = new System.Drawing.Size(87, 25);
            this.name_Label.TabIndex = 0;
            this.name_Label.Text = "Nombre";
            // 
            // name_Box
            // 
            this.name_Box.Enabled = false;
            this.name_Box.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_Box.Location = new System.Drawing.Point(209, 23);
            this.name_Box.Name = "name_Box";
            this.name_Box.Size = new System.Drawing.Size(237, 33);
            this.name_Box.TabIndex = 1;
            this.name_Box.TextChanged += new System.EventHandler(this.name_Box_TextChanged);
            // 
            // salary_base_Box
            // 
            this.salary_base_Box.Enabled = false;
            this.salary_base_Box.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary_base_Box.Location = new System.Drawing.Point(209, 103);
            this.salary_base_Box.Name = "salary_base_Box";
            this.salary_base_Box.Size = new System.Drawing.Size(116, 33);
            this.salary_base_Box.TabIndex = 3;
            // 
            // salary_base_Label
            // 
            this.salary_base_Label.AutoSize = true;
            this.salary_base_Label.Font = new System.Drawing.Font("Roboto", 15.75F);
            this.salary_base_Label.Location = new System.Drawing.Point(77, 106);
            this.salary_base_Label.Name = "salary_base_Label";
            this.salary_base_Label.Size = new System.Drawing.Size(126, 25);
            this.salary_base_Label.TabIndex = 2;
            this.salary_base_Label.Text = "Salario Base";
            // 
            // discount_Box
            // 
            this.discount_Box.Enabled = false;
            this.discount_Box.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discount_Box.Location = new System.Drawing.Point(209, 142);
            this.discount_Box.Name = "discount_Box";
            this.discount_Box.Size = new System.Drawing.Size(116, 33);
            this.discount_Box.TabIndex = 5;
            // 
            // discount_Label
            // 
            this.discount_Label.AutoSize = true;
            this.discount_Label.Font = new System.Drawing.Font("Roboto", 15.75F);
            this.discount_Label.Location = new System.Drawing.Point(90, 145);
            this.discount_Label.Name = "discount_Label";
            this.discount_Label.Size = new System.Drawing.Size(113, 25);
            this.discount_Label.TabIndex = 4;
            this.discount_Label.Text = "Descuento";
            // 
            // salary_Box
            // 
            this.salary_Box.Enabled = false;
            this.salary_Box.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary_Box.Location = new System.Drawing.Point(209, 181);
            this.salary_Box.Name = "salary_Box";
            this.salary_Box.Size = new System.Drawing.Size(116, 33);
            this.salary_Box.TabIndex = 7;
            // 
            // salary_Label
            // 
            this.salary_Label.AutoSize = true;
            this.salary_Label.Font = new System.Drawing.Font("Roboto", 15.75F);
            this.salary_Label.Location = new System.Drawing.Point(78, 184);
            this.salary_Label.Name = "salary_Label";
            this.salary_Label.Size = new System.Drawing.Size(125, 25);
            this.salary_Label.TabIndex = 6;
            this.salary_Label.Text = "Salario Final";
            // 
            // usd_Label
            // 
            this.usd_Label.AutoSize = true;
            this.usd_Label.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usd_Label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.usd_Label.Location = new System.Drawing.Point(331, 112);
            this.usd_Label.Name = "usd_Label";
            this.usd_Label.Size = new System.Drawing.Size(49, 18);
            this.usd_Label.TabIndex = 13;
            this.usd_Label.Text = "$ USD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(331, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "$ USD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(331, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "$ USD";
            // 
            // job_Box
            // 
            this.job_Box.Enabled = false;
            this.job_Box.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.job_Box.Location = new System.Drawing.Point(209, 62);
            this.job_Box.Name = "job_Box";
            this.job_Box.Size = new System.Drawing.Size(237, 33);
            this.job_Box.TabIndex = 17;
            // 
            // job_Label
            // 
            this.job_Label.AutoSize = true;
            this.job_Label.Font = new System.Drawing.Font("Roboto", 15.75F);
            this.job_Label.Location = new System.Drawing.Point(36, 65);
            this.job_Label.Name = "job_Label";
            this.job_Label.Size = new System.Drawing.Size(167, 25);
            this.job_Label.TabIndex = 16;
            this.job_Label.Text = "Posicion Laboral";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 257);
            this.Controls.Add(this.job_Box);
            this.Controls.Add(this.job_Label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usd_Label);
            this.Controls.Add(this.salary_Box);
            this.Controls.Add(this.salary_Label);
            this.Controls.Add(this.discount_Box);
            this.Controls.Add(this.discount_Label);
            this.Controls.Add(this.salary_base_Box);
            this.Controls.Add(this.salary_base_Label);
            this.Controls.Add(this.name_Box);
            this.Controls.Add(this.name_Label);
            this.Name = "Form2";
            this.Text = "Resultado";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name_Label;
        private System.Windows.Forms.TextBox name_Box;
        private System.Windows.Forms.TextBox salary_base_Box;
        private System.Windows.Forms.Label salary_base_Label;
        private System.Windows.Forms.TextBox discount_Box;
        private System.Windows.Forms.Label discount_Label;
        private System.Windows.Forms.TextBox salary_Box;
        private System.Windows.Forms.Label salary_Label;
        private System.Windows.Forms.Label usd_Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox job_Box;
        private System.Windows.Forms.Label job_Label;
    }
}