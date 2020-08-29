using Prism.Commands;
using Prism.Mvvm;

namespace MyApp.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        #region 変更通知プロパティ

        private string _Result = "";
        public string Result
        {
            get { return _Result; }
            set { SetProperty(ref _Result, value); }
        }

        #endregion

        #region コマンド

        private DelegateCommand _PrimitiveCommand;
        public DelegateCommand PrimitiveCommand =>
            _PrimitiveCommand ?? (_PrimitiveCommand = new DelegateCommand(() =>
            {
            }));

        private DelegateCommand _ClassCommand;
        public DelegateCommand ClassCommand =>
            _ClassCommand ?? (_ClassCommand = new DelegateCommand(() =>
            {
            }));

        private DelegateCommand _StructCommand;
        public DelegateCommand StructCommand =>
            _StructCommand ?? (_StructCommand = new DelegateCommand(() =>
            {
            }));

        private DelegateCommand _ArrayCommand;
        public DelegateCommand ArrayCommand =>
            _ArrayCommand ?? (_ArrayCommand = new DelegateCommand(() =>
            {
            }));

        private DelegateCommand _InCommand;
        public DelegateCommand InCommand =>
            _InCommand ?? (_InCommand = new DelegateCommand(() =>
            {
            }));

        private DelegateCommand _OutCommand;
        public DelegateCommand OutCommand =>
            _OutCommand ?? (_OutCommand = new DelegateCommand(() =>
            {
            }));

        private DelegateCommand _RefCommand;
        public DelegateCommand RefCommand =>
            _RefCommand ?? (_RefCommand = new DelegateCommand(() =>
            {
            }));

        #endregion


        public MainWindowViewModel()
        {

        }
    }
}
