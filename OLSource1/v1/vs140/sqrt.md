---
title: "sqrt"
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
  - "sqrt"
  - "std::sqrt"
  - "std.sqrt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "sqrt function"
ms.assetid: 4f518db7-a438-4844-aace-9e192ef4934e
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# sqrt
Calculates the square root of a complex number.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The complex number whose square root is to be found.  
  
## Return Value  
 The square root of a complex number.  
  
## Remarks  
 The square root will have a phase angle in the half-open interval (-pi/2, pi/2].  
  
 The branch cuts in the complex plane are along the negative real axis.  
  
 The square root of a complex number will have a modulus that is the square root of the input number and an argument that is one-half that of the input number.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **c1 = polar ( 5.0 ) = (-2.58529e-012,25)**  
**c2 = sqrt ( c1 ) = (3.53553,3.53553)**  
**The modulus of c2 is recovered from c2 using: abs ( c2 ) = 5**  
**Argument of c2 is recovered from c2 using:**  
 **arg ( c2 ) = 0.785398 radians, which is 45 degrees.**  
**The modulus of c2 = sqrt( abs ( c1 ) ) =5**  
**The argument of c2 = ( 1 / 2 ) \* arg ( c1 ) =0.785398 radians,**  
 **which is 45 degrees.**   
## Requirements  
 **Header:** \<complex>  
  
 **Namespace:** std