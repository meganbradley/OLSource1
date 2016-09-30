---
title: "abs, labs, llabs, _abs64"
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
  - "abs"
  - "_abs64"
  - "labs"
  - "llabs"
apilocation: 
  - "msvcr90.dll"
  - "msvcr80.dll"
  - "msvcr110.dll"
  - "msvcrt.dll"
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr100.dll"
  - "msvcr120_clr0400.dll"
  - "api-ms-win-crt-math-l1-1-0.dll"
apitype: "DLLExport"
f1_keywords: 
  - "stdlib/_abs64"
  - "math/abs"
  - "_abs64"
  - "abs"
  - "labs"
  - "math/labs"
  - "llabs"
  - "math/llabs"
  - "cmath/abs"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "absolute values"
  - "abs function"
  - "abs64 function"
  - "_abs64 function"
  - "calculating absolute values"
ms.assetid: 60f789d1-4a1e-49f5-9e4e-0bdb277ea26a
caps.latest.revision: 31
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# abs, labs, llabs, _abs64
Calculates the absolute value of the argument.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Numeric value.  
  
## Return Value  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> functions return the absolute value of the parameter <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. There is no error return.  
  
## Remarks  
 Because C++ allows overloading, you can call overloads of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> that take and return <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> values. These overloads are defined in the \<cmath> header. In a C program, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> always takes and returns an int.  
  
 **Microsoft Specific**  
  
 Because the range of negative integers that can be represented by using any integral type is larger than the range of positive integers that can be represented by using that type, it's possible to supply an argument to these functions that can’t be converted. If the absolute value of the argument cannot be represented by the return type, the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> functions return the argument value unchanged. Specifically, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>. This means that the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> functions cannot be used to guarantee a positive value.  
  
 **End Microsoft Specific**  
  
## Requirements  
  
|Routine|Required C header|Required C++ header|  
|-------------|-----------------------|---------------------------|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|\<math.h> or \<stdlib.h>|\<cmath>, \<cstdlib>, \<stdlib.h> or \<math.h>|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|\<stdlib.h>|\<cstdlib> or \<stdlib.h>|  
  
 To use the overloaded versions of <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> in C++, you must include the \<cmath> header.  
  
## Example  
 This program computes and displays the absolute values of several numbers.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The absolute value of -4 is 4**  
**The absolute value of -41567 is 41567**  
**The absolute value of -9876543210 is 9876543210**  
**The absolute value of 0xffffffffffffffff is 0x0000000000000001**  
**Microsoft implementation-specific results:**  
 **abs(INT_MIN) returns -2147483648**  
 **labs(LONG_MIN) returns -2147483648**  
 **llabs(LLONG_MIN) returns -9223372036854775808**  
 **_abs64(_I64_MIN) returns 0x8000000000000000**   
## .NET Framework Equivalent  
 [System::Math::Abs](https://msdn.microsoft.com/en-us/library/system.math.abs.aspx)  
  
## See Also  
 [Data Conversion](../vs140/data-conversion.md)   
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [_cabs](../vs140/_cabs.md)   
 [fabs, fabsf, fabsl](../vs140/fabs--fabsf--fabsl.md)   
 [imaxabs](../vs140/imaxabs.md)