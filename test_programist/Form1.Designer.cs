using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace test_programist
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 800);
            this.Text = "Programmer test";
            this.BackColor = Color.BlanchedAlmond;
            this.Size = new System.Drawing.Size(800, 800);
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.StartPosition = FormStartPosition.CenterScreen;
            //this.AutoScroll = true;

            this.answer_btn.Location = new Point(650, 700);
            this.answer_btn.Size = new Size(100, 50);
            this.answer_btn.BackColor = Color.Transparent;
            this.answer_btn.Font = new Font("Times New Romans", 11, FontStyle.Regular, GraphicsUnit.Point);
            this.answer_btn.Text = "Следующий вопрос";
            this.answer_btn.Click += Answer_btn_Click;
            //this.answer_btn



            this.start_test.Location = new Point(350, 320);
            this.start_test.Size = new Size(100, 100);
            this.start_test.BackColor = Color.Azure;
            this.start_test.Font = new Font("Times New Romans", 11, FontStyle.Regular, GraphicsUnit.Point);
            this.start_test.Text = "Начать тест";
            this.start_test.Click += Start_test_Click;
            this.Controls.Add(start_test);


            this.test_text.Location = new Point(100, 359);
            this.test_text.Size = new Size(600, 70);
            this.test_text.Font = new Font("Times New Romans", 16, FontStyle.Regular, GraphicsUnit.Point);
            this.Controls.Add(test_text);

            this.check.Location = new Point(350, 330);
            this.check.Size = new Size(70, 50);
            this.check.Font = new Font("Times New Romans", 15, FontStyle.Regular, GraphicsUnit.Point);
            this.check.BackColor = Color.WhiteSmoke;
            this.check.TextAlign = ContentAlignment.TopCenter;
            
            



            this.img_test_1.Image = Image.FromFile("tets_1.jpg");
            this.img_test_1.Location = new Point(45, 20);
            this.img_test_1.Size = new Size(700, 303);
            this.img_test_1.SizeMode = PictureBoxSizeMode.Zoom;
            

            

            this.progressBar.Style = ProgressBarStyle.Continuous;
            this.progressBar.Maximum = 12;
            this.progressBar.Minimum = 1;
            this.progressBar.Location = new Point(45,330);
            this.progressBar.Size = new Size(700, 29);
            this.progressBar.Step = 1;
            //progressBar.Increment(10);


            this.radio_1.Size = new Size(500, 50);
            this.radio_1.Font = new Font("Times New Romans", 13, FontStyle.Regular, GraphicsUnit.Point);
            this.radio_1.Location = new Point(100, 430);
            //this.radio_1.Click += Radio_1_Click;


            this.radio_2.Size = new Size(500, 50);
            this.radio_2.Font = new Font("Times New Romans", 13, FontStyle.Regular, GraphicsUnit.Point);
            this.radio_2.Location = new Point(100, 500);

            this.radio_3.Size = new Size(500, 50);
            this.radio_3.Font = new Font("Times New Romans", 13, FontStyle.Regular, GraphicsUnit.Point);
            this.radio_3.Location = new Point(100, 570);

            this.radio_4.Size = new Size(500, 50);
            this.radio_4.Font = new Font("Times New Romans", 13, FontStyle.Regular, GraphicsUnit.Point);
            this.radio_4.Location = new Point(100, 640);
            this.timer.Tick += Timer_Tick;
        }

        

        int check_answer_checkbox()
        {
            if (next_btn == 11)
            {
                if (test_3.Checked == true)
                {
                     num++;
                }
                if (test_7.Checked == true)
                {
                    num++;
                }
                if (test_8.Checked == true)
                {
                    num++;
                }
            }
            if (next_btn == 12)
            {
                if (test_1.Checked == true)
                {
                    num++;
                }
                if (test_2.Checked == true)
                {
                    num++;
                }

                if (test_4.Checked == true)
                {
                    num++;
                }
                if (test_5.Checked == true)
                {
                    num++;
                }
                if (test_6.Checked == true)
                {
                    num++;
                }
                next_btn++;
            }
            
            return num;
        }
        void end_test()
        {
            
            next_btn++;
            this.Controls.Remove(answer_btn);
            this.end_test_button.Location = new Point(650, 700);
            this.end_test_button.Size = new Size(100, 50);
            this.end_test_button.Font = new Font("Times New Romans", 11, FontStyle.Regular, GraphicsUnit.Point);
            this.end_test_button.Text = "Закончить тест";
            this.end_test_button.Click += End_test_button_Click;
            this.Controls.Add(end_test_button);
        }

        private void End_test_button_Click(object sender, EventArgs e)
        {
            this.timer.Stop();
            if (num >= 0 || num <=4)
            {
                string message = string.Format("Вы набрали :{0} очка\n Ваше время: {1}\nВы на верном пути. Вам стоит попробовать — и у вас может получиться\n\n\t\t\tХотите ещё раз?", num,time.ToString());
                string caption = "End";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
                if (result == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else
                {
                    Application.ExitThread();
                }
            }
            if (num >= 5 || num <= 10)
            {
                string message = string.Format("Вы набрали :{0} очка\n Ваше время: {1}\nУ вас хорошо выходит но стоит повторить ещё\n\n\t\t\tХотите ещё раз?", num, time.ToString());
                string caption = "End";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
                if (result == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else
                {
                    Application.ExitThread();
                }
            }
            if (num >= 11 || num <= 15)
            {
                string message = string.Format("Вы набрали :{0} очка\n Ваше время: {1}\nИнформатику вы знатее хорошо)\n\n\t\t\tХотите ещё раз?", num, time.ToString());
                string caption = "End";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
                if (result == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else
                {
                    Application.ExitThread();
                }
            }
            if (num >= 16 || num <= 18)
            {
                string message = string.Format("Вы набрали :{0} очка\n Ваше время: {1}\nЭто успех! Или вы уже занимаетесь программированием?\n\n\t\t\tХотите ещё раз?", num, time.ToString());
                string caption = "End";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
                
            }

        }

        void checkbox()
        {
            this.Controls.Remove(radio_1);
            this.Controls.Remove(radio_2);
            this.Controls.Remove(radio_3);
            this.Controls.Remove(radio_4);
            this.test_1.Size = new Size(500, 40);
            this.test_1.Font = new Font("Times New Romans", 13, FontStyle.Regular, GraphicsUnit.Point);
            this.test_1.Location = new Point(100, 420);
            //this.radio_1.Click += Radio_1_Click;
            this.Controls.Add(test_1);

            this.test_2.Size = new Size(500, 40);
            this.test_2.Font = new Font("Times New Romans", 13, FontStyle.Regular, GraphicsUnit.Point);
            this.test_2.Location = new Point(100, 450);
            this.Controls.Add(test_2);

            this.test_3.Size = new Size(500, 40);
            this.test_3.Font = new Font("Times New Romans", 13, FontStyle.Regular, GraphicsUnit.Point);
            this.test_3.Location = new Point(100, 480);
            this.Controls.Add(test_3);

            this.test_4.Size = new Size(500, 40);
            this.test_4.Font = new Font("Times New Romans", 13, FontStyle.Regular, GraphicsUnit.Point);
            this.test_4.Location = new Point(100, 510);
            this.Controls.Add(test_4);

            this.test_5.Size = new Size(500, 40);
            this.test_5.Font = new Font("Times New Romans", 13, FontStyle.Regular, GraphicsUnit.Point);
            this.test_5.Location = new Point(100, 540);
            //this.radio_1.Click += Radio_1_Click;
            this.Controls.Add(test_5);

            this.test_6.Size = new Size(500, 40);
            this.test_6.Font = new Font("Times New Romans", 13, FontStyle.Regular, GraphicsUnit.Point);
            this.test_6.Location = new Point(100, 570);
            this.Controls.Add(test_6);

            this.test_7.Size = new Size(500, 40);
            this.test_7.Font = new Font("Times New Romans", 13, FontStyle.Regular, GraphicsUnit.Point);
            this.test_7.Location = new Point(100, 600);
            this.Controls.Add(test_7);

            this.test_8.Size = new Size(500, 40);
            this.test_8.Font = new Font("Times New Romans", 13, FontStyle.Regular, GraphicsUnit.Point);
            this.test_8.Location = new Point(100, 630);
            this.Controls.Add(test_8);
        }
        void first_test()
        {

            this.test_text.Text = "Начнем с простого. Найдите общее между всеми этими предметами и определите, что здесь лишнее?";
            this.radio_1.Text = "Торшер";
            this.radio_2.Text = "Луна";
            this.radio_4.Text = "Костер";
            this.radio_3.Text = "Спичка";
            this.img_test_1.Image = Image.FromFile("tets_1.jpg");
            

        }
        void second_test()
        {
            this.test_text.Text = "Это обычные дроби. Мы их изучали в школе. Какая должна чувствовать себя чужой в окружении других?";
            this.radio_1.Text = "3/4";
            this.radio_2.Text = "3/6";
            this.radio_3.Text = "3/8";
            this.radio_4.Text = "3/10";
            
            this.img_test_1.Image = Image.FromFile("test_2.png");
            
        }
        void third_test()
        {
            this.test_text.Text = "Количество единиц растет, а нулей — уменьшается: 100001100011100111…";
            this.radio_1.Text = "…01100…";
            this.radio_2.Text = "…00111…";
            this.radio_3.Text = "…11100…";
            this.radio_4.Text = "…00110…";
            this.img_test_1.Image = Image.FromFile("test_3.png");

        }

        void fourth_test()
        {
            this.test_text.Text = "Предположим, птицы с рождения умеют программировать. Некоторые птицы — жаворонки. Все жаворонки обязательно знают три языка программирования. Что из этого верно?";
            this.radio_1.Text = "Все птицы, которые знают только два языка программирования, не являются жаворонками";
            this.radio_2.Text = "Все птицы, которые знают три языка программирования, являются жаворонками";
            this.radio_3.Text = "Птицы, которые знают больше трех языков, не являются жаворонками";
            this.radio_4.Text = "Совы не знают языков программирования";
            this.img_test_1.Image = Image.FromFile("test_4.jpg");

        }

        void fifth_test()
        {
            this.test_text.Text = "Некоторые программисты любят математику. Некоторые любители математики любят слушать Баха. Из этого утверждения следует, что …";
            this.radio_1.Text = "… среди программистов обязательно должны быть любители музыки Баха";
            this.radio_2.Text = "… все программисты слушают Баха";
            this.radio_3.Text = "… любители Баха есть и среди программистов, и среди математиков";
            this.radio_4.Text = "Здесь нет правильного ответа";
            this.img_test_1.Image = Image.FromFile("test_5.jpg");

        }

        void sixth_test()
        {
            this.test_text.Text = "Продолжите фразу: «Единственный язык, напрямую выполняемый ЭВМ, — это …";
            this.radio_1.Text = "… Basic";
            this.radio_2.Text = "… исходный код";
            this.radio_3.Text = "…машинный язык";
            this.radio_4.Text = "Здесь нет правильного ответа";
            this.img_test_1.Image = Image.FromFile("test_6.jpg");

        }

        void seventh_test()
        {
            this.test_text.Text = "Как правило, первая программа, которую пишет каждый программист, начиная изучать новый язык программирования, — это программа, выводящая на экран текст…";
            this.radio_1.Text = "Game started!";
            this.radio_2.Text = "You did it!";
            this.radio_3.Text = "Hello, world!";
            this.radio_4.Text = "Just Another Programmer Born";
            this.img_test_1.Image = Image.FromFile("test_7.jpg");

        }

        void eighth_test()
        {
            this.test_text.Text = "В школе все из нас на уроках информатики изучали язык программирования Basic. Узнайте его по фрагменту кода";
            this.radio_1.Text = "cout << \"Hello, World!\"";
            this.radio_2.Text = "System.out.println(\"Hello, World!\")";
            this.radio_3.Text = "PRINT \"HELLO WORLD\"";
            this.radio_4.Text = "println(\"Hello, world!\")";
            this.img_test_1.Image = Image.FromFile("test_8.jpg");

        }

        void ninth_test()
        {
            this.test_text.Text = "Вы уже определились, что хотите стать веб-разработчиком и делать сайты? Тогда вам нужно освоить…";
            this.radio_1.Text = "Java, Objective-C, Swift";
            this.radio_2.Text = "HTML, CSS, JavaScript";
            this.radio_3.Text = "С++, PHP, Ruby";
            this.radio_4.Text = "Английский язык, математику, метод слепой печати на клавиатуре";
            this.img_test_1.Image = Image.FromFile("test_9.jpg");

        }
        void tenth_test()
        {
            this.test_text.Text = "Вы решили сделать карьеру программиста. Тогда вас ожидают следующие карьерные ступени: Junior, Middle и …";
            this.radio_1.Text = "… Older";
            this.radio_2.Text = "… Major";
            this.radio_3.Text = "… Senior";
            this.radio_4.Text = "… Master";
            this.img_test_1.Image = Image.FromFile("test_10.jpg");

        }
        void eleventh_test()
        {
            checkbox();
            this.test_text.Text = "Какие языки програмирования подходят для новечков?";
            this.test_1.Text = "Java";
            this.test_2.Text = "CSS";
            this.test_3.Text = "С#";
            this.test_4.Text = "JavaScript";
            this.test_5.Text = "Rudy";
            this.test_6.Text = "PHP";
            this.test_7.Text = "C++";
            this.test_8.Text = "HTML";
            this.img_test_1.Image = Image.FromFile("test_11.jpg");
            
        }
        void twelfth_test()
        {
            checkbox();
            this.test_text.Text = "Какие языки програмирования подходят для професионалов?";
            this.test_1.Text = "Java";
            this.test_2.Text = "CSS";
            this.test_3.Text = "С#";
            this.test_4.Text = "JavaScript";
            this.test_5.Text = "Rudy";
            this.test_6.Text = "PHP";
            this.test_7.Text = "C++";
            this.test_8.Text = "HTML";
            this.img_test_1.Image = Image.FromFile("test_12.jpg");
        }
        private void Start_test_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(start_test);
            this.Controls.Add(check);
            this.Controls.Add(radio_1);
            this.Controls.Add(radio_2);
            this.Controls.Add(radio_3);
            this.Controls.Add(radio_4);
            this.Controls.Add(answer_btn);
            this.Controls.Add(img_test_1);
            this.Controls.Add(progressBar);
            this.check.Text = "1/12";
            first_test();
            this.timer.Start();
            
            
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            time++;
        }
        private void Answer_btn_Click(object sender, EventArgs e)
        {

            if (radio_1.Checked ||radio_2.Checked ||radio_3.Checked || radio_4.Checked)
            {


                if (next_btn == 0)
                {
                    next_btn++;
                }
                this.check.Text = string.Format((next_btn + 1) + ("/12"));

                switch (next_btn)
                {
                    case 1:
                        check_answer();
                        second_test();
                        break;
                    case 2:
                        check_answer();
                        third_test();
                        break;
                    case 3:
                        check_answer();
                        fourth_test();
                        break;
                    case 4:
                        check_answer();
                        fifth_test();
                        break;
                    case 5:
                        check_answer();
                        sixth_test();
                        break;
                    case 6:
                        check_answer();
                        seventh_test();

                        break;
                    case 7:
                        check_answer();
                        eighth_test();

                        break;
                    case 8:
                        check_answer();
                        ninth_test();

                        break;
                    case 9:
                        check_answer();
                        tenth_test();

                        break;
                    case 10:

                        check_answer();
                        eleventh_test();
                        break;
                    case 11:
                        check_answer_checkbox();
                        twelfth_test();
                        end_test();
                        break;
                    default:
                        MessageBox.Show("the end");
                        break;
                }



                this.progressBar.Value = next_btn;
            }
            else
            {
                MessageBox.Show("Вырерите хотя бы 1 значение");
            }
        }
        int check_answer()
        {
            
            if (next_btn == 0)
            {
                if (radio_2.Checked == true)
                {
                    num++;
                    
                }
            }
            if (next_btn == 1)
            {
                if (radio_2.Checked == true)
                {
                    num++;
                }
            }
            if (next_btn == 2)
            {
                if (radio_2.Checked == true)
                {
                    num++;
                }
            }
            if (next_btn == 3)
            {
                if (radio_1.Checked == true)
                {
                    num++;
                }
            }
            if (next_btn == 4)
            {
                if (radio_4.Checked == true)
                {
                    num++;
                }

            }
            if (next_btn == 5)
            {
                if (radio_3.Checked == true)
                {
                    num++;
                }
            }
            if (next_btn == 6)
            {
                if (radio_3.Checked == true)
                {
                    num++;
                }
            }
            if (next_btn == 7)
            {
                if (radio_3.Checked == true)
                {
                    num++;
                }
            }
            if (next_btn == 8)
            {
                if (radio_2.Checked == true)
                {
                    num++;
                }
            }
            if (next_btn == 9)
            {
                if (radio_3.Checked == true)
                {
                    num++;
                }
                
            }
            
            next_btn++;

            return num;
        }


        Label test_text = new Label();
        Label check = new Label();
        Button answer_btn = new Button();
        Button start_test = new Button();
        Button end_test_button = new Button();
        RadioButton radio_1 = new RadioButton();
        RadioButton radio_2 = new RadioButton();
        RadioButton radio_3 = new RadioButton();
        RadioButton radio_4 = new RadioButton();
        CheckBox test_1 = new CheckBox();
        CheckBox test_2 = new CheckBox();
        CheckBox test_3 = new CheckBox();
        CheckBox test_4 = new CheckBox();
        CheckBox test_5 = new CheckBox();
        CheckBox test_6 = new CheckBox();
        CheckBox test_7 = new CheckBox();
        CheckBox test_8 = new CheckBox();
        Timer timer = new Timer();
        PictureBox img_test_1 = new PictureBox();
        static int num = 0;
        static int next_btn = 0;
        int time;
        ProgressBar progressBar = new ProgressBar();
        #endregion

    }
}

