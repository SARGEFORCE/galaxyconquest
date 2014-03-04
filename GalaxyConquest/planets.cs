using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// для работы с библиотекой OpenGL 
using Tao.OpenGl;
// для работы с библиотекой FreeGLUT 
using Tao.FreeGlut;
// для работы с элементом управления SimpleOpenGLControl 
using Tao.Platform.Windows;

namespace GalaxyConquest
{
    public partial class planets : Form
    {
        public planets()
        {
            InitializeComponent();
            planetsViev.InitializeContexts();
        }

        private void showbutton_Click(object sender, EventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);

            Gl.glLoadIdentity();
            Gl.glColor3f(1.0f, 0, 0);

            Gl.glPushMatrix();
            Gl.glTranslated(0, 0, -6);
            Gl.glRotated(45, 1, 1, 0);

            // рисуем сферу с помощью библиотеки FreeGLUT 
            Glut.glutWireSphere(2, 32, 32);

            Gl.glPopMatrix();
            Gl.glFlush();
            planetsViev.Invalidate();
        }

        private void planets_Load(object sender, EventArgs e)
        {

            // очитка окна 
            Gl.glClearColor(255, 255, 255, 1);

            // установка порта вывода в соотвествии с размерами элемента anT 
            Gl.glViewport(0, 0, planetsViev.Width, planetsViev.Height);


            // настройка проекции 
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Glu.gluPerspective(45, (float)planetsViev.Width / (float)planetsViev.Height, 0.1, 200);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();

            // настройка параметров OpenGL для визуализации 
            Gl.glEnable(Gl.GL_DEPTH_TEST);
        }
    }
}
