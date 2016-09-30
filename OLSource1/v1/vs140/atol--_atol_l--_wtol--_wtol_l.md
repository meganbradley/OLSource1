---
title: "atol, _atol_l, _wtol, _wtol_l"
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
  - "atol"
  - "_wtol_l"
  - "_wtol"
  - "_atol_l"
apilocation: 
  - "msvcr80.dll"
  - "msvcrt.dll"
  - "msvcr110.dll"
  - "msvcr90.dll"
  - "msvcr120.dll"
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_atol_l"
  - "_ttol_l"
  - "_tstol_l"
  - "_tstol"
  - "_wtol"
  - "_ttol"
  - "_wtol_l"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "tstol function"
  - "atol function"
  - "ttol function"
  - "_atol_l function"
  - "_tstol_l function"
  - "string conversion, to integers"
  - "_tstol function"
  - "_ttol function"
  - "_ttol_l function"
  - "atol_l function"
  - "wtol_l function"
  - "_wtol_l function"
  - "wtol function"
  - "_wtol function"
ms.assetid: cedfc21c-2d64-4e9c-bd04-bdf60b12db46
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# atol, _atol_l, _wtol, _wtol_l
Convert a string to a long integer.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 String to be converted.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Locale to use.  
  
## Return Value  
 Each function returns the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> value produced by interpreting the input characters as a number. The return value is 0L for <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if the input cannot be converted to a value of that type.  
  
 In the case of overflow with large positive integral values, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>; in the case of overflow with large negative integral values, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is returned. In all out-of-range cases, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. If the parameter passed in is <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, these functions set <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and return 0.  
  
## Remarks  
 These functions convert a character string to a long integer value (<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>).  
  
 The input string is a sequence of characters that can be interpreted as a numerical value of the specified type. The function stops reading the input string at the first character that it cannot recognize as part of a number. This character may be the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> character ('\0' or L'\0') terminating the string.  
  
 The <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> argument to <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> has the following form:  
  
 [<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>] [<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>] [<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>]]  
  
 A <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> consists of space or tab characters, which are ignored; <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is either plus (+) or minus (–); and <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> are one or more digits.  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is identical to <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> except that it takes a wide character string.  
  
 The versions of these functions with the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> suffix are identical except that they use the locale parameter passed in instead of the current locale. For more information, see [Locale](../vs140/locale.md).  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routines|Required header|  
|--------------|---------------------|  
|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|\<stdlib.h>|  
|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|\<stdlib.h> and \<wchar.h>|  
  
## Example  
 This program shows how numbers stored as strings can be converted to numeric values using the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> function.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Function: atol( "  -2309 " ) = -2309**  
**Function: atol( "314127.64" ) = 314127**  
**Function: atol( "3336402735171707160320" ) = 2147483647**  
**Overflow condition occurred.**   
## .NET Framework Equivalent  
  
-   [System::Convert::ToInt32](https://msdn.microsoft.com/en-us/library/system.convert.toint32.aspx)  
  
-   [System::Convert::ToUInt32](https://msdn.microsoft.com/en-us/library/system.convert.touint32.aspx)  
  
## See Also  
 [Data Conversion](../vs140/data-conversion.md)   
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [Locale](../vs140/locale.md)   
 [_ecvt](../vs140/_ecvt.md)   
 [_fcvt](../vs140/_fcvt.md)   
 [_gcvt](../vs140/_gcvt.md)   
 [setlocale, _wsetlocale](../vs140/setlocale--_wsetlocale.md)   
 [_atodbl, _atoldbl, _atoflt](../vs140/_atodbl--_atodbl_l--_atoldbl--_atoldbl_l--_atoflt--_atoflt_l.md)