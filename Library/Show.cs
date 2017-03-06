using System;
using System.Text;

namespace Library
{
    public static class Show
    {
        public static string Array (object[] a)
        {
            StringBuilder builder = new StringBuilder ("{ ");

            for (int i = 0; i < a.Length; i++)
            {
                builder.Append (a [i]);
                if (i == a.Length - 1)
                {
                    break;
                }
                builder.Append (',');
            }
            builder.Append (" }");

            return builder.ToString ();
        }
    }
}