---
title: "_fclose_nolock"
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
  - "_fclose_nolock"
apilocation: 
  - "msvcr120.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "fclose_nolock"
  - "_fclose_nolock"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "streams, closing"
  - "fclose_nolock function"
  - "_fclose_nolock function"
ms.assetid: b4af4392-5fc8-49bb-9fe2-ca7293d3ce04
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _fclose_nolock
Closes a stream without thread-locking.  
  
## Syntax  
  
```  
int _fclose_nolock(   
   FILE *stream   
);  
```  
  
#### Parameters  
 `stream`  
 Pointer to the `FILE` structure.  
  
## Return Value  
 `fclose` returns 0 if the stream is successfully closed. Returns `EOF` to indicate an error.  
  
## Remarks  
 This functions is a non-locking version of `fclose`. It is identical except that it is not protected from interference by other threads. It might be faster because it does not incur the overhead of locking out other threads. Use this function only in thread-safe contexts such as single-threaded applications or where the calling scope already handles thread isolation.  
  
## Requirements  
  
|Function|Required header|  
|--------------|---------------------|  
|`_fclose_nolock`|<stdio.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## .NET Framework Equivalent  
  
-   [System::IO::BinaryReader::Close](https://msdn.microsoft.com/en-us/library/system.io.binaryreader.close.aspx)  
  
-   [System::IO::BinaryWriter::Close](https://msdn.microsoft.com/en-us/library/system.io.binarywriter.close.aspx)  
  
-   [System::IO::StringReader::Close](https://msdn.microsoft.com/en-us/library/system.io.stringreader.close.aspx)  
  
-   [System::IO::StringWriter::Close](https://msdn.microsoft.com/en-us/library/system.io.stringwriter.close.aspx)  
  
-   [System::IO::Stream::Close](https://msdn.microsoft.com/en-us/library/system.io.stream.close.aspx)  
  
-   [System::IO::StreamReader::Close](https://msdn.microsoft.com/en-us/library/system.io.streamreader.close.aspx)  
  
-   [System::IO::StreamWriter::Close](https://msdn.microsoft.com/en-us/library/system.io.streamwriter.close.aspx)  
  
-   [System::IO::TextReader::Close](https://msdn.microsoft.com/en-us/library/system.io.textreader.close.aspx)  
  
-   [System::IO::TextWriter::Close](https://msdn.microsoft.com/en-us/library/system.io.textwriter.close.aspx)  
  
## See Also  
 [Stream I/O](../vs140/stream-i-o.md)   
 [_close](../vs140/_close.md)   
 [_fdopen, _wfdopen](../vs140/_fdopen--_wfdopen.md)   
 [fflush](../vs140/fflush.md)   
 [fopen, _wfopen](../vs140/fopen--_wfopen.md)   
 [freopen, _wfreopen](../vs140/freopen--_wfreopen.md)