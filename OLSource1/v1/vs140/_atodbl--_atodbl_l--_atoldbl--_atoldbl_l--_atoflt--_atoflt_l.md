---
title: "_atodbl, _atodbl_l, _atoldbl, _atoldbl_l, _atoflt, _atoflt_l"
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
  - "_atoldbl"
  - "_atoldbl_l"
  - "_atodbl"
  - "_atoflt"
  - "_atoflt_l"
  - "_atodbl_l"
apilocation: 
  - "msvcr100.dll"
  - "msvcrt.dll"
  - "msvcr110.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_atoflt"
  - "_atoflt_l"
  - "atodbl_l"
  - "atoflt_l"
  - "_atoldbl"
  - "_atoldbl_l"
  - "atodbl"
  - "_atodbl_l"
  - "atoldbl"
  - "atoflt"
  - "atoldbl_l"
  - "_atodbl"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_atodbl function"
  - "_atoldbl_l function"
  - "atoflt function"
  - "atoflt_l function"
  - "atoldbl function"
  - "_atoldbl function"
  - "atodbl_l function"
  - "_atoflt_l function"
  - "atoldbl_l function"
  - "atodbl function"
  - "string conversion, to floating point values"
  - "_atoflt function"
  - "_atodbl_l function"
ms.assetid: 2d2530f4-4bd4-42e3-8083-f2d2fbc8432a
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _atodbl, _atodbl_l, _atoldbl, _atoldbl_l, _atoflt, _atoflt_l
Converts a string to a double (<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>), long double (<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>), or float (<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The double, long double, or float value that's produced by converting the string to a floating-point value. These values are wrapped in a structure.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The string to be parsed to convert into a floating-point value.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The locale to use.  
  
## Return Value  
 Returns 0 if successful. Possible error codes are <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, which are defined in the header file Math.h.  
  
## Remarks  
 These functions convert a string to a floating-point value. The difference between these functions and the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> family of functions is that these functions do not generate floating-point code and do not cause hardware exceptions. Instead, error conditions are reported as error codes.  
  
 If a string does not have a valid interpretation as a floating-point value, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is set to zero and the return value is zero.  
  
 The versions of these functions that have the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> suffix are identical the versions that don't have the suffix, except that they use the locale parameter that's passed in instead of the current thread locale.  
  
## Requirements  
  
|Routines|Required header|  
|--------------|---------------------|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|\<stdlib.h>|  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Double value: 3.141593**  
**Return value: 0**  
**Float value: 3.141593**  
**Return value: 0**  
**Float value: 0.000000**  
**Return value: 0**  
**Float value: 1.#INF00**  
**Return value: 3**   
## See Also  
 [Data Conversion](../vs140/data-conversion.md)   
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [Locale](../vs140/locale.md)   
 [atof, _atof_l, _wtof, _wtof_l](../vs140/atof--_atof_l--_wtof--_wtof_l.md)