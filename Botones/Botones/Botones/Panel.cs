using System;
using System.Collections.Generic;
using Gtk;

namespace Botones
{
    public class Panel
    {
        public static uint rows = 4;
        public static uint columns = 5;

        private IList<Button> buttons = new List<Button>();


        public Panel(VBox vbox1)
        {

        Table table = new Table(rows, columns, true);
         int index = 0;
         for (uint row = 0; row < rows; row++)
             for (uint column = 0; column < columns; column++)
             {
                 index++;
                 Button button = new Button();
                 button.Label = index.ToString();
                 button.HeightRequest =50;
                 button.WidthRequest = 10;
                 table.Attach(button, column, column+ 1, row, row+ 1);
                 buttons.Add(button);
            }
         table.ShowAll();
         vbox1.Add(table);
           

        }


    }
}