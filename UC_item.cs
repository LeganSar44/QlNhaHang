﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QlNhaHang
{
    public partial class UC_item : UserControl
    {
        public Image itemImage
        {
            get { return imgItem.Image; }
        set { imgItem.Image = value; }
        }
        public string itemName
        {
            get { return lblItemName.Text; }
            set { lblItemName.Text = value; }   
        }
        public string itemPrice
        {
            get { return lblItemPrice.Text; }
            set { lblItemPrice.Text = value; }
        }
        public UC_item()
        {
            InitializeComponent();
        }

        private void lblItemName_Click(object sender, EventArgs e)
        {

        }
    }
       
        
    
}
