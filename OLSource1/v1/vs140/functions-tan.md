---
title: "Functions tan"
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
  - "tan"
  - "std::tan"
  - "std.tan"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "tan function"
  - "calculating tangents"
ms.assetid: 3ed884cb-c670-4a56-9952-e709949598d0
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Functions tan
Returns the tangent of a complex number.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The complex number whose tangent is being determined.  
  
## Return Value  
 The complex number that is the tangent of the input complex number.  
  
## Remarks  
 Identities defining the complex cotangent:  
  
 tan (*z*) = sin (*z*) / cos (*z*) = ( exp (*iz*) – exp (-*iz*) ) / *i*( exp (*iz*) + exp (-*iz*) )  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Complex number c1 = (3,4)**  
**Complex number c2 = tan ( c1 ) = (-0.000187346,0.999356)**  
**The modulus of c2 is: 0.999356**  
**The argument of c2 is: 1.57098 radians, which is 90.0107 degrees.**  
**The complex components tan (vci), where abs (vci) = 1**  
**& arg (vci) = i \* pi / 6 of the vector v1 are:**  
**(0.713931,0.85004)**  
**(0.24356,0.792403)**  
**(-4.34302e-014,0.761594)**  
**(-0.24356,0.792403)**  
**(-0.713931,0.85004)**  
**(-1.55741,-7.08476e-013)**   
## Requirements  
 **Header:** \<complex>  
  
 **Namespace:** std