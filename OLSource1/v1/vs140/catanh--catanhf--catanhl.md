---
title: "catanh, catanhf, catanhl"
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
  - "catanh"
  - "catanhf"
  - "catanhl"
apilocation: 
  - "msvcr120.dll"
  - "api-ms-win-crt-math-l1-1-0.dll"
apitype: "DLLExport"
f1_keywords: 
  - "catanh"
  - "catanhf"
  - "catanhl"
  - "complex/catanh"
  - "complex/catanhf"
  - "complex/catanhl"
dev_langs: 
  - "C"
  - "C++"
helpviewer_keywords: 
  - "catanh function"
  - "catanhf function"
  - "catanhl function"
ms.assetid: 1b6021cb-647a-41b4-9d7f-919cc8b57b86
caps.latest.revision: 14
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# catanh, catanhf, catanhl
Retrieves the inverse hyperbolic tangent of a complex number, with branch cuts outside the interval [−1; +1] along the real axis.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A complex number that represents an angle, in radians.  
  
## Return Value  
 The inverse hyperbolic tangent of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, in radians. The result is unbounded along the real axis, and  in the interval [−iπ/2; +iπ/2] along the imaginary axis. A domain error will occur if <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is outside the interval [-1, +1]. A pole error will occur if <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is -1 or +1.  
  
## Remarks  
 Because C++ allows overloading, you can call overloads of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> that take and return <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> values. In a C program, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> always takes and returns a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> value.  
  
## Requirements  
  
|Routine|C header|C++ header|  
|-------------|--------------|------------------|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>,               <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|\<complex.h>|\<ccomplex>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## See Also  
 [CRT Alphabetical Function Reference](../vs140/crt-alphabetical-function-reference.md)   
 [ctanh, ctanhf, ctanhl](../vs140/ctanh--ctanhf--ctanhl.md)   
 [catan, catanf, catanl](../vs140/catan--catanf--catanl.md)   
 [csinh, csinhf, csinhl](../vs140/csinh--csinhf--csinhl.md)   
 [casinh, casinhf, casinhl](../vs140/casinh--casinhf--casinhl.md)   
 [ccosh, ccoshf, ccoshl](../vs140/ccosh--ccoshf--ccoshl.md)   
 [cacosh, cacoshf, cacoshl](../vs140/cacosh--cacoshf--cacoshl.md)   
 [cacos, cacosf, cacosl](../vs140/cacos--cacosf--cacosl.md)   
 [ctan, ctanf, ctanl](../vs140/ctan--ctanf--ctanl.md)   
 [csin, csinf, csinl](../vs140/csin--csinf--csinl.md)   
 [casin, casinf, casinl](../vs140/casin--casinf--casinl.md)   
 [ccos, ccosf, ccosl](../vs140/ccos--ccosf--ccosl.md)   
 [csqrt, csqrtf, csqrtl](../vs140/csqrt--csqrtf--csqrtl.md)