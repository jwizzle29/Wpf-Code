using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_V1._1
{
    public interface IWindowService
    {
        void OpenAsDialog(string typeName, object viewModel);
        void OpenAsWindow(string typeName, object viewMode, object identifier);
        object GetUserControl(string name);
        object GetUserControl(string name, object viewModelToAssign);
        object GetUserControl(string name, object viewModelToAssign, object[] parameters);
        void PerformUITask(string taskName, object[] parameters);
    }
}
