---
title: "_atoi64, _atoi64_l, _wtoi64, _wtoi64_l"
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
  - "_atoi64_l"
  - "_wtoi64"
  - "_atoi64"
  - "_wtoi64_l"
apilocation: 
  - "msvcr120.dll"
  - "msvcr110.dll"
  - "msvcr80.dll"
  - "msvcrt.dll"
  - "msvcr90.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_atoi64"
  - "_tstoi64"
  - "_ttoi64"
  - "wtoi64"
  - "_tstoi64_l"
  - "atoi64"
  - "_wtoi64_l"
  - "_wtoi64"
  - "wtoi64_l"
  - "_atoi64_l"
  - "atoi64_l"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "tstoi64 function"
  - "wtoi64 function"
  - "atoi64_l function"
  - "_ttoi64 function"
  - "string conversion, to integers"
  - "wtoi64_l function"
  - "atoi64 function"
  - "_tstoi64 function"
  - "_atoi64_l function"
  - "_wtoi64_l function"
  - "ttoi64 function"
  - "_wtoi64 function"
  - "_atoi64 function"
ms.assetid: 2c3e30fd-545d-4222-8364-0c5905df9526
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _atoi64, _atoi64_l, _wtoi64, _wtoi64_l
Converts a string to a 64-bit integer.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 String to be converted.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Locale to use.  
  
## Return Value  
 Each function returns the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> value produced by interpreting the input characters as a number. The return value is 0 for <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> if the input cannot be converted to a value of that type.  
  
 In the case of overflow with large positive integral values, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> in the case of overflow with large negative integral values.  
  
 In all out-of-range cases, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. If the parameter passed in is <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, these functions set <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and return 0.  
  
## Remarks  
 These functions convert a character string to a 64-bit integer value.  
  
 The input string is a sequence of characters that can be interpreted as a numerical value of the specified type. The function stops reading the input string at the first character that it cannot recognize as part of a number. This character might be the null character ('\0' or L'\0') terminating the string.  
  
 The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> argument to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> has the following form:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> consists of space or tab characters, which are ignored; <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is either plus (+) or minus (–); and <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> are one or more digits.  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is identical to <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> except that it takes a wide character string as a parameter.  
  
 The versions of these functions with the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> suffix are identical except that they use the locale parameter passed in instead of the current locale. For more information, see [Locale](../vs140/locale.md).  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routines|Required header|  
|--------------|---------------------|  
|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|\<stdlib.h>|  
|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|\<stdlib.h> or \<wchar.h>|  
  
## Example  
 This program shows how numbers stored as strings can be converted to numeric values using the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> functions.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **Function: _atoi64( "  -2309 " ) = -2309**  
**Function: _atoi64( "314127.64" ) = 314127**  
**Function: _atoi64( "3336402735171707160320" ) = -1**  
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