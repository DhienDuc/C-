using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager
{
    public partial class DBConnect : Component
    {
        public DBConnect()
        {
            InitializeComponent();
        }

        public DBConnect(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
