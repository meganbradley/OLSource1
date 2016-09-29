---
title: "CStdioFile::Seek"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "Cstdio.Seek"
  - "CStdio::Seek"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CStdioFile class, pointer positioning"
  - "Seek method"
ms.assetid: 345b23a0-4981-4602-9611-fb9915bddb36
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStdioFile::Seek
Repositions the pointer in a previously opened file.  
  
## Syntax  
  
```  
virtual ULONGLONG Seek(  
   LONGLONG lOff,  
   UINT nFrom   
);  
```  
  
#### Parameters  
 `lOff`  
 Number of bytes to move the pointer.  
  
 `nFrom`  
 Pointer movement mode. Must be one of the following values:  
  
-   `CFile::begin`: Move the file pointer `lOff` bytes forward from the beginning of the file.  
  
-   `CFile::current`: Move the file pointer `lOff` bytes from the current position in the file.  
  
-   `CFile::end`: Move the file pointer `lOff` bytes from the end of the file. Note that `lOff` must be negative to seek into the existing file; positive values will seek past the end of the file.  
  
## Return Value  
 If the requested position is legal, `Seek` returns the new byte offset from the beginning of the file. Otherwise, the return value is undefined and a `CFileException` object is thrown.  
  
## Remarks  
 The `Seek` function permits random access to a file's contents by moving the pointer a specified amount, absolutely or relatively. No data is actually read during the seek. If the requested position is larger than the size of the file, the file length will be extended to that position, and no exception will be thrown.  
  
 When a file is opened, the file pointer is positioned at offset 0, the beginning of the file.  
  
 This implementation of `Seek` is based on the Run-Time Library (CRT) function `fseek`. There are several limits on the usage of `Seek` on streams opened in text mode. For more information, see [fseek](../vs140/fseek--_fseeki64.md).  
  
## Example  
 The following example shows how to use `Seek` to move the pointer 1000 bytes from the beginning of the `cfile` file. Note that `Seek` does not read data, so you must subsequently call [CStdioFile::ReadString](../vs140/cstdiofile--readstring.md) to read data.  
  
 [!code[NVC_MFCFiles#39](../vs140/codesnippet/CPP/cstdiofile--seek_1.cpp)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CStdioFile Class](../vs140/cstdiofile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFileException Class](../vs140/cfileexception-class.md)   
 [CStdioFile::ReadString](../vs140/cstdiofile--readstring.md)   
 [CFile::Read](../vs140/cfile--read.md)