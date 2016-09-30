---
title: "moneypunct::grouping"
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
  - "grouping"
  - "locale/std::moneypunct::grouping"
  - "moneypunct::grouping"
  - "std.moneypunct.grouping"
  - "moneypunct.grouping"
  - "std::moneypunct::grouping"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "grouping method"
ms.assetid: 87932aa2-af0f-4a53-bf1b-57f48093d7c9
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# moneypunct::grouping
Returns a locale-specific rule for determining how digits are grouped to the left of any decimal point.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A locale-specific rule for determining how digits are grouped to the left of any decimal point.  
  
## Remarks  
 The member function returns [do_grouping](../vs140/moneypunct--do_grouping.md).  
  
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