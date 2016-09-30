---
title: "fread"
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
  - "fread"
apilocation: 
  - "msvcr80.dll"
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr120.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "fread"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "reading data [C++], from input streams"
  - "fread function"
  - "data [C++], reading from input stream"
  - "streams [C++], reading data from"
ms.assetid: 9a3c1538-93dd-455e-ae48-77c1e23c53f0
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# fread
Reads data from a stream.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Storage location for data.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Item size in bytes.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Maximum number of items to be read.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Pointer to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> structure.  
  
## Return Value  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> returns the number of full items actually read, which may be less than <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> if an error occurs or if the end of the file is encountered before reaching <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>*.* Use the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> function to distinguish a read error from an end-of-file condition. If <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is 0, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> returns 0 and the buffer contents are unchanged. If <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is a null pointer, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> invokes the invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, this function sets <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> and returns 0.  
  
 See [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md) for more information on these, and other, error codes.  
  
## Remarks  
 The <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> function reads up to <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> items of <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> bytes from the input <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> and stores them in <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>*.* The file pointer associated with <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> (if there is one) is increased by the number of bytes actually read. If the given stream is opened in text mode, carriage return–linefeed pairs are replaced with single linefeed characters. The replacement has no effect on the file pointer or the return value. The file-pointer position is indeterminate if an error occurs. The value of a partially read item cannot be determined.  
  
 This function locks out other threads. If you need a non-locking version, use <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.  
  
## Requirements  
  
|Function|Required header|  
|--------------|---------------------|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|\<stdio.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Wrote 25 items**  
**Number of items read = 25**  
**Contents of buffer = zyxwvutsrqponmlkjihgfedcb**   
## .NET Framework Equivalent  
 [System::IO::FileStream::Read](https://msdn.microsoft.com/en-us/library/system.io.filestream.read.aspx)  
  
## See Also  
 [Stream I/O](../vs140/stream-i-o.md)   
 [fwrite](../vs140/fwrite.md)   
 [_read](../vs140/_read.md)