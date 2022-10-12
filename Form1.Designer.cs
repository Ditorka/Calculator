namespace BalanceCalculator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.btn_sum = new System.Windows.Forms.Button();
            this.btn_inv = new System.Windows.Forms.Button();
            this.btn_dif = new System.Windows.Forms.Button();
            this.btn_mul = new System.Windows.Forms.Button();
            this.btn_exp = new System.Windows.Forms.Button();
            this.btn_out = new System.Windows.Forms.Button();
            this.txt_a = new System.Windows.Forms.TextBox();
            this.lbl_a = new System.Windows.Forms.Label();
            this.txt_b = new System.Windows.Forms.TextBox();
            this.lbl_b = new System.Windows.Forms.Label();
            this.txt_m = new System.Windows.Forms.TextBox();
            this.lbl_m = new System.Windows.Forms.Label();
            this.lbl_r = new System.Windows.Forms.Label();
            this.txt_r = new System.Windows.Forms.TextBox();
            this.btn_prime = new System.Windows.Forms.Button();
            this.lbl_prime = new System.Windows.Forms.Label();
            this.btn_gen = new System.Windows.Forms.Button();
            this.btn_evk = new System.Windows.Forms.Button();
            this.lbl_evk = new System.Windows.Forms.Label();
            this.btn_eul = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_inv_del = new System.Windows.Forms.Button();
            this.btn_inv_eul = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_sum
            // 
            this.btn_sum.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btn_sum.Location = new System.Drawing.Point(49, 76);
            this.btn_sum.Name = "btn_sum";
            this.btn_sum.Size = new System.Drawing.Size(163, 56);
            this.btn_sum.TabIndex = 1;
            this.btn_sum.Text = "Додавання a+b";
            this.btn_sum.UseVisualStyleBackColor = true;
            this.btn_sum.Click += new System.EventHandler(this.btn_sum_Click);
            // 
            // btn_inv
            // 
            this.btn_inv.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btn_inv.Location = new System.Drawing.Point(49, 161);
            this.btn_inv.Name = "btn_inv";
            this.btn_inv.Size = new System.Drawing.Size(163, 56);
            this.btn_inv.TabIndex = 3;
            this.btn_inv.Text = "Зворотній елемент (-а)";
            this.btn_inv.UseVisualStyleBackColor = true;
            this.btn_inv.Click += new System.EventHandler(this.btn_inv_Click);
            // 
            // btn_dif
            // 
            this.btn_dif.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btn_dif.Location = new System.Drawing.Point(49, 247);
            this.btn_dif.Name = "btn_dif";
            this.btn_dif.Size = new System.Drawing.Size(163, 56);
            this.btn_dif.TabIndex = 4;
            this.btn_dif.Text = "Віднімання a-b";
            this.btn_dif.UseVisualStyleBackColor = true;
            this.btn_dif.Click += new System.EventHandler(this.btn_dif_Click);
            // 
            // btn_mul
            // 
            this.btn_mul.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btn_mul.Location = new System.Drawing.Point(677, 29);
            this.btn_mul.Name = "btn_mul";
            this.btn_mul.Size = new System.Drawing.Size(163, 56);
            this.btn_mul.TabIndex = 5;
            this.btn_mul.Text = "Множенняa a*b";
            this.btn_mul.UseVisualStyleBackColor = true;
            this.btn_mul.Click += new System.EventHandler(this.btn_mul_Click);
            // 
            // btn_exp
            // 
            this.btn_exp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btn_exp.Location = new System.Drawing.Point(677, 292);
            this.btn_exp.Name = "btn_exp";
            this.btn_exp.Size = new System.Drawing.Size(163, 56);
            this.btn_exp.TabIndex = 6;
            this.btn_exp.Text = "Зведення в ступінь a^b";
            this.btn_exp.UseVisualStyleBackColor = true;
            this.btn_exp.Click += new System.EventHandler(this.btn_exp_Click);
            // 
            // btn_out
            // 
            this.btn_out.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_out.ForeColor = System.Drawing.Color.Black;
            this.btn_out.Location = new System.Drawing.Point(374, 353);
            this.btn_out.Name = "btn_out";
            this.btn_out.Size = new System.Drawing.Size(150, 71);
            this.btn_out.TabIndex = 13;
            this.btn_out.Text = "Очистити";
            this.btn_out.UseVisualStyleBackColor = true;
            this.btn_out.Click += new System.EventHandler(this.btn_out_Click);
            // 
            // txt_a
            // 
            this.txt_a.Location = new System.Drawing.Point(347, 149);
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(78, 27);
            this.txt_a.TabIndex = 14;
            // 
            // lbl_a
            // 
            this.lbl_a.AutoSize = true;
            this.lbl_a.Location = new System.Drawing.Point(310, 152);
            this.lbl_a.Name = "lbl_a";
            this.lbl_a.Size = new System.Drawing.Size(31, 20);
            this.lbl_a.TabIndex = 15;
            this.lbl_a.Text = "a =";
            // 
            // txt_b
            // 
            this.txt_b.Location = new System.Drawing.Point(481, 149);
            this.txt_b.Name = "txt_b";
            this.txt_b.Size = new System.Drawing.Size(78, 27);
            this.txt_b.TabIndex = 16;
            // 
            // lbl_b
            // 
            this.lbl_b.AutoSize = true;
            this.lbl_b.Location = new System.Drawing.Point(443, 152);
            this.lbl_b.Name = "lbl_b";
            this.lbl_b.Size = new System.Drawing.Size(32, 20);
            this.lbl_b.TabIndex = 17;
            this.lbl_b.Text = "b =";
            // 
            // txt_m
            // 
            this.txt_m.Location = new System.Drawing.Point(416, 204);
            this.txt_m.Name = "txt_m";
            this.txt_m.Size = new System.Drawing.Size(78, 27);
            this.txt_m.TabIndex = 18;
            // 
            // lbl_m
            // 
            this.lbl_m.AutoSize = true;
            this.lbl_m.Location = new System.Drawing.Point(374, 207);
            this.lbl_m.Name = "lbl_m";
            this.lbl_m.Size = new System.Drawing.Size(36, 20);
            this.lbl_m.TabIndex = 19;
            this.lbl_m.Text = "m =";
            // 
            // lbl_r
            // 
            this.lbl_r.AutoSize = true;
            this.lbl_r.Location = new System.Drawing.Point(259, 283);
            this.lbl_r.Name = "lbl_r";
            this.lbl_r.Size = new System.Drawing.Size(82, 20);
            this.lbl_r.TabIndex = 20;
            this.lbl_r.Text = "Результат: ";
            // 
            // txt_r
            // 
            this.txt_r.Location = new System.Drawing.Point(347, 280);
            this.txt_r.Multiline = true;
            this.txt_r.Name = "txt_r";
            this.txt_r.Size = new System.Drawing.Size(212, 49);
            this.txt_r.TabIndex = 21;
            // 
            // btn_prime
            // 
            this.btn_prime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btn_prime.Location = new System.Drawing.Point(49, 434);
            this.btn_prime.Name = "btn_prime";
            this.btn_prime.Size = new System.Drawing.Size(163, 56);
            this.btn_prime.TabIndex = 22;
            this.btn_prime.Text = "Число - просте?";
            this.btn_prime.UseVisualStyleBackColor = true;
            this.btn_prime.Click += new System.EventHandler(this.btn_prime_Click);
            // 
            // lbl_prime
            // 
            this.lbl_prime.AutoSize = true;
            this.lbl_prime.Location = new System.Drawing.Point(237, 452);
            this.lbl_prime.Name = "lbl_prime";
            this.lbl_prime.Size = new System.Drawing.Size(0, 20);
            this.lbl_prime.TabIndex = 23;
            // 
            // btn_gen
            // 
            this.btn_gen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btn_gen.Location = new System.Drawing.Point(49, 511);
            this.btn_gen.Name = "btn_gen";
            this.btn_gen.Size = new System.Drawing.Size(163, 56);
            this.btn_gen.TabIndex = 24;
            this.btn_gen.Text = "Генерація простого числа";
            this.btn_gen.UseVisualStyleBackColor = true;
            this.btn_gen.Click += new System.EventHandler(this.btn_gen_Click);
            // 
            // btn_evk
            // 
            this.btn_evk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btn_evk.Location = new System.Drawing.Point(677, 434);
            this.btn_evk.Name = "btn_evk";
            this.btn_evk.Size = new System.Drawing.Size(163, 56);
            this.btn_evk.TabIndex = 25;
            this.btn_evk.Text = "Алгоритм Евкліда";
            this.btn_evk.UseVisualStyleBackColor = true;
            this.btn_evk.Click += new System.EventHandler(this.btn_evk_Click);
            // 
            // lbl_evk
            // 
            this.lbl_evk.AutoSize = true;
            this.lbl_evk.Location = new System.Drawing.Point(645, 411);
            this.lbl_evk.Name = "lbl_evk";
            this.lbl_evk.Size = new System.Drawing.Size(224, 20);
            this.lbl_evk.TabIndex = 26;
            this.lbl_evk.Text = "Відповідь на Алгоритм Евкліда";
            // 
            // btn_eul
            // 
            this.btn_eul.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btn_eul.Location = new System.Drawing.Point(677, 511);
            this.btn_eul.Name = "btn_eul";
            this.btn_eul.Size = new System.Drawing.Size(163, 56);
            this.btn_eul.TabIndex = 27;
            this.btn_eul.Text = "Функція Ейлера a^(-1)";
            this.btn_eul.UseVisualStyleBackColor = true;
            this.btn_eul.Click += new System.EventHandler(this.btn_eul_Click);
            // 
            // btn_del
            // 
            this.btn_del.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btn_del.Location = new System.Drawing.Point(677, 116);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(163, 56);
            this.btn_del.TabIndex = 28;
            this.btn_del.Text = "Ділення a*b^(-1)";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_inv_del
            // 
            this.btn_inv_del.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btn_inv_del.Location = new System.Drawing.Point(677, 204);
            this.btn_inv_del.Name = "btn_inv_del";
            this.btn_inv_del.Size = new System.Drawing.Size(163, 56);
            this.btn_inv_del.TabIndex = 29;
            this.btn_inv_del.Text = "Зворотній елемент а^(-1)";
            this.btn_inv_del.UseVisualStyleBackColor = true;
            this.btn_inv_del.Click += new System.EventHandler(this.btn_inv_del_Click);
            // 
            // btn_inv_eul
            // 
            this.btn_inv_eul.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btn_inv_eul.Location = new System.Drawing.Point(677, 589);
            this.btn_inv_eul.Name = "btn_inv_eul";
            this.btn_inv_eul.Size = new System.Drawing.Size(163, 56);
            this.btn_inv_eul.TabIndex = 30;
            this.btn_inv_eul.Text = "Зворотній елемент ф. Ейлера а^(-1)";
            this.btn_inv_eul.UseVisualStyleBackColor = true;
            this.btn_inv_eul.Click += new System.EventHandler(this.btn_inv_eul_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(919, 692);
            this.Controls.Add(this.btn_inv_eul);
            this.Controls.Add(this.btn_inv_del);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_eul);
            this.Controls.Add(this.lbl_evk);
            this.Controls.Add(this.btn_evk);
            this.Controls.Add(this.btn_gen);
            this.Controls.Add(this.lbl_prime);
            this.Controls.Add(this.btn_prime);
            this.Controls.Add(this.txt_r);
            this.Controls.Add(this.lbl_r);
            this.Controls.Add(this.lbl_m);
            this.Controls.Add(this.txt_m);
            this.Controls.Add(this.lbl_b);
            this.Controls.Add(this.txt_b);
            this.Controls.Add(this.lbl_a);
            this.Controls.Add(this.txt_a);
            this.Controls.Add(this.btn_out);
            this.Controls.Add(this.btn_exp);
            this.Controls.Add(this.btn_mul);
            this.Controls.Add(this.btn_dif);
            this.Controls.Add(this.btn_inv);
            this.Controls.Add(this.btn_sum);
            this.Name = "Form1";
            this.Text = "Калькулятор Срібної Владіміри";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_sum;
        private Button btn_inv;
        private Button btn_dif;
        private Button btn_mul;
        private Button btn_exp;
        private Button btn_out;
        private TextBox txt_a;
        private Label lbl_a;
        private TextBox txt_b;
        private Label lbl_b;
        private TextBox txt_m;
        private Label lbl_m;
        private Label lbl_r;
        private TextBox txt_r;
        private Button btn_prime;
        private Label lbl_prime;
        private Button btn_gen;
        private Button btn_evk;
        private Label lbl_evk;
        private Button btn_eul;
        private Button btn_del;
        private Button btn_inv_del;
        private Button btn_inv_eul;
    }
}
