---
title: "strerror, _strerror, _wcserror, __wcserror"
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
  - "strerror"
  - "_strerror"
  - "_wcserror"
  - "__wcserror"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcr100.dll"
  - "msvcr120.dll"
  - "msvcrt.dll"
  - "msvcr90.dll"
  - "msvcr80.dll"
  - "msvcr110.dll"
apitype: "DLLExport"
f1_keywords: 
  - "__sys_errlist"
  - "wcserror"
  - "_strerror"
  - "__wcserror"
  - "strerror"
  - "__sys_nerr"
  - "_tcserror"
  - "_wcserror"
  - "tcserror"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "strerror function"
  - "_strerror function"
  - "__sys_errlist"
  - "wcserror function"
  - "error messages, printing"
  - "__sys_nerr"
  - "tcserror function"
  - "printing error messages"
  - "_wcserror function"
  - "_tcserror function"
  - "__wcserror function"
  - "error messages, getting"
ms.assetid: 27b72255-f627-43c0-8836-bcda8b003e14
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# strerror, _strerror, _wcserror, __wcserror
Gets a system error message string (<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>) or formats a user-supplied error message string (<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>). More secure versions of these functions are available; see [strerror_s, _strerror_s, _wcserror_s, \__wcserror_s](../vs140/strerror_s--_strerror_s--_wcserror_s--__wcserror_s.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Error number.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 User-supplied message.  
  
## Return Value  
 All of these functions return a pointer to the error-message string. Subsequent calls can overwrite the string.  
  
## Remarks  
 The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> function maps <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to an error-message string and returns a pointer to the string. Neither <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> nor <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> actually prints the message: For that, you have to call an output function such as [fprintf](../vs140/fprintf--_fprintf_l--fwprintf--_fwprintf_l.md):  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is passed as <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> returns a pointer to a string that contains the system error message for the last library call that produced an error. The error-message string is terminated by the newline character ('\n'). If <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is not equal to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, then <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> returns a pointer to a string that contains (in order) your string message, a colon, a space, the system error message for the last library call that produces an error, and a newline character. Your string message can be, at most, 94 characters long.  
  
 The actual error number for <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is stored in the variable [errno](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md). To produce accurate results, call <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> immediately after a library routine returns with an error. Otherwise, subsequent calls to <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> can overwrite the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> value.  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> are wide-character versions of <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, respectively.  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> are not part of the ANSI definition; they are Microsoft extensions and we recommend that you do not use them where you want portable code. For ANSI compatibility, use <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> instead.  
  
 To get error strings, we recommend <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> instead of the deprecated macros [_sys_errlist](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md) and [_sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md) and the deprecated internal functions <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>.  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|\<string.h>|  
|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|\<string.h>|  
|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|\<string.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
 See the example for [perror](../vs140/perror--_wperror.md).  
  
## .NET Framework Equivalent  
 [System::Exception::Message](https://msdn.microsoft.com/en-us/library/system.exception.message.aspx)  
  
## See Also  
 [String Manipulation](../vs140/string-manipulation--crt-.md)   
 [clearerr](../vs140/clearerr.md)   
 [ferror](../vs140/ferror.md)   
 [perror, _wperror](../vs140/perror--_wperror.md)