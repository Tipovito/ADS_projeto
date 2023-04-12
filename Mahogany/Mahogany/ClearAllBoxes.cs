using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mahogany
{
    internal class ClearAllBoxes
    {
        public static void LimparTudo(Control containerControl)
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                {
                    if (control is TextBox || control is ComboBox)
                    {
                        control.ResetText();
                    }
                    else
                    {
                        func(control.Controls);
                    }
                }
            };
            func(containerControl.Controls);
        }

        public static void LimparText(Control containerControl)
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                {
                    if (control is TextBox)
                    {
                        control.ResetText();
                    }
                    else
                    {
                        func(control.Controls);
                    }
                }
            };
            func(containerControl.Controls);
        }

        public static void LimparCombo(Control containerControl)
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                {
                    if (control is ComboBox)
                    {
                        control.ResetText();
                    }
                    else
                    {
                        func(control.Controls);
                    }
                }
            };
            func(containerControl.Controls);
        }

        public static void LimparEsteText(Control containerControl, List<TextBox> textBoxes)
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                {
                    if (control is TextBox && textBoxes.Contains(control))
                    {
                        control.ResetText();
                    }
                    else
                    {
                        func(control.Controls);
                    }
                }
            };
            func(containerControl.Controls);
        }

        public static void LimparEsteCombo(Control containerControl, List<ComboBox> ComboBoxes)
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                {
                    if (control is ComboBox && ComboBoxes.Contains(control))
                    {
                        control.ResetText();
                    }
                    else
                    {
                        func(control.Controls);
                    }
                }
            };
            func(containerControl.Controls);
        }
        public static bool AreTextBoxesFilled(Control containerControl)
        {
            bool areFilled = true;
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                {
                    if (control is TextBox)
                    {
                        TextBox textbox = (TextBox)control;
                        if (string.IsNullOrWhiteSpace(textbox.Text))
                        {
                            areFilled = false;
                            break;
                        }
                    }
                    else
                    {
                        func(control.Controls);
                    }
                }
            };
            func(containerControl.Controls);
            return areFilled;
        }
    }
}
   