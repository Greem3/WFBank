using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    internal static class Helper
    {
        public static Exception TryCatch(Action func)
        {
            try
            {
                func();
                return null;
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public static (T Value, Exception Error) TryCatch<T>(Func<T> func)
        {
            try
            {
                return (func(), null);
            }
            catch (Exception e)
            {
                return (default(T), e);
            }
        }

        public static T TryCatch<T>(Func<T> func, Func<T> errorFunc)
        {
            try
            {
                return func();
            }
            catch (Exception e)
            {
                return errorFunc();
            }
        }

        public static T TryCatch<T>(Func<T> func, Func<Exception, T> errorFunc)
        {
            try
            {
                return func();
            }
            catch (Exception e)
            {
                return errorFunc(e);
            }
        }

        public static void TryCatch(Action func, Action errorFunc)
        {
            try
            {
                func();
            }
            catch (Exception e)
            {
                errorFunc();
            }
        }

        public static void TryCatch(Action func, Action<Exception> errorFunc)
        {
            try
            {
                func();
            }
            catch (Exception e)
            {
                errorFunc(e);
            }
        }

        public static T TryCatch<T>(Action func, Func<T> errorFunc)
        {
            try
            {
                func();
            }
            catch (Exception e)
            {
                return errorFunc();
            }

            return default(T);
        }

        public static T TryCatch<T>(Action func, Func<Exception, T> errorFunc)
        {
            try
            {
                func();
            }
            catch (Exception e)
            {
                return errorFunc(e);
            }

            return default(T);
        }

        public static T TryCatch<T>(Func<T> func, Action errorFunc)
        {
            try
            {
                return func();
            }
            catch
            {
                errorFunc();
                return default(T);
            }
        }

        public static T TryCatch<T>(Func<T> func, Action<Exception> errorFunc)
        {
            try
            {
                return func();
            }
            catch (Exception e)
            {
                errorFunc(e);
                return default(T);
            }
        }
    }
}