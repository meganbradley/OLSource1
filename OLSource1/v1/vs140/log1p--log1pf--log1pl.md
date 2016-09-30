---
title: "log1p, log1pf, log1pl"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "cpp"
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
apiname: 
  - "log1p"
  - "log1pf"
  - "log1pl"
apilocation: 
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
  - "api-ms-win-crt-math-l1-1-0.dll"
apitype: "DLLExport"
f1_keywords: 
  - "log1p"
  - "log1pf"
  - "log1pl"
  - "math/log1p"
  - "math/log1pf"
  - "math/log1pl"
helpviewer_keywords: 
  - "log1p function"
  - "log1pf function"
  - "log1pl function"
ms.assetid: a40d965d-b4f6-42f4-ba27-2395546f7c12
caps.latest.revision: 11
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# log1p, log1pf, log1pl
Computes the natural logarithm of 1 plus the specified value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The floating-point argument.  
  
## Return Value  
 If successful, returns the natural (base-e) log of (<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>+1).  
  
 Otherwise, may return one of the following values:  
  
|Input|Result|SEH exception|errno|  
|-----------|------------|-------------------|-----------|  
|+inf|+inf|||  
|Denormals|Same as input|UNDERFLOW||  
|±0|Same as input|||  
|-1|-inf|DIVBYZERO|ERANGE|  
|< -1|nan|INVALID|EDOM|  
|-inf|nan|INVALID|EDOM|  
|±SNaN|Same as input|INVALID||  
|±QNaN, indefinite|Same as input|||  
  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> value is set to ERANGE if <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> = -1. The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> value is set to EDOM if <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> < −1.  
  
## Remarks  
 The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> functions may be more accurate than using log(<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>+1) when x is near 0.  
  
 Because C++ allows overloading, you can call overloads of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> that take and return float and long double types. In a C program, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> always takes and returns a double.  
  
 If <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is a natural number, this function returns the logarithm of the factorial of (<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>-1).  
  
## Requirements  
  
|Function|C header|C++ header|  
|--------------|--------------|------------------|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>,                <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>,  <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|\<math.h>|\<cmath>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## See Also  
 [Alphabetical Function Reference](../vs140/crt-alphabetical-function-reference.md)   
 [log2, log2f, log2l](../vs140/log2--log2f--log2l.md)   
 [log, logf, log10, log10f](../vs140/log--logf--log10--log10f.md)