---
title: "operator- (&lt;complex&gt;)2"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "operator/ (&lt;complex&gt;)"
f1_keywords: 
  - "std.operator/"
  - "std::/"
  - "/"
  - "std./"
  - "std::operator/"
  - "operator/"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "/ operator"
  - "arithmetic operators [C++], division"
  - "/ operator, complex numbers"
  - "division operator, complex numbers"
  - "operators [C++], division"
ms.assetid: 1e1def74-21fa-4081-8c9f-eba34a7528ee
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator- (&lt;complex&gt;)2
Divides two complex numbers, one or both of which may belong to the subset of the type for the real and imaginary parts.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A complex number or a number that is of the parameter type for a complex number that is the numerator to be divided by the denominator with the / operation.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A complex number or a number that is of the parameter type for a complex number that is the denominator to be used to divide the numerator with the / operation.  
  
## Return Value  
 The complex number that results from the division of the numerator by the denominator, the values of which are specified by the parameter inputs.  
  
## Remarks  
 The operation is overloaded so that simple arithmetic operations can be executed without the conversion of the data to a particular format.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The left-side complex number is cl1 = (2.59808,1.5)**  
**The right-side complex number is cr1 = (1,1.73205)**  
**The quotient of the two complex numbers is: cs1 = cl1 /cr1 = (1.29904,-0.75)**  
**The modulus of cs1 is: 1.5**  
**The argument of cs1 is: -0.523599 radians, which is -30 degrees.**  
**The left-side complex number is cl2 = (2.59808,1.5)**  
**The right-side complex number is cr2 = 5**  
**The quotient of the two complex numbers is: cs2 = cl2 /cr2 = (0.519615,0.3)**  
**The modulus of cs2 is: 0.6**  
**The argument of cs2 is: 0.523599 radians, which is 30 degrees.**  
**The left-side complex number is cl3 = 5**  
**The right-side complex number is cr3 = (2.59808,1.5)**  
**The quotient of the two complex numbers is: cs3 = cl3 /cr2 = (1.44338,-0.833333)**  
**The modulus of cs3 is: 1.66667**  
**The argument of cs3 is: -0.523599 radians, which is -30 degrees.**   
## Requirements  
 **Header:** \<complex>  
  
 **Namespace:** std