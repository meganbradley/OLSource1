---
title: "_cabs"
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
  - "_cabs"
apilocation: 
  - "msvcr120.dll"
  - "msvcr80.dll"
  - "msvcr100.dll"
  - "msvcrt.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "cabsl"
  - "_cabs"
  - "_cabsl"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "cabs function"
  - "cabsl function"
  - "absolute values"
  - "_cabsl function"
  - "_cabs function"
  - "calculating absolute values"
ms.assetid: fea292ee-1a39-4a0a-b416-4a189346ff26
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _cabs
Calculates the absolute value of a complex number.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Complex number.  
  
## Return Value  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> returns the absolute value of its argument if successful. On overflow, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and sets <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. You can change error handling with [_matherr](../vs140/_matherr.md).  
  
## Remarks  
 The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> function calculates the absolute value of a complex number, which must be a structure of type [_complex](../vs140/standard-types.md). The structure <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is composed of a real component <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and an imaginary component <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. A call to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> produces a value equivalent to that of the expression <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>( <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>*<CodeContentPlaceHolder>15\</CodeContentPlaceHolder> ).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|\<math.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The absolute value of 3.000000 + 4.000000i is 5.000000**   
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [abs, labs, llabs, _abs64](../vs140/abs--labs--llabs--_abs64.md)   
 [fabs, fabsf, fabsl](../vs140/fabs--fabsf--fabsl.md)   
 [labs, llabs](../vs140/labs--llabs.md)