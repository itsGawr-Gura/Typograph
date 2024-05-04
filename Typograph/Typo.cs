using System;
using System.Windows.Forms;

namespace Typograph
{
    public partial class Typo : Form
    {
        public Typo()
        {
            InitializeComponent();
        }

        public void print_Click(object sender, EventArgs e)
        {
            string text = unverified.Text;
            text = SpaceCheck(text);
            text = ForgingReplace(text);
            text = DashWithoutSpaces(text);
            text = PlusMinus(text);
            text = Elipsis(text);
            text = DungeonMaster(text);
            text = FuckingDot(text);
            text = Weapon(text);
            verified.Text = text;
        }
        // Правило 2
        public string SpaceCheck(string text)
        {
           string[] words = text.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);
           string result = string.Join(" ", words);
           return result;
        }
        // Правило 3
        public string ForgingReplace(string text)
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
        public string DashWithoutSpaces(string text)
        {
            text = text.Replace(" -", "-").Replace("- ", "-");
            return text;
        }
        // Правило 9
        public string PlusMinus(string text)
        {
            text = text.Replace("+-", "±").Replace("-+", "±").Replace("(+,−)", "±");
            return text;
        }
        // Правило 13
        public string Elipsis(string text)
        {
            text = text.Replace("...", "…");
            return text;
        }
        // Правило DungeonMaster
        public string DungeonMaster(string text)
        {
            text = text.Replace("master", "Dungeon Mastеr!").Replace("Master", "Dungeon Mastеr!").Replace("Мастер", "Dungeon Mastеr!").Replace("мастер", "Dungeon Mastеr!");
            return text;
        }
        // Правило FuckingDot
        public string FuckingDot(string text)
        {
            text = text.Replace(".", " IT'S A FUCKING DOT!!! ");
            return text;
        }
        // Правило правильного оружия
        public string Weapon(string text)
        {
            text = text.Replace("gun", "︻デ═一").Replace("Gun", "︻デ═一").Replace("оружие", "︻デ═一").Replace("Пушка", "︻デ═一").Replace("Оружие", "︻デ═一").Replace("пушка", "︻デ═一");
            return text;
        }
    }
}
