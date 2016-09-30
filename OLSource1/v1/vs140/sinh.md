---
title: "sinh"
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
  - "std.sinh"
  - "sinh"
  - "std::sinh"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "sinh function"
ms.assetid: 2188cb75-07c3-4bab-978c-a9e24f4c5cb9
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# sinh
Returns the hyperbolic sine of a complex number.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The complex number whose hyperbolic sine is being determined.  
  
## Return Value  
 The complex number that is the hyperbolic sine of the input complex number.  
  
## Remarks  
 Identities defining the complex hyperbolic sines:  
  
 sinh (*z*) = (1/2)\*( exp (*z*) – exp (-*z*) )  
  
 sinh (*z*) = sinh (*a + bi*) = sinh (*a*) cos (*b*) + *i*cosh (*a*) sin (*b*)  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Complex number c1 = (3,4)**  
**Complex number c2 = sinh ( c1 ) = (-6.54812,-7.61923)**  
**The modulus of c2 is: 10.0464**  
**The argument of c2 is: -2.28073 radians, which is -130.676 degrees.**  
**The complex components sinh (vci), where abs (vci) = 1**  
**& arg (vci) = i \* pi / 6 of the vector v1 are:**  
**(0.858637,0.670731)**  
**(0.337596,0.85898)**  
**(-5.58735e-014,0.841471)**  
**(-0.337596,0.85898)**  
**(-0.858637,0.670731)**  
**(-1.1752,-3.19145e-013)**   
## Requirements  
 **Header:** \<complex>  
  
 **Namespace:** std