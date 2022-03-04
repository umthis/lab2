namespace lab2
{
    public partial class Form1 : Form
    {
        int[] a;
        int n;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt32(textBox1.Text);
            a = new int[n];
            Random b = new Random();
            for (int i = 0; i < n; ++i)
            {
                a[i] = b.Next(100) - 50;
                textBox2.Text += Convert.ToString(a[i]) + (char)13 + (char)10;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt32(textBox1.Text);
            int co = 0;
            for (int i = 0; i < n; ++i)
            {
                if (a[i] < 0)
                {
                    ++co;
                }
            }
            textBox3.Text = Convert.ToString(co);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int min = Math.Abs(a[0]), minid = 0, sum = 0;
            for (int i = 0; i < n; ++i)
            {
                if (min > Math.Abs(a[i]))
                {
                    min = Math.Abs(a[i]);
                    minid = i;
                }
            }
            for (int i = minid; i < n; ++i)
            {
                sum += Math.Abs(a[i]);
            }
            sum = sum - Math.Abs(a[minid]);
            textBox4.Text = Convert.ToString(sum);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int min;
            for (int i = 0; i < n; ++i)
            {
                if (a[i] < 0)
                    a[i] = a[i] * a[i];
            }
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n - 1; ++j)
                {
                    if (a[j + 1] < a[j])
                    {
                        min = a[j + 1];
                        a[j + 1] = a[j];
                        a[j] = min;
                    }
                }
            }
            for (int i = 0; i < n; ++i)
            {
                textBox5.Text += Convert.ToString(a[i]) + (char)13 + (char)10;
            }
        }
        // начало второго задния______________________________________________________
        int [,] arr = new int [6,6];
        private void button6_Click(object sender, EventArgs e)
        {
            Random b = new Random();
            dataGridView1.RowCount = 6;
            dataGridView1.ColumnCount = 6;
            for  (int i = 0; i < 6; ++i)
            {
                for (int j=0; j < 6; ++j)
                {
                    arr[i, j] = b.Next(100);
                    dataGridView1.Rows[i].Cells[j].Value = arr[i,j];
                }
            }
        }
    }
}