namespace practica1LabVideo
{
    public partial class PARALLAX : Form
    {
        // GLOBAL VARIABLES

        int motion1 = 2;
        int motion2 = 4;
        int motion3 = 8;
        int motion4 = 16;

        int width = 688;

        int l1_x1, l1_x2, l2_x1, l2_x2, l3_x1, l3_x2; // layers

        Bitmap layer1, layer2, layer3;
        bool right, hold = true;

        private void player_Click(object sender, EventArgs e)
        {

        }

        static Graphics g;

       
        
        public PARALLAX()
        {
            InitializeComponent();

            layer1 = Resource1.L1_1_;
            layer2 = Resource1.L2_1_;
            layer3 = Resource1.L3_1_;

            l1_x1 = l2_x1 = l3_x1 = 0;
            l1_x2 = l2_x2 = l3_x2 = width;

            player.Image = Resource1.Mhold_1_;
        }

        private void PARALLAX_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)

        {

            if (right)
                BackgroundMove();

        }

        private void PARALLAX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Right & hold)
            {
                right = true;
                hold = false;
                player.Image = Resource1.running_1_;
            }

        }

        private void PARALLAX_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Right & !hold)
            {
                right = false;
                hold = true;
                player.Image = Resource1.Mhold_1_;
            }

        }

        private void PARALLAX_Paint(object sender, PaintEventArgs e)

        {
            g = e.Graphics;
            g.DrawImage(layer1, l1_x1, 0, layer1.Width, this.Height - 50);
            g.DrawImage(layer1, l1_x2, 0, layer1.Width, this.Height - 50);

            g.DrawImage(layer2, l2_x1, 50, layer1.Width, this.Height - 150);
            g.DrawImage(layer2, l2_x2, 50, layer1.Width, this.Height - 150);

            g.DrawImage(layer3, l3_x1, 0, layer1.Width, this.Height - 50);
            g.DrawImage(layer3, l3_x2, 0, layer1.Width, this.Height - 50);


            /* recibe que imagenobjeto dibujas y luego el punto inicial de la esquina superior izquierda */

        }

        private void BackgroundMove()
        {

            if (l1_x1 < -width) { l1_x1 = width - motion1; }
            { l1_x1 -= motion1; l1_x2 -= motion1; }
            if (l1_x2 < -width) { l1_x2 = width - motion1; }

            /**/
            if (l2_x1 < -width) {l2_x1 = width - motion2; }
            { l2_x1 -= motion2;l2_x2 -= motion2; }
            if(l2_x2 < -width) { l2_x2 = width - motion2; }

           

            if (l3_x1 < -(width)) { l3_x1 = width - motion3; }
            { l3_x1 -= motion3; l3_x2 -= motion3; }
            if (l3_x2 < -width) { l3_x2 = width - motion3; }

            Invalidate();       
        }
    }
}