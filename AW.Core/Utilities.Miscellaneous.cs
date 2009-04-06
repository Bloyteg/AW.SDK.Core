using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Utilities
{
    internal static class Miscellaneous
    {
        public static uint IPStringToInt(string ipAddress)
        {
            uint r = 0;
            foreach (string s in ipAddress.Split('.'))
                r = (r << 8) ^ (uint)UInt32.Parse(s);
            return r;
        }

        public static byte[] StructToBytes(object obj)
        {
            int length = Marshal.SizeOf(obj.GetType());
            byte[] returnArr = new byte[length];
            IntPtr ptr = Marshal.AllocHGlobal(length);

            try
            {
                Marshal.StructureToPtr(obj, ptr, true);
                Marshal.Copy(ptr, returnArr, 0, length);
            }
            finally
            {
                Marshal.FreeHGlobal(ptr);
            }

            return returnArr;
        }

        public static T BytesToStruct<T>(byte[] data, int index)
        {
            int length = Marshal.SizeOf(typeof(T));
            IntPtr ptr = Marshal.AllocHGlobal(length);
            T outObj;

            try
            {
                if (length + index > data.Length || index > data.Length)
                {
                    Marshal.FreeHGlobal(ptr);
                    throw new IndexOutOfRangeException("Index or Structure is out of range.");
                }

                Marshal.Copy(data, index, ptr, length);
                outObj = (T)Marshal.PtrToStructure(ptr, typeof(T));
            }
            finally
            {
                Marshal.FreeHGlobal(ptr);
            }

            return outObj;
        }

        public static T[] ConcatArrays<T>(params T[][] arrays)
        {
            List<T> outList = new List<T>();
            foreach (T[] arr in arrays)
            {
                outList.AddRange(arr);
            }

            return outList.ToArray();
        }
    }
}