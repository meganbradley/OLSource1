---
title: "atof, _atof_l, _wtof, _wtof_l"
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
  - "_wtof_l"
  - "atof"
  - "_atof_l"
  - "_wtof"
apilocation: 
  - "msvcr90.dll"
  - "msvcr100.dll"
  - "msvcr110.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_wtof_l"
  - "atof"
  - "_atof_l"
  - "_tstof"
  - "_ttof"
  - "_wtof"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "tstof function"
  - "atof_l function"
  - "_atof_l function"
  - "atof function"
  - "_tstof function"
  - "_ttof function"
  - "wtof function"
  - "_wtof_l function"
  - "ttof function"
  - "wtof_l function"
  - "_wtof function"
  - "string conversion, to floating point values"
ms.assetid: eb513241-c9a9-4f5c-b7e7-a49b14abfb75
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# atof, _atof_l, _wtof, _wtof_l
Convert a string to double.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 String to be converted.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Locale to use.  
  
## Return Value  
 Each function returns the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> value produced by interpreting the input characters as a number. The return value is 0.0 if the input cannot be converted to a value of that type.  
  
 In all out-of-range cases, errno is set to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. If the parameter passed in is <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, these functions set <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and return 0.  
  
## Remarks  
 These functions convert a character string to a double-precision, floating-point value.  
  
 The input string is a sequence of characters that can be interpreted as a numerical value of the specified type. The function stops reading the input string at the first character that it cannot recognize as part of a number. This character may be the null character ('\0' or L'\0') terminating the string.  
  
 The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> argument to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> has the following form:  
  
 [<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>] [<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>] [<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>] [<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>] [ {<CodeContentPlaceHolder>16\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> }[<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>]<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>]  
  
 A <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> consists of space or tab characters, which are ignored; <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is either plus (+) or minus (–); and <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> are one or more decimal digits. If no digits appear before the decimal point, at least one must appear after the decimal point. The decimal digits may be followed by an exponent, which consists of an introductory letter (<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>) and an optionally signed decimal integer.  
  
 The versions of these functions with the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> suffix are identical except that they use the locale parameter passed in instead of the current locale.  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine(s)|Required header|  
|------------------|---------------------|  
|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|\<math.h> and \<stdlib.h>|  
|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|\<math.h> and \<stdlib.h>|  
|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|\<stdlib.h> or \<wchar.h>|  
  
## Example  
 This program shows how numbers stored as strings can be converted to numeric values using the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> function.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Function: atof( "  3336402735171707160320 " ) = 3.336403e+021**  
**Function: atof( "3.1412764583d210" ) = 3.141276e+210**  
**Function: atof( "  -2309.12E-15" ) = -2.309120e-012**   
## .NET Framework Equivalent  
  
-   [System::Convert::ToSingle](https://msdn.microsoft.com/en-us/library/system.convert.tosingle.aspx)  
  
-   [System::Convert::ToDouble](https://msdn.microsoft.com/en-us/library/system.convert.todouble.aspx)  
  
## See Also  
 [Data Conversion](../vs140/data-conversion.md)   
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [Locale](../vs140/locale.md)   
 [_ecvt](../vs140/_ecvt.md)   
 [_fcvt](../vs140/_fcvt.md)   
 [_gcvt](../vs140/_gcvt.md)   
 [setlocale, _wsetlocale](../vs140/setlocale--_wsetlocale.md)   
 [_atodbl, _atoldbl, _atoflt](../vs140/_atodbl--_atodbl_l--_atoldbl--_atoldbl_l--_atoflt--_atoflt_l.md)