namespace GalaxyConquest
{
    partial class planets
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.planetsViev = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.showbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // planetsViev
            // 
            this.planetsViev.AccumBits = ((byte)(0));
            this.planetsViev.AutoCheckErrors = false;
            this.planetsViev.AutoFinish = false;
            this.planetsViev.AutoMakeCurrent = true;
            this.planetsViev.AutoSwapBuffers = true;
            this.planetsViev.BackColor = System.Drawing.Color.Black;
            this.planetsViev.ColorBits = ((byte)(32));
            this.planetsViev.DepthBits = ((byte)(16));
            this.planetsViev.Location = new System.Drawing.Point(13, 13);
            this.planetsViev.Name = "planetsViev";
            this.planetsViev.Size = new System.Drawing.Size(354, 268);
            this.planetsViev.StencilBits = ((byte)(0));
            this.planetsViev.TabIndex = 0;
            // 
            // showbutton
            // 
            this.showbutton.Location = new System.Drawing.Point(380, 12);
            this.showbutton.Name = "showbutton";
            this.showbutton.Size = new System.Drawing.Size(75, 23);
            this.showbutton.TabIndex = 1;
            this.showbutton.Text = "show";
            this.showbutton.UseVisualStyleBackColor = true;
            this.showbutton.Click += new System.EventHandler(this.showbutton_Click);
            // 
            // planets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 293);
            this.Controls.Add(this.showbutton);
            this.Controls.Add(this.planetsViev);
            this.Name = "planets";
            this.Text = "planets";
            this.Load += new System.EventHandler(this.planets_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl planetsViev;
        private System.Windows.Forms.Button showbutton;
    }
}