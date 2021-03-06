﻿//<auto-generated>
#region License
//-----------------------------------------------------------------------
// <copyright>
//     Copyright matatabi-ux 2014.
// </copyright>
//-----------------------------------------------------------------------
#endregion

namespace ResponsiveNaviBarSample.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Serialization;

    /// <summary>
    /// PhotoItem のインタフェース
    /// </summary>
    public partial interface IPhotoItem
    {
        string Title { get; set; }
        string ImageUri { get; set; }
        string OwnerName { get; set; }
    }

    /// <summary>
    /// PhotoItem
    /// </summary>
    [XmlRoot("photo")]
    public partial class PhotoItem : IPhotoItem
    {
        #region Title:タイトル プロパティ
        /// <summary>
        /// タイトル
        /// </summary>
        private string title; 

        /// <summary>
        /// タイトル の取得および設定
        /// </summary>
        [XmlAttribute("title")]
        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }
        #endregion //Title:タイトル プロパティ

        #region ImageUri:画像Uri プロパティ
        /// <summary>
        /// 画像Uri
        /// </summary>
        private string imageUri; 

        /// <summary>
        /// 画像Uri の取得および設定
        /// </summary>
        [XmlAttribute("uri")]
        public string ImageUri
        {
            get { return this.imageUri; }
            set { this.imageUri = value; }
        }
        #endregion //ImageUri:画像Uri プロパティ

        #region OwnerName:作者名 プロパティ
        /// <summary>
        /// 作者名
        /// </summary>
        private string ownerName; 

        /// <summary>
        /// 作者名 の取得および設定
        /// </summary>
        [XmlAttribute("owner")]
        public string OwnerName
        {
            get { return this.ownerName; }
            set { this.ownerName = value; }
        }
        #endregion //OwnerName:作者名 プロパティ

    }

}