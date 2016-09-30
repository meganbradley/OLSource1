---
title: "fclose, _fcloseall"
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
  - "fclose"
  - "_fcloseall"
apilocation: 
  - "msvcr90.dll"
  - "msvcr120.dll"
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr110.dll"
apitype: "DLLExport"
f1_keywords: 
  - "fclose"
  - "_fcloseall"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "fclose function"
  - "streams, closing"
  - "_fcloseall function"
ms.assetid: c3c6ea72-92c6-450a-a33e-3e568d2784a4
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# fclose, _fcloseall
Closes a stream (<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>) or closes all open streams (<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Pointer to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> structure.  
  
## Return Value  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> returns 0 if the stream is successfully closed. <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> returns the total number of streams closed. Both functions return <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to indicate an error.  
  
## Remarks  
 The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> function closes <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> sets <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and returns <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. It is recommended that the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> pointer always be checked prior to calling this function.  
  
 See [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md) for more information on these, and other, error codes.  
  
 The <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> function closes all open streams except <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> (and, in MS-DOS, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>). It also closes and deletes any temporary files created by <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>. In both functions, all buffers associated with the stream are flushed prior to closing. System-allocated buffers are released when the stream is closed. Buffers assigned by the user with <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> are not automatically released.  
  
 **Note:** When these functions are used to close a stream, the underlying file descriptor and OS file handle (or socket) are closed, as well as the stream. Thus, if the file was originally opened as a file handle or file descriptor and is closed with <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, do not also call <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> to close the file descriptor; do not call the Win32 function <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> to close the file handle.  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> include code to protect against interference from other threads. For non-locking version of a <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, see <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>.  
  
## Requirements  
  
|Function|Required header|  
|--------------|---------------------|  
|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|\<stdio.h>|  
|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|\<stdio.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
 See the example for [fopen](../vs140/fopen--_wfopen.md).  
  
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