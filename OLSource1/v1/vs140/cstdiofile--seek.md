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
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStdioFile::Seek
Repositions the pointer in a previously opened file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Number of bytes to move the pointer.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer movement mode. Must be one of the following values:  
  
-   <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>: Move the file pointer <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> bytes forward from the beginning of the file.  
  
-   <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>: Move the file pointer <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> bytes from the current position in the file.  
  
-   <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>: Move the file pointer <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> bytes from the end of the file. Note that <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> must be negative to seek into the existing file; positive values will seek past the end of the file.  
  
## Return Value  
 If the requested position is legal, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> returns the new byte offset from the beginning of the file. Otherwise, the return value is undefined and a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object is thrown.  
  
## Remarks  
 The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> function permits random access to a file's contents by moving the pointer a specified amount, absolutely or relatively. No data is actually read during the seek. If the requested position is larger than the size of the file, the file length will be extended to that position, and no exception will be thrown.  
  
 When a file is opened, the file pointer is positioned at offset 0, the beginning of the file.  
  
 This implementation of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is based on the Run-Time Library (CRT) function <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. There are several limits on the usage of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> on streams opened in text mode. For more information, see [fseek](../vs140/fseek--_fseeki64.md).  
  
## Example  
 The following example shows how to use <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> to move the pointer 1000 bytes from the beginning of the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> file. Note that <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> does not read data, so you must subsequently call [CStdioFile::ReadString](../vs140/cstdiofile--readstring.md) to read data.  
  
 [!code[NVC_MFCFiles#39](../vs140/codesnippet/CPP/cstdiofile--seek_1.cpp)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CStdioFile Class](../vs140/cstdiofile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFileException Class](../vs140/cfileexception-class.md)   
 [CStdioFile::ReadString](../vs140/cstdiofile--readstring.md)   
 [CFile::Read](../vs140/cfile--read.md)