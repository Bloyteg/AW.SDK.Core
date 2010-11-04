﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Utilities
{
    /// <summary>
    /// Miscellaneous methods used internally by the .NET wrapper to perform common and important tasks
    /// related to the InterOp of the wrapper and the C SDK plus other functionality that has no real
    /// categorization into individual concrete classes.
    /// </summary>
    internal static class Miscellaneous
    {
        /// <summary>
        /// Converts an IP address represented as a string into a integer representation.
        /// </summary>
        /// <param name="ipAddress">The IP address to convert.</param>
        /// <returns>The integer representation of the IP address.</returns>
        public static int IPStringToInt(string ipAddress)
        {
            int r = 0;
            string[] ipArr = ipAddress.Split('.');
            foreach (string s in ipArr)
                r = (r << 8) ^ (int)UInt32.Parse(s);
            return r;
        }

        /// <summary>
        /// Converts a structure into a byte-array.
        /// </summary>
        /// <param name="obj">The structure being converted.</param>
        /// <returns>A byte-array representing the structure being converted.</returns>
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

        /// <summary>
        /// Converts a byte array into a structure.
        /// </summary>
        /// <typeparam name="T">The type of the structure to convert to.</typeparam>
        /// <param name="data">A byte-array of data being converted to a structure.</param>
        /// <param name="index">The starting index in the array where the structure is located.</param>
        /// <returns>A structure representation of the byte-array passed in.</returns>
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

        /// <summary>
        /// Concatenates together two or more arrays into one array, in the order that they were passed.
        /// </summary>
        /// <typeparam name="T">The type of the arrays being concatenate.</typeparam>
        /// <param name="arrays">The arrays being concatenated together.</param>
        /// <returns>All arrays concatenated into one array.</returns>
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