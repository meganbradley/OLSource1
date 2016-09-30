---
title: "cosh"
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
  - "cosh"
  - "std::cosh"
  - "std.cosh"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "cosh function"
ms.assetid: c55ad8c3-ca2b-442a-9943-76bf5dd8a479
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# cosh
Returns the hyperbolic cosine of a complex number.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The complex number whose hyperbolic cosine is being determined.  
  
## Return Value  
 The complex number that is the hyperbolic cosine of the input complex number.  
  
## Remarks  
 Identities defining the complex hyperbolic cosines:  
  
 cos (*z*) = (1/2)\*( exp (*z*) + exp (-*z*) )  
  
 cos (*z*) = cosh (*a + bi*) = cosh (*a*) cos (*b*) + isinh (*a*) sin (*b*)  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Complex number c1 = (3,4)**  
**Complex number c2 = cosh ( c1 ) = (-6.58066,-7.58155)**  
**The modulus of c2 is: 10.0392**  
**The argument of c2 is: -2.28564 radians, which is -130.957 degrees.**  
**The complex components cosh (vci), where abs (vci) = 1**  
**& arg (vci) = i \* pi / 6 of the vector v1 are:**  
**(1.22777,0.469075)**  
**(0.730543,0.39695)**  
**(0.540302,-8.70178e-014)**  
**(0.730543,-0.39695)**  
**(1.22777,-0.469075)**  
**(1.54308,2.43059e-013)**   
## Requirements  
 **Header:** \<complex>  
  
 **Namespace:** std