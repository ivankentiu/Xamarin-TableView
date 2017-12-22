using System;
using System.Collections.Generic;
using UIKit;

namespace listviewapp
{
    public partial class ViewController : UIViewController
    {
        List<string> tableItems;

        protected ViewController(IntPtr handle) : base(handle)
        {
            tableItems = new List<string>();

            //for (var i = 0; i < 40; i++)
            //{
            //    tableItems.Add("Item number " + i.ToString());
            //}

            tableItems.Add("Apple");
            tableItems.Add("Aardvark");
            tableItems.Add("Bee");
            tableItems.Add("Butterfly");
            tableItems.Add("Zebra");
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            tableView.Source = new MyTableViewSource(tableItems);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
