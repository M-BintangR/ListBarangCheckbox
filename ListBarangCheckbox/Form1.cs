namespace ListBarangCheckbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked)
            {
                this.listBox1.Items.Add("Beras");
                this.comboBox1.Items.Add("Beras");
            }

            if (this.checkBox2.Checked)
            {
                this.listBox1.Items.Add("Terigu");
                this.comboBox1.Items.Add("Terigu");
            }

            if (this.checkBox3.Checked)
            {
                this.listBox1.Items.Add("Telur");
                this.comboBox1.Items.Add("Telur");
            }

            if (this.checkBox4.Checked)
            {
                this.listBox1.Items.Add("Roti");
                this.comboBox1.Items.Add("Roti");
            }

            if (this.checkBox5.Checked)
            {
                this.listBox1.Items.Add("Mie Instant");
                this.comboBox1.Items.Add("Mie Instant");
            }

            if (this.checkBox6.Checked)
            {
                this.listBox1.Items.Add("Kopi");
                this.comboBox1.Items.Add("Kopi");
            }

            if (this.checkBox7.Checked)
            {
                this.listBox1.Items.Add("Gula");
                this.comboBox1.Items.Add("Gula");
            }

            if (this.checkBox8.Checked)
            {
                this.listBox1.Items.Add("Kanji");
                this.comboBox1.Items.Add("Kanji");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.label2.Text = this.comboBox1.Text;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.label3.Text = this.listBox1.Text;
        }
    }
}
