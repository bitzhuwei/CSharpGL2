﻿using CSharpGL.GlyphTextures;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Xml.Linq;

namespace CSharpGL.GlyphTextures
{
    /// <summary>
    /// 含有字形贴图及其配置信息的单例类型。
    /// </summary>
    public sealed class FontResource : IDisposable
    {
        private static FontResource defaultInstance = new FontResource();

        public static FontResource Default
        {
            get
            {
                return defaultInstance;
            }
        }

        public const string strTTFTexture = "TTFTexture";
        public const string strFontHeight = "FontHeight";
        public const string strFirstChar = "FirstChar";
        public const string strLastChar = "LastChar";

        private FontResource()
        {
            this.FontBitmap = ManifestResourceLoader.LoadBitmap("LucidaTypewriterRegular.ttf.png");

            string xmlContent = ManifestResourceLoader.LoadTextFile("LucidaTypewriterRegular.ttf.xml");
            XElement xElement = XElement.Parse(xmlContent, LoadOptions.None);
            this.FontHeight = int.Parse(xElement.Attribute(strFontHeight).Value);
            this.FirstChar = (char)int.Parse(xElement.Attribute(strFirstChar).Value);
            this.LastChar = (char)int.Parse(xElement.Attribute(strLastChar).Value);
            this.CharInfoDict = CharacterInfoDictHelper.Parse(
                xElement.Element(CharacterInfoDictHelper.strCharacterInfoDict));
        }

        /// <summary>
        /// 字形高度
        /// </summary>
        public int FontHeight { get; set; }

        /// <summary>
        /// 第一个字符
        /// </summary>
        public char FirstChar { get; set; }

        /// <summary>
        /// 最后一个字符
        /// </summary>
        public char LastChar { get; set; }

        /// <summary>
        /// 含有各个字形的贴图。
        /// </summary>
        public System.Drawing.Bitmap FontBitmap { get; private set; }

        /// <summary>
        /// 记录每个字符在<see cref="FontBitmap"/>里的偏移量及其字形的宽高。
        /// </summary>
        public FullDictionary<char, CharacterInfo> CharInfoDict { get; private set; }

        ~FontResource()
        {
            this.Dispose();
        }

        #region IDisposable Members

        /// <summary>
        /// Internal variable which checks if Dispose has already been called
        /// </summary>
        Boolean disposed;

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources
        /// </summary>
        /// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
        void Dispose(Boolean disposing)
        {
            if (disposed)
            {
                return;
            }

            if (disposing)
            {
                //Managed cleanup code here, while managed refs still valid
            }
            //Unmanaged cleanup code here
            System.Drawing.Bitmap bmp = this.FontBitmap;
            if (bmp != null)
            {
                this.FontBitmap = null;
                //this.CharInfoDict.Clear();
                bmp.Dispose();
            }

            disposed = true;
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            // Call the private Dispose(bool) helper and indicate
            // that we are explicitly disposing
            this.Dispose(true);

            // Tell the garbage collector that the object doesn't require any
            // cleanup when collected since Dispose was called explicitly.
            GC.SuppressFinalize(this);
        }

        #endregion

    }
}
