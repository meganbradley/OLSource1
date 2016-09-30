---
title: "moneypunct::frac_digits"
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
  - "frac_digits"
  - "moneypunct.frac_digits"
  - "moneypunct::frac_digits"
  - "std::moneypunct::frac_digits"
  - "std.moneypunct.frac_digits"
  - "locale/std::moneypunct::frac_digits"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "frac_digits method"
ms.assetid: d051ee7a-93e6-4b4d-847b-cee234e71401
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# moneypunct::frac_digits
Returns a locale-specific count of the number of digits to display to the right of any decimal point.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A locale-specific count of the number of digits to display to the right of any decimal point.  
  
## Remarks  
 The member function returns [do_frac_digits](../vs140/moneypunct--do_frac_digits.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **German_Germany.1252 international grouping:**  
 **the 0th group to the left of the radix character is of size 3**  
**German_Germany.1252 international frac_digits**  
 **to the right of the radix character: 2**  
**German_Germany.1252 domestic grouping:**  
 **the 0th group to the left of the radix character is of size 3**  
**German_Germany.1252 domestic frac_digits**  
 **to the right of the radix character: 2**   
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [moneypunct Class](../vs140/moneypunct-class.md)