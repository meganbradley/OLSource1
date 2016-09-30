---
title: "sscanf_s, _sscanf_s_l, swscanf_s, _swscanf_s_l"
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
  - "_sscanf_s_l"
  - "sscanf_s"
  - "_swscanf_s_l"
  - "swscanf_s"
apilocation: 
  - "msvcr90.dll"
  - "msvcr80.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr110.dll"
  - "msvcr100.dll"
  - "msvcr120.dll"
  - "msvcrt.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_stscanf_s"
  - "sscanf_s"
  - "swscanf_s"
  - "_swscanf_s_l"
  - "_stscanf_s_l"
  - "_sscanf_s_l"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "stscanf_s_l function"
  - "stscanf_s function"
  - "swscanf_s function"
  - "swscanf_s_l function"
  - "sscanf_s_l function"
  - "_stscanf_s_l function"
  - "strings [C++], reading data from"
  - "sscanf_s function"
  - "_swscanf_s_l function"
  - "_stscanf_s function"
  - "reading data, strings"
  - "strings [C++], reading"
  - "_sscanf_s_l function"
ms.assetid: 956e65c8-00a5-43e8-a2f2-0f547ac9e56c
caps.latest.revision: 32
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# sscanf_s, _sscanf_s_l, swscanf_s, _swscanf_s_l
Reads formatted data from a string. These versions of [sscanf, _sscanf_l, swscanf, _swscanf_l](../vs140/sscanf--_sscanf_l--swscanf--_swscanf_l.md) have security enhancements, as described in [Security Enhancements in the CRT](../vs140/security-features-in-the-crt.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Stored data  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Format-control string. For more information, see [Format Specification Fields: scanf and wscanf Functions](../vs140/format-specification-fields--scanf-and-wscanf-functions.md).  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Optional arguments  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The locale to use  
  
## Return Value  
 Each of these functions returns the number of fields that are successfully converted and assigned; the return value does not include fields that were read but not assigned. A return value of 0 indicates that no fields were assigned. The return value is <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> for an error or if the end of the string is reached before the first conversion.  
  
 If <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> pointer, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, these functions return -1 and set <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
 For information about these and other error codes, see [errno, _doserrno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
## Remarks  
 The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> function reads data from <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> into the location that's given by each <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. The arguments after the format string specify pointers to variables that have a type that corresponds to a type specifier in <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. Unlike the less secure version <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, a buffer size parameter is required when you use the type field characters <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, or string control sets that are enclosed in <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>. The buffer size in characters must be supplied as an additional parameter immediately after each buffer parameter that requires it. For example, if you are reading into a string, the buffer size for that string is passed as follows:  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
  
 The buffer size includes the terminating null. A width specification field may be used to ensure that the token that's read in will fit into the buffer. If no width specification field is used, and the token read in is too big to fit in the buffer, nothing is written to that buffer.  
  
 In the case of characters, a single character may be read as follows:  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
  
 This example reads a single character from the input string and then stores it in a wide-character buffer. When you read multiple characters for non-null terminated strings, unsigned integers are used as the width specification and the buffer size.  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
  
 For more information, see [scanf_s, wscanf_s](../vs140/scanf_s--_scanf_s_l--wscanf_s--_wscanf_s_l.md) and [scanf Type Field Characters](../vs140/scanf-type-field-characters.md).  
  
> [!NOTE]
>  The size parameter is of type <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, not <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>. When compiling for 64-bit targets, use a static cast to convert <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> results to the correct size.  
  
 The <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> argument controls the interpretation of the input fields and has the same form and function as the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> argument for the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> function. If copying occurs between strings that overlap, the behavior is undefined.  
  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> is a wide-character version of <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> the arguments to <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> are wide-character strings. <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> does not handle multibyte hexadecimal characters. <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> does not handle Unicode full-width hexadecimal or "compatibility zone" characters. Otherwise, <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> behave identically.  
  
 The versions of these functions that have the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> suffix are identical except that they use the locale parameter that's passed in instead of the current thread locale.  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>|\<stdio.h>|  
|<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>|\<stdio.h> or \<wchar.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **String    = 15**  
**Character = 1**  
**Integer:  = 15**  
**Real:     = 15.000000**   
## .NET Framework Equivalent  
 See <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> methods, such as [System::Double::Parse](https://msdn.microsoft.com/en-us/library/system.double.parse.aspx).  
  
## See Also  
 [Stream I/O](../vs140/stream-i-o.md)   
 [fscanf, fwscanf](../vs140/fscanf--_fscanf_l--fwscanf--_fwscanf_l.md)   
 [scanf, wscanf](../vs140/scanf--_scanf_l--wscanf--_wscanf_l.md)   
 [sprintf, swprintf](../vs140/sprintf--_sprintf_l--swprintf--_swprintf_l--__swprintf_l.md)   
 [_snprintf, _snwprintf](../vs140/snprintf--_snprintf--_snprintf_l--_snwprintf--_snwprintf_l.md)