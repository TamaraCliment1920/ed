using System;
using Botones;
using Gtk;



public partial class MainWindow : Gtk.Window
{
    private Random random = new Random();
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
        Panel panel = new Panel(vbox1);


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
        MessageDialog b = new MessageDialog(null, DialogFlags.Modal, MessageType.Question, ButtonsType.Ok, "Hola "+Text.Text);
        b.Run();
        b.Destroy();

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

    protected void OnBAleatorioClicked(object sender, EventArgs e)
    {
    int indexAleatorio = random.Next(1,10);
    MessageDialog a = new MessageDialog(null, DialogFlags.Modal, MessageType.Question, ButtonsType.Ok, "Número Aleatorio: " + indexAleatorio);
    a.Run();
    a.Destroy();
}
}
