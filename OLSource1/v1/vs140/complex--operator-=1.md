---
title: "complex::operator-=1"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "complex::operator-="
f1_keywords: 
  - "complex.operator-="
  - "operator-="
  - "-="
  - "std::complex::operator-="
  - "std.complex.operator-="
  - "complex::operator-="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator-="
  - "-= operator"
ms.assetid: 62b55c1f-c397-4722-b9a8-1a537f3aebe8
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# complex::operator-=1
Subtracts a number from a target complex number, where the number subtracted may be complex or of the same type as are the real and imaginary parts of the complex number to which it is added.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A complex number to be subtracted from the target complex number.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A real number to be subtracted from the target complex number.  
  
## Return Value  
 A complex number that has had the number specified as a parameter subtracted from it.  
  
## Remarks  
 The operation is overloaded so that simple arithmetic operations can be executed without the conversion of the data to a particular format.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The left-side complex number is cl1 = (3,4)**  
**The right-side complex number is cr1 = (2,-1)**  
**The difference between the two complex numbers is:**  
 **cs1 = cl1 - cr1 = (1,5)**  
**Complex number cr1 subtracted from complex number cl1 is:**  
 **cl1 -= cr1 = (1,5)**  
**The modulus of cl1 is: 5.09902**  
**The argument of cl1 is: 1.3734 radians, which is 78.6901 degrees.**  
**The left-side complex number is cl2 = (2,4)**  
**The right-side complex number is cr2 = 5**  
**The difference between the two complex numbers is:**  
 **cs2 = cl2 - cr2 = (-3,4)**  
**Complex number cr2 subtracted from complex number cl2 is:**  
 **cl2 -= cr2 = (-3,4)**  
**The modulus of cl2 is: 5**  
**The argument of cl2 is: 2.2143 radians, which is 126.87 degrees.**   
## Requirements  
 **Header:** \<complex>  
  
 **Namespace:** std  
  
## See Also  
 [complex Class](../vs140/complex-class.md)