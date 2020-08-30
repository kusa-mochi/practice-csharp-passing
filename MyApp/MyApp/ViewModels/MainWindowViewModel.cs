using Prism.Commands;
using Prism.Mvvm;
using MyApp.Models;
using MyApp.Structs;

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
                Result = "";
                int n = 0;
                Result += $"n: {n}\n";
                PrimitiveMethod(n);
                Result += "PrimitiveMethod(n)\n";
                Result += $"n: {n}\n\n";
                string s = "abc";
                Result += $"s: {s}\n";
                PrimitiveMethod(s);
                Result += "PrimitiveMethod(s)\n";
                Result += $"s: {s}\n";
            }));

        private DelegateCommand _ClassCommand;
        public DelegateCommand ClassCommand =>
            _ClassCommand ?? (_ClassCommand = new DelegateCommand(() =>
            {
                Result = "";
                SampleClass sc = new SampleClass();
                Result += $"sc.SampleProperty: {sc.SampleProperty}\n";
                ClassMethod(sc);
                Result += "ClassMethod(sc)\n";
                Result += $"sc.SampleProperty: {sc.SampleProperty}\n";
            }));

        private DelegateCommand _StructCommand;
        public DelegateCommand StructCommand =>
            _StructCommand ?? (_StructCommand = new DelegateCommand(() =>
            {
                Result = "";
                SampleStruct ss = new SampleStruct { SampleMember = 0 };
                Result += $"ss.SampleMember: {ss.SampleMember}\n";
                StructMethod(ss);
                Result += "StructMethod(ss)\n";
                Result += $"ss.SampleMember: {ss.SampleMember}\n";
            }));

        private DelegateCommand _ArrayCommand;
        public DelegateCommand ArrayCommand =>
            _ArrayCommand ?? (_ArrayCommand = new DelegateCommand(() =>
            {
                Result = "";
                int[] arr = new int[] { 1, 2, 3, 4, 5 };
                Result += $"arr: [{arr[0]}, {arr[1]}, {arr[2]}, {arr[3]}, {arr[4]}]\n";
                ArrayMethod(arr);
                Result += "ArrayMethod(arr)\n";
                Result += $"arr: [{arr[0]}, {arr[1]}, {arr[2]}, {arr[3]}, {arr[4]}]\n";
            }));

        private DelegateCommand _InCommand;
        public DelegateCommand InCommand =>
            _InCommand ?? (_InCommand = new DelegateCommand(() =>
            {
                Result = "in修飾子が付けられた引数の値は変更できません。変更しようとするとコンパイルエラーとなります。\n";
                Result += "が、クラスのインスタンスや配列が渡された場合は、インスタンスのメンバや配列の要素を変更してもエラーにはなりません。\n";
                SampleClass sc = new SampleClass();
                Result += $"sc.SampleProperty: {sc.SampleProperty}\n";
                InMethod(in sc);
                Result += "InMethod(in sc)\n";
                Result += $"sc.SampleProperty: {sc.SampleProperty}\n";
            }));

        private DelegateCommand _OutCommand;
        public DelegateCommand OutCommand =>
            _OutCommand ?? (_OutCommand = new DelegateCommand(() =>
            {
                Result = "";
                int n = 0;
                OutMethod(out n);
                Result += "OutMethod(out in n)\n";
                Result += $"n: {n}\n\n";
                OutMethod(out SampleClass sc);
                Result += $"sc.SampleProperty: {sc.SampleProperty}\n";

            }));

        private DelegateCommand _RefCommand;
        public DelegateCommand RefCommand =>
            _RefCommand ?? (_RefCommand = new DelegateCommand(() =>
            {
                Result = "";
                int n = 0;
                Result += $"n: {n}\n";
                RefMethod(ref n);
                Result += "RefMethod(ref n)\n";
                Result += $"n: {n}\n";
            }));

        #endregion

        public MainWindowViewModel()
        {

        }

        private void PrimitiveMethod(int n)
        {
            n++;
        }

        private void PrimitiveMethod(string s)
        {
            s += "def";
        }

        private void ClassMethod(SampleClass sc)
        {
            sc.SampleProperty++;
        }

        private void StructMethod(SampleStruct ss)
        {
            ss.SampleMember++;
        }

        private void ArrayMethod(int[] arr)
        {
            arr[2] = 100;
        }

        private void InMethod(in SampleClass sc)
        {
            sc.SampleProperty++;
        }

        private void OutMethod(out int n)
        {
            n = 100;
        }

        private void OutMethod(out SampleClass sc)
        {
            sc = new SampleClass();
            sc.SampleProperty = 100;
        }

        private void RefMethod(ref int n)
        {
            n++;
        }
    }
}
