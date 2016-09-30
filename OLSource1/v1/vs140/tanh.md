---
title: "tanh"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "tanh"
  - "std.tanh"
  - "std::tanh"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "tanh function"
ms.assetid: 19215cdd-f857-473e-b9c0-1933f0335196
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# tanh
Returns the hyperbolic tangent of a complex number.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The complex number whose hyperbolic tangent is being determined.  
  
## Return Value  
 The complex number that is the hyperbolic tangent of the input complex number.  
  
## Remarks  
 Identities defining the complex hyperbolic cotangent:  
  
 tanh (*z*) = sinh (*z*) / cosh (*z*) = ( exp (*z*) – exp (-*z*) ) / ( exp (*z*) + exp (-*z*) )  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Complex number c1 = (3,4)**  
**Complex number c2 = tanh ( c1 ) = (1.00071,0.00490826)**  
**The modulus of c2 is: 1.00072**  
**The argument of c2 is: 0.00490474 radians, which is 0.281021 degrees.**  
**The complex components tanh (vci), where abs (vci) = 1**  
**& arg (vci) = i \* pi / 6 of the vector v1 are:**  
**(0.792403,0.24356)**  
**(0.85004,0.713931)**  
**(-3.54238e-013,1.55741)**  
**(-0.85004,0.713931)**  
**(-0.792403,0.24356)**  
**(-0.761594,-8.68604e-014)**   
## Requirements  
 **Header:** \<complex>  
  
 **Namespace:** std