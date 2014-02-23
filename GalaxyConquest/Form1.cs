using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Media;

namespace GalaxyConquest
{
    public partial class Form1 : Form
    {
        public ModelGalaxy galaxy;
        public Bitmap galaxyBitmap;

        public double spinX = 0.0;
        public double spinY = 0.0;

        public float scaling = 1f;
        public int horizontal = 0;
        public int vertical = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void mainMenuQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mainMenuNew_Click(object sender, EventArgs e)
        {
            Form_NewGameDialog nd = new Form_NewGameDialog();
            if (nd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                galaxy = new ModelGalaxy();
                galaxy.name = "Млечный путь";

                generate_map(true, nd.getGalaxySize());
                generate_map(false, nd.getGalaxySize());

            }

#region someoldcode
            /*
            Random r = new Random();

            for (int i = 0; i < 100; i++)
            {

                StarSystem s = new StarSystem();
                s.name = "Солнце_" + i.ToString();
                s.type = 1;
                s.x = 200.0 - 400.0 * r.NextDouble();
                s.y = 200.0 - 400.0 * r.NextDouble();
                s.z = 200.0 - 400.0 * r.NextDouble();

                galaxy.stars.Add(s);
            }

            */
            /*
            galaxy = new ModelGalaxy();
            galaxy.name = "Млечный путь";

            StarSystem s = new StarSystem();
            s.name = "Солнце";
            s.type = 1;
            s.x = 50.0;
            s.y = 50.0;
            s.z = 50.0;

            galaxy.stars.Add(s);

            s = new StarSystem();
            s.name = "Альфа Центавра";
            s.type = 1;
            s.x = 50.0;
            s.y = 50.0;
            s.z = -50.0;

            galaxy.stars.Add(s);


            s = new StarSystem();
            s.name = "Бетельгейзе";
            s.type = 1;
            s.x = 50.0;
            s.y = -50.0;
            s.z = 50.0;

            galaxy.stars.Add(s);


            s = new StarSystem();
            s.name = "Бетельгейзе";
            s.type = 1;
            s.x = -50.0;
            s.y = 50.0;
            s.z = 50.0;
            galaxy.stars.Add(s);

            s = new StarSystem();
            s.name = "Бетельгейзе";
            s.type = 1;
            s.x = -50.0;
            s.y = -50.0;
            s.z = 50.0;
            galaxy.stars.Add(s);

            s = new StarSystem();
            s.name = "Бетельгейзе";
            s.type = 1;
            s.x = -50.0;
            s.y = 50.0;
            s.z = -50.0;
            galaxy.stars.Add(s);


            s = new StarSystem();
            s.name = "Бетельгейзе";
            s.type = 1;
            s.x = 50.0;
            s.y = -50.0;
            s.z = -50.0;
            galaxy.stars.Add(s);

            s = new StarSystem();
            s.name = "Бетельгейзе";
            s.type = 1;
            s.x = -50.0;
            s.y = -50.0;
            s.z = -50.0;
            galaxy.stars.Add(s);

            StarWarp w = new StarWarp();
            w.name = "warp1";
            w.type = 1;
            w.system1 = galaxy.stars[0];
            w.system2 = galaxy.stars[2];

            galaxy.lanes.Add(w);
             */
#endregion
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            Redraw();
        }

        private void buttonSpinLeft_Click(object sender, EventArgs e)
        {
            spinX -= 0.2;
            Redraw();
        }

        private void buttonSpinRight_Click(object sender, EventArgs e)
        {
            spinX += 0.2;
            Redraw();
        }


        private void buttonScalingUp_Click(object sender, EventArgs e)
        {
            if (scaling >= 10)
            {
                return;
            }

            else
            {
                scaling += 1f;
                Redraw();
            }
        }

        private void buttonScalingDown_Click(object sender, EventArgs e)
        {
            if (scaling <= 1)
            {
                return;
            }
            else
            {
                scaling -= 1f;
                Redraw();
            }
        }


        private void buttonMoveRight_Click(object sender, EventArgs e)
        {
            horizontal += 5;
            Redraw();
        }

        private void buttonMoveLeft_Click(object sender, EventArgs e)
        {
            horizontal -= 5;
            Redraw();
        }

        private void buttonMoveUp_Click(object sender, EventArgs e)
        {
            vertical -= 5;
            Redraw();
        }

        private void buttonMoveDown_Click(object sender, EventArgs e)
        {
            vertical += 5;
            Redraw();
        }


