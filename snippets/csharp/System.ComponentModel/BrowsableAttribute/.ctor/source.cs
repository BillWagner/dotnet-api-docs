﻿using System.ComponentModel;
using System.Windows.Forms;

public class Form1 : Form
{
    protected TextBox textBox1;
    // <Snippet1>
    [Browsable(true)]
    public int MyProperty
    {
        get =>
            // Insert code here.
            0;
        set
        {
            // Insert code here.
        }
    }

    // </Snippet1>
}
