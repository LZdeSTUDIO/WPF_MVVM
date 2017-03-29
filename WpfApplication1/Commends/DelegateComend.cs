using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApplication1.Commends
{
    class DelegateComend : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            if (this.CanExecuteFunc == null)
            {
                return true;
            }
            return CanExecuteFunc(parameter);
        }

        //当命令实现
        public void Execute(object parameter)
        {
            if (this.ExecuteAction == null)
            {
                return;
            }
            this.ExecuteAction(parameter);
        }

        public Action<object> ExecuteAction { set; get; }
        public Func<object,bool> CanExecuteFunc {  get; set; }
    }
}
