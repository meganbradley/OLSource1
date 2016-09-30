---
title: "_chsize_s"
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
  - "_chsize_s"
apilocation: 
  - "msvcr120.dll"
  - "msvcr110.dll"
  - "msvcr90.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "chsize_s"
  - "_chsize_s"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "files [C++], changing size"
  - "chsize_s function"
  - "_chsize_s function"
ms.assetid: d88d2e94-6e3b-42a5-8631-16ac4d82fa38
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _chsize_s
Changes the size of a file. This is a version of [_chsize](../vs140/_chsize.md) with security enhancements as described in [Security Enhancements in the CRT](../vs140/security-features-in-the-crt.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 File descriptor referring to an open file.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 New length of the file in bytes.  
  
## Return Value  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> returns the value 0 if the file size is successfully changed. A nonzero return value indicates an error: the return value is <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if the specified file is locked against access, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if the specified file is read-only or the descriptor is invalid, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> if no space is left on the device, or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> if size is less than zero. <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is set to the same value.  
  
 For more information about these and other return codes, see [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
## Remarks  
 The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> function extends or truncates the file associated with <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to the length specified by <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. The file must be open in a mode that permits writing. Null characters ('\0') are appended if the file is extended. If the file is truncated, all data from the end of the shortened file to the original length of the file is lost.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> takes a 64-bit integer as the file size, and therefore can handle file sizes greater than 4 GB. <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is limited to 32-bit file sizes.  
  
 This function validates its parameters. If <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is not a valid file descriptor or size is less than zero, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md).  
  
## Requirements  
  
|Routine|Required header|Optional header|  
|-------------|---------------------|---------------------|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|\<io.h>|\<errno.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## .NET Framework Equivalent  
  
-   [System::IO::Stream::SetLength](https://msdn.microsoft.com/en-us/library/system.io.stream.setlength.aspx)  
  
-   [System::IO::FileStream::SetLength](https://msdn.microsoft.com/en-us/library/system.io.filestream.setlength.aspx)  
  
## See Also  
 [File Handling](../vs140/file-handling.md)   
 [_chsize](../vs140/_chsize.md)   
 [_close](../vs140/_close.md)   
 [_creat, _wcreat](../vs140/_creat--_wcreat.md)   
 [_open, _wopen](../vs140/_open--_wopen.md)