---
title: "operator== (&lt;complex&gt;)"
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
  - "std.=="
  - "std::=="
  - "operator=="
  - "std.operator=="
  - "std::operator=="
  - "=="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator==, complex numbers"
  - "operator ==, complex numbers"
  - "== operator, with specific standard C++ objects"
ms.assetid: 4bc38a57-89dc-4b0c-b3bc-32e5d3aff515
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# operator== (&lt;complex&gt;)
Tests for equality between two complex numbers, one or both of which may belong to the subset of the type for the real and imaginary parts.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A complex number or object of its parameter type to be tested for inequality.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A complex number or object of its parameter type to be tested for inequality.  
  
## Return Value  
 **true** if the numbers are equal; **false** if numbers are not equal.  
  
## Remarks  
 Two complex numbers are equal if and only if their real parts are equal and their imaginary parts are equal. Otherwise, they are unequal.  
  
 The operation is overloaded so that comparison tests can be executed without the conversion of the data to a particular format.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The left-side complex number is cl1 = (2.59808,1.5)**  
**The 1st right-side complex number is cr1a = (2.59808,1.5)**  
**The 2nd right-side complex number is cr1b = (1,1.73205)**  
**The complex numbers cl1 & cr1a are equal.**  
**The complex numbers cl1 & cr1b are not equal.**  
**The 1st left-side complex number is cl2a = (3,4)**  
**The 1st right-side complex number is cr2a = 3**  
**The complex numbers cl2a & cr2a are not equal.**  
**The 2nd left-side complex number is cl2b = (5,0)**  
**The 2nd right-side complex number is cr2b = 5**  
**The complex numbers cl2b & cr2b are equal.**  
**The 1st left-side complex number is cl3a = 3**  
**The 1st right-side complex number is cr3a = (3,4)**  
**The complex numbers cl3a & cr3a are not equal.**  
**The 2nd left-side complex number is cl3b = 5**  
**The 2nd right-side complex number is cr3b = (5,0)**  
**The complex numbers cl3b & cr3b are equal.**   
## Requirements  
 **Header:** \<complex>  
  
 **Namespace:** std