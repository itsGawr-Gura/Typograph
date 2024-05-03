using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Typograph
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void print_Click(object sender, EventArgs e)
        {
            string text = unverified.Text;
            text = SpaceCheck(text);
            text = ForgingReplace(text);
            text = DashWithoutSpaces(text);
            text = PlusMinus(text);
            text = Elipsis(text);
            text = DungeonMaster(text);
            text = FuckingDot(text);
            verified.Text = text;
        }
        // Правило 2
        static string SpaceCheck(string text)
        {
           string[] words = text.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);
           string result = string.Join(" ", words);
           return result;
        }
        // Правило 3
        static string ForgingReplace(string text)
        {
            for(int i = 1; i<text.Length; i++ )
            {
                string search = "\"";
                int pos = text.IndexOf(search);
                if (pos < 0)
                {
                    return text;
                }
                text = text.Substring(0, pos) + "«" + text.Substring(pos + search.Length);

                int pos1 = text.IndexOf(search);
                if (pos1 < 0)
                {
                    return text;
                }
                text = text.Substring(0, pos1) + "»" + text.Substring(pos1 + search.Length);
            }
            return text;
        }
        // Правило 5
        static string DashWithoutSpaces(string text)
        {
            text = text.Replace(" -", "-").Replace("- ", "-");
            return text;
        }
        // Правило 9
        static string PlusMinus(string text)
        {
            text = text.Replace("+-", "±").Replace("-+", "±").Replace("(+,−)", "±");
            return text;
        }
        // Правило 13
        static string Elipsis(string text)
        {
            text = text.Replace("...", "…");
            return text;
        }
        // Правило DungeonMaster
        static string DungeonMaster(string text)
        {
            text = text.Replace("master", "Dungeon Mastеr!").Replace("Master", "Dungeon Mastеr!").Replace("Мастер", "Dungeon Mastеr!").Replace("мастер", "Dungeon Mastеr!");
            return text;
        }
        // Правило
        static string FuckingDot(string text)
        {
            text = text.Replace(".", " IT'S A FUCKING DOT!!! ");
            return text;
        }
    }
}
