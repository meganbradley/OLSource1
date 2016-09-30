---
title: "atoll, _atoll_l, _wtoll, _wtoll_l"
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
  - "_wtoll"
  - "_atoll_l"
  - "_wtoll_l"
  - "atoll"
apilocation: 
  - "msvcr120.dll"
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
  - "msvcr80.dll"
  - "msvcrt.dll"
  - "msvcr110.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_tstoll_l"
  - "_wtoll"
  - "_atoll_l"
  - "_ttoll"
  - "_tstoll"
  - "_wtoll_l"
  - "atoll"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "atoll function"
  - "_wtoll_l function"
  - "_wtoll function"
  - "_atoll_l function"
ms.assetid: 5e85fcac-b351-4882-bff2-6e7c469b7fa8
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# atoll, _atoll_l, _wtoll, _wtoll_l
Converts a string to a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> integer.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 String to be converted.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Locale to use.  
  
## Return Value  
 Each function returns the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> value that's produced by interpreting the input characters as a number. The return value for <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is 0 if the input cannot be converted to a value of that type.  
  
 For overflow with large positive integral values, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, and for overflow with large negative integral values, it returns <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
 In all out-of-range cases, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. If the parameter that's passed in is <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, these functions set <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and return 0.  
  
## Remarks  
 These functions convert a character string to a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> integer value.  
  
 The input string is a sequence of characters that can be interpreted as a numerical value of the specified type. The function stops reading the input string at the first character that it cannot recognize as part of a number. This character might be the null character ('\0' or L'\0') that terminates the string.  
  
 The <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> argument to <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> has the following form:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> consists of space or tab characters, which are ignored; <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is either plus (+) or minus (–); and <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> are one or more digits.  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is identical to <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> except that it takes a wide character string as a parameter.  
  
 The versions of these functions that have the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> suffix are identical to the versions that don't have it, except that they use the locale parameter that's passed in instead of the current locale. For more information, see [Locale](../vs140/locale.md).  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routines|Required header|  
|--------------|---------------------|  
|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|\<stdlib.h>|  
|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|\<stdlib.h> or \<wchar.h>|  
  
## Example  
 This program shows how to use the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> functions to convert numbers stored as strings to numeric values.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **Function: atoll("  -27182818284 ") = -27182818284**  
**Function: atoll("314127.64") = 314127**  
**Function: atoll("3336402735171707160320") = 9223372036854775807**  
**Overflow condition occurred.**   
## .NET Framework Equivalent  
  
-   [System::Convert::ToInt64](https://msdn.microsoft.com/en-us/library/system.convert.toint64.aspx)  
  
-   [System::Convert::ToUInt64](https://msdn.microsoft.com/en-us/library/system.convert.touint64.aspx)  
  
## See Also  
 [Data Conversion](../vs140/data-conversion.md)   
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [Locale](../vs140/locale.md)   
 [_ecvt](../vs140/_ecvt.md)   
 [_fcvt](../vs140/_fcvt.md)   
 [_gcvt](../vs140/_gcvt.md)   
 [setlocale, _wsetlocale](../vs140/setlocale--_wsetlocale.md)   
 [_atodbl, _atoldbl, _atoflt](../vs140/_atodbl--_atodbl_l--_atoldbl--_atoldbl_l--_atoflt--_atoflt_l.md)