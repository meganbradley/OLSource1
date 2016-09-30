---
title: "carg, cargf, cargl"
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
  - "carg"
  - "cargf"
  - "cargl"
apilocation: 
  - "msvcr120.dll"
  - "api-ms-win-crt-math-l1-1-0.dll"
apitype: "DLLExport"
f1_keywords: 
  - "carg"
  - "cargf"
  - "cargl"
  - "complex/carg"
  - "complex/cargf"
  - "complex/cargl"
dev_langs: 
  - "C"
  - "C++"
helpviewer_keywords: 
  - "carg function"
  - "cargf function"
  - "cargl function"
ms.assetid: 610d6a93-b929-46ab-a966-b77db0b804be
caps.latest.revision: 12
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# carg, cargf, cargl
Retrieves the argument  of a complex number, with a branch cut along the negative real axis.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A complex number.  
  
## Return Value  
 The argument (also known as the phase) of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. The result is in the interval [−π, +π].  
  
## Remarks  
 Because C++ allows overloading, you can call overloads of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> that take <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> values, and return <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> values. In a C program, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> always takes a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> value and returns a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> value.  
  
## Requirements  
  
|Routine|C header|C++ header|  
|-------------|--------------|------------------|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>,               <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|\<complex.h>|\<ccomplex>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## See Also  
 [CRT Alphabetical Function Reference](../vs140/crt-alphabetical-function-reference.md)   
 [norm, normf, norml](../vs140/norm--normf--norml.md)   
 [creal, crealf, creall](../vs140/creal--crealf--creall.md)   
 [cproj, cprojf, cprojl](../vs140/cproj--cprojf--cprojl.md)   
 [conj, conjf, conjl](../vs140/conj--conjf--conjl.md)   
 [cimag, cimagf, cimagl](../vs140/cimag--cimagf--cimagl.md)   
 [cabs, cabsf, cabsl](../vs140/cabs--cabsf--cabsl.md)