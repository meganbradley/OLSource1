---
title: "conj"
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
  - "std::conj"
  - "std.conj"
  - "conj"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "conj function"
ms.assetid: 2852df59-6f2c-4ba2-8ab5-c878d72af192
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# conj
Returns the complex conjugate of a complex number.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The complex number whose complex conjugate is being returned.  
  
## Return Value  
 The complex conjugate of the input complex number.  
  
## Remarks  
 The complex conjugate of a complex number *a + bi* is *a – bi*. The product of a complex number and its conjugate is the norm of the number *a*2 + *b*2.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The complex number c1 = (4,3)**  
**The real part of c1 is real ( c1 ) = 4.**  
**The imaginary part of c1 is imag ( c1 ) = 3.**  
**The complex conjugate of c1 is c2 = conj ( c1 )= (4,-3)**  
**The real part of c2 is real ( c2 ) = 4.**  
**The imaginary part of c2 is imag ( c2 ) = -3.**  
**The norm of (c1 \* conj (c1) ) is c1 \* c2 = 25**   
## Requirements  
 **Header:** \<complex>  
  
 **Namespace:** std