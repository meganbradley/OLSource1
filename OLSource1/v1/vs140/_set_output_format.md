---
title: "_set_output_format"
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
  - "_set_output_format"
apilocation: 
  - "msvcrt.dll"
  - "msvcr120.dll"
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "set_output_format"
  - "_set_output_format"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_TWO_DIGIT_EXPONENT constant"
  - "output formatting"
  - "TWO_DIGIT_EXPONENT constant"
  - "_set_output_format function"
  - "set_output_format function"
ms.assetid: 1cb48df8-44b4-4400-bd27-287831d6b3ff
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _set_output_format
Customizes output formats used by formatted I/O functions.  
  
> [!IMPORTANT]
>  This function is obsolete. Beginning in Visual Studio 2015, it is not available in the CRT.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An value representing the format to use.  
  
## Return value  
 The previous output format.  
  
## Remarks  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is used to configure the output of formatted I/O functions such as [printf_s](../vs140/printf_s--_printf_s_l--wprintf_s--_wprintf_s_l.md). At present, the only formatting convention that can be changed by this function is the number of digits displayed in exponents in the output of floating point numbers.  
  
 By default, the output of floating point numbers by functions such as <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, and related functions in the Visual C++ Standard C library prints three digits for the exponent, even if three digits are not required to represent the value of the exponent. Zeroes are used to pad the value to three digits. <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> allows you to change this behavior so that only two digits are printed in the exponent unless a third digit is required by the size of the exponent.  
  
 To enable two-digit exponents, call this function with the parameter <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, as shown in the example. To disable two digit exponents, call this function with an argument of 0.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|\<stdio.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **1.2110e-005 2.3056e-112**  
**1.2110E-005 2.3056E-112**  
 **1.211e-005  2.306e-112**  
 **1.211E-005  2.306E-112**  
 **1.2110e-05 2.3056e-112**  
 **1.2110E-05 2.3056E-112**  
 **1.211e-05  2.306e-112**  
 **1.211E-05  2.306E-112**  
**1.2110e-005 2.3056e-112**  
**1.2110E-005 2.3056E-112**  
 **1.211e-005  2.306e-112**  
 **1.211E-005  2.306E-112**   
## See Also  
 [printf_s, _printf_s_l, wprintf_s, _wprintf_s_l](../vs140/printf_s--_printf_s_l--wprintf_s--_wprintf_s_l.md)   
 [printf Type Field Characters](../vs140/printf-type-field-characters.md)   
 [_get_output_format](../vs140/_get_output_format.md)