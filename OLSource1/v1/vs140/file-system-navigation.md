---
title: "File System Navigation"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
ms.assetid: f7cc5f5e-a541-4e00-87c7-a3769ef6096d
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# File System Navigation
The \<filesystem> header implements the C++ File System Technical Specification ISO/IEC TS 18822:2015 (Final draft: [ISO/IEC JTC 1/SC 22/WG 21 N4100](http://www.open-std.org/jtc1/sc22/wg21/docs/papers/2014/n4100.pdf)) and has types and functions that enable you to write platform-independent code for navigating the file system. Because it is cross-platform, it contains APIs that are not relevant for Windows systems. For example, this means that <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> always returns <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> on Windows. The header is based on a draft Technical Specification that was not voted into the C++17 standard as of Visual Studio 2015 RTM. Its members are found in the  <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> namespace.  
  
## Overview  
 Use the \<filesystem> APIs for the following tasks:  
  
-   iterate over files and directories under a specified path  
  
-   get information about files including the time created, size, extension, and root directory  
  
-   compose, decompose, and compare paths  
  
-   create, copy and delete directories  
  
-   copy and delete files  
  
 For more information about File IO using the Standard Library, see [iostream Programming](../vs140/iostream-programming.md).  
  
## Paths  
  
### Constructing and composing paths  
 Paths in Windows (since XP) are stored natively in Unicode. The [path](../vs140/path-class--c---standard-template-library-.md) class automatically performs all necessary string conversions. It accepts arguments of both wide and narrow character arrays, as well as <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> types formatted as UTF8 or UTF16. The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> class also automatically normalizes path separators. You can use a single forward slash as a directory separator in constructor arguments. This enables you to use the same strings to store paths in both Windows and UNIX environments:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 To concatenate two paths, you can use the overloaded <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> operators, which are analogous to the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> operators on <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object will conveniently supply the separators if you don’t.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Examining paths  
 The path class has several methods that return information about various parts of the path itself, as distinct from the file system entity it might refer to. You can get the root, the relative path, the file name, the file extension, and more. You can iterate over a path object to examine all the folders in the hierarchy. The following example shows how to iterate over a path (not the directory it refers to), and to retrieve information about its parts.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The code produces this output:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Comparing paths  
 The <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> class overloads the same comparison operators as <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>. When you compare two paths, you are performing a string comparison after the separators have been normalized. If a trailing slash (or backslash) is missing it is not added and affects the comparison. The following example demonstrates how path values compare:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 To run this code, paste it into the full example above and uncomment the line that calls it in main.  
  
### Converting between path and string types  
 A <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> object is implicitly convertible to <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>. This means you can pass a path to functions such as [wofstream::open](../vs140/basic_ofstream--open.md), as shown in this example:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
## Iterating directories and files  
 The \<filesystem> header provides the [directory_iterator](../vs140/directory_iterator-class.md) type to iterate over single directories, and the [recursive_directory_iterator](../vs140/recursive_directory_iterator-class.md) class to iterate recursively over a directory and its subdirectories. After you construct an iterator by passing it a <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object, the iterator points to the first directory_entry in the path. Create the end iterator by calling the default constructor.  
  
 When iterating through a directory, there are several kinds of items you might encounter, including but not limited to directories, files, symbolic links, and socket files. The <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> returns its items as [directory_entry](../vs140/directory_entry-class.md) objects, and each object has a [status()](assetId:///a70a3c55-3a76-417f-abaf-862ff94b2056) member that tells what kind of entry you are looking at. By examining this value, you can make decisions about what to do for any particular entry. The following example iterates over a single directory, and if the directory entry is a regular file, the code prints out some information about that file. If the entry is a directory, only the name is displayed.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Iterating a directory tree recursively  
 The following example shows how to iterate recursively through a directory tree. To run this function, paste it into the previous code example after the DisplayFolderContents function, and uncomment the line that calls it in main.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Handling symbolic links  
 Symbolic link detection is not yet supported in Visual C++ as of Visual Studio 2015.