---
title: "strerror_s, _strerror_s, _wcserror_s, __wcserror_s"
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
  - "__wcserror_s"
  - "_strerror_s"
  - "_wcserror_s"
  - "strerror_s"
apilocation: 
  - "msvcr90.dll"
  - "msvcr110.dll"
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
  - "msvcr100.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "wcserror_s"
  - "__wcserror_s"
  - "_tcserror_s"
  - "_wcserror_s"
  - "tcserror_s"
  - "strerror_s"
  - "_strerror_s"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "__wcserror_s function"
  - "error messages, printing"
  - "tcserror_s function"
  - "printing error messages"
  - "strerror_s function"
  - "_wcserror_s function"
  - "_tcserror_s function"
  - "_strerror_s function"
  - "wcserror_s function"
  - "error messages, getting"
ms.assetid: 9e5b15a0-efe1-4586-b7e3-e1d7c31a03d6
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# strerror_s, _strerror_s, _wcserror_s, __wcserror_s
Get a system error message (<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>) or print a user-supplied error message (<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>). These are versions of [strerror, _strerror, _wcserror, \__wcserror](../vs140/strerror--_strerror--_wcserror--__wcserror.md) with security enhancements as described in [Security Enhancements in the CRT](../vs140/security-features-in-the-crt.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Buffer to hold error string.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Size of buffer.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Error number.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 User-supplied message.  
  
## Return Value  
 Zero if successful, an error code on failure.  
  
### Error Condtions  
  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|Contents of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|  
|--------------|------------------------|-----------------|--------------------------|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|any|any|n/a|  
|any|0|any|not modified|  
  
## Remarks  
 The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> function maps <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> to an error-message string, returning the string in <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> doesn't take the error number; it uses the current value of <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> to determine the appropriate message. Neither <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> nor <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> actually prints the message: For that, you need to call an output function such as [fprintf](../vs140/fprintf--_fprintf_l--fwprintf--_fwprintf_l.md):  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> returns a string in <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> containing the system error message for the last library call that produced an error. The error-message string is terminated by the newline character ('\n'). If <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> is not equal to <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, then <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> returns a string in <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> containing (in order) your string message, a colon, a space, the system error message for the last library call producing an error, and a newline character. Your string message can be, at most, 94 characters long.  
  
 These functions truncate the error message if its length exceeds <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> -1. The resulting string in <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> is always null-terminated.  
  
 The actual error number for <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> is stored in the variable [errno](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md). The system error messages are accessed through the variable [_sys_errlist](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md), which is an array of messages ordered by error number. <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> accesses the appropriate error message by using the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> value as an index to the variable <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>. The value of the variable [_sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md) is defined as the maximum number of elements in the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> array. To produce accurate results, call <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> immediately after a library routine returns with an error. Otherwise, subsequent calls to <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> can overwrite the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> value.  
  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>are wide-character versions of <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>and <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>, respectively.  
  
 These functions validate their parameters. If buffer is <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> or if the size parameter is 0, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md) . If execution is allowed to continue, the functions return <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> and set <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> are not part of the ANSI definition but are instead Microsoft extensions to it. Do not use them where portability is desired; for ANSI compatibility, use <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> instead.  
  
 In C++, using these functions is simplified by template overloads; the overloads can infer buffer length automatically, eliminating the need to specify a size argument. For more information, see [Secure Template Overloads](../vs140/secure-template-overloads.md).  
  
 The debug versions of these functions first fill the buffer with 0xFD. To disable this behavior, use [_CrtSetDebugFillThreshold](../vs140/_crtsetdebugfillthreshold.md).  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>|\<string.h>|  
|<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>|\<string.h> or \<wchar.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
 See the example for [perror](../vs140/perror--_wperror.md).  
  
## .NET Framework Equivalent  
 [System::Exception::Message](https://msdn.microsoft.com/en-us/library/system.exception.message.aspx)  
  
## See Also  
 [String Manipulation](../vs140/string-manipulation--crt-.md)   
 [clearerr](../vs140/clearerr.md)   
 [ferror](../vs140/ferror.md)   
 [perror, _wperror](../vs140/perror--_wperror.md)