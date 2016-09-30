---
title: "Classes Used in .NET Framework File I-O and the File System (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "Classes Used in .NET Framework File I/O and the File System (Visual Basic)"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "file I/O classes"
ms.assetid: 4a5ca924-eea8-4a95-a5f0-6ac10de276a3
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Classes Used in .NET Framework File I-O and the File System (Visual Basic)
The following tables list the classes commonly used for .NET Framework file I/O, categorized into file I/O classes, classes used for creating streams, and classes used to read and write to streams.  
  
 To enter the [!INCLUDE[dnprdnlong](../vs140/includes/dnprdnlong_md.md)] documentation and find a more comprehensive listing, see [.NET Framework Class Library Overview](assetId:///7e4c5921-955d-4b06-8709-101873acf157).  
  
## Basic I/O Classes for Files, Drives, and Directories  
 The following table lists and describes the main classes used for file I/O.  
  
|Class|Description|  
|-----------|-----------------|  
|\<xref:System.IO.Directory*?displayProperty=fullName>|Provides static methods for creating, moving, and enumerating through directories and subdirectories.|  
|\<xref:System.IO.DirectoryInfo*?displayProperty=fullName>|Provides instance methods for creating, moving, and enumerating through directories and subdirectories.|  
|\<xref:System.IO.DriveInfo*?displayProperty=fullName>|Provides instance methods for creating, moving, and enumerating through drives.|  
|\<xref:System.IO.File*?displayProperty=fullName>|Provides static methods for creating, copying, deleting, moving, and opening files, and aids in the creation of a <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>.|  
|\<xref:System.IO.FileAccess*?displayProperty=fullName>|Defines constants for read, write, or read/write access to a file.|  
|\<xref:System.IO.FileAttributes*?displayProperty=fullName>|Provides attributes for files and directories such as <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.|  
|\<xref:System.IO.FileInfo*?displayProperty=fullName>|Provides static methods for creating, copying, deleting, moving, and opening files, and aids in the creation of a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.|  
|\<xref:System.IO.FileMode*?displayProperty=fullName>|Controls how a file is opened. This parameter is specified in many of the constructors for <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, and for the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> methods of \<xref:System.IO.File*> and \<xref:System.IO.FileInfo*>.|  
|\<xref:System.IO.FileShare*?displayProperty=fullName>|Defines constants for controlling the type of access other file streams can have to the same file.|  
|\<xref:System.IO.Path*?displayProperty=fullName>|Provides methods and properties for processing directory strings.|  
|\<xref:System.Security.Permissions.FileIOPermission*?displayProperty=fullName>|Controls the access of files and folders by defining \<xref:System.Security.Permissions.FileIOPermissionAttribute.Read*>, \<xref:System.Security.Permissions.FileIOPermissionAttribute.Write*>, \<xref:System.Security.Permissions.FileIOPermissionAttribute.Append*> and \<xref:System.Security.Permissions.FileIOPermissionAttribute.PathDiscovery*> permissions.|  
  
## Classes Used to Create Streams  
 The following table lists and describes the main classes used to create streams.  
  
|Class|Description|  
|-----------|-----------------|  
|\<xref:System.IO.BufferedStream*?displayProperty=fullName>|Adds a buffering layer to read and write operations on another stream.|  
|\<xref:System.IO.FileStream*?displayProperty=fullName>|Supports random access to files through its \<xref:System.IO.FileStream.Seek*> method. \<xref:System.IO.FileStream*> opens files synchronously by default but also supports asynchronous operation.|  
|\<xref:System.IO.MemoryStream*?displayProperty=fullName>|Creates a stream whose backing store is memory, rather than a file.|  
|\<xref:System.Net.Sockets.NetworkStream*?displayProperty=fullName>|Provides the underlying stream of data for network access.|  
|\<xref:System.Security.Cryptography.CryptoStream*?displayProperty=fullName>|Defines a stream that links data streams to cryptographic transformations.|  
  
## Classes Used to Read from and Write to Streams  
 The following table shows the specific classes used for reading from and writing to files with streams.  
  
|**Class**|**Description**|  
|---------------|---------------------|  
|\<xref:System.IO.BinaryReader*?displayProperty=fullName>|Reads encoded strings and primitive data types from a \<xref:System.IO.FileStream*>.|  
|\<xref:System.IO.BinaryWriter*?displayProperty=fullName>|Writes encoded strings and primitive data types to a \<xref:System.IO.FileStream*>.|  
|\<xref:System.IO.StreamReader*?displayProperty=fullName>|Reads characters from a \<xref:System.IO.FileStream*>, using \<xref:System.IO.StreamReader.CurrentEncoding*> to convert characters to and from bytes. \<xref:System.IO.StreamReader*> has a constructor that attempts to ascertain the correct \<xref:System.IO.StreamReader.CurrentEncoding*> for a given stream, based on the presence of a \<xref:System.IO.StreamReader.CurrentEncoding*>-specific preamble, such as a byte order mark.|  
|\<xref:System.IO.StreamWriter*?displayProperty=fullName>|Writes characters to a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, using \<xref:System.IO.StreamWriter.Encoding*> to convert characters to bytes.|  
|\<xref:System.IO.StringReader*?displayProperty=fullName>|Reads characters from a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. Output can be either a stream in any encoding or a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.|  
|\<xref:System.IO.StringWriter*?displayProperty=fullName>|Writes characters to a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. Output can be either a stream in any encoding or a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.|  
  
## See Also  
 [Composing Streams](assetId:///da761658-a535-4f26-a452-b30df47f73d5)   
 [File and Stream I/O](assetId:///4f4a33a9-66b7-4cd7-a285-4ad3e4276cd2)   
 [Asynchronous File I/O](assetId:///dbdd55e7-d6b9-4f9e-8abb-ab0edd4457f7)   
 [Basics of .NET Framework File I/O and the FileSystem](../vs140/basics-of-.net-framework-file-i-o-and-the-file-system--visual-basic-.md)