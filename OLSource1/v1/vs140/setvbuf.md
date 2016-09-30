---
title: "setvbuf"
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
  - "setvbuf"
apilocation: 
  - "msvcr90.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr100.dll"
  - "msvcr110.dll"
apitype: "DLLExport"
f1_keywords: 
  - "setvbuf"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "controlling stream buffering"
  - "stream buffering"
  - "setvbuf function"
ms.assetid: 6aa5aa37-3408-4fa0-992f-87f9f9c4baea
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# setvbuf
Controls stream buffering and buffer size.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> structure.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 User-allocated buffer.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Mode of buffering.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Buffer size in bytes. Allowable range: 2 <= <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> <= INT_MAX (2147483647). Internally, the value supplied for <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is rounded down to the nearest multiple of 2.  
  
## Return Value  
 Returns 0 if successful.  
  
 If <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, or if <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is not within a valid change, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, this function returns -1 and sets <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
 For information on these and other error codes, see [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
## Remarks  
 The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> function allows the program to control both buffering and buffer size for <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> must refer to an open file that has not undergone an I/O operation since it was opened. The array pointed to by <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is used as the buffer, unless it is <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, in which case <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> uses an automatically allocated buffer of length <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>/2 * 2 bytes.  
  
 The mode must be <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, then <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is used as the size of the buffer. If <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, the stream is unbuffered and <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> are ignored. Values for <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> and their meanings are:  
  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 Full buffering; that is, <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> is used as the buffer and <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> is used as the size of the buffer. If <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>, an automatically allocated buffer <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> bytes long is used.  
  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 For some systems, this provides line buffering. However, for Win32, the behavior is the same as <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> - Full Buffering.  
  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 No buffer is used, regardless of <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|\<stdio.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Libraries  
 All versions of the [C run-time libraries](../vs140/crt-library-features.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **'stream1' now has a buffer of 1024 bytes**  
**'stream2' now has no buffer**   
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Stream I/O](../vs140/stream-i-o.md)   
 [fclose, _fcloseall](../vs140/fclose--_fcloseall.md)   
 [fflush](../vs140/fflush.md)   
 [fopen, _wfopen](../vs140/fopen--_wfopen.md)   
 [setbuf](../vs140/setbuf.md)