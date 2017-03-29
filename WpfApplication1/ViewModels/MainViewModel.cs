using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApplication1.Commends;

namespace WpfApplication1.ViewModels
{
    class MainViewModel:NotificationObject
    {
        private double input1;
        public double Input1
        {
            get { return input1; }
            set
            {
                input1 = value;
                this.RaisePropertyChanged("Input1");
            }
        }

        private double input2;
        public double Input2
        {
            get { return input2; }
            set
            {
                input2 = value;
                this.RaisePropertyChanged("Input2");
            }
        }

        private double  result;
        public double Result
        {
            get { return result; }
            set
            {
                result = value;
                this.RaisePropertyChanged("Result");
            }
        }

        public DelegateComend AddComment { get; set; }
        private void Add(object parameter)
        {
            this.Result = this.Input1 + this.Input2;
        }

        public DelegateComend SaveCommend { set; get; }
        private void Save(object parameter)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.ShowDialog();
        }

        public MainViewModel()
        {
            this.AddComment = new DelegateComend();
            this.AddComment.ExecuteAction = new Action<object>(this.Add);

            this.SaveCommend = new DelegateComend();
            this.SaveCommend.ExecuteAction = new Action<object>(this.Save);
        }
    }
}
