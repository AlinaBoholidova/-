namespace Курсовая
{
    partial class Main
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
            this.pupilsButton_Main = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.pfilesButton_Main = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pupilsButton_Main
            // 
            this.pupilsButton_Main.Location = new System.Drawing.Point(43, 74);
            this.pupilsButton_Main.Name = "pupilsButton_Main";
            this.pupilsButton_Main.Size = new System.Drawing.Size(115, 35);
            this.pupilsButton_Main.TabIndex = 0;
            this.pupilsButton_Main.Text = "Учні";
            this.pupilsButton_Main.UseVisualStyleBackColor = true;
            this.pupilsButton_Main.Click += new System.EventHandler(this.pupilsButton_Main_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(295, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "Додаткова активність";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(530, 74);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 35);
            this.button3.TabIndex = 2;
            this.button3.Text = "Списки оплати";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(39, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Навчальний процес";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(291, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Додаткові заходи";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(526, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Оплата";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(43, 168);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 35);
            this.button4.TabIndex = 6;
            this.button4.Text = "Предмети";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(295, 127);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(115, 35);
            this.button5.TabIndex = 7;
            this.button5.Text = "Додаткова участь";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(530, 127);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(115, 35);
            this.button6.TabIndex = 8;
            this.button6.Text = "Тарифи оплати";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // pfilesButton_Main
            // 
            this.pfilesButton_Main.Location = new System.Drawing.Point(43, 122);
            this.pfilesButton_Main.Name = "pfilesButton_Main";
            this.pfilesButton_Main.Size = new System.Drawing.Size(115, 35);
            this.pfilesButton_Main.TabIndex = 9;
            this.pfilesButton_Main.Text = "Особові справи";
            this.pfilesButton_Main.UseVisualStyleBackColor = true;
            this.pfilesButton_Main.Click += new System.EventHandler(this.pfilesButton_Main_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 397);
            this.Controls.Add(this.pfilesButton_Main);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pupilsButton_Main);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "v";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pupilsButton_Main;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button pfilesButton_Main;
    }
}

