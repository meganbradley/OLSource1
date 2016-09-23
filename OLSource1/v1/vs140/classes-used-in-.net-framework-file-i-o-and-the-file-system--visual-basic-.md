---
title: "Classes Used in .NET Framework File I-O and the File System (Visual Basic)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-visual-basic
ms.tgt_pltfrm: na
ms.topic: article
H1: Classes Used in .NET Framework File I/O and the File System (Visual Basic)
dev_langs: 
  - VB
helpviewer_keywords: 
  - file I/O classes
ms.assetid: 4a5ca924-eea8-4a95-a5f0-6ac10de276a3
caps.latest.revision: 19
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Classes Used in .NET Framework File I-O and the File System (Visual Basic)
The following tables list the classes commonly used for .NET Framework file I/O, categorized into file I/O classes, classes used for creating streams, and classes used to read and write to streams.  
  
 To enter the [!INCLUDE[dnprdnlong](../vs140/includes/dnprdnlong_md.md)] documentation and find a more comprehensive listing, see [.NET Framework Class Library Overview](assetId:///7e4c5921-955d-4b06-8709-101873acf157).  
  
## Basic I/O Classes for Files, Drives, and Directories  
 The following table lists and describes the main classes used for file I/O.  
  
|Class|Description|  
|-----------|-----------------|  
|<xref:System.IO.Directory?qualifyHint=True>|Provides static methods for creating, moving, and enumerating through directories and subdirectories.|  
|<xref:System.IO.DirectoryInfo?qualifyHint=True>|Provides instance methods for creating, moving, and enumerating through directories and subdirectories.|  
|<xref:System.IO.DriveInfo?qualifyHint=True>|Provides instance methods for creating, moving, and enumerating through drives.|  
|<xref:System.IO.File?qualifyHint=True>|Provides static methods for creating, copying, deleting, moving, and opening files, and aids in the creation of a `FileStream`.|  
|<xref:System.IO.FileAccess?qualifyHint=True>|Defines constants for read, write, or read/write access to a file.|  
|<xref:System.IO.FileAttributes?qualifyHint=True>|Provides attributes for files and directories such as `Archive`, `Hidden`, and `ReadOnly`.|  
|<xref:System.IO.FileInfo?qualifyHint=True>|Provides static methods for creating, copying, deleting, moving, and opening files, and aids in the creation of a `FileStream`.|  
|<xref:System.IO.FileMode?qualifyHint=True>|Controls how a file is opened. This parameter is specified in many of the constructors for `FileStream` and `IsolatedStorageFileStream`, and for the `Open` methods of <xref:System.IO.File?qualifyHint=False> and <xref:System.IO.FileInfo?qualifyHint=False>.|  
|<xref:System.IO.FileShare?qualifyHint=True>|Defines constants for controlling the type of access other file streams can have to the same file.|  
|<xref:System.IO.Path?qualifyHint=True>|Provides methods and properties for processing directory strings.|  
|<xref:System.Security.Permissions.FileIOPermission?qualifyHint=True>|Controls the access of files and folders by defining <xref:System.Security.Permissions.FileIOPermissionAttribute.Read?qualifyHint=False>, <xref:System.Security.Permissions.FileIOPermissionAttribute.Write?qualifyHint=False>, <xref:System.Security.Permissions.FileIOPermissionAttribute.Append?qualifyHint=False> and <xref:System.Security.Permissions.FileIOPermissionAttribute.PathDiscovery?qualifyHint=False> permissions.|  
  
## Classes Used to Create Streams  
 The following table lists and describes the main classes used to create streams.  
  
|Class|Description|  
|-----------|-----------------|  
|<xref:System.IO.BufferedStream?qualifyHint=True>|Adds a buffering layer to read and write operations on another stream.|  
|<xref:System.IO.FileStream?qualifyHint=True>|Supports random access to files through its <xref:System.IO.FileStream.Seek?qualifyHint=False> method. <xref:System.IO.FileStream?qualifyHint=False> opens files synchronously by default but also supports asynchronous operation.|  
|<xref:System.IO.MemoryStream?qualifyHint=True>|Creates a stream whose backing store is memory, rather than a file.|  
|<xref:System.Net.Sockets.NetworkStream?qualifyHint=True>|Provides the underlying stream of data for network access.|  
|<xref:System.Security.Cryptography.CryptoStream?qualifyHint=True>|Defines a stream that links data streams to cryptographic transformations.|  
  
## Classes Used to Read from and Write to Streams  
 The following table shows the specific classes used for reading from and writing to files with streams.  
  
|**Class**|**Description**|  
|---------------|---------------------|  
|<xref:System.IO.BinaryReader?qualifyHint=True>|Reads encoded strings and primitive data types from a <xref:System.IO.FileStream?qualifyHint=False>.|  
|<xref:System.IO.BinaryWriter?qualifyHint=True>|Writes encoded strings and primitive data types to a <xref:System.IO.FileStream?qualifyHint=False>.|  
|<xref:System.IO.StreamReader?qualifyHint=True>|Reads characters from a <xref:System.IO.FileStream?qualifyHint=False>, using <xref:System.IO.StreamReader.CurrentEncoding?qualifyHint=False> to convert characters to and from bytes. <xref:System.IO.StreamReader?qualifyHint=False> has a constructor that attempts to ascertain the correct <xref:System.IO.StreamReader.CurrentEncoding?qualifyHint=False> for a given stream, based on the presence of a <xref:System.IO.StreamReader.CurrentEncoding?qualifyHint=False>-specific preamble, such as a byte order mark.|  
|<xref:System.IO.StreamWriter?qualifyHint=True>|Writes characters to a `FileStream`, using <xref:System.IO.StreamWriter.Encoding?qualifyHint=False> to convert characters to bytes.|  
|<xref:System.IO.StringReader?qualifyHint=True>|Reads characters from a `String`. Output can be either a stream in any encoding or a `String`.|  
|<xref:System.IO.StringWriter?qualifyHint=True>|Writes characters to a `String`. Output can be either a stream in any encoding or a `String`.|  
  
## See Also  
 [Composing Streams](assetId:///da761658-a535-4f26-a452-b30df47f73d5)   
 [File and Stream I/O](assetId:///4f4a33a9-66b7-4cd7-a285-4ad3e4276cd2)   
 [Asynchronous File I/O](assetId:///dbdd55e7-d6b9-4f9e-8abb-ab0edd4457f7)   
 [Basics of .NET Framework File I/O and the FileSystem](../vs140/basics-of-.net-framework-file-i-o-and-the-file-system--visual-basic-.md)