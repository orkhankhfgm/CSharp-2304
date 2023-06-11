using System;

namespace Virtual_Methods
{
    public class BaseClass
    {
        #region Create and use virtual methods
        public void WriteText(string text)
        {
            Console.WriteLine(text);
        }

        public virtual void ShowText(string text)
        {
            Console.WriteLine(text);
        }
        #endregion
    }
}
