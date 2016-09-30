---
title: "abs"
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
  - "std::abs"
  - "std.abs"
  - "abs"
  - "xcomplex/std::abs"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "abs function"
ms.assetid: 88aaa679-b1eb-45a9-969c-fed23d898b37
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# abs
Calculates the modulus of a complex number.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The complex number whose modulus is to be determined.  
  
## Return Value  
 The modulus of a complex number.  
  
## Remarks  
 The *modulus* of a complex number is a measure of the length of the vector representing the complex number. The modulus of a complex number a + bi is sqrt (a<sup>2\</sup> + b<sup>2\</sup>),  written &#124;a + bi&#124;. The *norm* of a complex number a + bi is  (a<sup>2\</sup> + b<sup>2\</sup>), so the modulus of a complex number is the square root of its norm.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **c1 = polar ( 5.0 ) = (5,0)**  
**c2 = polar ( 5.0 , pi / 6 ) = (4.33013,2.5)**  
**c3 = polar ( 5.0 , 13 \* pi / 6 ) = (4.33013,2.5)**  
**The modulus of c1 is recovered from c1 using: abs ( c1 ) = 5**  
**Argument of c1 is recovered from c1 using:**  
 **arg ( c1 ) = 0 radians, which is 0 degrees.**  
**The modulus of c2 is recovered from c2 using: abs ( c2 ) = 5**  
**Argument of c2 is recovered from c2 using:**  
 **arg ( c2 ) = 0.523599 radians, which is 30 degrees.**  
**The complex numbers c2 & c3 have the same principal arguments.**   
## Requirements  
 **Header:** \<complex>  
  
 **Namespace:** std