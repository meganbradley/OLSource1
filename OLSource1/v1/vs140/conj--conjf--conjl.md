---
title: "conj, conjf, conjl"
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
  - "conj"
  - "conjf"
  - "conjl"
apilocation: 
  - "msvcr120.dll"
  - "api-ms-win-crt-math-l1-1-0.dll"
apitype: "DLLExport"
f1_keywords: 
  - "conj"
  - "conjf"
  - "conjl"
  - "complex/conj"
  - "complex/conjf"
  - "complex/conjl"
dev_langs: 
  - "C"
  - "C++"
helpviewer_keywords: 
  - "conj function"
  - "conjf function"
  - "conjl function"
ms.assetid: 792fccfa-19c6-4890-99f9-a3b89effccd6
caps.latest.revision: 14
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# conj, conjf, conjl
Retrieves the complex conjugate of a complex number.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A complex number.  
  
## Return Value  
 The complex conjugate  of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  The result has the same real and imaginary part as <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, but with the opposite sign.  
  
## Remarks  
 Because C++ allows overloading, you can call overloads of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> that take and return <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> values. In a C program, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> always takes and returns a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> value.  
  
## Requirements  
  
|Routine|C header|C++ header|  
|-------------|--------------|------------------|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>,               <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|\<complex.h>|\<ccomplex>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## See Also  
 [CRT Alphabetical Function Reference](../vs140/crt-alphabetical-function-reference.md)   
 [norm, normf, norml](../vs140/norm--normf--norml.md)   
 [creal, crealf, creall](../vs140/creal--crealf--creall.md)   
 [cproj, cprojf, cprojl](../vs140/cproj--cprojf--cprojl.md)   
 [cimag, cimagf, cimagl](../vs140/cimag--cimagf--cimagl.md)   
 [carg, cargf, cargl](../vs140/carg--cargf--cargl.md)   
 [cabs, cabsf, cabsl](../vs140/cabs--cabsf--cabsl.md)