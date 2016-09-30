---
title: "operator- (&lt;complex&gt;)1"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "operator- (&lt;complex&gt;)"
f1_keywords: 
  - "std.-"
  - "-"
  - "operator-"
  - "std.operator-"
  - "std::-"
  - "std::operator-"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "- operator"
  - "- operator, additive operators in C++"
ms.assetid: 5cec877d-4d53-4ba1-9ab7-98cb02d74d48
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator- (&lt;complex&gt;)1
Subtracts two complex numbers, one or both of which may belong to the subset of the type for the real and imaginary parts.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The first of two complex numbers or a number that is of the parameter type for a complex number that is to be subtracted by the - operation.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The second of two complex numbers or a number that is of the parameter type for a complex number that is to be subtracted by the - operation.  
  
## Return Value  
 The complex number that results from the subtraction of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> from <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, the two numbers whose values are specified by the parameter inputs.  
  
## Remarks  
 The operation is overloaded so that simple arithmetic operations can be executed without the conversion of the data to a particular format.  
  
 The unary operator changes the sign of a complex number and returns a value whose real part is the negative of the real part of the number input and whose imaginary part is the negative of the imaginary part of the number input.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The left-side complex number is cl1 = (3,4)**  
**The right-side complex number is cr1 = (2,5)**  
**Difference of two complex numbers is: cs1 = (1,-1)**  
**The modulus of cs1 is: 1.41421**  
**The argument of cs1 is: -0.785398 radians, which is -45 degrees.**  
**The left-side complex number is cl2 = (3,4)**  
**The right-side complex number is cr2 = 5**  
**Difference of two complex numbers is: cs2 = (-2,4)**  
**The modulus of cs2 is: 4.47214**  
**The argument of cs2 is: 2.03444 radians, which is 116.565 degrees.**  
**The left-side complex number is cl3 = 5**  
**The right-side complex number is cr3 = (3,4)**  
**Difference of two complex numbers is: cs3 = (2,-4)**  
**The modulus of cs3 is: 4.47214**  
**The argument of cs3 is: -1.10715 radians, which is -63.4349 degrees.**  
**The right-side complex number is cr4 = (3,4)**  
**The result of the unary application of - to the right-side**  
 **complex number is: cs4 = (-3,-4)**  
**The modulus of cs4 is: 5**  
**The argument of cs4 is: -2.2143 radians, which is -126.87 degrees.**   
## Requirements  
 **Header:** \<complex>  
  
 **Namespace:** std