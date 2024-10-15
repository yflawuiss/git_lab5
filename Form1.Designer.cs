namespace task_2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbR1 = new System.Windows.Forms.Label();
            this.lbR2 = new System.Windows.Forms.Label();
            this.lbMultiplier = new System.Windows.Forms.Label();
            this.lbAfterAdd = new System.Windows.Forms.Label();
            this.lbAfterDiff = new System.Windows.Forms.Label();
            this.lbR1AfterMultiplier = new System.Windows.Forms.Label();
            this.lbR2AfterMultiplier = new System.Windows.Forms.Label();
            this.btnGetResult = new System.Windows.Forms.Button();
            this.numR1 = new System.Windows.Forms.NumericUpDown();
            this.numR2 = new System.Windows.Forms.NumericUpDown();
            this.numMultiplier = new System.Windows.Forms.NumericUpDown();
            this.tbAfterAdd = new System.Windows.Forms.TextBox();
            this.tbAfterDiff = new System.Windows.Forms.TextBox();
            this.tbR1AfterMultiplier = new System.Windows.Forms.TextBox();
            this.tbR2AfterMultiplier = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numR1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numR2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMultiplier)).BeginInit();
            this.SuspendLayout();
            // 
            // lbR1
            // 
            this.lbR1.AutoSize = true;
            this.lbR1.BackColor = System.Drawing.Color.LightCyan;
            this.lbR1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbR1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbR1.ForeColor = System.Drawing.Color.Teal;
            this.lbR1.Location = new System.Drawing.Point(30, 60);
            this.lbR1.Name = "lbR1";
            this.lbR1.Size = new System.Drawing.Size(146, 20);
            this.lbR1.TabIndex = 0;
            this.lbR1.Text = "Радіус 1-го кола:";
            this.lbR1.Click += new System.EventHandler(this.lbR1_Click);
            // 
            // lbR2
            // 
            this.lbR2.AutoSize = true;
            this.lbR2.BackColor = System.Drawing.Color.LightCyan;
            this.lbR2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbR2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbR2.ForeColor = System.Drawing.Color.Teal;
            this.lbR2.Location = new System.Drawing.Point(30, 100);
            this.lbR2.Name = "lbR2";
            this.lbR2.Size = new System.Drawing.Size(146, 20);
            this.lbR2.TabIndex = 1;
            this.lbR2.Text = "Радіус 2-го кола:";
            this.lbR2.Click += new System.EventHandler(this.lbR2_Click);
            // 
            // lbMultiplier
            // 
            this.lbMultiplier.AutoSize = true;
            this.lbMultiplier.BackColor = System.Drawing.Color.LightCyan;
            this.lbMultiplier.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbMultiplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMultiplier.ForeColor = System.Drawing.Color.Teal;
            this.lbMultiplier.Location = new System.Drawing.Point(30, 140);
            this.lbMultiplier.Name = "lbMultiplier";
            this.lbMultiplier.Size = new System.Drawing.Size(296, 20);
            this.lbMultiplier.TabIndex = 2;
            this.lbMultiplier.Text = "Число-множник на радіуси двох кіл:";
            this.lbMultiplier.Click += new System.EventHandler(this.lbMultiplier_Click);
            // 
            // lbAfterAdd
            // 
            this.lbAfterAdd.AutoSize = true;
            this.lbAfterAdd.BackColor = System.Drawing.Color.LightCyan;
            this.lbAfterAdd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbAfterAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAfterAdd.ForeColor = System.Drawing.Color.Teal;
            this.lbAfterAdd.Location = new System.Drawing.Point(30, 240);
            this.lbAfterAdd.Name = "lbAfterAdd";
            this.lbAfterAdd.Size = new System.Drawing.Size(244, 20);
            this.lbAfterAdd.TabIndex = 3;
            this.lbAfterAdd.Text = "Радіус після додавання обох:";
            this.lbAfterAdd.Click += new System.EventHandler(this.lbAfterAdd_Click);
            // 
            // lbAfterDiff
            // 
            this.lbAfterDiff.AutoSize = true;
            this.lbAfterDiff.BackColor = System.Drawing.Color.LightCyan;
            this.lbAfterDiff.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbAfterDiff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAfterDiff.ForeColor = System.Drawing.Color.Teal;
            this.lbAfterDiff.Location = new System.Drawing.Point(30, 280);
            this.lbAfterDiff.Name = "lbAfterDiff";
            this.lbAfterDiff.Size = new System.Drawing.Size(303, 20);
            this.lbAfterDiff.TabIndex = 4;
            this.lbAfterDiff.Text = "Радіус після віднімання 1-го від 2-го:";
            this.lbAfterDiff.Click += new System.EventHandler(this.lbAfterDiff_Click);
            // 
            // lbR1AfterMultiplier
            // 
            this.lbR1AfterMultiplier.AutoSize = true;
            this.lbR1AfterMultiplier.BackColor = System.Drawing.Color.LightCyan;
            this.lbR1AfterMultiplier.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbR1AfterMultiplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbR1AfterMultiplier.ForeColor = System.Drawing.Color.Teal;
            this.lbR1AfterMultiplier.Location = new System.Drawing.Point(30, 320);
            this.lbR1AfterMultiplier.Name = "lbR1AfterMultiplier";
            this.lbR1AfterMultiplier.Size = new System.Drawing.Size(276, 20);
            this.lbR1AfterMultiplier.TabIndex = 5;
            this.lbR1AfterMultiplier.Text = "Радіус 1-го кола після множення:";
            this.lbR1AfterMultiplier.Click += new System.EventHandler(this.lbR1AfterMultiplier_Click);
            // 
            // lbR2AfterMultiplier
            // 
            this.lbR2AfterMultiplier.AutoSize = true;
            this.lbR2AfterMultiplier.BackColor = System.Drawing.Color.LightCyan;
            this.lbR2AfterMultiplier.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbR2AfterMultiplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbR2AfterMultiplier.ForeColor = System.Drawing.Color.Teal;
            this.lbR2AfterMultiplier.Location = new System.Drawing.Point(30, 360);
            this.lbR2AfterMultiplier.Name = "lbR2AfterMultiplier";
            this.lbR2AfterMultiplier.Size = new System.Drawing.Size(276, 20);
            this.lbR2AfterMultiplier.TabIndex = 6;
            this.lbR2AfterMultiplier.Text = "Радіус 2-го кола після множення:";
            this.lbR2AfterMultiplier.Click += new System.EventHandler(this.lbR2AfterMultiplier_Click);
            // 
            // btnGetResult
            // 
            this.btnGetResult.BackColor = System.Drawing.Color.LightCyan;
            this.btnGetResult.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGetResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGetResult.ForeColor = System.Drawing.Color.Teal;
            this.btnGetResult.Location = new System.Drawing.Point(350, 185);
            this.btnGetResult.Name = "btnGetResult";
            this.btnGetResult.Size = new System.Drawing.Size(120, 35);
            this.btnGetResult.TabIndex = 7;
            this.btnGetResult.Text = "Обчислити";
            this.btnGetResult.UseVisualStyleBackColor = false;
            this.btnGetResult.Click += new System.EventHandler(this.btnGetResult_Click);
            // 
            // numR1
            // 
            this.numR1.BackColor = System.Drawing.Color.LightCyan;
            this.numR1.ForeColor = System.Drawing.Color.Teal;
            this.numR1.Location = new System.Drawing.Point(350, 58);
            this.numR1.Name = "numR1";
            this.numR1.Size = new System.Drawing.Size(70, 24);
            this.numR1.TabIndex = 8;
            this.numR1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numR1.ValueChanged += new System.EventHandler(this.numR1_ValueChanged);
            // 
            // numR2
            // 
            this.numR2.BackColor = System.Drawing.Color.LightCyan;
            this.numR2.ForeColor = System.Drawing.Color.Teal;
            this.numR2.Location = new System.Drawing.Point(350, 98);
            this.numR2.Name = "numR2";
            this.numR2.Size = new System.Drawing.Size(70, 24);
            this.numR2.TabIndex = 9;
            this.numR2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numR2.ValueChanged += new System.EventHandler(this.numR2_ValueChanged);
            // 
            // numMultiplier
            // 
            this.numMultiplier.BackColor = System.Drawing.Color.LightCyan;
            this.numMultiplier.ForeColor = System.Drawing.Color.Teal;
            this.numMultiplier.Location = new System.Drawing.Point(350, 138);
            this.numMultiplier.Name = "numMultiplier";
            this.numMultiplier.Size = new System.Drawing.Size(70, 24);
            this.numMultiplier.TabIndex = 10;
            this.numMultiplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numMultiplier.ValueChanged += new System.EventHandler(this.numMultiplier_ValueChanged);
            // 
            // tbAfterAdd
            // 
            this.tbAfterAdd.BackColor = System.Drawing.Color.Azure;
            this.tbAfterAdd.Cursor = System.Windows.Forms.Cursors.No;
            this.tbAfterAdd.ForeColor = System.Drawing.Color.Teal;
            this.tbAfterAdd.Location = new System.Drawing.Point(350, 238);
            this.tbAfterAdd.Name = "tbAfterAdd";
            this.tbAfterAdd.ReadOnly = true;
            this.tbAfterAdd.Size = new System.Drawing.Size(90, 24);
            this.tbAfterAdd.TabIndex = 11;
            this.tbAfterAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbAfterAdd.TextChanged += new System.EventHandler(this.tbAfterAdd_TextChanged);
            // 
            // tbAfterDiff
            // 
            this.tbAfterDiff.BackColor = System.Drawing.Color.Azure;
            this.tbAfterDiff.Cursor = System.Windows.Forms.Cursors.No;
            this.tbAfterDiff.ForeColor = System.Drawing.Color.Teal;
            this.tbAfterDiff.Location = new System.Drawing.Point(350, 278);
            this.tbAfterDiff.Name = "tbAfterDiff";
            this.tbAfterDiff.ReadOnly = true;
            this.tbAfterDiff.Size = new System.Drawing.Size(90, 24);
            this.tbAfterDiff.TabIndex = 12;
            this.tbAfterDiff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbAfterDiff.TextChanged += new System.EventHandler(this.tbAfterDiff_TextChanged);
            // 
            // tbR1AfterMultiplier
            // 
            this.tbR1AfterMultiplier.BackColor = System.Drawing.Color.Azure;
            this.tbR1AfterMultiplier.Cursor = System.Windows.Forms.Cursors.No;
            this.tbR1AfterMultiplier.ForeColor = System.Drawing.Color.Teal;
            this.tbR1AfterMultiplier.Location = new System.Drawing.Point(350, 318);
            this.tbR1AfterMultiplier.Name = "tbR1AfterMultiplier";
            this.tbR1AfterMultiplier.ReadOnly = true;
            this.tbR1AfterMultiplier.Size = new System.Drawing.Size(90, 24);
            this.tbR1AfterMultiplier.TabIndex = 13;
            this.tbR1AfterMultiplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbR1AfterMultiplier.TextChanged += new System.EventHandler(this.tbR1AfterMultiplier_TextChanged);
            // 
            // tbR2AfterMultiplier
            // 
            this.tbR2AfterMultiplier.BackColor = System.Drawing.Color.Azure;
            this.tbR2AfterMultiplier.Cursor = System.Windows.Forms.Cursors.No;
            this.tbR2AfterMultiplier.ForeColor = System.Drawing.Color.Teal;
            this.tbR2AfterMultiplier.Location = new System.Drawing.Point(351, 358);
            this.tbR2AfterMultiplier.Name = "tbR2AfterMultiplier";
            this.tbR2AfterMultiplier.ReadOnly = true;
            this.tbR2AfterMultiplier.Size = new System.Drawing.Size(90, 24);
            this.tbR2AfterMultiplier.TabIndex = 14;
            this.tbR2AfterMultiplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbR2AfterMultiplier.TextChanged += new System.EventHandler(this.tbR2AfterMultiplier_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(798, 409);
            this.Controls.Add(this.tbR2AfterMultiplier);
            this.Controls.Add(this.tbR1AfterMultiplier);
            this.Controls.Add(this.tbAfterDiff);
            this.Controls.Add(this.tbAfterAdd);
            this.Controls.Add(this.numMultiplier);
            this.Controls.Add(this.numR2);
            this.Controls.Add(this.numR1);
            this.Controls.Add(this.btnGetResult);
            this.Controls.Add(this.lbR2AfterMultiplier);
            this.Controls.Add(this.lbR1AfterMultiplier);
            this.Controls.Add(this.lbAfterDiff);
            this.Controls.Add(this.lbAfterAdd);
            this.Controls.Add(this.lbMultiplier);
            this.Controls.Add(this.lbR2);
            this.Controls.Add(this.lbR1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Програма-клієнт для тестування (з узагальненням)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numR1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numR2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMultiplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbR1;
        private System.Windows.Forms.Label lbR2;
        private System.Windows.Forms.Label lbMultiplier;
        private System.Windows.Forms.Label lbAfterAdd;
        private System.Windows.Forms.Label lbAfterDiff;
        private System.Windows.Forms.Label lbR1AfterMultiplier;
        private System.Windows.Forms.Label lbR2AfterMultiplier;
        private System.Windows.Forms.Button btnGetResult;
        private System.Windows.Forms.NumericUpDown numR1;
        private System.Windows.Forms.NumericUpDown numR2;
        private System.Windows.Forms.NumericUpDown numMultiplier;
        private System.Windows.Forms.TextBox tbAfterAdd;
        private System.Windows.Forms.TextBox tbAfterDiff;
        private System.Windows.Forms.TextBox tbR1AfterMultiplier;
        private System.Windows.Forms.TextBox tbR2AfterMultiplier;
    }
}

