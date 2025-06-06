﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Builder;
using System.IO;
using System.IO.Packaging;
using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Packaging;

/// <summary>
/// Defines WordprocessingDocument - an OpenXmlPackage represents a Word document.
/// </summary>
public partial class WordprocessingDocument
{
    /// <summary>
    /// Creates a new editable instance of WordprocessingDocument from an <see cref="XDocument"/>
    /// in Flat OPC format, opened on a <see cref="MemoryStream"/>.
    /// </summary>
    /// <param name="document">The document in Flat OPC format.</param>
    /// <returns>A new instance of WordprocessingDocument.</returns>
    public static WordprocessingDocument FromFlatOpcDocument(XDocument document)
        => DefaultBuilder
            .Build()
            .WithFlatOpcTemplate(document)
            .Open();

    /// <summary>
    /// Creates a new instance of WordprocessingDocument from an <see cref="XDocument"/>
    /// in Flat OPC format.
    /// </summary>
    /// <param name="document">The document in Flat OPC format.</param>
    /// <param name="stream">The <see cref="Stream"/> on which the WordprocessingDocument will be created.</param>
    /// <param name="isEditable">In ReadWrite mode. False for Read only mode.</param>
    /// <returns>A new instance of WordprocessingDocument.</returns>
    public static WordprocessingDocument FromFlatOpcDocument(XDocument document, Stream stream, bool isEditable)
        => DefaultBuilder
            .Build()
            .WithFlatOpcTemplate(document, isEditable)
            .Open(stream, PackageOpenMode.Create);

    /// <summary>
    /// Creates a new instance of WordprocessingDocument from an <see cref="XDocument"/>
    /// in Flat OPC format.
    /// </summary>
    /// <param name="document">The document in Flat OPC format.</param>
    /// <param name="path">The path and file name of the target WordprocessingDocument.</param>
    /// <param name="isEditable">In ReadWrite mode. False for Read only mode.</param>
    /// <returns>A new instance of WordprocessingDocument.</returns>
    public static WordprocessingDocument FromFlatOpcDocument(XDocument document, string path, bool isEditable)
        => DefaultBuilder
            .Build()
            .WithFlatOpcTemplate(document, isEditable)
            .Open(path, PackageOpenMode.Create);

    /// <summary>
    /// Creates a new instance of WordprocessingDocument from an <see cref="XDocument"/>
    /// in Flat OPC format.
    /// </summary>
    /// <param name="document">The document in Flat OPC format.</param>
    /// <param name="package">The <see cref="Package"/> of the target WordprocessingDocument.</param>
    /// <returns>A new instance of WordprocessingDocument.</returns>
    public static WordprocessingDocument FromFlatOpcDocument(XDocument document, Package package)
        => DefaultBuilder
            .Build()
            .WithFlatOpcTemplate(document)
            .Open(package);

    /// <summary>
    /// Creates a new instance of WordprocessingDocument from a string
    /// in Flat OPC format on a <see cref="MemoryStream"/> with expandable
    /// capacity.
    /// </summary>
    /// <param name="text">The string in Flat OPC format.</param>
    /// <returns>A new instance of WordprocessingDocument.</returns>
    public static WordprocessingDocument FromFlatOpcString(string text)
        => DefaultBuilder
            .Build()
            .WithFlatOpcTemplate(text)
            .Open();

    /// <summary>
    /// Creates a new instance of WordprocessingDocument from a string
    /// in Flat OPC format on a
    /// </summary>
    /// <param name="text">The string in Flat OPC format.</param>
    /// <param name="stream">The <see cref="Stream"/> on which the WordprocessingDocument will be created.</param>
    /// <param name="isEditable">In ReadWrite mode. False for Read only mode.</param>
    /// <returns>A new instance of WordprocessingDocument.</returns>
    public static WordprocessingDocument FromFlatOpcString(string text, Stream stream, bool isEditable)
        => DefaultBuilder
            .Build()
            .WithFlatOpcTemplate(text, isEditable)
            .Open(stream, PackageOpenMode.Create);

    /// <summary>
    /// Creates a new instance of WordprocessingDocument from a string
    /// in Flat OPC format.
    /// </summary>
    /// <param name="text">The string in Flat OPC format.</param>
    /// <param name="path">The path and file name of the target WordprocessingDocument.</param>
    /// <param name="isEditable">In ReadWrite mode. False for Read only mode.</param>
    /// <returns>A new instance of WordprocessingDocument.</returns>
    public static WordprocessingDocument FromFlatOpcString(string text, string path, bool isEditable)
        => DefaultBuilder
            .Build()
            .WithFlatOpcTemplate(text, isEditable)
            .Open(path, PackageOpenMode.Create);

    /// <summary>
    /// Creates a new instance of WordprocessingDocument from a string
    /// in Flat OPC format.
    /// </summary>
    /// <param name="text">The string in Flat OPC format.</param>
    /// <param name="package">The <see cref="Package"/> of the target WordprocessingDocument.</param>
    /// <returns>A new instance of WordprocessingDocument.</returns>
    public static WordprocessingDocument FromFlatOpcString(string text, Package package)
        => DefaultBuilder
            .Build()
            .WithFlatOpcTemplate(text)
            .Open(package);
}
