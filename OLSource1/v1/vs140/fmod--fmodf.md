---
title: "fmod, fmodf"
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
  - "fmod"
  - "fmodf"
apilocation: 
  - "msvcr100.dll"
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr110.dll"
  - "msvcr120.dll"
  - "msvcr90.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "fmod"
  - "_fmodl"
  - "fmodf"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "calculating floating-point remainders"
  - "fmodf function"
  - "fmod function"
  - "floating-point numbers, calculating remainders"
ms.assetid: 6962d369-d11f-40b1-a6d7-6f67239f8a23
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# fmod, fmodf
Calculates the floating-point remainder.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Floating-point values.  
  
## Return Value  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> returns the floating-point remainder of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> / <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. If the value of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is 0.0, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> returns a quiet NaN. For information about representation of a quiet NaN by the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> family, see [printf](../vs140/printf--_printf_l--wprintf--_wprintf_l.md).  
  
## Remarks  
 The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> function calculates the floating-point remainder <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> / <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> such that <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> = <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> + <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is an integer, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> has the same sign as <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, and the absolute value of <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is less than the absolute value of <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.  
  
 C++ allows overloading, so you can call overloads of <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>. In a C program, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> always takes two doubles and returns a double.  
  
## Requirements  
  
|Function|Required header|  
|--------------|---------------------|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|\<math.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The remainder of -10.00 / 3.00 is -1.000000**   
## .NET Framework Equivalent  
 [System::Math::IEEERemainder](https://msdn.microsoft.com/en-us/library/system.math.ieeeremainder.aspx)  
  
## See Also  
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [ceil, ceilf, ceill](../vs140/ceil--ceilf--ceill.md)   
 [fabs, fabsf, fabsl](../vs140/fabs--fabsf--fabsl.md)   
 [floor, floorf, floorl](../vs140/floor--floorf--floorl.md)   
 [_CIfmod](../vs140/_cifmod.md)