        public void Redraw()
        {
            if (galaxy == null)
            {
                MessageBox.Show("Error occured :`(\n\n'Nothing to draw'", "Draw Galaxy", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            galaxyBitmap = new Bitmap(galaxyImage.Width, galaxyImage.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            Graphics g = Graphics.FromImage(galaxyBitmap);
            

            
            g.ScaleTransform(scaling, scaling);
            
            g.FillRectangle(Brushes.Black, 0, 0, galaxyBitmap.Width, galaxyBitmap.Height);

            
            g.DrawString(galaxy.name, new Font("Arial", 10.0F), Brushes.White, new PointF(1.0F, 1.0F));



            int centerX = galaxyBitmap.Width / 2 / (int)scaling;
            int centerY = galaxyBitmap.Height / 2 / (int)scaling;

            centerX += horizontal;
            centerY += vertical;

            int starSize = 0;




            double screenX;
            double screenY;





            //рисуем звездные системы
            for (int i = 0; i < galaxy.stars.Count; i++)
            {
                StarSystem s = galaxy.stars[i];

                double tX, tY, tZ;

                tX = s.x * Math.Cos(spinX) - s.z * Math.Sin(spinX);
                tZ = s.x * Math.Sin(spinX) + s.z * Math.Cos(spinX);
                tY = s.y * Math.Cos(spinY) - tZ * Math.Sin(spinY);
                screenX = tX;
                screenY = tY;

                starSize = s.type + 4;
                
               

                //create new brush with color from alfa and RGB
                SolidBrush br = new SolidBrush(Color.FromArgb(s.color_A, s.color_R, s.color_G, s.color_B));
                
                g.FillEllipse(br, centerX + (int)screenX - starSize / 2, centerY + (int)screenY - starSize / 2, starSize, starSize);
                g.DrawString(s.name, new Font("Arial", 8.0F), Brushes.White, new PointF(centerX + (int)screenX, centerY + (int)screenY));
                
            }












            //рисуем гиперпереходы
            for (int i = 0; i < galaxy.lanes.Count; i++)
            {
                StarWarp w = galaxy.lanes[i];

                g.DrawLine(Pens.Gray,
                    new Point((centerX + (int)w.system1.x), (centerY + (int)w.system1.y)),
                    new Point((centerX + (int)w.system2.x), (centerY + (int)w.system2.y)));
            }

            galaxyImage.Image = galaxyBitmap;
            galaxyImage.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            spinY -= 0.2;
            Redraw();
        }

        private void buttonSpinUp_Click(object sender, EventArgs e)
        {
            spinY += 0.2;
            Redraw();
        }

        private void mainMenuSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sDlg = new SaveFileDialog();
            if (sDlg.ShowDialog() == DialogResult.OK)
            {
                string fileName = sDlg.FileName;

                FileStream fs = new FileStream(fileName, FileMode.CreateNew);

                
                //XmlSerializer xs = new XmlSerializer(typeof(ModelGalaxy));
                //xs.Serialize(fs, galaxy);                
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, galaxy);

                fs.Close();


            }
        }

        private void mainMenuOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog sDlg = new OpenFileDialog();
            if (sDlg.ShowDialog() == DialogResult.OK)
            {
                string fileName = sDlg.FileName;

                FileStream fs = new FileStream(fileName, FileMode.Open);


                //XmlSerializer xs = new XmlSerializer(typeof(ModelGalaxy));
                //xs.Serialize(fs, galaxy);                
                BinaryFormatter bf = new BinaryFormatter();
                galaxy = (ModelGalaxy)bf.Deserialize(fs);

                fs.Close();

                Redraw();
            }

        }

        private void mainMenuAbout_Click(object sender, EventArgs e)
        {
            Form_About af = new Form_About();
            af.ShowDialog();
        }

        public void generate_map(bool rotate, int galaxysize)
        {
            Double x;
            Double y;
            Double r;
            Double t;
            Double z = 0;
            Double curve = 0;
            Random rand = new Random();

            for (int j = 0; j < 30 * (galaxysize + 1); j++)
            {
                r = 0;
                t = 0;
                for (int i = 0; i < 40; i++)
                {
                    r += rand.Next(4) + 2 + galaxysize;
                    curve = Math.Pow((r - 4), 2);
                    curve = curve / 150;
                    t += 0.2;
                    z = t + (rand.NextDouble() - 0.5) * 2;
                    x = curve * Math.Cos(z) + rand.Next(30) - 15;
                    y = curve * Math.Sin(z) + rand.Next(30) - 15;

                    if (rotate == true)
                    {
                        x = -x;
                        y = -y;
                    }

                    StarSystem s = new StarSystem();
                    s.x = x;
                    s.y = -5.0 + rand.NextDouble() * 10.0;
                    s.z = y;
                    s.type = rand.Next(7);  //type impact on size and color
                    s.name = "";
                    //RGB color with alfa
                    s.color_A = rand.Next(200) + 55;
                    switch (s.type)
                    {
                        //O - Blue, t =30 000 — 60 000 K
                        case 0:
                            s.color_R = 123;
                            s.color_G = 104;
                            s.color_B = 238;
                        break;

                        //B - Light blue, t = 10 500 — 30 000 K
                        case 1:
                            s.color_A = 180;
                            s.color_R = 135;
                            s.color_G = 206;
                            s.color_B = 235;
                        break;

                        //A - White, t = 7500—10 000 K
                        case 2:
                            s.color_R = 255;
                            s.color_G = 250;
                            s.color_B = 240;
                        break;

                        //F - Light Yellow, t = 6000—7200 K
                        case 3:
                            s.color_A = 180;
                            s.color_R = 255;
                            s.color_G = 255;
                            s.color_B = 0;
                        break;

                        //G - Yellow, t = 5500 — 6000 K
                        case 4:
                            s.color_R = 255;
                            s.color_G = 255;
                            s.color_B = 0;
                        break;

                        //K - Orange, t = 4000 — 5250 K
                        case 5:
                            s.color_R = 255;
                            s.color_G = 140;
                            s.color_B = 0;
                        break;

                        //M - Red, t = 2600 — 3850 K
                        case 6:
                            s.color_R = 255;
                            s.color_G = 0;
                            s.color_B = 0;
                        break;

                    }

                    galaxy.stars.Add(s);
                }
            }
        }

        

        
    }
}
