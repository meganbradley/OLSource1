---
title: "_ltoa_s, _ltow_s"
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
  - "_ltoa_s"
  - "_ltow_s"
apilocation: 
  - "msvcr90.dll"
  - "msvcr80.dll"
  - "msvcr120.dll"
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr110.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_ltow_s"
  - "_ltoa_s"
  - "ltoa_s"
  - "ltow_s"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "converting integers"
  - "_ltoa_s function"
  - "ltow_s function"
  - "long integer conversion to string"
  - "converting numbers, to strings"
  - "ltoa_s function"
  - "_ltow_s function"
ms.assetid: d7dc61ea-1ccd-412d-b262-555a58647386
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _ltoa_s, _ltow_s
Converts a long integer to a string. These are versions of [_ltoa, _ltow](../vs140/_ltoa--_ltow.md) with security enhancements as described in [Security Enhancements in the CRT](../vs140/security-features-in-the-crt.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Number to be converted.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Buffer for the resulting string.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Size of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> in bytes for <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> or words for <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Base of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Return Value  
 Zero if the function was successful or an error code.  
  
## Remarks  
 The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> function converts the digits of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to a null-terminated character string and stores the result (up to 33 bytes) in <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> argument specifies the base of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, which must be in the range 2 – 36. If <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> equals 10 and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is negative, the first character of the stored string is the minus sign (–). <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is a wide character version of <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>; the second argument of <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is a wide character strings.  
  
 If <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is a <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> pointer or <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is less than or equal to zero, these functions invoke an invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, these functions return -1 and set <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> or if the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> out of range of a long integer, these functions return a -1 and set the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.  
  
 In C++, using these functions is simplified by template overloads; the overloads can infer buffer length automatically (eliminating the need to specify a size argument) and they can automatically replace older, non-secure functions with their newer, secure counterparts. For more information, see [Secure Template Overloads](../vs140/secure-template-overloads.md).  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|\<stdlib.h>|  
|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|\<stdlib.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## .NET Framework Equivalent  
 [System::Convert::ToString](https://msdn.microsoft.com/en-us/library/system.convert.tostring.aspx)  
  
## See Also  
 [Data Conversion](../vs140/data-conversion.md)   
 [_itoa, _itow](../vs140/_itoa--_i64toa--_ui64toa--_itow--_i64tow--_ui64tow.md)   
 [_ultoa, _ultow](../vs140/_ultoa--_ultow.md)   
 [_ultoa_s, _ultow_s](../vs140/_ultoa_s--_ultow_s.md)