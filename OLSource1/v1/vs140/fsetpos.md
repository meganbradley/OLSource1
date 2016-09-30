---
title: "fsetpos"
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
  - "fsetpos"
apilocation: 
  - "msvcr80.dll"
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr110.dll"
  - "msvcr100.dll"
  - "msvcr90.dll"
  - "msvcrt.dll"
apitype: "DLLExport"
f1_keywords: 
  - "fsetpos"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "streams, setting position indicators"
  - "fsetpos function"
ms.assetid: 6d19ff48-1a2b-47b3-9f23-ed0a47b5a46e
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# fsetpos
Sets the stream-position indicator.  
  
## Syntax  
  
```  
int fsetpos(   
   FILE *stream,  
   const fpos_t *pos   
);  
```  
  
#### Parameters  
 `stream`  
 Pointer to `FILE` structure.  
  
 `pos`  
 Position-indicator storage.  
  
## Return Value  
 If successful, `fsetpos` returns 0. On failure, the function returns a nonzero value and sets `errno` to one of the following manifest constants (defined in ERRNO.H): `EBADF`, which means the file is not accessible or the object that `stream` points to is not a valid file structure; or `EINVAL`, which means an invalid value for `stream` or `pos` was passed. If an invalid parameter is passed in, these functions invoke the invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md).  
  
 See [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md) for more information on these, and other, return codes.  
  
## Remarks  
 The `fsetpos` function sets the file-position indicator for `stream` to the value of `pos`*,* which is obtained in a prior call to `fgetpos` against `stream`*.* The function clears the end-of-file indicator and undoes any effects of [ungetc](../vs140/ungetc--ungetwc.md) on `stream`*.* After calling `fsetpos`, the next operation on `stream` may be either input or output.  
  
## Requirements  
  
|Function|Required header|  
|--------------|---------------------|  
|`fsetpos`|\<stdio.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
 See the example for [fgetpos](../vs140/fgetpos.md).  
  
## .NET Framework Equivalent  
 [System::IO::FileStream::Position](https://msdn.microsoft.com/en-us/library/system.io.filestream.position.aspx)  
  
## See Also  
 [Stream I/O](../vs140/stream-i-o.md)   
 [fgetpos](../vs140/fgetpos.md)