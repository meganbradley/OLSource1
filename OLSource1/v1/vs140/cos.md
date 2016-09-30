---
title: "cos"
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
  - "cos"
  - "std.cos"
  - "std::cos"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "cos function"
ms.assetid: 9972ddd9-17e1-4a75-b0de-f79863699898
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# cos
Returns the cosine of a complex number.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The complex number whose cosine is being determined.  
  
## Return Value  
 The complex number that is the cosine of the input complex number.  
  
## Remarks  
 Identities defining the complex cosines:  
  
 cos (*z*) = (1/2)\*( exp (*iz*) + exp (-*iz*) )  
  
 cos (*z*) = cos (*a* + *bi*) = cos (*a*) cosh (*b*) - isin (*a*) sinh (*b*)  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Complex number c1 = (3,4)**  
**Complex number c2 = cos ( c1 ) = (-27.0349,-3.85115)**  
**The modulus of c2 is: 27.3079**  
**The argument of c2 is: -3.00009 radians, which is -171.893 degrees.**  
**The complex components cos (vci), where abs (vci) = 1**  
**& arg (vci) = i \* pi / 6 of the vector v1 are:**  
**(0.730543,-0.39695)**  
**(1.22777,-0.469075)**  
**(1.54308,1.21529e-013)**  
**(1.22777,0.469075)**  
**(0.730543,0.39695)**  
**(0.540302,-1.74036e-013)**   
## Requirements  
 **Header:** \<complex>  
  
 **Namespace:** std