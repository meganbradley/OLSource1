---
title: "atoi, _atoi_l, _wtoi, _wtoi_l"
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
  - "_wtoi"
  - "_wtoi_l"
  - "atoi"
  - "_atoi_l"
apilocation: 
  - "msvcr80.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
  - "msvcr120.dll"
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_tstoi"
  - "_wtoi"
  - "_ttoi"
  - "atoi"
  - "_atoi_l"
  - "_wtoi_l"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_atoi_l function"
  - "ttoi function"
  - "atoi_l function"
  - "string conversion, to integers"
  - "_wtoi function"
  - "wtoi_l function"
  - "tstoi function"
  - "_ttoi function"
  - "_tstoi function"
  - "_wtoi_l function"
  - "atoi function"
  - "wtoi function"
ms.assetid: ad7fda30-28ab-421f-aaad-ef0b8868663a
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# atoi, _atoi_l, _wtoi, _wtoi_l
Convert a string to integer.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 String to be converted.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Locale to use.  
  
## Return Value  
 Each function returns the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> value produced by interpreting the input characters as a number. The return value is 0 for <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, if the input cannot be converted to a value of that type.  
  
 In the case of overflow with large negative integral values, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is returned. <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> return <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> on these conditions. In all out-of-range cases, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. If the parameter passed in is <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, these functions set <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and return 0.  
  
## Remarks  
 These functions convert a character string to an integer value (<CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>). The input string is a sequence of characters that can be interpreted as a numerical value of the specified type. The function stops reading the input string at the first character that it cannot recognize as part of a number. This character may be the null character ('\0' or L'\0') terminating the string.  
  
 The <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> argument to <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>and <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> has the following form:  
  
 [<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>] [<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>] [<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>]]  
  
 A <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> consists of space or tab characters, which are ignored; <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> is either plus (+) or minus (–); and <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> are one or more digits.  
  
 The versions of these functions with the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> suffix are identical except that they use the locale parameter passed in instead of the current locale. For more information, see [Locale](../vs140/locale.md).  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routines|Required header|  
|--------------|---------------------|  
|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|\<stdlib.h>|  
|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|\<stdlib.h> or \<wchar.h>|  
  
## Example  
 This program shows how numbers stored as strings can be converted to numeric values using the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> functions.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Function: atoi( "  -2309 " ) = -2309**  
**Function: atoi( "31412764" ) = 31412764**  
**Function: atoi( "3336402735171707160320" ) = 2147483647**  
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