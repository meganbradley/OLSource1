---
title: "sin"
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
  - "sin"
  - "std::sin"
  - "std.sin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "sin function"
ms.assetid: 75ad5daf-822a-4137-8f66-961ae46e7384
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# sin
Returns the sine of a complex number.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The complex number whose sine is being determined.  
  
## Return Value  
 The complex number that is the sine of the input complex number.  
  
## Remarks  
 Identities defining the complex sines:  
  
 sin (*z*) = (1/2*i*)\*( exp (*iz*) – exp (-*iz*) )  
  
 sin (*z*) = sin (*a + bi*) = sin (*a*) cosh (*b*) + icos (*a*) sinh (*b*)  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Complex number c1 = (3,4)**  
**Complex number c2 = sin ( c1 ) = (3.85374,-27.0168)**  
**The modulus of c2 is: 27.2903**  
**The argument of c2 is: -1.42911 radians, which is -81.882 degrees.**  
**The complex components sin (vci), where abs (vci) = 1**  
**& arg (vci) = i \* pi / 6 of the vector v1 are:**  
**(0.85898,0.337596)**  
**(0.670731,0.858637)**  
**(-1.59572e-013,1.1752)**  
**(-0.670731,0.858637)**  
**(-0.85898,0.337596)**  
**(-0.841471,-1.11747e-013)**   
## Requirements  
 **Header:** \<complex>  
  
 **Namespace:** std