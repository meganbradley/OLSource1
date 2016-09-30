---
title: "remainder, remainderf, remainderl"
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
  - "remainderl"
  - "remainder"
  - "remainderf"
apilocation: 
  - "msvcrt.dll"
  - "msvcr110.dll"
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
  - "msvcr90.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "remainderf"
  - "remainder"
  - "remainderl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "remainderf"
  - "remainderl"
  - "remainder"
ms.assetid: 5f721fb3-8b78-4597-9bc0-ca9bcd1f1d0e
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# remainder, remainderf, remainderl
Computes the remainder of the quotient of two floating-point values, rounded to the nearest integral value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The numerator.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The denominator.  
  
## Return Value  
 The floating-point remainder of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> / <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. If the value of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is 0.0, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> returns a quiet NaN. For information about the representation of a quiet NaN by the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> family, see [printf, _printf_l, wprintf, _wprintf_l](../vs140/printf--_printf_l--wprintf--_wprintf_l.md).  
  
## Remarks  
 The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> function calculates the floating-point remainder <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> / <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> such that <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> = <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> * <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> + <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is the integer nearest in value to <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> / <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is even whenever &#124; <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> - <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> / <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> &#124; = 1/2. When <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> = 0, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> has the same sign as <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.  
  
 Because C++ allows overloading, you can call overloads of <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> that take and return <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> values. In a C program, <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> always takes two doubles and returns a double.  
  
## Requirements  
  
|Function|Required header|  
|--------------|---------------------|  
|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|\<math.h>|  
  
 For compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The remainder of -10.00 / 3.00 is -1.000000**   
## .NET Framework Equivalent  
 [System::Math::IEEERemainder](https://msdn.microsoft.com/en-us/library/system.math.ieeeremainder.aspx)  
  
## See Also  
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [ldiv, lldiv](../vs140/ldiv--lldiv.md)   
 [imaxdiv](../vs140/imaxdiv.md)   
 [fmod](../vs140/fmod--fmodf.md)   
 [remquo](../vs140/remquo--remquof--remquol.md)