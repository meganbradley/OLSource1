---
title: "putchar, putwchar"
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
  - "putchar"
  - "putwchar"
apilocation: 
  - "msvcrt.dll"
  - "msvcr120.dll"
  - "msvcr90.dll"
  - "msvcr80.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr110.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "putchar"
  - "putwchar"
  - "_puttchar"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "putchar function"
  - "_puttchar function"
  - "characters, writing"
  - "standard output, writing to"
  - "putwchar function"
ms.assetid: 93657c7f-cca1-4032-8e3a-cd6ab6193748
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# putchar, putwchar
Writes a character to **stdout**.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Character to be written.  
  
## Return Value  
 Returns the character written. To indicate an error or end-of-file condition, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> return <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>; <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> return **WEOF**. For all four routines, use [ferror](../vs140/ferror.md) or [feof](../vs140/feof.md) to check for an error or end of file. If passed a null pointer for <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, these functions generate an invalid parameter exception, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, they return <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> or **WEOF** and set <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
 See [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md) for more information on these, and other, error codes.  
  
## Remarks  
 The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> routine writes the single character <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> to the output <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> at the current position. Any integer can be passed to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, but only the lower 8 bits are written. The <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> routine is identical to **putc(** <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>**, stdout )**. For each routine, if a read error occurs, the error indicator for the stream is set. <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> are similar to <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, respectively, but are implemented both as functions and as macros (see [Choosing Between Functions and Macros](../vs140/recommendations-for-choosing-between-functions-and-macros.md)). <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> are wide-character versions of <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, respectively.  
  
 The versions with the **_nolock** suffix are identical except that they are not protected from interference by other threads. They may be faster since they do not incur the overhead of locking out other threads. Use these functions only in thread-safe contexts such as single-threaded applications or where the calling scope already handles thread isolation.  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|**putwchar**|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|\<stdio.h>|  
|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|\<stdio.h> or \<wchar.h>|  
  
 The console is not supported in [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] apps. The standard stream handles that are associated with the console—<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>—must be redirected before C run-time functions can use them in [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] apps. For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Libraries  
 All versions of the [C run-time libraries](../vs140/crt-library-features.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## .NET Framework Equivalent  
  
-   [System::IO::StreamWriter::Write](https://msdn.microsoft.com/en-us/library/system.io.streamwriter.write.aspx)  
  
-   [System::Console::Write](https://msdn.microsoft.com/en-us/library/system.console.write.aspx)  
  
## See Also  
 [Stream I/O](../vs140/stream-i-o.md)   
 [fputc, fputwc](../vs140/fputc--fputwc.md)   
 [getc, getwc](../vs140/getc--getwc.md)