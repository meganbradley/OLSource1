---
title: "_fseek_nolock, _fseeki64_nolock"
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
  - "_fseek_nolock"
  - "_fseeki64_nolock"
apilocation: 
  - "msvcr90.dll"
  - "msvcr80.dll"
  - "msvcr120.dll"
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr100.dll"
  - "msvcrt.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_fseek_nolock"
  - "_fseeki64_nolock"
  - "fseek_nolock"
  - "fseeki64_nolock"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_fseek_nolock function"
  - "fseeki64_nolock function"
  - "file pointers [C++], moving"
  - "fseek_nolock function"
  - "_fseeki64_nolock function"
  - "seek file pointers"
ms.assetid: 2dd4022e-b715-462b-b935-837561605a02
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _fseek_nolock, _fseeki64_nolock
Moves the file pointer to a specified location.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> structure.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Number of bytes from <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Initial position.  
  
## Return Value  
 Same as [fseek, _fseeki64](../vs140/fseek--_fseeki64.md) respectively.  
  
## Remarks  
 These functions are the non-locking versions of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, respectively.These are identical to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> except that they are not protected from interference by other threads. These functions might be faster because they do not incur the overhead of locking out other threads. Use these functions only in thread-safe contexts such as single-threaded applications or where the calling scope already handles thread isolation.  
  
## Requirements  
  
|Function|Required header|  
|--------------|---------------------|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|\<stdio.h>|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|\<stdio.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## .NET Framework Equivalent  
  
-   [System::IO::FileStream::Position](https://msdn.microsoft.com/en-us/library/system.io.filestream.position.aspx)  
  
-   [System::IO::FileStream::Seek](https://msdn.microsoft.com/en-us/library/system.io.filestream.seek.aspx)  
  
## See Also  
 [Stream I/O](../vs140/stream-i-o.md)   
 [ftell, _ftelli64](../vs140/ftell--_ftelli64.md)   
 [_lseek, _lseeki64](../vs140/_lseek--_lseeki64.md)   
 [rewind](../vs140/rewind.md)