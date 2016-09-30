---
title: "polar"
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
  - "std.polar"
  - "std::polar"
  - "polar"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "polar function"
ms.assetid: 36d5b8d1-c60c-49d2-9653-91425d89d2f7
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# polar
Returns the complex number, which corresponds to a specified modulus and argument, in Cartesian form.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *_Modulus*  
 The modulus of the complex number being input.  
  
 *_Argument*  
 The argument of the complex number being input.  
  
## Return Value  
 Cartesian form of the complex number specified in polar form.  
  
## Remarks  
 The polar form of a complex number provides the modulus *r* and the argument , where these parameters are related to the real and imaginary Cartesian components *a* and *b* by the equations *a* = r \* cos (  ) and b = *r* \* sin ()*.*  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **c1 = polar ( 5.0 ) = (5,0)**  
**c2 = polar ( 5.0 , pi / 6 ) = (4.33013,2.5)**  
**c3 = polar ( 5.0 , 13 \* pi / 6 ) = (4.33013,2.5)**  
**The complex numbers c2 & c3 have the same principal arguments.**  
**The modulus of c2 is recovered from c2 using: abs ( c2 ) = 5**  
**Argument of c2 is recovered from c2 using:**  
 **arg ( c2 ) = 0.523599 radians, which is 30 degrees.**   
## Requirements  
 **Header:** \<complex>  
  
 **Namespace:** std