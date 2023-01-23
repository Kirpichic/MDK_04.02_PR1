
namespace MDK_04._02_PR1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Линейный = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.textBoxZ = new System.Windows.Forms.TextBox();
            this.Otwet = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Линейный.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Линейный
            // 
            this.Линейный.Controls.Add(this.tabPage1);
            this.Линейный.Controls.Add(this.tabPage2);
            this.Линейный.Location = new System.Drawing.Point(3, 1);
            this.Линейный.Name = "Линейный";
            this.Линейный.SelectedIndex = 0;
            this.Линейный.Size = new System.Drawing.Size(465, 611);
            this.Линейный.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.Otwet);
            this.tabPage1.Controls.Add(this.textBoxZ);
            this.tabPage1.Controls.Add(this.textBoxY);
            this.tabPage1.Controls.Add(this.textBoxX);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(457, 585);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Линейный";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(16, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Введите значение Z:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(16, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите значение Y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите значение X:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(409, 131);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(457, 618);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Разветвляющийся";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(243, 169);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(185, 20);
            this.textBoxX.TabIndex = 4;
            this.textBoxX.TextChanged += new System.EventHandler(this.textBoxX_TextChanged);
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(243, 214);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(185, 20);
            this.textBoxY.TabIndex = 5;
            this.textBoxY.TextChanged += new System.EventHandler(this.textBoxY_TextChanged);
            // 
            // textBoxZ
            // 
            this.textBoxZ.Location = new System.Drawing.Point(243, 261);
            this.textBoxZ.Name = "textBoxZ";
            this.textBoxZ.Size = new System.Drawing.Size(185, 20);
            this.textBoxZ.TabIndex = 6;
            this.textBoxZ.TextChanged += new System.EventHandler(this.textBoxZ_TextChanged);
            // 
            // Otwet
            // 
            this.Otwet.Location = new System.Drawing.Point(19, 321);
            this.Otwet.Name = "Otwet";
            this.Otwet.Size = new System.Drawing.Size(409, 177);
            this.Otwet.TabIndex = 7;
            this.Otwet.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(184, 534);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Ответ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 616);
            this.Controls.Add(this.Линейный);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Линейный.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Линейный;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxZ;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.RichTextBox Otwet;
        private System.Windows.Forms.Button button1;
    }
}

