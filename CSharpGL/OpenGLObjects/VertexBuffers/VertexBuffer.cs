﻿using CSharpGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGL
{
    /// <summary>
    /// 顶点缓存（VBO）
    /// </summary>
    /// <typeparam name="T">此buffer存储的是哪种struct的数据？</typeparam>
    public abstract class VertexBuffer<T> : IDisposable where T : struct
    {
        private UnmanagedArray<T> array = null;

        /// <summary>
        /// 此VBO中的数据在内存中的起始地址
        /// </summary>
        public IntPtr Header
        {
            get { return (this.array == null) ? IntPtr.Zero : this.array.Header; }
        }

        /// <summary>
        /// 获取此VBO的内存首地址。用于快速读写。
        /// </summary>
        /// <returns></returns>
        public unsafe void* FirstElement()
        {
            UnmanagedArrayBase array = this.array;
            if (array == null) { return (void*)0; }
            else
            {
                return array.FirstElement();
            }
        }

        /// <summary>
        /// 此VBO中的数据在内存中占用多少个字节？
        /// </summary>
        public int ByteLength
        {
            get { return (this.array == null) ? 0 : this.array.ByteLength; }

        }

        /// <summary>
        /// 此VBO含有多个个元素？
        /// </summary>
        public int Length
        {
            get { return (this.array == null) ? 0 : this.array.Length; }
        }

        /// <summary>
        /// usage in glBufferData(uint target, int size, IntPtr data, uint usage);
        /// </summary>
        public BufferUsage Usage { get; private set; }

        /// <summary>
        /// 顶点缓存（VBO）
        /// </summary>
        /// <param name="usage"></param>
        public VertexBuffer(BufferUsage usage)
        {
            this.Usage = usage;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("VBO: {0}, usage: {1}", this.array, Usage);
        }

        /// <summary>
        /// 根据buffer内存放的具体的结构类型创建非托管数组。
        /// </summary>
        /// <param name="elementCount">数组元素的数目。</param>
        /// <returns></returns>
        protected virtual UnmanagedArray<T> CreateElements(int elementCount)
        {
            return new UnmanagedArray<T>(elementCount);
        }

        /// <summary>
        /// 填充此buffer的数据。
        /// <para>此方法较慢，如果数据量大，请用<see cref="this.FirstElement()"/></para>
        /// </summary>
        /// <param name="dataProvider"></param>
        /// <param name="startIndex"></param>
        public void FillData(Func<IEnumerable<T>> dataProvider, int startIndex = 0)
        {
            int elementSize = this.array.ByteLength / this.array.Length;
            IntPtr current = this.Header + startIndex;
            foreach (var item in dataProvider())
            {
                System.Runtime.InteropServices.Marshal.StructureToPtr(item, current, true);
                //System.Runtime.InteropServices.Marshal.StructureToPtr<T>(item, current, true);// works in .net 4.5.1
                current += elementSize;
            }
        }

        /// <summary>
        /// 获取或设置索引为<paramref name="index"/>的元素。
        /// <para>此方法较慢，如果数据量大，请用<see cref="this.FirstElement()"/></para>
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T this[int index]
        {
            get
            {
                return this.array[index];
            }
            set
            {
                this.array[index] = value;
            }
        }

        /// <summary>
        /// 申请指定长度的非托管数组。
        /// </summary>
        /// <param name="elementCount">数组元素的数目。</param>
        public void Alloc(int elementCount)
        {
            this.array = CreateElements(elementCount);
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~VertexBuffer()
        {
            this.Dispose(false);
        }

        private bool disposedValue = false;

        private void Dispose(bool disposing)
        {
            if (this.disposedValue == false)
            {
                if (disposing)
                {
                    // Dispose managed resources.

                }

                // Dispose unmanaged resources.
                UnmanagedArray<T> array = this.array;
                this.array = null;
                if (array != null)
                {
                    array.Dispose();
                }
            }

            this.disposedValue = true;
        }


        /// <summary>
        /// 获取一个可渲染此VBO的渲染器。
        /// </summary>
        /// <returns></returns>
        protected abstract BufferPtr CreateRenderer();

        private BufferPtr renderer = null;

        /// <summary>
        /// 获取一个可渲染此VBO的渲染器。
        /// </summary>
        /// <returns></returns>
        public BufferPtr GetRenderer()
        {
            if (renderer == null)
            {
                renderer = CreateRenderer();
            }

            return renderer;
        }
    }

}
