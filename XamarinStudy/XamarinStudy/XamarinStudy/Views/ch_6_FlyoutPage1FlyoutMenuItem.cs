using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinStudy.Views
{
    public class ch_6_FlyoutPage1FlyoutMenuItem
    {
        public ch_6_FlyoutPage1FlyoutMenuItem()
        {
            TargetType = typeof(ch_6_FlyoutPage1FlyoutMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}