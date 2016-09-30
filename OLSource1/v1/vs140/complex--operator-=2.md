---
title: "complex::operator-=2"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "complex::operator/="
f1_keywords: 
  - "complex::operator/="
  - "std::complex::operator/="
  - "std.complex.operator/="
  - "operator/="
  - "/="
  - "complex.operator/="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator/="
  - "operator /="
  - "/= operator"
ms.assetid: 1804d6dd-7455-4527-a69e-dbb17e4ac39a
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# complex::operator-=2
Divides a target complex number by a divisor, which may be complex or be the same type as are the real and imaginary parts of the complex number.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A complex number to be subtracted from the target complex number.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A real number to be subtracted from the target complex number.  
  
## Return Value  
 A complex number that has been divided by the number specified as a parameter.  
  
## Remarks  
 The operation is overloaded so that simple arithmetic operations can be executed without the conversion of the data to a particular format.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The left-side complex number is cl1 = (2.59808,1.5)**  
**The right-side complex number is cr1 = (1,1.73205)**  
**The quotient of the two complex numbers is: cs1 = cl1 /cr1 = (1.29904,-0.75)**  
**Quotient of two complex numbers is also: cl1 /= cr1 = (1.29904,-0.75)**  
**The modulus of cl1 is: 1.5**  
**The argument of cl1 is: -0.523599 radians, which is -30 degrees.**  
**The left-side complex number is cl2 = (2.59808,1.5)**  
**The right-side complex number is cr2 = 5**  
**The quotient of the two complex numbers is: cs2 /= cl2 cr2 = (0.519615,0.3)**  
**Quotient of two complex numbers is also: cl2 = /cr2 = (0.519615,0.3)**  
**The modulus of cl2 is: 0.6**  
**The argument of cl2 is: 0.523599 radians, which is 30 degrees.**   
## Requirements  
 **Header:** \<complex>  
  
 **Namespace:** std  
  
## See Also  
 [complex Class](../vs140/complex-class.md)