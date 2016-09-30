---
title: "norm"
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
  - "std.norm"
  - "std::norm"
  - "norm"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "norm function"
ms.assetid: efbb0eea-12dc-413c-886f-4f41bad1b573
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# norm
Extracts the norm of a complex number.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The complex number whose norm is to be determined.  
  
## Return Value  
 The norm of a complex number.  
  
## Remarks  
 The norm of a complex number *a + bi* is *(a*<sup>2\</sup> *+ b*<sup>2\</sup>*).* The norm of a complex number is the square of its modulus. The modulus of a complex number is a measure of the length of the vector representing the complex number. The modulus of a complex number *a + bi* is <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>*(a*<sup>2\</sup> *+ b*<sup>2\</sup>*),* written *&#124;a + bi&#124;.*  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **c1 = polar ( 5.0 ) = (5,0)**  
**c2 = polar ( 5.0 , pi / 6 ) = (4.33013,2.5)**  
**c3 = polar ( 5.0 , 13 \* pi / 6 ) = (4.33013,2.5)**  
**The complex numbers c2 & c3 have the same principal arguments.**  
**The modulus of c2 is recovered from c2 using: abs ( c2 ) = 5**  
**Argument of c2 is recovered from c2 using:**  
 **arg ( c2 ) = 0.523599 radians, which is 30 degrees.**  
**The norm of c2 given by: norm ( c2 ) = 25**  
**The modulus of c2 is the square root of the norm: sqrt ( normc2 ) = 5.**   
## Requirements  
 **Header:** \<complex>  
  
 **Namespace:** std