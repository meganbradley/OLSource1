---
title: "_chsize"
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
  - "_chsize"
apilocation: 
  - "msvcr90.dll"
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr80.dll"
  - "msvcrt.dll"
  - "msvcr100.dll"
  - "msvcr110.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_chsize"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "size"
  - "_chsize function"
  - "size, changing file"
  - "files [C++], changing size"
  - "chsize function"
ms.assetid: b3e881c5-7b27-4837-a3d4-c51591ab10ff
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _chsize
Changes the size of a file. A more secure version is available; see [_chsize_s](../vs140/_chsize_s.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 File descriptor referring to an open file.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 New length of the file in bytes.  
  
## Return Value  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> returns the value 0 if the file size is successfully changed. A return value of –1 indicates an error: <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> if the specified file is locked against access, to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> if the specified file is read-only or the descriptor is invalid, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> if no space is left on the device, or <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is less than zero.  
  
 See [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md) for more information on these, and other, return codes.  
  
## Remarks  
 The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> function extends or truncates the file associated with <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to the length specified by <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. The file must be open in a mode that permits writing. Null characters ('\0') are appended if the file is extended. If the file is truncated, all data from the end of the shortened file to the original length of the file is lost.  
  
 This function validates its parameters. If <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is less than zero or <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is a bad file descriptor, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md).  
  
## Requirements  
  
|Routine|Required header|Optional header|  
|-------------|---------------------|---------------------|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|\<io.h>|\<errno.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **File length before: 0**  
**Size successfully changed**  
**File length after:  329678**   
## .NET Framework Equivalent  
  
-   [System::IO::Stream::SetLength](https://msdn.microsoft.com/en-us/library/system.io.stream.setlength.aspx)  
  
-   [System::IO::FileStream::SetLength](https://msdn.microsoft.com/en-us/library/system.io.filestream.setlength.aspx)  
  
## See Also  
 [File Handling](../vs140/file-handling.md)   
 [_close](../vs140/_close.md)   
 [_sopen, _wsopen](../vs140/_sopen--_wsopen.md)   
 [_open, _wopen](../vs140/_open--_wopen.md)