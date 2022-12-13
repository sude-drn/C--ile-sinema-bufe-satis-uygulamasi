namespace sinema_büfe_satış_uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, bilet, su, cay,toplam;
            misir = Convert.ToInt16(txtmisir.Text);
            su = Convert.ToInt16(txtsu.Text);
            bilet = Convert.ToInt16(txtbilet.Text);
            cay = Convert.ToInt16(txtcay.Text);
            toplam= misir * 4 + cay * 2 + su * 1+ bilet * 10;
            lbltoplam.Text = toplam.ToString()+ " TL";
            kasatutar = kasatutar + toplam;
            lblkasa.Text = kasatutar.ToString()+" TL";





        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtbilet.Text=" ";
            txtcay.Text = " ";
            txtmisir.Text = " ";
            txtsu.Text = " ";
            txtmisir.Focus();


        }
    }
}