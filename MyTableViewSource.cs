using System;
using System.Collections.Generic;
using Foundation;
using UIKit;
namespace listviewapp
{
    public class MyTableViewSource : UITableViewSource
    {

        List<string> tableItems;

        public MyTableViewSource(List<string> _tableItems)
        {
            tableItems = _tableItems;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell("tableViewCell") as MyCustomCell;

            if (cell == null)
                cell = new MyCustomCell(new NSString("tableViewCell"));

            cell.UpdateCell(tableItems[indexPath.Row], tableItems[indexPath.Row]); 
            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return tableItems.Count;
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            tableView.DeselectRow(indexPath, true);
        }

        public override nfloat GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
        {
            return 75f;
        }
    }
}
