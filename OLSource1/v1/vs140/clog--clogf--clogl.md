---
title: "clog, clogf, clogl"
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
  - "clog"
  - "clogf"
  - "clogl"
apilocation: 
  - "msvcr120.dll"
  - "api-ms-win-crt-math-l1-1-0.dll"
apitype: "DLLExport"
f1_keywords: 
  - "clog"
  - "clogf"
  - "clogl"
  - "complex/clog"
  - "complex/clogf"
  - "complex/clogl"
dev_langs: 
  - "C"
  - "C++"
helpviewer_keywords: 
  - "clog function"
  - "clogf function"
  - "clogl function"
ms.assetid: 870b9b0b-6618-46f3-bfcf-da595cbd5e18
caps.latest.revision: 13
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# clog, clogf, clogl
Retrieves the natural logarithm of a complex number, with a branch cut along the negative real axis.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The base of the logarithm.  
  
## Return Value  
 The natural logarithm of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. The result is unbounded along the real axis and in the interval [−iπ, +iπ] along the imaginary axis.  
  
 The possible return values are:  
  
|z parameter|Return value|  
|-----------------|------------------|  
|Positive|The base 10 logarithm of z|  
|Zero|- ∞|  
|Negative|NaN|  
|NaN|NaN|  
|+ ∞|+ ∞|  
  
## Remarks  
 Because C++ allows overloading, you can call overloads of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> that take and return <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> values. In a C program, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> always takes and returns a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> value.  
  
## Requirements  
  
|Routine|C header|C++ header|  
|-------------|--------------|------------------|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>,               <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|\<complex.h>|\<ccomplex>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## See Also  
 [CRT Alphabetical Function Reference](../vs140/crt-alphabetical-function-reference.md)   
 [cexp, cexpf, cexpl](../vs140/cexp--cexpf--cexpl.md)   
 [cpow, cpowf, cpowl](../vs140/cpow--cpowf--cpowl.md)   
 [clog10, clog10f, clog10l](../vs140/clog10--clog10f--clog10l.md)