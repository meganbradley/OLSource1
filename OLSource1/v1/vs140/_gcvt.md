---
title: "_gcvt"
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
  - "_gcvt"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcr100.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr120.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_gcvt"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_gcvt function"
  - "_CVTBUFSIZE"
  - "gcvt function"
  - "floating-point functions, converting number to string"
  - "numbers, converting to strings"
  - "conversions, floating point to strings"
  - "strings [C++], converting from floating point"
  - "CVTBUFSIZE"
ms.assetid: 5761411e-c06b-409a-912f-810fe7f4bcb5
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _gcvt
Converts a floating-point value to a string, which it stores in a buffer. A more secure version of this function is available; see [_gcvt_s](../vs140/_gcvt_s.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Value to be converted.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Number of significant digits stored.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Storage location for the result.  
  
## Return Value  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> returns a pointer to the string of digits.  
  
## Remarks  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> function converts a floating-point <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to a character string (which includes a decimal point and a possible sign byte) and stores the string in <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> should be large enough to accommodate the converted value plus a terminating null character, which is appended automatically. If a buffer size of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> + 1 is used, the function overwrites the end of the buffer. This is because the converted string includes a decimal point and can contain sign and exponent information. There is no provision for overflow. <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> attempts to produce <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> digits in decimal format. If it cannot, it produces <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> digits in exponential format. Trailing zeros might be suppressed in the conversion.  
  
 A <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> of length <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is sufficient for any floating point value.  
  
 This function validates its parameters. If <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, this function sets <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> and returns <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|\<stdlib.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The following numbers were converted by _gcvt(value,12,buffer):**  
**buffer: '-1234567890.12' (14 chars)**  
**buffer: '-12345678901.2' (14 chars)**  
**buffer: '-123456789012' (13 chars)**  
**buffer: '-1.23456789012e+012' (19 chars)**  
**buffer: '-12.3456789012' (14 chars)**  
**buffer: '-1.23456789012' (14 chars)**  
**buffer: '-0.123456789012' (15 chars)**  
**buffer: '-1.23456789012e-002' (19 chars)**   
## .NET Framework Equivalent  
 [System::Convert::ToString](https://msdn.microsoft.com/en-us/library/system.convert.tostring.aspx)  
  
## See Also  
 [Data Conversion](../vs140/data-conversion.md)   
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [atof, _atof_l, _wtof, _wtof_l](../vs140/atof--_atof_l--_wtof--_wtof_l.md)   
 [_ecvt](../vs140/_ecvt.md)   
 [_fcvt](../vs140/_fcvt.md)