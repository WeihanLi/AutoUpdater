﻿namespace GeneralUpdate.ClientCore.Utils
{
    public enum StringOption 
    {
        Url = 0,
        File
    }

    public static class StringEx
    {
        public static string GetName(this string str, StringOption option)
        {
            string resultName = string.Empty;
            int pos = 0;
            switch (option)
            {
                case StringOption.Url:
                    pos = str.LastIndexOf('/');
                    break;
                case StringOption.File:
                    pos = str.LastIndexOf('\\');
                    break;
            }
            resultName = str.Substring(pos + 1);
            return resultName;
        }

        public static string ExcludeName(this string str, StringOption option)
        {
            string resultName = string.Empty;
            int pos = 0;
            switch (option)
            {
                case StringOption.Url:
                    pos = str.LastIndexOf('/');
                    break;
                case StringOption.File:
                    pos = str.LastIndexOf('\\');
                    break;
            }
            resultName = str.Substring(0,pos);
            return resultName;
        }
    }
}
