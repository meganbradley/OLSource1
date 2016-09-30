---
title: "frexp"
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
  - "frexp"
apilocation: 
  - "msvcr120.dll"
  - "msvcr100.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
apitype: "DLLExport"
f1_keywords: 
  - "frexp"
  - "_frexpl"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_frexpl function"
  - "mantissas, floating-point variables"
  - "frexpl function"
  - "exponent, floating-point numbers"
  - "frexp function"
  - "floating-point functions, mantissa and exponent"
ms.assetid: 9b020f2e-3967-45ec-a6a8-d467a071aa55
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# frexp
Gets the mantissa and exponent of a floating-point number.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Floating-point value.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Pointer to stored integer exponent.  
  
## Return Value  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> returns the mantissa. If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is 0, the function returns 0 for both the mantissa and the exponent. If <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, the invalid parameter handler is invoked as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, this function sets <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and returns 0.  
  
## Remarks  
 The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> function breaks down the floating-point value (<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>) into a mantissa (<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>) and an exponent (<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>), such that the absolute value of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is greater than or equal to 0.5 and less than 1.0, and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> = <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>*2<sup>n\</sup>. The integer exponent <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is stored at the location pointed to by <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
 C++ allows overloading, so you can call overloads of <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. In a C program, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> always takes a double and an integer and returns a double.  
  
## Requirements  
  
|Function|Required header|  
|--------------|---------------------|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|\<math.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **frexp( 16.400000, &n ) = 0.512500, n = 5**   
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [ldexp](../vs140/ldexp.md)   
 [modf, modff, modfl](../vs140/modf--modff--modfl.md)