
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vBox;

	private global::Gtk.VBox vbox2;

	private global::Gtk.Label Text;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vBox = new global::Gtk.VBox();
		this.vBox.Name = "vBox";
		this.vBox.Spacing = 6;
		// Container child vBox.Gtk.Box+BoxChild
		this.vbox2 = new global::Gtk.VBox();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.Text = new global::Gtk.Label();
		this.Text.Name = "Text";
		this.Text.LabelProp = global::Mono.Unix.Catalog.GetString("Tabla");
		this.vbox2.Add(this.Text);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.Text]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		this.vBox.Add(this.vbox2);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vBox[this.vbox2]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		this.Add(this.vBox);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 400;
		this.DefaultHeight = 300;
		this.Show();
	}
}