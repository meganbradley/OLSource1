---
title: "_snscanf_s, _snscanf_s_l, _snwscanf_s, _snwscanf_s_l"
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
  - "_snwscanf_s_l"
  - "_snwscanf_s"
  - "_snscanf_s"
  - "_snscanf_s_l"
apilocation: 
  - "msvcr90.dll"
  - "msvcrt.dll"
  - "msvcr100.dll"
  - "msvcr110.dll"
  - "msvcr80.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_sntscanf_s"
  - "snscanf_s"
  - "_snwscanf_s_l"
  - "sntscanf_s_l"
  - "snwscanf_s_l"
  - "snwscanf_s"
  - "_snscanf_s"
  - "_snwscanf_s"
  - "snscanf_s_l"
  - "_sntscanf_s_l"
  - "_snscanf_s_l"
  - "sntscanf_s"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_snscanf_s_l function"
  - "snwscanf_s function"
  - "_snwscanf_s function"
  - "sntscanf_s_l function"
  - "sntscanf_s function"
  - "_snwscanf_s_l function"
  - "_snscanf_s function"
  - "snscanf_s_l function"
  - "strings [C++], reading data from"
  - "_sntscanf_s_l function"
  - "reading data, strings"
  - "snscanf_s function"
  - "strings [C++], reading"
  - "_sntscanf_s function"
  - "snwscanf_s_l function"
ms.assetid: 72356653-7362-461a-af73-597b9c0a8094
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _snscanf_s, _snscanf_s_l, _snwscanf_s, _snwscanf_s_l
Reads formatted data of a specified length from a string. These are versions of [_snscanf, _snscanf_l, _snwscanf, _snwscanf_l](../vs140/_snscanf--_snscanf_l--_snwscanf--_snwscanf_l.md) with security enhancements as described in [Security Enhancements in the CRT](../vs140/security-features-in-the-crt.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Input string to examine.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Number of characters to examine in <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 One or more format specifiers.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Variables that will be used to store the values extracted from the input string by the format specifiers in <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The locale to use.  
  
## Return Value  
 Both of these functions returns the number of fields successfully converted and assigned; the return value does not include fields that were read but not assigned. A return value of 0 indicates that no fields were assigned. The return value is <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> for an error or if the end of the string is reached before the first conversion. For more information, see [sscanf_s, swscanf_s](../vs140/sscanf_s--_sscanf_s_l--swscanf_s--_swscanf_s_l.md).  
  
 If <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> pointer, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, these functions return <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and set <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
 For information about these and other error codes, see [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
## Remarks  
 This function is like <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> except that it provides the ability to specify a fixed number of characters to examine from the input string. For more information, see [sscanf_s, swscanf_s](../vs140/sscanf_s--_sscanf_s_l--swscanf_s--_swscanf_s_l.md).  
  
 The buffer size parameter is required with the type field characters <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>. For more information, see [scanf Type Field Characters](../vs140/scanf-type-field-characters.md).  
  
> [!NOTE]
>  The size parameter is of type <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, not <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.  
  
 The versions of these functions with the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> suffix are identical except that they use the locale parameter passed in instead of the current thread locale.  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, _<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|\<stdio.h>|  
|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|\<stdio.h> or \<wchar.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **_snscanf_s converted 2 fields: 15 and 12.000000**  
**_snwscanf_s converted 2 fields: 15 and 12.000000**   
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [scanf Width Specification](../vs140/scanf-width-specification.md)