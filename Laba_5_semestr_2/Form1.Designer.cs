namespace Laba_5_semestr_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            V_all = new Button();
            V_1 = new Button();
            V_2 = new Button();
            VPeople_all = new ListBox();
            VPeople_1 = new ListBox();
            VPeople_2 = new ListBox();
            Vack = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // V_all
            // 
            V_all.Location = new Point(192, 69);
            V_all.Name = "V_all";
            V_all.Size = new Size(120, 70);
            V_all.TabIndex = 0;
            V_all.Text = "Отправить всех на вакцинацию";
            V_all.UseVisualStyleBackColor = true;
            V_all.Click += V_all_Click;
            // 
            // V_1
            // 
            V_1.Location = new Point(192, 173);
            V_1.Name = "V_1";
            V_1.Size = new Size(120, 70);
            V_1.TabIndex = 1;
            V_1.Text = "Отправить на первичную вакцинацию";
            V_1.UseVisualStyleBackColor = true;
            V_1.Click += V_1_Click;
            // 
            // V_2
            // 
            V_2.Location = new Point(192, 283);
            V_2.Name = "V_2";
            V_2.Size = new Size(120, 70);
            V_2.TabIndex = 2;
            V_2.Text = "Отправить на вторичную вакцинацию";
            V_2.UseVisualStyleBackColor = true;
            V_2.Click += V_2_Click;
            // 
            // VPeople_all
            // 
            VPeople_all.FormattingEnabled = true;
            VPeople_all.Location = new Point(2, 69);
            VPeople_all.Name = "VPeople_all";
            VPeople_all.Size = new Size(161, 284);
            VPeople_all.TabIndex = 3;
            // 
            // VPeople_1
            // 
            VPeople_1.FormattingEnabled = true;
            VPeople_1.Location = new Point(347, 69);
            VPeople_1.Name = "VPeople_1";
            VPeople_1.Size = new Size(200, 244);
            VPeople_1.TabIndex = 4;
            // 
            // VPeople_2
            // 
            VPeople_2.FormattingEnabled = true;
            VPeople_2.Location = new Point(586, 69);
            VPeople_2.Name = "VPeople_2";
            VPeople_2.Size = new Size(202, 244);
            VPeople_2.TabIndex = 5;
            // 
            // Vack
            // 
            Vack.Location = new Point(347, 323);
            Vack.Name = "Vack";
            Vack.Size = new Size(200, 30);
            Vack.TabIndex = 6;
            Vack.Text = "Провести вакцинацию";
            Vack.UseVisualStyleBackColor = true;
            Vack.Click += Vack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 46);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 7;
            label1.Text = "Все пациенты";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(347, 46);
            label2.Name = "label2";
            label2.Size = new Size(190, 20);
            label2.TabIndex = 8;
            label2.Text = "Пациенты на вакцинации";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(586, 46);
            label3.Name = "label3";
            label3.Size = new Size(202, 20);
            label3.TabIndex = 9;
            label3.Text = "Пациенты с сертификатами";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Vack);
            Controls.Add(VPeople_2);
            Controls.Add(VPeople_1);
            Controls.Add(VPeople_all);
            Controls.Add(V_2);
            Controls.Add(V_1);
            Controls.Add(V_all);
            Name = "Form1";
            Text = "Вакцинация пациентов";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button V_all;
        private Button V_1;
        private Button V_2;
        private ListBox VPeople_all;
        private ListBox VPeople_1;
        private ListBox VPeople_2;
        private Button Vack;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
