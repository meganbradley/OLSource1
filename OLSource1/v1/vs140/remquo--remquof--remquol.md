---
title: "remquo, remquof, remquol"
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
  - "remquof"
  - "remquo"
  - "remquol"
apilocation: 
  - "msvcr120.dll"
  - "msvcr100.dll"
  - "msvcr80.dll"
  - "msvcr110.dll"
  - "msvcr90.dll"
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "remquof"
  - "remquol"
  - "remquo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "remquol function"
  - "remquof function"
  - "remquo function"
ms.assetid: a1d3cb8b-8027-4cd3-8deb-04eb17f299fc
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# remquo, remquof, remquol
Computes the remainder of two integer values, and stores an integer value with the sign and approximate magnitude of the quotient in a location that's specified in a parameter.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The numerator.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The denominator.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A pointer to an integer to store a value that has the sign and approximate magnitude of the quotient.  
  
## Return Value  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> returns the floating-point remainder of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> / <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. If the value of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is 0.0, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> returns a quiet NaN. For information about the representation of a quiet NaN by the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> family, see [printf, _printf_l, wprintf, _wprintf_l](../vs140/printf--_printf_l--wprintf--_wprintf_l.md).  
  
## Remarks  
 The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> function calculates the floating-point remainder <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> / <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> such that <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> = <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> + <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is an integer, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> has the same sign as <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, and the absolute value of <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is less than the absolute value of <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
 C++ allows overloading, so you can call overloads of <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> that take and return <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> values. In a C program, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> always takes two doubles and returns a double.  
  
## Requirements  
  
|Function|Required header|  
|--------------|---------------------|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|\<math.h>|  
  
 For compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The remainder of -10.00 / 3.00 is -1.000000**  
**Approximate signed quotient is -3**   
## .NET Framework Equivalent  
 [System::Math::IEEERemainder](https://msdn.microsoft.com/en-us/library/system.math.ieeeremainder.aspx)  
  
## See Also  
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [ldiv, lldiv](../vs140/ldiv--lldiv.md)   
 [imaxdiv](../vs140/imaxdiv.md)   
 [fmod](../vs140/fmod--fmodf.md)   
 [remainder](../vs140/remainder--remainderf--remainderl.md)