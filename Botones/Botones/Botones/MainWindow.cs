using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void hola(object sender, EventArgs e)
    {
    }

    protected void OnButton1Clicked(object sender, EventArgs e)
    {
        MessageDialog md = new MessageDialog(null, DialogFlags.Modal, MessageType.Question, ButtonsType.Ok, "hola "+Text.Text);
        md.Run();
        md.Destroy();

    }

    protected void OnButton2Clicked(object sender, EventArgs e)
    {
        string display = pantalla.Text.ToString ();
        pantalla.DeleteText(0, pantalla.Text.Length);
        pantalla.InsertText(display + "1");
    }

    protected void OnButton3Clicked(object sender, EventArgs e)
    {
        string display = pantalla.Text.ToString();
        pantalla.DeleteText(0, pantalla.Text.Length);
        pantalla.InsertText(display + "2");
    }

  
}
