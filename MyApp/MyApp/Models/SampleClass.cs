using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.Models
{
    public class SampleClass
    {
        public int SampleProperty { get; set; } = 0;

        public void InSample(in int n)
        {
            //// in修飾子が付けられた引数nの値は変更できないため、コンパイルエラーとなる。
            // n++;
        }

        public void OutSample(out int n)
        {
            //// 未割り当ての変数nの値が使われるため、コンパイルエラーとなる。
            // n++;

            // 次のように値を代入する分には問題ない。
            n = 123;
        }

        public void RefSample(ref int n)
        {
            n++;
        }
    }
}
