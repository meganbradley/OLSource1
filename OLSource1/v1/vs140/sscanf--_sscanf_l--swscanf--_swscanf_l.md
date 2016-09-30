---
title: "sscanf, _sscanf_l, swscanf, _swscanf_l"
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
  - "swscanf"
  - "sscanf"
  - "_sscanf_l"
  - "_swscanf_l"
apilocation: 
  - "msvcr110.dll"
  - "msvcr120.dll"
  - "msvcrt.dll"
  - "msvcr100.dll"
  - "msvcr90.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_sscanf_l"
  - "_stscanf"
  - "swscanf"
  - "_stscanf_l"
  - "sscanf"
  - "_swscanf_l"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "swscanf function"
  - "_stscanf function"
  - "sscanf function"
  - "_stscanf_l function"
  - "_sscanf_l function"
  - "_swscanf_l function"
  - "swscanf_l function"
  - "strings [C++], reading data from"
  - "stscanf function"
  - "reading data, strings"
  - "strings [C++], reading"
  - "sscanf_l function"
  - "stscanf_l function"
ms.assetid: c2dcf0d2-9798-499f-a4a8-06f7e2b9a80c
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# sscanf, _sscanf_l, swscanf, _swscanf_l
Read formatted data from a string. More secure versions of these functions are available; see [sscanf_s, _sscanf_s_l, swscanf_s , _swscanf_s_l](../vs140/sscanf_s--_sscanf_s_l--swscanf_s--_swscanf_s_l.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Stored data  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Format-control string. For more information, see [Format Specifications](../vs140/format-specification-fields--scanf-and-wscanf-functions.md).  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Optional arguments  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The locale to use  
  
## Return Value  
 Each of these functions returns the number of fields successfully converted and assigned; the return value does not include fields that were read but not assigned. A return value of 0 indicates that no fields were assigned. The return value is <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> for an error or if the end of the string is reached before the first conversion.  
  
 If <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> pointer, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, these functions return -1 and set <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
 For information on these and other error codes, see [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
## Remarks  
 The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> function reads data from <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> into the location given by each <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. Every <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> must be a pointer to a variable with a type that corresponds to a type specifier in <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> argument controls the interpretation of the input fields and has the same form and function as the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> argument for the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> function. If copying takes place between strings that overlap, the behavior is undefined.  
  
> [!IMPORTANT]
>  When reading a string with <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, always specify a width for the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> format (for example, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> instead of <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>); otherwise, improperly formatted input can easily cause a buffer overrun.  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is a wide-character version of <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>; the arguments to <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> are wide-character strings. <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>does not handle multibyte hexadecimal characters. <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> does not handle Unicode full-width hexadecimal or "compatibility zone" characters. Otherwise, <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> behave identically.  
  
 The versions of these functions with the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> suffix are identical except that they use the locale parameter passed in instead of the current thread locale.  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|\<stdio.h>|  
|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|\<stdio.h> or \<wchar.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **String    = 15**  
**Character = 1**  
**Integer:  = 15**  
**Real:     = 15.000000**   
## .NET Framework Equivalent  
 See <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> methods, such as [System::Double::Parse](https://msdn.microsoft.com/en-us/library/system.double.parse.aspx).  
  
## See Also  
 [Stream I/O](../vs140/stream-i-o.md)   
 [fscanf, fwscanf](../vs140/fscanf--_fscanf_l--fwscanf--_fwscanf_l.md)   
 [scanf, wscanf](../vs140/scanf--_scanf_l--wscanf--_wscanf_l.md)   
 [sprintf, swprintf](../vs140/sprintf--_sprintf_l--swprintf--_swprintf_l--__swprintf_l.md)   
 [_snprintf, _snwprintf](../vs140/snprintf--_snprintf--_snprintf_l--_snwprintf--_snwprintf_l.md)