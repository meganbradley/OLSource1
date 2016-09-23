---
title: "Reading and Writing Files"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - C++
helpviewer_keywords: 
  - CFile class, objects
  - examples [MFC], reading files
  - files [C++], writing to
  - examples [MFC], writing to files
  - files [C++], reading
  - MFC [C++], file operations
  - CFile class, reading and writing CFile objects
  - reading files
  - writing to files [C++]
ms.assetid: cac0c826-ba56-495f-99b3-ce6336f65763
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Reading and Writing Files
If you've used the C run-time library file-handling functions, MFC reading and writing operations will appear familiar. This article describes reading directly from and writing directly to a `CFile` object. You can also do buffered file I/O with the [CArchive](../vs140/carchive-class.md) class.  
  
#### To read from and write to the file  
  
1.  Use the **Read** and **Write** member functions to read and write data in the file.  
  
     -or-  
  
2.  The `Seek` member function is also available for moving to a specific offset within the file.  
  
 **Read** takes a pointer to a buffer and the number of bytes to read and returns the actual number of bytes that were read. If the required number of bytes could not be read because end-of-file (EOF) is reached, the actual number of bytes read is returned. If any read error occurs, an exception is thrown. **Write** is similar to **Read**, but the number of bytes written is not returned. If a write error occurs, including not writing all the bytes specified, an exception is thrown. If you have a valid `CFile` object, you can read from it or write to it as shown in the following example:  
  
 [!code[NVC_MFCFiles#2](../vs140/codesnippet/CPP/reading-and-writing-files_1.cpp)]
  
  
> [!NOTE]
>  You should normally carry out input/output operations within a **try**/**catch** exception handling block. For more information, see [Exception Handling (MFC)](../vs140/exception-handling-in-mfc.md).  
  
## See Also  
 [Files](../vs140/files-in-mfc.md)