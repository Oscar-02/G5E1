
namespace G5E1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.program_label = new System.Windows.Forms.Label();
            this.name_Box = new System.Windows.Forms.TextBox();
            this.salary_Box = new System.Windows.Forms.TextBox();
            this.job_Combo = new System.Windows.Forms.ComboBox();
            this.name_Label = new System.Windows.Forms.Label();
            this.salary_Label = new System.Windows.Forms.Label();
            this.job_Label = new System.Windows.Forms.Label();
            this.calculate_Button = new System.Windows.Forms.Button();
            this.exit_Button = new System.Windows.Forms.Button();
            this.code_Button = new System.Windows.Forms.Button();
            this.usd_Label = new System.Windows.Forms.Label();
            this.name_Tip = new System.Windows.Forms.ToolTip(this.components);
            this.salary_Tip = new System.Windows.Forms.ToolTip(this.components);
            this.job_Tip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // program_label
            // 
            this.program_label.AutoSize = true;
            this.program_label.Font = new System.Drawing.Font("Arvo", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.program_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.program_label.Location = new System.Drawing.Point(12, 9);
            this.program_label.Name = "program_label";
            this.program_label.Size = new System.Drawing.Size(350, 33);
            this.program_label.TabIndex = 0;
            this.program_label.Text = "Calculadora de Salarios";
            // 
            // name_Box
            // 
            this.name_Box.Location = new System.Drawing.Point(139, 74);
            this.name_Box.Name = "name_Box";
            this.name_Box.Size = new System.Drawing.Size(213, 20);
            this.name_Box.TabIndex = 1;
            this.name_Box.TextChanged += new System.EventHandler(this.name_Box_TextChanged);
            // 
            // salary_Box
            // 
            this.salary_Box.Location = new System.Drawing.Point(139, 110);
            this.salary_Box.Name = "salary_Box";
            this.salary_Box.Size = new System.Drawing.Size(81, 20);
            this.salary_Box.TabIndex = 2;
            this.salary_Box.TextChanged += new System.EventHandler(this.salary_Box_TextChanged);
            // 
            // job_Combo
            // 
            this.job_Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.job_Combo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.job_Combo.FormattingEnabled = true;
            this.job_Combo.Items.AddRange(new object[] {
            "-Seleccione una opcion-",
            "Gerente",
            "Subgerente",
            "Secretaria"});
            this.job_Combo.Location = new System.Drawing.Point(139, 146);
            this.job_Combo.Name = "job_Combo";
            this.job_Combo.Size = new System.Drawing.Size(136, 21);
            this.job_Combo.TabIndex = 3;
            this.job_Combo.SelectedIndexChanged += new System.EventHandler(this.job_Combo_SelectedIndexChanged);
            // 
            // name_Label
            // 
            this.name_Label.AutoSize = true;
            this.name_Label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.name_Label.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_Label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.name_Label.Location = new System.Drawing.Point(71, 74);
            this.name_Label.Name = "name_Label";
            this.name_Label.Size = new System.Drawing.Size(62, 18);
            this.name_Label.TabIndex = 4;
            this.name_Label.Text = "Nombre";
            this.name_Label.Click += new System.EventHandler(this.name_Label_Click);
            // 
            // salary_Label
            // 
            this.salary_Label.AutoSize = true;
            this.salary_Label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salary_Label.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary_Label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.salary_Label.Location = new System.Drawing.Point(78, 110);
            this.salary_Label.Name = "salary_Label";
            this.salary_Label.Size = new System.Drawing.Size(55, 18);
            this.salary_Label.TabIndex = 5;
            this.salary_Label.Text = "Salario";
            this.salary_Label.Click += new System.EventHandler(this.salary_Label_Click);
            // 
            // job_Label
            // 
            this.job_Label.AutoSize = true;
            this.job_Label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.job_Label.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.job_Label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.job_Label.Location = new System.Drawing.Point(12, 146);
            this.job_Label.Name = "job_Label";
            this.job_Label.Size = new System.Drawing.Size(121, 18);
            this.job_Label.TabIndex = 6;
            this.job_Label.Text = "Posicion Laboral";
            this.job_Label.Click += new System.EventHandler(this.job_Label_Click);
            // 
            // calculate_Button
            // 
            this.calculate_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate_Button.Location = new System.Drawing.Point(388, 12);
            this.calculate_Button.Name = "calculate_Button";
            this.calculate_Button.Size = new System.Drawing.Size(234, 55);
            this.calculate_Button.TabIndex = 7;
            this.calculate_Button.Text = "Calcular Ahora";
            this.calculate_Button.UseVisualStyleBackColor = true;
            this.calculate_Button.Click += new System.EventHandler(this.calculate_Button_Click);
            // 
            // exit_Button
            // 
            this.exit_Button.Location = new System.Drawing.Point(513, 154);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(109, 33);
            this.exit_Button.TabIndex = 9;
            this.exit_Button.Text = "Salir del programa";
            this.exit_Button.UseVisualStyleBackColor = true;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // code_Button
            // 
            this.code_Button.Location = new System.Drawing.Point(408, 154);
            this.code_Button.Name = "code_Button";
            this.code_Button.Size = new System.Drawing.Size(99, 33);
            this.code_Button.TabIndex = 11;
            this.code_Button.Text = "Ver codigo >>";
            this.code_Button.UseVisualStyleBackColor = true;
            this.code_Button.Click += new System.EventHandler(this.code_Button_Click);
            // 
            // usd_Label
            // 
            this.usd_Label.AutoSize = true;
            this.usd_Label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usd_Label.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usd_Label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.usd_Label.Location = new System.Drawing.Point(226, 110);
            this.usd_Label.Name = "usd_Label";
            this.usd_Label.Size = new System.Drawing.Size(49, 18);
            this.usd_Label.TabIndex = 12;
            this.usd_Label.Text = "$ USD";
            this.usd_Label.Click += new System.EventHandler(this.usd_Label_Click);
            // 
            // name_Tip
            // 
            this.name_Tip.IsBalloon = true;
            this.name_Tip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // salary_Tip
            // 
            this.salary_Tip.IsBalloon = true;
            this.salary_Tip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // job_Tip
            // 
            this.job_Tip.IsBalloon = true;
            this.job_Tip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(634, 199);
            this.Controls.Add(this.usd_Label);
            this.Controls.Add(this.code_Button);
            this.Controls.Add(this.exit_Button);
            this.Controls.Add(this.calculate_Button);
            this.Controls.Add(this.job_Label);
            this.Controls.Add(this.salary_Label);
            this.Controls.Add(this.name_Label);
            this.Controls.Add(this.job_Combo);
            this.Controls.Add(this.salary_Box);
            this.Controls.Add(this.name_Box);
            this.Controls.Add(this.program_label);
            this.Name = "Form1";
            this.Text = "Calculadora de Salarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label program_label;
        private System.Windows.Forms.TextBox name_Box;
        private System.Windows.Forms.TextBox salary_Box;
        private System.Windows.Forms.ComboBox job_Combo;
        private System.Windows.Forms.Label name_Label;
        private System.Windows.Forms.Label salary_Label;
        private System.Windows.Forms.Label job_Label;
        private System.Windows.Forms.Button calculate_Button;
        private System.Windows.Forms.Button exit_Button;
        private System.Windows.Forms.Button code_Button;
        private System.Windows.Forms.Label usd_Label;
        private System.Windows.Forms.ToolTip name_Tip;
        private System.Windows.Forms.ToolTip salary_Tip;
        private System.Windows.Forms.ToolTip job_Tip;
    }
}

