﻿// <auto-generated/>

// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2019.Excel.DynamicArray
{
    /// <summary>
    /// <para>Defines the DynamicArrayProperties Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xda:dynamicArrayProperties.</para>
    /// </summary>
    /// <remarks>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Excel.DynamicArray.ExtensionList" /> <c>&lt;xda:extLst></c></description></item>
    /// </list>
    /// </remarks>
    public partial class DynamicArrayProperties : OpenXmlCompositeElement
    {
        #pragma warning disable CS0109
        internal static readonly new OpenXmlQualifiedName ElementQName = new("http://schemas.microsoft.com/office/spreadsheetml/2017/dynamicarray", "dynamicArrayProperties");
        internal static readonly new OpenXmlQualifiedName ElementTypeName = new("http://schemas.microsoft.com/office/spreadsheetml/2017/dynamicarray", "CT_DynamicArrayProperties");
        internal static readonly new OpenXmlSchemaType ElementType = new(ElementQName, ElementTypeName);
        #pragma warning restore CS0109

        /// <summary>
        /// Initializes a new instance of the DynamicArrayProperties class.
        /// </summary>
        public DynamicArrayProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DynamicArrayProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DynamicArrayProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DynamicArrayProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DynamicArrayProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DynamicArrayProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DynamicArrayProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>fDynamic, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: fDynamic</para>
        /// </summary>
        public BooleanValue? FDynamic
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>fCollapsed, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: fCollapsed</para>
        /// </summary>
        public BooleanValue? FCollapsed
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(ElementType);
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild(DocumentFormat.OpenXml.Office2019.Excel.DynamicArray.ExtensionList.ElementType, static () => new DocumentFormat.OpenXml.Office2019.Excel.DynamicArray.ExtensionList());
            builder.AddElement<DynamicArrayProperties>()
                .AddAttribute("fDynamic", a => a.FDynamic)
                .AddAttribute("fCollapsed", a => a.FCollapsed);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(DocumentFormat.OpenXml.Office2019.Excel.DynamicArray.ExtensionList.ElementType, 0, 1, version: FileFormatVersions.Office2019)
            };
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: xda:extLst.</para>
        /// </summary>
        /// <remarks>
        /// xmlns:xda = http://schemas.microsoft.com/office/spreadsheetml/2017/dynamicarray
        /// </remarks>
        public DocumentFormat.OpenXml.Office2019.Excel.DynamicArray.ExtensionList? ExtensionList
        {
            get => GetElement(DocumentFormat.OpenXml.Office2019.Excel.DynamicArray.ExtensionList.ElementType) as DocumentFormat.OpenXml.Office2019.Excel.DynamicArray.ExtensionList;
            set => SetElement(value, DocumentFormat.OpenXml.Office2019.Excel.DynamicArray.ExtensionList.ElementType);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DynamicArrayProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the ExtensionList Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xda:extLst.</para>
    /// </summary>
    /// <remarks>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.Extension" /> <c>&lt;x:ext></c></description></item>
    /// </list>
    /// </remarks>
    public partial class ExtensionList : OpenXmlCompositeElement
    {
        #pragma warning disable CS0109
        internal static readonly new OpenXmlQualifiedName ElementQName = new("http://schemas.microsoft.com/office/spreadsheetml/2017/dynamicarray", "extLst");
        internal static readonly new OpenXmlQualifiedName ElementTypeName = new("http://schemas.openxmlformats.org/spreadsheetml/2006/main", "CT_ExtensionList");
        internal static readonly new OpenXmlSchemaType ElementType = new(ElementQName, ElementTypeName);
        #pragma warning restore CS0109

        /// <summary>
        /// Initializes a new instance of the ExtensionList class.
        /// </summary>
        public ExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ExtensionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ExtensionList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(ElementType);
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild(DocumentFormat.OpenXml.Spreadsheet.Extension.ElementType, static () => new DocumentFormat.OpenXml.Spreadsheet.Extension());
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
                    {
                        new ElementParticle(DocumentFormat.OpenXml.Spreadsheet.Extension.ElementType, 0, 0)
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ExtensionList>(deep);
    }
}