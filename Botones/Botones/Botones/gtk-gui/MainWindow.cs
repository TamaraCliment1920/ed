
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox2;

	private global::Gtk.Label label1;

	private global::Gtk.HBox hbox1;

	private global::Gtk.Arrow arrow1;

	private global::Gtk.Entry Text;

	private global::Gtk.Button button1;

	private global::Gtk.HBox hbox2;

	private global::Gtk.Entry pantalla;

	private global::Gtk.Button button2;

	private global::Gtk.Button button3;

	private global::Gtk.Button BAleatorio;

	private global::Gtk.VBox vbox1;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		this.Resizable = false;
		this.AllowGrow = false;
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox2 = new global::Gtk.VBox();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		this.vbox2.BorderWidth = ((uint)(18));
		// Container child vbox2.Gtk.Box+BoxChild
		this.label1 = new global::Gtk.Label();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Mi Primera Aplicación");
		this.label1.Justify = ((global::Gtk.Justification)(2));
		this.vbox2.Add(this.label1);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.label1]));
		w1.Position = 0;
		w1.Expand = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.arrow1 = new global::Gtk.Arrow(((global::Gtk.ArrowType)(3)), ((global::Gtk.ShadowType)(2)));
		this.arrow1.Name = "arrow1";
		this.hbox1.Add(this.arrow1);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.arrow1]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.Text = new global::Gtk.Entry();
		this.Text.CanFocus = true;
		this.Text.Name = "Text";
		this.Text.IsEditable = true;
		this.Text.InvisibleChar = '•';
		this.hbox1.Add(this.Text);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.Text]));
		w3.Position = 1;
		// Container child hbox1.Gtk.Box+BoxChild
		this.button1 = new global::Gtk.Button();
		this.button1.CanFocus = true;
		this.button1.Name = "button1";
		this.button1.UseUnderline = true;
		this.button1.Label = global::Mono.Unix.Catalog.GetString("Saludar");
		this.hbox1.Add(this.button1);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.button1]));
		w4.Position = 2;
		w4.Expand = false;
		w4.Fill = false;
		this.vbox2.Add(this.hbox1);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox1]));
		w5.Position = 1;
		w5.Expand = false;
		w5.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox2 = new global::Gtk.HBox();
		this.hbox2.Name = "hbox2";
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.pantalla = new global::Gtk.Entry();
		this.pantalla.WidthRequest = 40;
		this.pantalla.HeightRequest = 40;
		this.pantalla.CanFocus = true;
		this.pantalla.Name = "pantalla";
		this.pantalla.IsEditable = false;
		this.pantalla.InvisibleChar = '•';
		this.hbox2.Add(this.pantalla);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.pantalla]));
		w6.Position = 0;
		// Container child hbox2.Gtk.Box+BoxChild
		this.button2 = new global::Gtk.Button();
		this.button2.WidthRequest = 40;
		this.button2.CanFocus = true;
		this.button2.Name = "button2";
		this.button2.UseUnderline = true;
		this.button2.Label = global::Mono.Unix.Catalog.GetString("1");
		this.hbox2.Add(this.button2);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.button2]));
		w7.Position = 1;
		w7.Expand = false;
		w7.Fill = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.button3 = new global::Gtk.Button();
		this.button3.WidthRequest = 40;
		this.button3.CanFocus = true;
		this.button3.Name = "button3";
		this.button3.UseUnderline = true;
		this.button3.Label = global::Mono.Unix.Catalog.GetString("2");
		this.hbox2.Add(this.button3);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.button3]));
		w8.Position = 2;
		w8.Expand = false;
		w8.Fill = false;
		this.vbox2.Add(this.hbox2);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox2]));
		w9.Position = 2;
		w9.Expand = false;
		w9.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.BAleatorio = new global::Gtk.Button();
		this.BAleatorio.CanFocus = true;
		this.BAleatorio.Name = "BAleatorio";
		this.BAleatorio.UseUnderline = true;
		this.BAleatorio.Label = global::Mono.Unix.Catalog.GetString("Aleatorio");
		this.vbox2.Add(this.BAleatorio);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.BAleatorio]));
		w10.Position = 3;
		w10.Expand = false;
		w10.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.vbox1 = new global::Gtk.VBox();
		this.vbox1.Name = "vbox1";
		this.vbox2.Add(this.vbox1);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.vbox1]));
		w11.Position = 4;
		this.Add(this.vbox2);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 343;
		this.DefaultHeight = 410;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.button1.Clicked += new global::System.EventHandler(this.OnButton1Clicked);
		this.button2.Clicked += new global::System.EventHandler(this.OnButton2Clicked);
		this.button3.Clicked += new global::System.EventHandler(this.OnButton3Clicked);
		this.BAleatorio.Clicked += new global::System.EventHandler(this.OnBAleatorioClicked);
	}
}
