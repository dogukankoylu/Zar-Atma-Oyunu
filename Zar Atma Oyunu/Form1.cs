namespace Zar_Atma_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sure = 30;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            
            
            

            Random rastgele = new Random();
            int zar1, zar2;
            zar1 = rastgele.Next(0, 6);
            zar2 = rastgele.Next(0, 6);
            pictureBox1.Image = ýmageList1.Images[zar1];
            pictureBox2.Image = ýmageList1.Images[zar2];

            sure = sure - 1;
            if (sure == 0)
            {
                
                timer1.Enabled =false;
                sure = 30;
            }

        }
    }
}
