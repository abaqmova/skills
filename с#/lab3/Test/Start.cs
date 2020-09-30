using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCompany.StudAbakumova
{
    public partial class Start : Form
    {
        String[] strTips =
        {
            "Тест для компонента кнопки, \n" +
            "генерирующей щелчки мыши",
            "Тест для компонента скроллирующей кнопки \n" +
            "со стрелками, генерирующей щелчки мыши",
            "Тест для компонента текстового \n" +
            "поля со счётчиком"
        };

        ToolTip[] tips =
        {
            new ToolTip(),
            new ToolTip(),
            new ToolTip()
        };

        public Start()
        {
            InitializeComponent();
            tips[0].SetToolTip(Form1, strTips[0]);
            tips[1].SetToolTip(Form2, strTips[1]);
            tips[2].SetToolTip(Form3, strTips[2]);
            for (int i = 0; i < tips.Length; i++)
            {
                tips[i].IsBalloon = true;
                tips[i].ToolTipIcon = ToolTipIcon.Info;
                tips[i].ToolTipTitle = "Упражнение " + (i + 1);
                tips[i].ForeColor = Color.Magenta;
                tips[i].BackColor = Color.LightGoldenrodYellow;
            }

        }
        Form frm;

        private void Start_Load(object sender, EventArgs e)
        {

        }

        private void OnLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Повышаем полномочия ссылки и извлекаем закрепленное имя формы
            string formName = (string)((LinkLabel)sender).Tag;
            //Читаем коллекцию запущенных форм 
            FormCollection fc = Application.OpenForms;
            bool IsRun = false;
            //Перебираем коллекцию
            foreach (Form form in fc)
            {
                if (form.Name == formName)
                {
                    IsRun = true;
                    frm = form;
                    break;
                }
            }
            if (!IsRun)
            {
                switch (formName)
                {
                    case "Form1":
                        frm = new Form1();
                        break;
                    case "Form2":
                        frm = new Form2();
                        break;
                    case "Form3":
                        frm = new Form3();
                        break;
                }
                this.AddOwnedForm(frm);
                frm.ShowInTaskbar = false;
                frm.Show();
            }
            else
                frm.Focus();
        }


    }
}

