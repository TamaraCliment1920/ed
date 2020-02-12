using System;
using System.Collections.Generic;
using CBingo;
using Gtk;

namespace CBingo
{
    public partial class Carton : Gtk.Window
    {
        public Carton() :
                base(Gtk.WindowType.Toplevel)
        {
            Build();
            Table table = new Table(3, 9, true);
            int index = 0;
            for (int row = 0; row < 3; row++)
                for (int column = 0; column < 9; column++)
                {
                    index++;
                    Button button = new Button();
                    table.Attach(button, (uint)column, (uint)column + 1, (uint)row, (uint)row + 1);
                    button.Label = index.ToString();
                    vbox2.Add(table);
                    table.ShowAll();
                }
        }
    }
}
