﻿using System;
using Gtk;
using CTabla;

public partial class MainWindow : Gtk.Window
{
    //private string jugador = "X";
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        {
            Build();
            Panel panel= new Panel(vBox);

            /*Table table = new Table( 3, 3, true);
            int index = 0;
            for (int row = 0; row < 3; row++)
                for (int column = 0; column < 3; column++)
                {
                    index++;
                    Button button = new Button();
                    table.Attach(button, (uint)column, (uint)column+1, (uint)row, (uint)row + 1);
                    button.Label = "Button "+ index.ToString();
                    //button.Label = index.ToString();
                    button.Clicked += delegate
                    {
                        button.ModifyBg(StateType.Normal, new Gdk.Color(100, 200, 250));
                    };
                                      
                      /*{
                          if (button.Label != null)
                              return;
                          button.Label = jugador;
                          if (jugador == "X")
                              jugador = "0";
                          else
                              jugador = "X";

                      };*/
               // }*/

           // vBox.Add(table);
           // table.ShowAll();
        }
    }




    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

}