---
title: "_itoa_s, _i64toa_s, _ui64toa_s, _itow_s, _i64tow_s, _ui64tow_s"
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
  - "_ui64tow_s"
  - "_itoa_s"
  - "_itow_s"
  - "_ui64toa_s"
  - "_i64tow_s"
  - "_i64toa_s"
apilocation: 
  - "msvcr80.dll"
  - "msvcrt.dll"
  - "msvcr110.dll"
  - "msvcr90.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "i64tot_s"
  - "itow_s"
  - "_ui64tow_s"
  - "_itow_s"
  - "ui64tot_s"
  - "_ui64toa_s"
  - "itoa_s"
  - "_i64tow_s"
  - "_i64tot_s"
  - "_itot_s"
  - "_i64toa_s"
  - "_itoa_s"
  - "ui64toa_s"
  - "i64toa_s"
  - "_ui64tot_s"
  - "i64tow_s"
  - "itot_s"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_ui64toa_s function"
  - "_itow_s function"
  - "_i64tow_s function"
  - "_itot_s function"
  - "converting integers"
  - "itow_s function"
  - "i64toa_s function"
  - "_ui64tow_s function"
  - "integers, converting"
  - "_i64tot_s function"
  - "itoa_s function"
  - "_itoa_s function"
  - "ui64toa_s function"
  - "i64tow_s function"
  - "converting numbers, to strings"
  - "_ui64tot_s function"
  - "_i64toa_s function"
ms.assetid: eb746581-bff3-48b5-a973-bfc0a4478ecf
caps.latest.revision: 32
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _itoa_s, _i64toa_s, _ui64toa_s, _itow_s, _i64tow_s, _ui64tow_s
Converts an integer to a string. These are versions of [_itoa, _i64toa, _ui64toa, _itow, _i64tow, _ui64tow](../vs140/_itoa--_i64toa--_ui64toa--_itow--_i64tow--_ui64tow.md) with security enhancements as described in [Security Enhancements in the CRT](../vs140/security-features-in-the-crt.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Number to be converted.  
  
 [out] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Filled with the result of the conversion.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Size of the buffer in single-byte characters or wide characters.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Base of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>; which must be in the range 2–36.  
  
## Return Value  
 Zero if successful; an error code on failure. If any of the following conditions applies, the function invokes an invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md).  
  
### Error Conditions  
  
|value|buffer|sizeInCharacters|radix|Return|  
|-----------|------------|----------------------|-----------|------------|  
|any|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|any|any|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|  
|any|any|<=0|any|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|  
|any|any|<= length of the result string required|any|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|  
|any|any|any|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder> < 2 or <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> > 36|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|  
  
 **Security Issues**  
  
 These functions can generate an access violation if <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> does not point to valid memory and is not <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, or if the length of the buffer is not long enough to hold the result string.  
  
## Remarks  
 Except for the parameters and return value, the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> functions have the same behavior as the corresponding less secure versions.  
  
 In C++, using these functions is simplified by template overloads; the overloads can infer buffer length automatically (eliminating the need to specify a size argument) and they can automatically replace older, non-secure functions with their newer, secure counterparts. For more information, see [Secure Template Overloads](../vs140/secure-template-overloads.md).  
  
 The debug versions of these functions first fill the buffer with 0xFD. To disable this behavior, use [_CrtSetDebugFillThreshold](../vs140/_crtsetdebugfillthreshold.md).  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|\<stdlib.h>|  
|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|\<stdlib.h>|  
|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|\<stdlib.h>|  
|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|\<stdlib.h> or \<wchar.h>|  
|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|\<stdlib.h> or \<wchar.h>|  
|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|\<stdlib.h> or \<wchar.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## .NET Framework Equivalent  
 [System::Convert::ToString](https://msdn.microsoft.com/en-us/library/system.convert.tostring.aspx)  
  
## See Also  
 [Data Conversion](../vs140/data-conversion.md)   
 [_ltoa, _ltow](../vs140/_ltoa--_ltow.md)   
 [_ultoa, _ultow](../vs140/_ultoa--_ultow.md)