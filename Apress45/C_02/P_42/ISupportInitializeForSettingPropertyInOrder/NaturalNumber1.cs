﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ISupportInitializeForSettingPropertyInOrder
{
public class NaturalNumber1
{

    private string _order="";

    private string _n1;
    public string N1
    {
        get => _n1;
        set
        {
            _n1 = value;
            _order += value + ",";
        }
    }
    private string _n2;
    public string N2
    {
        get => _n2;
        set
        {
            _n2 = value;
            _order += value + ",";
        }
    }
    private string _n3;
    public string N3
    {
        get => _n3;
        set
        {
            _n3 = value;
            _order += value + ",";
        }
    }

    public string NumbersInOrder
    {
        get => _order;
    }
}
}
