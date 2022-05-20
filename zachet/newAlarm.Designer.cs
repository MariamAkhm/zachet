
namespace zachet
{
    partial class newAlarm
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
            this.components = new System.ComponentModel.Container();
            this.delete = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(69, 47);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(149, 29);
            this.delete.TabIndex = 0;
            this.delete.Text = "Отмена";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(556, 47);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(153, 29);
            this.save.TabIndex = 1;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.maskedTextBox1.Location = new System.Drawing.Point(290, 77);
            this.maskedTextBox1.Mask = "00:00";
            this.maskedTextBox1.MinimumSize = new System.Drawing.Size(200, 200);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(200, 99);
            this.maskedTextBox1.TabIndex = 2;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(290, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Название";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(290, 344);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "Повтор";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(256, 394);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(265, 29);
            this.button3.TabIndex = 5;
            this.button3.Text = "Повторение сигнала (да/нет)";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "/";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // newAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.save);
            this.Controls.Add(this.delete);
            this.Name = "newAlarm";
            this.Text = "Новый будильник";
            this.Load += new System.EventHandler(this.newAlarm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label label1;
    }
}