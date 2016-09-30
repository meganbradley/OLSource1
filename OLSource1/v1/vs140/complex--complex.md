---
title: "complex::complex"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "complex"
  - "std::complex::complex"
  - "complex.complex"
  - "std.complex.complex"
  - "complex::complex"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "complex method"
  - "complex class, constructor"
ms.assetid: b6371cf8-6f79-4dfa-8746-171140430214
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# complex::complex
Constructs a complex number with specified real and imaginary parts or as a copy of some other complex number.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The value of the real part used to initialize the complex number being constructed.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The value of the imaginary part used to initialize the complex number being constructed.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The complex number whose real and imaginary parts are used to initialize the complex number being constructed.  
  
## Remarks  
 The first constructor initializes the stored real part to _*RealVal* and the stored imaginary part to \_*Imagval*. The second constructor initializes the stored real part to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>**.real**() and the stored imaginary part to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>**.imag**().  
  
 In this implementation, if a translator does not support member template functions, the template:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 is replaced with:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 which is the copy constructor.  
  
## Example  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<complex>  
  
 **Namespace:** std  
  
## See Also  
 [complex Class](../vs140/complex-class.md)