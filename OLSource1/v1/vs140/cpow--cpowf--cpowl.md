---
title: "cpow, cpowf, cpowl"
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
  - "cpow"
  - "cpowf"
  - "cpowl"
apilocation: 
  - "msvcr120.dll"
  - "api-ms-win-crt-math-l1-1-0.dll"
apitype: "DLLExport"
f1_keywords: 
  - "cpow"
  - "cpowf"
  - "cpowl"
  - "complex/cpow"
  - "complex/cpowf"
  - "complex/copwl"
dev_langs: 
  - "C"
  - "C++"
helpviewer_keywords: 
  - "cpow function"
  - "cpowf function"
  - "complex/cpowl function"
ms.assetid: 83fe2187-22b7-4295-ab16-4d77abdbb80b
caps.latest.revision: 17
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# cpow, cpowf, cpowl
Retrieves the value of a number raised to the specified power, where the base and exponent are complex numbers. This function has a branch cut for the exponent along the negative real axis.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The base.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The exponent.  
  
## Return Value  
 The value of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> raised to the power of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> with a branch cut for <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> along the negative real axis.  
  
## Remarks  
 Because C++ allows overloading, you can call overloads of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> that take and return <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> values. In a C program, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> always takes and returns a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> value.  
  
## Requirements  
  
|Routine|C header|C++ header|  
|-------------|--------------|------------------|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>,               <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|\<complex.h>|\<ccomplex>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## See Also  
 [CRT Alphabetical Function Reference](../vs140/crt-alphabetical-function-reference.md)   
 [cexp, cexpf, cexpl](../vs140/cexp--cexpf--cexpl.md)   
 [clog10, clog10f, clog10l](../vs140/clog10--clog10f--clog10l.md)   
 [clog, clogf, clogl](../vs140/clog--clogf--clogl.md)