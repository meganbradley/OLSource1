---
title: "vsscanf_s, vswscanf_s"
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
  - "vswscanf_s"
  - "vsscanf_s"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcr100.dll"
  - "msvcr90.dll"
  - "msvcrt.dll"
  - "msvcr110.dll"
  - "msvcr80.dll"
  - "msvcr120.dll"
apitype: "DLLExport"
f1_keywords: 
  - "vsscanf_s"
  - "vswscanf_s"
  - "_vstscanf_s"
dev_langs: 
  - "C++"
ms.assetid: 7b732e68-c6f4-4579-8917-122f5a7876e1
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# vsscanf_s, vswscanf_s
Reads formatted data from a string. These versions of [vsscanf, vswscanf](../vs140/vsscanf--vswscanf.md) have security enhancements, as described in [Security Enhancements in the CRT](../vs140/security-features-in-the-crt.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Stored data  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Format-control string. For more information, see [Format Specification Fields: scanf and wscanf Functions](../vs140/format-specification-fields--scanf-and-wscanf-functions.md).  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Variable argument list.  
  
## Return Value  
 Each of these functions returns the number of fields that are successfully converted and assigned; the return value does not include fields that were read but not assigned. A return value of 0 indicates that no fields were assigned. The return value is <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> for an error or if the end of the string is reached before the first conversion.  
  
 If <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> pointer, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, these functions return -1 and set <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
 For information about these and other error codes, see [errno, _doserrno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
## Remarks  
 The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> function reads data from <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> into the locations that are given by each argument in the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> argument list. The arguments in the argument list specify pointers to variables that have a type that corresponds to a type specifier in <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. Unlike the less secure version <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, a buffer size parameter is required when you use the type field characters <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, or string-control sets that are enclosed in <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>. The buffer size in characters must be supplied as an additional parameter immediately after each buffer parameter that requires it.  
  
 The buffer size includes the terminating null. A width specification field may be used to ensure that the token that's read in will fit into the buffer. If no width specification field is used, and the token read in is too big to fit in the buffer, nothing is written to that buffer.  
  
 For more information, see [scanf_s, wscanf_s](../vs140/scanf_s--_scanf_s_l--wscanf_s--_wscanf_s_l.md) and [scanf Type Field Characters](../vs140/scanf-type-field-characters.md).  
  
> [!NOTE]
>  The size parameter is of type <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, not <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.  
  
 The <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> argument controls the interpretation of the input fields and has the same form and function as the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> argument for the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> function. If copying occurs between strings that overlap, the behavior is undefined.  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> is a wide-character version of <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>; the arguments to <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> are wide-character strings. <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> does not handle multibyte hexadecimal characters. <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> does not handle Unicode full-width hexadecimal or "compatibility zone" characters. Otherwise, <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> behave identically.  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|\<stdio.h>|  
|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|\<stdio.h> or \<wchar.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **String    = 15**  
**Character = 1**  
**Integer:  = 15**  
**Real:     = 15.000000**   
## .NET Framework Equivalent  
 See <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> methods, such as [System::Double::Parse](https://msdn.microsoft.com/en-us/library/system.double.parse.aspx).  
  
## See Also  
 [Stream I/O](../vs140/stream-i-o.md)   
 [scanf, wscanf](../vs140/scanf--_scanf_l--wscanf--_wscanf_l.md)   
 [sscanf, swscanf](../vs140/sscanf--_sscanf_l--swscanf--_swscanf_l.md)   
 [sscanf_s](../vs140/sscanf_s--_sscanf_s_l--swscanf_s--_swscanf_s_l.md)   
 [sprintf, swprintf](../vs140/sprintf--_sprintf_l--swprintf--_swprintf_l--__swprintf_l.md)   
 [vsscanf, vswscanf](../vs140/vsscanf--vswscanf.md)