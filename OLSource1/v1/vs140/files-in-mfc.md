---
title: "Files in MFC"
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
helpviewer_keywords: 
  - "serialization [C++], MFC files"
  - "I/O [C++], MFC classes"
  - "files [C++], MFC"
  - "files [C++], serialization"
  - "binary access, binary file operations in MFC"
  - "file I/O classes [C++]"
  - "I/O [MFC]"
  - "persistence [C++]"
  - "MFC [C++], file operations"
  - "files [C++], manipulating"
  - "binary access"
ms.assetid: ae25e2c5-2859-4679-ab97-438824e93ce1
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Files in MFC
In the Microsoft Foundation Class Library (MFC), class [CFile](../vs140/cfile-class.md) handles normal file I/O operations. This family of articles explains how to open and close files as well as read and write data to those files. It also discusses file status operations. For a description of how to use the object-based serialization features of MFC as an alternative way of reading and writing data in files, see the article [Serialization](../vs140/serialization-in-mfc.md).  
  
> [!NOTE]
>  When you use MFC **CDocument** objects, the framework does much of the serialization work for you. In particular, the framework creates and uses the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> object. You only have to write code in your override of the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> member function of class **CDocument**.  
  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> class provides an interface for general-purpose binary file operations. The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> classes derived from <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> class derived from <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> supply more specialized file services.  
  
 For more information about alternatives to MFC file handling, see [File Handling](../vs140/file-handling.md) in the *Run-Time Library Reference*.  
  
 For information about derived <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> classes, see the [MFC hierarchy chart](../vs140/hierarchy-chart.md).  
  
## What do you want to do?  
 *Use CFile*  
  
-   [Open a file with CFile](../vs140/opening-files.md)  
  
-   [Read and write a file with CFile](../vs140/reading-and-writing-files.md)  
  
-   [Close a file with CFile](../vs140/closing-files.md)  
  
-   [Access file status with CFile](../vs140/accessing-file-status.md)  
  
 *Use MFC Serialization (Object Persistence)*  
  
-   [Create a serializable class](../vs140/serialization--making-a-serializable-class.md)  
  
-   [Serialize an object via a CArchive object](../vs140/serialization--serializing-an-object.md)  
  
-   [Create a CArchive object](../vs140/two-ways-to-create-a-carchive-object.md)  
  
-   [Use CArchive <\< and >> operators](../vs140/using-the-carchive----and----operators.md)  
  
-   [Store and load CObjects and CObject-derived objects via an archive](../vs140/storing-and-loading-cobjects-via-an-archive.md)  
  
## See Also  
 [Concepts](../vs140/mfc-concepts.md)   
 [General MFC Topics](../vs140/general-mfc-topics.md)   
 [CArchive Class](../vs140/carchive-class.md)   
 [CObject Class](../vs140/cobject-class.md)   
 [How Do I: Use the CFile Class?](http://go.microsoft.com/fwlink/?LinkId=128046)