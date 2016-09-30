---
title: "fread_s"
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
  - "fread_s"
apilocation: 
  - "msvcr80.dll"
  - "msvcr120.dll"
  - "msvcr110.dll"
  - "msvcrt.dll"
  - "msvcr100.dll"
  - "msvcr90.dll"
  - "msvcr110_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "fread_s"
  - "stdio/fread_s"
dev_langs: 
  - "C++"
ms.assetid: ce735de0-f005-435d-a8f2-6f4b80ac775e
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# fread_s
Reads data from a stream. This version of [fread](../vs140/fread.md) has security enhancements, as described in [Security Enhancements in the CRT](../vs140/security-features-in-the-crt.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Storage location for data.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Size of the destination buffer in bytes.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Size of the item to read in bytes.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Maximum number of items to be read.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Pointer to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> structure.  
  
## Return Value  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> returns the number of (whole) items that were read into the buffer, which may be less than <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> if a read error or the end of the file is encountered before <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is reached. Use the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> function to distinguish an error from an end-of-file condition. If <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is 0, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> returns 0 and the buffer contents are unchanged. If <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is a null pointer, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> invokes the invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, this function sets <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> and returns 0.  
  
 For more information about error codes, see [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
## Remarks  
 The <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> function reads up to <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> items of <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> bytes from the input <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> and stores them in <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.  The file pointer that is associated with <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> (if there is one) is increased by the number of bytes actually read. If the given stream is opened in text mode, carriage return–linefeed pairs are replaced with single linefeed characters. The replacement has no effect on the file pointer or the return value. The file-pointer position is indeterminate if an error occurs. The value of a partially read item cannot be determined.  
  
 This function locks out other threads. If you require a non-locking version, use <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.  
  
## Requirements  
  
|Function|Required header|  
|--------------|---------------------|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|\<stdio.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Contents of buffer before write/read:**   
 **zyxwvutsrqponmlkjihgfe**   
**Wrote 22 items**   
**Number of 11-byte elements read = 2**   
**Contents of buffer after write/read:**   
 **zyxwvutsrqponmlkjihgfe**    
## See Also  
 [Stream I/O](../vs140/stream-i-o.md)   
 [fwrite](../vs140/fwrite.md)   
 [_read](../vs140/_read.md)