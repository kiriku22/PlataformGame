namespace Plataform_Game
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            points = new Label();
            player = new PictureBox();
            ball = new PictureBox();
            GTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ball).BeginInit();
            SuspendLayout();
            // 
            // points
            // 
            points.AutoSize = true;
            points.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            points.ForeColor = Color.White;
            points.Location = new Point(15, 15);
            points.Margin = new Padding(4, 0, 4, 0);
            points.Name = "points";
            points.Size = new Size(88, 22);
            points.TabIndex = 0;
            points.Text = "Score: 0";
            points.Click += Score_Click;
            // 
            // player
            // 
            player.BackColor = Color.White;
            player.Location = new Point(345, 576);
            player.Margin = new Padding(4, 3, 4, 3);
            player.Name = "player";
            player.Size = new Size(152, 10);
            player.TabIndex = 1;
            player.TabStop = false;
            // 
            // ball
            // 
            ball.BackColor = Color.Yellow;
            ball.Image = (Image)resources.GetObject("ball.Image");
            ball.Location = new Point(394, 349);
            ball.Margin = new Padding(4, 3, 4, 3);
            ball.Name = "ball";
            ball.Size = new Size(29, 27);
            ball.TabIndex = 1;
            ball.TabStop = false;
            ball.Click += Erzebet;
            // 
            // GTimer
            // 
            GTimer.Interval = 20;
            GTimer.Tick += Erzebet;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(812, 618);
            Controls.Add(ball);
            Controls.Add(player);
            Controls.Add(points);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Plataform Game";
            Load += Erzebet;
            KeyDown += Abajo;
            KeyUp += Press;
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)ball).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label points;
        private PictureBox player;
        private PictureBox ball;
        private System.Windows.Forms.Timer GTimer;
    }
}

