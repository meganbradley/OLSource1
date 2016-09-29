---
title: "_fread_nolock_s"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "cpp"
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
apiname: 
  - "_fread_nolock_s"
apilocation: 
  - "api-ms-win-crt-stdio-l1-1-0.dll"
  - "msvcr120.dll"
  - "msvcr110.dll"
  - "msvcr100.dll"
  - "msvcr90.dll"
  - "msvcr120_clr0400.dll"
  - "msvcr110_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_fread_nolock_s"
  - "stdio/_fread_nolock_s"
dev_langs: 
  - "C"
  - "C++"
ms.assetid: 5badb9ab-11df-4e17-8162-30bda2a4572e
caps.latest.revision: 7
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _fread_nolock_s
Reads data from a stream, without locking other threads. This version of [fread_nolock](../vs140/_fread_nolock.md) has security enhancements, as described in [Security Enhancements in the CRT](../vs140/security-features-in-the-crt.md).  
  
## Syntax  
  
```  
size_t _fread_nolock_s(   
   void *buffer,  
   size_t bufferSize,  
   size_t elementSize,  
   size_t elementCount,  
   FILE *stream   
);  
```  
  
#### Parameters  
 `buffer`  
 Storage location for data.  
  
 `bufferSize`  
 Size of the destination buffer in bytes.  
  
 `elementSize`  
 Size of the item to read in bytes.  
  
 `elementCount`  
 Maximum number of items to be read.  
  
 `stream`  
 Pointer to `FILE` structure.  
  
## Return Value  
 See [fread_s](../vs140/fread_s.md).  
  
## Remarks  
 This function is a non-locking version of `fread_s`. It is identical to `fread_s` except that it is not protected from interference by other threads. It might be faster because it does not incur the overhead of locking out other threads. Use this function only in thread-safe contexts such as single-threaded applications or where the calling scope already handles thread isolation.  
  
## Requirements  
  
|Function|Required header|  
|--------------|---------------------|  
|`_fread_nolock_s`|C: <stdio.h>; C++: <cstdio\> or <stdio.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## .NET Framework Equivalent  
 [System::IO::FileStream::Read](https://msdn.microsoft.com/en-us/library/system.io.filestream.read.aspx)  
  
## See Also  
 [Stream I/O](../vs140/stream-i-o.md)   
 [fwrite](../vs140/fwrite.md)   
 [_read](../vs140/_read.md)