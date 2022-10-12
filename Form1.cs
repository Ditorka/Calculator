namespace BalanceCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //a+b
        private void btn_sum_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(txt_a.Text) || string.IsNullOrWhiteSpace(txt_b.Text) || string.IsNullOrWhiteSpace(txt_m.Text)) == false)
            {
                int A = int.Parse(txt_a.Text);
                int B = int.Parse(txt_b.Text);
                int M = int.Parse(txt_m.Text);
                int Result = (A + B) % M;
                txt_r.Text = string.Format("{0} + {1} (mod{2}) = {3}", A, B, M, Result);
            }
            else
            {
                MessageBox.Show("Çàïîâí³òü óñ³ ïîëÿ, áóäü ëàñêà :)");
            }
        }
        //-a
        private void btn_inv_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(txt_a.Text) || string.IsNullOrWhiteSpace(txt_m.Text)) == false)
            {
                int A = int.Parse(txt_a.Text);
                int M = int.Parse(txt_m.Text);
                int Result = M - A;
                txt_r.Text = string.Format("(mod{1}) - {0} = {2}", A, M, Result);
            }
            else
            {
                MessageBox.Show("Çàïîâí³òü ïîëå à òà ïîëå ìîäóëþ, áóäü ëàñêà :)");
            }
        }
        //a-b
        private void btn_dif_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(txt_a.Text) || string.IsNullOrWhiteSpace(txt_b.Text) || string.IsNullOrWhiteSpace(txt_m.Text)) == false)
            {
                int A = int.Parse(txt_a.Text);
                int B = int.Parse(txt_b.Text);
                int M = int.Parse(txt_m.Text);
                int inv_B = M - B;
                int Result = (inv_B + A) % M;
                txt_r.Text = string.Format("{0} + -{1} (mod{2}) = {3}", A, B, M, Result);
            }
            else
            {
                MessageBox.Show("Çàïîâí³òü óñ³ ïîëÿ, áóäü ëàñêà :)");
            }
        }
        //a*b
        private void btn_mul_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(txt_a.Text) || string.IsNullOrWhiteSpace(txt_b.Text) || string.IsNullOrWhiteSpace(txt_m.Text)) == false)
            {
                int A = int.Parse(txt_a.Text);
                int B = int.Parse(txt_b.Text);
                int M = int.Parse(txt_m.Text);
                int Result = (A * B) % M;
                txt_r.Text = string.Format("{0} * {1} (mod{2}) = {3}", A, B, M, Result);
            }
            else
            {
                MessageBox.Show("Çàïîâí³òü óñ³ ïîëÿ, áóäü ëàñêà :)");
            }
        }
        //a^(-1)
        private void btn_inv_del_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(txt_a.Text) || string.IsNullOrWhiteSpace(txt_m.Text)) == false)
            {
                int A = int.Parse(txt_a.Text);
                int M = int.Parse(txt_m.Text);
                int Result;
                for (int i = 0; i < M; i++)
                {
                    Result = (A * i) % M;
                    if (Result == 1)
                        txt_r.Text = string.Format("{0}^(-1) (mod{1}) = {2}", A, M, i);
                }
            }
            else
            {
                MessageBox.Show("Çàïîâí³òü ïîëå à òà ïîëå ìîäóëþ, áóäü ëàñêà :)");
            }
        }
        // /
        private void btn_del_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(txt_a.Text) || string.IsNullOrWhiteSpace(txt_b.Text) || string.IsNullOrWhiteSpace(txt_m.Text)) == false)
            {
                int A = int.Parse(txt_a.Text);
                int B = int.Parse(txt_b.Text);
                int M = int.Parse(txt_m.Text);
                int Result;
                for (int i = 0; i < M; i++)
                {
                    Result = (B * i) % M;
                    if (Result == 1)
                    {
                        Result = (A * i) % M;
                        txt_r.Text = string.Format("{0} * {1}^(-1) (mod{2}) = {3}", A, B, M, Result);
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Çàïîâí³òü óñ³ ïîëÿ, áóäü ëàñêà :)");
            }
        }

        //^
        private void btn_exp_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(txt_a.Text) || string.IsNullOrWhiteSpace(txt_b.Text) || string.IsNullOrWhiteSpace(txt_m.Text)) == false)
            {
                int A = int.Parse(txt_a.Text);
                int B = int.Parse(txt_b.Text);
                int M = int.Parse(txt_m.Text);
                int P = 1;
                for (int i = 0; i < B; i++)
                {
                    P *= A;
                    P %= M;
                }
                txt_r.Text = string.Format("{0} ^ {1} (mod{2}) = {3}", A, B, M, P);
            }
            else
            {
                MessageBox.Show("Çàïîâí³òü óñ³ ïîëÿ, áóäü ëàñêà :)");
            }
        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            txt_a.Text = String.Empty;
            txt_b.Text = String.Empty;
            txt_m.Text = String.Empty;
            txt_r.Text = String.Empty;
            lbl_prime.Text = String.Empty;
            lbl_evk.Text = String.Empty;
        }

        private void btn_prime_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_a.Text) == false)
            {
                int number = int.Parse(txt_a.Text);

                int divisor = 0;

                for (int i = 1; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        divisor++;
                    }
                }

                if (divisor == 2)
                    lbl_prime.Text = "Òàê!";
                else
                    lbl_prime.Text = "Í³!";
            }
            else
            {
                MessageBox.Show("Çàïîâí³òü ïîëå à, áóäü ëàñêà :)");
            }
        }

        private void btn_gen_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_a.Text) == false)
            {
                int number = int.Parse(txt_a.Text);

                int divisor = 0;

                for (int k = number; k > 1; k--)
                {

                    for (int i = 1; i <= k; i++)
                    {
                        if (k % i == 0)
                        {
                            divisor++;
                        }
                    }

                    if (divisor == 2)
                    {
                        txt_r.Text = string.Format("{0}", k);
                        break;
                    }

                    divisor = 0;
                }
            }
            else
            {
                MessageBox.Show("Çàïîâí³òü ïîëå à, áóäü ëàñêà :)");
            }
        }

        private void btn_evk_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(txt_a.Text) || string.IsNullOrWhiteSpace(txt_b.Text)) == false)
            {
                int A = int.Parse(txt_a.Text);
                int B = int.Parse(txt_b.Text);

                int maxNum, minNum;

                if (A > B)
                {
                    maxNum = A;
                    minNum = B;
                }
                else
                {
                    maxNum = B;
                    minNum = A;
                }

                int Result;

                for (int i = 0; i < B; i++)
                {
                    Result = maxNum % minNum;

                    if (Result == 0)
                    {
                        txt_r.Text = string.Format("Íàéá³ëüøèé ä³ëüíèê äëÿ äâîõ ÷èñåë: {0}", minNum);
                        if (minNum == 1)
                            lbl_evk.Text = string.Format("×èñëà º âçàºìíî ïðîñò³!");
                        else
                            lbl_evk.Text = string.Format("×èñëà íå º âçàºìíî ïðîñò³!");
                        break;
                    }
                    else
                    {
                        maxNum = minNum;
                        minNum = Result;
                    }
                }
            }
            else
            {
                MessageBox.Show("Çàïîâí³òü ïîëÿ a òà b , áóäü ëàñêà :)");
            }
        }

        private void btn_eul_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_a.Text) == false)
            {
                int A = int.Parse(txt_a.Text);

                int Result = A;

                for (int i = 2; i * i <= A; ++i)
                {
                    if (A % i == 0)
                    {
                        while (A % i == 0)
                        {
                            A /= i;
                        }
                        Result -= Result / i;
                    }
                }
                if (A > 1)
                    Result -= Result / A;
                txt_r.Text = string.Format("{0}", Result);
            }
            else
            {
                MessageBox.Show("Çàïîâí³òü ïîëå à, áóäü ëàñêà :)");
            }
        }

        private void btn_inv_eul_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(txt_a.Text) || string.IsNullOrWhiteSpace(txt_m.Text)) == false)
            {
                int M = int.Parse(txt_m.Text);

                int Result = M;

                for (int i = 2; i * i <= M; ++i)
                {
                    if (M % i == 0)
                    {
                        while (M % i == 0)
                        {
                            M /= i;
                        }
                        Result -= Result / i;
                    }
                }
                if (M > 1)
                    Result -= Result / M;

                int A = int.Parse(txt_a.Text);
                M = int.Parse(txt_m.Text);
                int P = 1;
                Result -= 1;

                for (int i = 0; i < Result; i++)
                {
                    P *= A;
                    P %= M;
                }
                //proof

                Result = (A * P) % M;
                if (Result == 1)
                    txt_r.Text = string.Format("{0}^(-1) (mod{1}) = {2}", A, M, P);
            }
            else
            {
                MessageBox.Show("Çàïîâí³òü ïîëå à, áóäü ëàñêà :)");
            }
        }
    }
}
