---
title: "cacos, cacosf, cacosl"
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
  - "cacos"
  - "cacosf"
  - "cacosl"
apilocation: 
  - "msvcr120.dll"
  - "api-ms-win-crt-math-l1-1-0.dll"
  - "ucrtbase.dll"
apitype: "DLLExport"
f1_keywords: 
  - "cacos"
  - "cacosf"
  - "cacosl"
  - "complex/cacos"
  - "complex/cacosf"
  - "complex/cacosl"
dev_langs: 
  - "C"
  - "C++"
helpviewer_keywords: 
  - "cacos function"
  - "cacosf function"
  - "cacosl function"
ms.assetid: 78118c00-0a07-49c1-8a13-4bf19ce3aea8
caps.latest.revision: 17
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# cacos, cacosf, cacosl
Retrieves the arccosine of a complex number, with branch cuts outside the interval [−1, +1] along the real axis.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A complex number that represents an angle, in radians.  
  
## Return Value  
 The arccosine of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, in radians. The result is unbounded along the imaginary axis, and  in the  in the interval [0, π] along the real axis. A domain error will occur if <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is outside the interval [-1, +1].  
  
## Remarks  
 Because C++ allows overloading, you can call overloads of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> that take and return <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> values. In a C program, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> always takes and returns a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> value.  
  
## Requirements  
  
|Routine|C header|C++ header|  
|-------------|--------------|------------------|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>,               <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|\<complex.h>|\<ccomplex>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## See Also  
 [CRT Alphabetical Function Reference](../vs140/crt-alphabetical-function-reference.md)   
 [catanh, catanhf, catanhl](../vs140/catanh--catanhf--catanhl.md)   
 [ctanh, ctanhf, ctanhl](../vs140/ctanh--ctanhf--ctanhl.md)   
 [catan, catanf, catanl](../vs140/catan--catanf--catanl.md)   
 [csinh, csinhf, csinhl](../vs140/csinh--csinhf--csinhl.md)   
 [casinh, casinhf, casinhl](../vs140/casinh--casinhf--casinhl.md)   
 [ccosh, ccoshf, ccoshl](../vs140/ccosh--ccoshf--ccoshl.md)   
 [cacosh, cacoshf, cacoshl](../vs140/cacosh--cacoshf--cacoshl.md)   
 [ctan, ctanf, ctanl](../vs140/ctan--ctanf--ctanl.md)   
 [csin, csinf, csinl](../vs140/csin--csinf--csinl.md)   
 [casin, casinf, casinl](../vs140/casin--casinf--casinl.md)   
 [ccos, ccosf, ccosl](../vs140/ccos--ccosf--ccosl.md)   
 [csqrt, csqrtf, csqrtl](../vs140/csqrt--csqrtf--csqrtl.md)