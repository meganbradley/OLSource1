---
title: "_fflush_nolock"
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
  - "_fflush_nolock"
apilocation: 
  - "msvcr80.dll"
  - "msvcrt.dll"
  - "msvcr100.dll"
  - "msvcr120.dll"
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
apitype: "DLLExport"
f1_keywords: 
  - "fflush_nolock"
  - "_fflush_nolock"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "fflush_nolock function"
  - "_fflush_nolock function"
  - "streams, flushing"
  - "flushing"
ms.assetid: 5e33c4a1-b10c-4001-ad01-210757919291
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _fflush_nolock
Flushes a stream without locking the thread.  
  
## Syntax  
  
```  
int _fflush_nolock(   
   FILE *stream   
);  
```  
  
#### Parameters  
 `stream`  
 Pointer to the `FILE` structure.  
  
## Return Value  
 See [fflush](../vs140/fflush.md).  
  
## Remarks  
 This function is a non-locking version of `fflush`. It is identical to `fflush` except that it is not protected from interference by other threads. It might be faster because it does not incur the overhead of locking out other threads. Use this function only in thread-safe contexts such as single-threaded applications or where the calling scope already handles thread isolation.  
  
## Requirements  
  
|Function|Required header|  
|--------------|---------------------|  
|`_fflush_nolock`|<stdio.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## .NET Framework Equivalent  
 [System::IO::FileStream::Flush](https://msdn.microsoft.com/en-us/library/2bw4h516.aspx)  
  
## See Also  
 [Stream I/O](../vs140/stream-i-o.md)   
 [fclose, _fcloseall](../vs140/fclose--_fcloseall.md)   
 [_flushall](../vs140/_flushall.md)   
 [setvbuf](../vs140/setvbuf.md)