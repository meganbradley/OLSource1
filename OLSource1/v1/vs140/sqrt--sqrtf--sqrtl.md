---
title: "sqrt, sqrtf, sqrtl"
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
  - "sqrtl"
  - "sqrtf"
  - "sqrt"
apilocation: 
  - "msvcr110.dll"
  - "msvcr80.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr100.dll"
  - "msvcrt.dll"
  - "msvcr120.dll"
  - "msvcr90.dll"
apitype: "DLLExport"
f1_keywords: 
  - "sqrt"
  - "sqrtf"
  - "_sqrtl"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "sqrtf function"
  - "sqrt function"
  - "sqrtl function"
  - "_sqrtl function"
  - "calculating square roots"
  - "square roots, calculating"
ms.assetid: 2ba9467b-f172-41dc-8f10-b86f68fa813c
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# sqrt, sqrtf, sqrtl
Calculates the square root.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Non-negative floating-point value  
  
## Remarks  
 Because C++ allows overloading, you can call overloads of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> that take <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> types. In a C program, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> always takes and returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Return Value  
 The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> functions return the square-root of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. By default, if <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is negative, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> returns an indefinite NaN.  
  
|Input|SEH Exception|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder> Exception|  
|-----------|-------------------|--------------------------|  
|± QNAN,IND|none|_DOMAIN|  
|- ∞|none|_DOMAIN|  
|x<0|none|_DOMAIN|  
  
## Requirements  
  
|Function|C header|C++ header|  
|--------------|--------------|------------------|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|\<math.h>|\<cmath>|  
  
 For compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The square root of 45.35 is 6.73**   
## .NET Framework Equivalent  
 [System::Math::Sqrt](https://msdn.microsoft.com/en-us/library/system.math.sqrt.aspx)  
  
## See Also  
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [exp, expf](../vs140/exp--expf.md)   
 [log, logf, log10, log10f](../vs140/log--logf--log10--log10f.md)   
 [pow, powf, powl](../vs140/pow--powf--powl.md)   
 [_CIsqrt](../vs140/_cisqrt.md)