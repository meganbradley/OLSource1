---
title: "imag"
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
  - "imag"
  - "std::imag"
  - "std.imag"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "imag function"
ms.assetid: f607a832-340e-428b-8b53-2cb4422d1ec1
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# imag
Extracts the imaginary component of a complex number.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The complex number whose real part is to be extracted.  
  
## Return Value  
 The imaginary part of the complex number as a global function.  
  
## Remarks  
 This template function cannot be used to modify the real part of the complex number. To change the real part, a new complex number must be assigned the component value.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The complex number c1 = (4,3)**  
**The real part of c1 is real ( c1 ) = 4.**  
**The imaginary part of c1 is imag ( c1 ) = 3.**   
## Requirements  
 **Header:** \<complex>  
  
 **Namespace:** std