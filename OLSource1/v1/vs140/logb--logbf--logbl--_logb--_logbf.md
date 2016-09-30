---
title: "logb, logbf, logbl, _logb, _logbf"
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
  - "logb"
  - "_logb"
  - "_logbl"
  - "logbf"
  - "logbl"
apilocation: 
  - "msvcr90.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr110.dll"
apitype: "DLLExport"
f1_keywords: 
  - "logb"
  - "logbl"
  - "_logb"
  - "_logbf"
  - "logbf"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_logbf function"
  - "mantissas, floating-point variables"
  - "logbf function"
  - "_logb function"
  - "exponent, floating-point numbers"
  - "logbl function"
  - "logb function"
  - "floating-point functions"
  - "floating-point functions, mantissa and exponent"
  - "exponents and mantissas"
ms.assetid: 780c4daa-6fe6-4fbc-9412-4c1ba1a1766f
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# logb, logbf, logbl, _logb, _logbf
Extracts the exponent value of a floating-point argument.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 x  
 A floating-point value.  
  
## Return Value  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> returns the unbiased exponent value of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> as a signed integer represented as a floating-point value.  
  
## Remarks  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> functions extract the exponential value of the floating-point argument <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, as though <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> were represented with infinite range. If the argument <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is denormalized, it is treated as if it were normalized.  
  
 Because C++ allows overloading, you can call overloads of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> that take and return <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> values. In a C program, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> always takes and returns a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
|Input|SEH exception|Matherr exception|  
|-----------|-------------------|-----------------------|  
|± QNAN,IND|None|_DOMAIN|  
|± 0|ZERODIVIDE|_SING|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|\<float.h>|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|\<math.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Libraries  
 All versions of the [C run-time libraries](../vs140/crt-library-features.md).  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [frexp](../vs140/frexp.md)