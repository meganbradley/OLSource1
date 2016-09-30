---
title: "_snscanf, _snscanf_l, _snwscanf, _snwscanf_l"
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
  - "_snwscanf"
  - "_snscanf_l"
  - "_snscanf"
  - "_snwscanf_l"
apilocation: 
  - "msvcr90.dll"
  - "msvcr120.dll"
  - "msvcr100.dll"
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_snscanf"
  - "_snscanf_l"
  - "_snwscanf"
  - "snscanf_l"
  - "snscanf"
  - "_sntscanf_l"
  - "_sntscanf"
  - "_snwscanf_l"
  - "sntscanf_l"
  - "sntscanf"
  - "snwscanf"
  - "snwscanf_l"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "snscanf_l function"
  - "snwscanf function"
  - "_sntscanf_l function"
  - "sntscanf function"
  - "_snwscanf_l function"
  - "_sntscanf function"
  - "_snscanf_l function"
  - "sntscanf_l function"
  - "strings [C++], reading data from"
  - "snscanf function"
  - "snwscanf_l function"
  - "_snwscanf function"
  - "reading data, strings"
  - "strings [C++], reading"
  - "_snscanf function"
ms.assetid: da1ac890-f905-4cd7-954b-3c90957b5551
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _snscanf, _snscanf_l, _snwscanf, _snwscanf_l
Reads formatted data of a specified length from a string. More secure versions of these functions are available; see [_snscanf_s, _snscanf_s_l, _snwscanf_s, _snwscanf_s_l](../vs140/_snscanf_s--_snscanf_s_l--_snwscanf_s--_snwscanf_s_l.md).  
  
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
 Both of these functions returns the number of fields successfully converted and assigned; the return value does not include fields that were read but not assigned. A return value of 0 indicates that no fields were assigned. The return value is <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> for an error or if the end of the string is reached before the first conversion. For more information, see [sscanf](../vs140/sscanf--_sscanf_l--swscanf--_swscanf_l.md).  
  
 If <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> pointer, or if <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is less than or equal to zero, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, these functions return <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and set <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
 For information about these and other error codes, see [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
## Remarks  
 This function is like <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> except that it provides the ability to specify a fixed number of characters to examine from the input string. For more information, see [sscanf](../vs140/sscanf--_sscanf_l--swscanf--_swscanf_l.md).  
  
 The versions of these functions with the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> suffix are identical except that they use the locale parameter passed in instead of the current thread locale.  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|\<stdio.h>|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|\<stdio.h> or \<wchar.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **_snscanf converted 2 fields: 15 and 12.000000**  
**_snwscanf converted 2 fields: 15 and 12.000000**   
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [scanf Width Specification](../vs140/scanf-width-specification.md)