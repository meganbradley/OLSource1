---
title: "_ultoa_s, _ultow_s"
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
  - "_ultow_s"
  - "_ultoa_s"
apilocation: 
  - "msvcr100.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
  - "msvcrt.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_ultow_s"
  - "ultoa_s"
  - "ultow_s"
  - "_ultoa_s"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_ultoa_s function"
  - "converting integers"
  - "integers, converting"
  - "_ultow_s function"
  - "ultoa_s function"
  - "converting numbers, to strings"
  - "ultow_s function"
ms.assetid: 606ce905-6752-46ac-a15a-bdc22920e1d4
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _ultoa_s, _ultow_s
Convert an unsigned long integer to a string. These are versions of [_ultoa, _ultow](../vs140/_ultoa--_ultow.md) with security enhancements as described in [Security Enhancements in the CRT](../vs140/security-features-in-the-crt.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Number to be converted.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 String result.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The size of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> in bytes for <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> or words for <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Base of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Return Value  
 Zero if the function was successful or an error code.  
  
## Remarks  
 The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> function converts the digits of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to a null-terminated character string and stores the result (up to 33 bytes) in <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> argument specifies the base of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, which must be in the range 2 – 36. <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is a wide character version of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>; the second argument of <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is a wide character strings.  
  
 If <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is a <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> pointer, or if <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is less than or equal to zero, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, these functions return -1 and set <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> or if the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> out of range of a long integer, these functions will return a -1 and set the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.  
  
 In C++, using these functions is simplified by template overloads; the overloads can infer buffer length automatically (eliminating the need to specify a size argument) and they can automatically replace older, non-secure functions with their newer, secure counterparts. For more information, see [Secure Template Overloads](../vs140/secure-template-overloads.md).  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|\<stdlib.h>|  
|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|\<stdlib.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## .NET Framework Equivalent  
 [System::Convert::ToString](https://msdn.microsoft.com/en-us/library/system.convert.tostring.aspx)  
  
## See Also  
 [Data Conversion](../vs140/data-conversion.md)   
 [_ultoa, _ultow](../vs140/_ultoa--_ultow.md)   
 [_ltoa, _ltow](../vs140/_ltoa--_ltow.md)   
 [_ltoa_s, _ltow_s](../vs140/_ltoa_s--_ltow_s.md)   
 [_ltoa_s, _ltow_s](../vs140/_ltoa_s--_ltow_s.md)