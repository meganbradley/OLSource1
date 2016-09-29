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
  
```  
int _fseek_nolock(   
   FILE *stream,  
   long offset,  
   int origin   
);  
int _fseeki64_nolock(   
   FILE *stream,  
   __int64 offset,  
   int origin   
);  
```  
  
#### Parameters  
 `stream`  
 Pointer to the `FILE` structure.  
  
 `offset`  
 Number of bytes from `origin.`  
  
 `origin`  
 Initial position.  
  
## Return Value  
 Same as [fseek, _fseeki64](../vs140/fseek--_fseeki64.md) respectively.  
  
## Remarks  
 These functions are the non-locking versions of `fseek` and `_fseeki64`, respectively.These are identical to `fseek` and `_fseeki64` except that they are not protected from interference by other threads. These functions might be faster because they do not incur the overhead of locking out other threads. Use these functions only in thread-safe contexts such as single-threaded applications or where the calling scope already handles thread isolation.  
  
## Requirements  
  
|Function|Required header|  
|--------------|---------------------|  
|`fseek`|<stdio.h>|  
|`_fseeki64`|<stdio.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## .NET Framework Equivalent  
  
-   [System::IO::FileStream::Position](https://msdn.microsoft.com/en-us/library/system.io.filestream.position.aspx)  
  
-   [System::IO::FileStream::Seek](https://msdn.microsoft.com/en-us/library/system.io.filestream.seek.aspx)  
  
## See Also  
 [Stream I/O](../vs140/stream-i-o.md)   
 [ftell, _ftelli64](../vs140/ftell--_ftelli64.md)   
 [_lseek, _lseeki64](../vs140/_lseek--_lseeki64.md)   
 [rewind](../vs140/rewind.md)