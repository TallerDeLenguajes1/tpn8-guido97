using System;
using System.Collections.Generic;
using Gtk;
using gtkproject;

public partial class MainWindow : Gtk.Window
{
    ListStore historial;
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
        button_Igual.IsFocus=true;


        historial = new ListStore(typeof(string), typeof(string));
        treeview1.AppendColumn("Fecha y hora", new CellRendererText(), "text", 0);
        treeview1.AppendColumn("Operación", new CellRendererText(), "text", 1);
        treeview1.Model = historial;


    }


    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnButtonCeroClicked(object sender, EventArgs e)
    {
        label1.Text += "0";

    }

    protected void OnButton1Clicked(object sender, EventArgs e)
    {
        label1.Text += "1";
    }

    protected void OnButtonPuntoClicked(object sender, EventArgs e)
    {
        label1.Text += ",";
    }

    protected void OnButtonIgualClicked(object sender, EventArgs e)
    {
        Calculadora c = new Calculadora(label1.Text);
        label1.Text = c.Calcular().ToString();
        if (c.FechaDeLaOperacion!=null)
        {
            historial.InsertWithValues(0,c.FechaDeLaOperacion, c.operacion);
        }
    }

    protected void OnButtonDivClicked(object sender, EventArgs e)
    {
        label1.Text += "/";
    }

    protected void OnButton2Clicked(object sender, EventArgs e)
    {
        label1.Text += "2";
    }

    protected void OnButtonSumaClicked(object sender, EventArgs e)
    {
        label1.Text += "+";
    }

    protected void OnButtonLimpiarClicked(object sender, EventArgs e)
    {
        label1.Text = "";
    }

    protected void OnButton3Clicked(object sender, EventArgs e)
    {
        label1.Text += "3";
    }

    protected void OnButtonMultClicked(object sender, EventArgs e)
    {
        label1.Text += "*";
    }

    protected void OnButton4Clicked(object sender, EventArgs e)
    {
        label1.Text += "4";
    }

    protected void OnButton5Clicked(object sender, EventArgs e)
    {
        label1.Text += "5";
    }

    protected void OnButton6Clicked(object sender, EventArgs e)
    {
        label1.Text += "6";
    }

    protected void OnButtonMenosClicked(object sender, EventArgs e)
    {
        label1.Text += "-";
    }

    protected void OnButton7Clicked(object sender, EventArgs e)
    {
        label1.Text += "7";
    }

    protected void OnButton8Clicked(object sender, EventArgs e)
    {
        label1.Text += "8";
    }

    protected void OnButton9Clicked(object sender, EventArgs e)
    {
        label1.Text += "9";

    }

    protected void OnKeyPressEvent(object o, KeyPressEventArgs args)
    {
        if (args.Event.Key == Gdk.Key.KP_0) OnButtonCeroClicked(o, args);
        if (args.Event.Key == Gdk.Key.KP_1) OnButton1Clicked(o, args);
        if (args.Event.Key == Gdk.Key.KP_2) OnButton2Clicked(o, args);
        if (args.Event.Key == Gdk.Key.KP_3) OnButton3Clicked(o, args);
        if (args.Event.Key == Gdk.Key.KP_4) OnButton4Clicked(o, args);
        if (args.Event.Key == Gdk.Key.KP_5) OnButton5Clicked(o, args);
        if (args.Event.Key == Gdk.Key.KP_6) OnButton6Clicked(o, args);
        if (args.Event.Key == Gdk.Key.KP_7) OnButton7Clicked(o, args);
        if (args.Event.Key == Gdk.Key.KP_8) OnButton8Clicked(o, args);
        if (args.Event.Key == Gdk.Key.KP_9) OnButton9Clicked(o, args);

        if (args.Event.Key == Gdk.Key.KP_Decimal) OnButtonPuntoClicked(o, args);

        if (args.Event.Key == Gdk.Key.KP_Add) OnButtonSumaClicked(o, args);
        if (args.Event.Key == Gdk.Key.KP_Subtract) OnButtonMenosClicked(o, args);
        if (args.Event.Key == Gdk.Key.KP_Multiply) OnButtonMultClicked(o, args);
        if (args.Event.Key == Gdk.Key.KP_Divide) OnButtonDivClicked(o, args);

        if (args.Event.Key == Gdk.Key.KP_Enter) OnButtonIgualClicked(o, args);
    }

  protected void OnTreeview1RowActivated(object o, RowActivatedArgs args)
    {
        historial.DragDataDelete(args.Path);
    }


}

