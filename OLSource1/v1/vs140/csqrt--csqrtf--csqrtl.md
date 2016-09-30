---
title: "csqrt, csqrtf, csqrtl"
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
  - "csqrt"
  - "csqrtf"
  - "csqrtl"
apilocation: 
  - "msvcr120.dll"
  - "api-ms-win-crt-math-l1-1-0.dll"
apitype: "DLLExport"
f1_keywords: 
  - "csqrt"
  - "csqrtf"
  - "csqrtl"
  - "complex/csqrt"
  - "complex/csqrtf"
  - "complex/csqrtl"
dev_langs: 
  - "C"
  - "C++"
helpviewer_keywords: 
  - "csqrt function"
  - "csqrtf function"
  - "csqrtl function"
ms.assetid: b65f086b-0f55-4622-a7a3-4e79d9c9c05c
caps.latest.revision: 15
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# csqrt, csqrtf, csqrtl
Retrieves the square root of a complex number, with a branch cut along the negative real axis.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A complex number.  
  
## Return Value  
 The square root of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. The result is in the right half-plane.  
  
|Input|SEH Exception|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder> Exception|  
|-----------|-------------------|--------------------------|  
|± QNAN, IND|none|_DOMAIN|  
|- ∞|none|_DOMAIN|  
  
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
 [cacos, cacosf, cacosl](../vs140/cacos--cacosf--cacosl.md)   
 [ctan, ctanf, ctanl](../vs140/ctan--ctanf--ctanl.md)   
 [csin, csinf, csinl](../vs140/csin--csinf--csinl.md)   
 [casin, casinf, casinl](../vs140/casin--casinf--casinl.md)   
 [ccos, ccosf, ccosl](../vs140/ccos--ccosf--ccosl.md)