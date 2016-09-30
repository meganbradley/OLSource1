---
title: "fputc, fputwc"
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
  - "fputc"
  - "fputwc"
apilocation: 
  - "msvcr80.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
  - "msvcr110.dll"
  - "msvcrt.dll"
  - "msvcr100.dll"
  - "msvcr90.dll"
apitype: "DLLExport"
f1_keywords: 
  - "fputc"
  - "fputwc"
  - "_fputtc"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "streams, writing characters to"
  - "fputtc function"
  - "_fputtc function"
  - "fputwc function"
  - "fputc function"
ms.assetid: 5a0a593d-43f4-4fa2-a401-ec4e23de4d2f
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# fputc, fputwc
Writes a character to a stream.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Character to be written.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Pointer to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> structure.  
  
## Return Value  
 Each of these functions returns the character written. For <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, a return value of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> indicates an error. For <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, a return value of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> indicates an error. If <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, these functions invoke the invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, they return <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and set <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
 See [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md) for more information on these, and other, error codes.  
  
## Remarks  
 Each of these functions writes the single character <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> to a file at the position indicated by the associated file position indicator (if defined) and advances the indicator as appropriate. In the case of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, the file is associated with <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>*.* If the file cannot support positioning requests or was opened in append mode, the character is appended to the end of the stream.  
  
 The two functions behave identically if the stream is opened in ANSI mode. <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> does not currently support output into a UNICODE stream.  
  
 The versions with the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> suffix are identical except that they are not protected from interference by other threads. For more information, see[_fputc_nolock, _fputwc_nolock](../vs140/_fputc_nolock--_fputwc_nolock.md).  
  
 Routine-specific remarks follow.  
  
|Routine|Remarks|  
|-------------|-------------|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|Equivalent to <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, but implemented only as a function, rather than as a function and a macro.|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|Wide-character version of <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>. Writes <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> as a multibyte character or a wide character according to whether <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> is opened in text mode or binary mode.|  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Function|Required header|  
|--------------|---------------------|  
|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|\<stdio.h>|  
|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|\<stdio.h> or \<wchar.h>|  
  
 The console is not supported in [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] apps. The standard stream handles that are associated with the console—<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>—must be redirected before C run-time functions can use them in [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] apps. For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **This is a test of fputc!!**   
## .NET Framework Equivalent  
  
-   [System::IO::StreamWriter::Write](https://msdn.microsoft.com/en-us/library/system.io.streamwriter.write.aspx)  
  
-   [System::Console::Write](https://msdn.microsoft.com/en-us/library/system.console.write.aspx)  
  
## See Also  
 [Stream I/O](../vs140/stream-i-o.md)   
 [fgetc, fgetwc](../vs140/fgetc--fgetwc.md)   
 [putc, putwc](../vs140/putc--putwc.md)