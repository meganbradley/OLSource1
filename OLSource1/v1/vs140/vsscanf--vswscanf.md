---
title: "vsscanf, vswscanf"
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
  - "vsscanf"
  - "vswscanf"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcr110.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr120.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_vstscanf"
  - "vsscanf"
  - "vswscanf"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "vswscanf function"
  - "vsscanf function"
ms.assetid: e96180f2-df46-423d-b4eb-0a49ab819bde
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# vsscanf, vswscanf
Reads formatted data from a string. More secure versions of these functions are available; see [vsscanf_s, vswscanf_s](../vs140/vsscanf_s--vswscanf_s.md).  
  
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
  
 If <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> pointer, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, these functions return -1 and set <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
 For information about these and other error codes, see [errno, _doserrno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
## Remarks  
 The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> function reads data from <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> into the locations that are given by each argument in the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> argument list. Every argument in the list must be a pointer to a variable that has a type that corresponds to a type specifier in <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> argument controls the interpretation of the input fields and has the same form and function as the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> argument for the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> function. If copying takes place between strings that overlap, the behavior is undefined.  
  
> [!IMPORTANT]
>  When you use <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> to read a string, always specify a width for the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> format (for example, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> instead of <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>); otherwise, incorrectly formatted input can cause a buffer overrun.  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is a wide-character version of <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>; the arguments to <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> are wide-character strings. <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> does not handle multibyte hexadecimal characters. <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> does not handle Unicode full-width hexadecimal or "compatibility zone" characters. Otherwise, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> behave identically.  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|\<stdio.h>|  
|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|\<stdio.h> or \<wchar.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **String    = 15**  
**Character = 1**  
**Integer:  = 15**  
**Real:     = 15.000000**   
## .NET Framework Equivalent  
 See <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> methods, such as [System::Double::Parse](https://msdn.microsoft.com/en-us/library/system.double.parse.aspx).  
  
## See Also  
 [Stream I/O](../vs140/stream-i-o.md)   
 [scanf, wscanf](../vs140/scanf--_scanf_l--wscanf--_wscanf_l.md)   
 [sscanf, swscanf](../vs140/sscanf--_sscanf_l--swscanf--_swscanf_l.md)   
 [sprintf, swprintf](../vs140/sprintf--_sprintf_l--swprintf--_swprintf_l--__swprintf_l.md)   
 [vsscanf_s, vswscanf_s](../vs140/vsscanf_s--vswscanf_s.md)