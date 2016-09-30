---
title: "_fread_nolock"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
apiname: 
  - "_fread_nolock"
apilocation: 
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr100.dll"
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
  - "msvcr120.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_fread_nolock"
  - "fread_nolock"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "reading data [C++], from input streams"
  - "data [C++], reading from input stream"
  - "fread_nolock function"
  - "_fread_nolock function"
  - "streams [C++], reading data from"
ms.assetid: 60e4958b-1097-46f5-a77b-94af5e7dba40
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _fread_nolock
Reads data from a stream, without locking other threads.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Storage location for data.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Item size in bytes.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Maximum number of items to be read.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Pointer to the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> structure.  
  
## Return Value  
 See [fread](../vs140/fread.md).  
  
## Remarks  
 This function is a non-locking version of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. It is identical to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> except that it is not protected from interference by other threads. It might be faster because it does not incur the overhead of locking out other threads. Use this function only in thread-safe contexts such as single-threaded applications or where the calling scope already handles thread isolation.  
  
## Requirements  
  
|Function|Required header|  
|--------------|---------------------|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|\<stdio.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## .NET Framework Equivalent  
 [System::IO::FileStream::Read](https://msdn.microsoft.com/en-us/library/system.io.filestream.read.aspx)  
  
## See Also  
 [Stream I/O](../vs140/stream-i-o.md)   
 [fwrite](../vs140/fwrite.md)   
 [_read](../vs140/_read.md)