// // (c) 2007 - 2011 Joshua R. Rodgers under the terms of the Ms-PL license.
using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace AW
{
    public static partial class Utility
    {
        /// <summary>
        /// Causes the SDK to wait for the specified <paramref name="duration"/> before dispatching any queued events or callbacks.
        /// </summary>
        /// <param name="duration">
        /// <para>-1 will cause the SDK to wait indefinitely while dispatching events or callbacks.</para>
        /// <para>Any other value of 0 or greater will cause the SDK to wait the specified number of milliseconds represented by the value.</para>
        /// </param>
        /// <returns>Returns <c>0</c> if the wait successfully completed.</returns>
        public static Result Wait(int duration)
        {
            return (Result)NativeMethods.aw_wait(duration);
        }

        /// <summary>
        /// Retrieves the sector number associated with the specified <paramref name="cell"/>.
        /// </summary>
        /// <param name="cell">The cell number (X or Z location divide by 1000) to convert.</param>
        /// <returns>The sector number that the <paramref name="cell"/> is located in.</returns>
        public static int SectorFromCell(int cell)
        {
            return NativeMethods.aw_sector_from_cell(cell);
        }

        /// <summary>
        /// Compresses <paramref name="data"/> using the <see href="http://www.zlib.net/">zlib</see> compress2 algorithm.
        /// </summary>
        /// <remarks>
        /// This compression method uses a set buffer of 4096.
        /// </remarks>
        /// <param name="data">A byte array representing the data to be compressed.</param>
        /// <returns>A byte array representing the compressed data.</returns>
        /// <exception cref="System.Exception">This exception will contain a message with the associated zlib error.</exception>
        [EnvironmentPermissionAttribute(SecurityAction.LinkDemand, Unrestricted = true)]
        public static byte[] Zip(byte[] data)
        {
            //Declare buffers
            IntPtr dataIn = Marshal.AllocHGlobal(data.Length);
            IntPtr dataOut = Marshal.AllocHGlobal(BufferSize);
            byte[] retArr = null;

            //Attempt to compress the data
            try
            {
                Marshal.Copy(data, 0, dataIn, data.Length);

// ReSharper disable RedundantAssignment
                int outLength = BufferSize;
// ReSharper restore RedundantAssignment
                int rc = NativeMethods.aw_zip(dataOut, out outLength, dataIn, data.Length);

                if (rc == 0)
                {
                    retArr = new byte[outLength];
                    Marshal.Copy(dataOut, retArr, 0, outLength);
                }
                else
                {
                    InternalZlibException.Assert(rc);
                }
            }
            finally
            {
                //Free all allocated memory.
                Marshal.FreeHGlobal(dataIn);
                Marshal.FreeHGlobal(dataOut);
            }

            return retArr;
        }

        /// <summary>
        /// Decompresses <paramref name="data"/> using the <see href="http://www.zlib.net/">zlib</see> decompress algorithm.
        /// </summary>
        /// <remarks>
        /// If the uncompressed data has a size greater than 4096 bytes, this function will throw an exception.
        /// </remarks>
        /// <param name="data">A byte array representing the data to be decompressed.</param>
        /// <returns>A byte array representing the decompressed data.</returns>
        /// <exception cref="System.Exception">This exception will contain a message with the associated zlib error.</exception>
        [EnvironmentPermissionAttribute(SecurityAction.LinkDemand, Unrestricted = true)]
        public static byte[] Unzip(byte[] data)
        {
            //Declare buffers
            IntPtr dataIn = Marshal.AllocHGlobal(data.Length);
            IntPtr dataOut = Marshal.AllocHGlobal(BufferSize);
            byte[] retArr = null;

            //Attempt to compress the data
            try
            {
                Marshal.Copy(data, 0, dataIn, data.Length);

// ReSharper disable RedundantAssignment
                int outLength = BufferSize;
// ReSharper restore RedundantAssignment
                int rc = NativeMethods.aw_unzip(dataOut, out outLength, dataIn, data.Length);

                if (rc == 0)
                {
                    retArr = new byte[outLength];
                    Marshal.Copy(dataOut, retArr, 0, outLength);
                }
                else
                {
                    InternalZlibException.Assert(rc);
                }
            }
            finally
            {
                //Free all allocated memory.
                Marshal.FreeHGlobal(dataIn);
                Marshal.FreeHGlobal(dataOut);
            }

            return retArr;
        }

        #region properties
        /// <summary>
        /// Returns a random number using the <see href="http://en.wikipedia.org/wiki/Mersenne_Twister">Mersenne Twister</see> algorithm.
        /// </summary>
        public static int Random
        {
            get
            {
                return NativeMethods.aw_random();
            }
        }

        /// <summary>
        /// Returns the amount of time that has elapsed since the first <see cref="AW.Instance" /> was initialized.
        /// </summary>
        public static TimeSpan Tick
        {
            get
            {
                return TimeSpan.FromMilliseconds(NativeMethods.aw_tick());
            }
        }
        #endregion
    }
}