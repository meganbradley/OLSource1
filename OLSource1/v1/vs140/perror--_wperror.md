---
title: "perror, _wperror"
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
  - "_wperror"
  - "perror"
apilocation: 
  - "msvcr100.dll"
  - "msvcr110.dll"
  - "msvcr80.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
  - "msvcr120.dll"
  - "msvcrt.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_wperror"
  - "_tperror"
  - "perror"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_tperror function"
  - "tperror function"
  - "wperror function"
  - "error messages, printing"
  - "printing error messages"
  - "_wperror function"
  - "perror function"
ms.assetid: 34fce792-16fd-4673-9849-cd88b54b6cd5
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# perror, _wperror
Print an error message.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 String message to print.  
  
## Remarks  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> function prints an error message to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is a wide-character version of **_perror**; the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> argument to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is a wide-character string. <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and **_perror** behave identically otherwise.  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is printed first, followed by a colon, then by the system error message for the last library call that produced the error, and finally by a newline character. If <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is a null pointer or a pointer to a null string, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> prints only the system error message.  
  
 The error number is stored in the variable [errno](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md) (defined in ERRNO.H). The system error messages are accessed through the variable [_sys_errlist](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md), which is an array of messages ordered by error number. <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> prints the appropriate error message using the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> value as an index to <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. The value of the variable [_sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md) is defined as the maximum number of elements in the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> array.  
  
 For accurate results, call <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> immediately after a library routine returns with an error. Otherwise, subsequent calls can overwrite the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> value.  
  
 In the Windows operating system, some <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> values listed in ERRNO.H are unused. These values are reserved for use by the UNIX operating system. See [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md) for a listing of <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> values used by the Windows operating system. <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> prints an empty string for any <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> value not used by these platforms.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|\<stdio.h> or \<stdlib.h>|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|\<stdio.h> or \<wchar.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Libraries  
 All versions of the [C run-time libraries](../vs140/crt-library-features.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Process and Environment Control](../vs140/process-and-environment-control.md)   
 [clearerr](../vs140/clearerr.md)   
 [ferror](../vs140/ferror.md)   
 [strerror, _strerror, _wcserror, \__wcserror](../vs140/strerror--_strerror--_wcserror--__wcserror.md)