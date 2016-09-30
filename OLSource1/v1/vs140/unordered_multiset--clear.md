---
title: "unordered_multiset::clear"
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
  - "std::tr1::unordered_multiset::clear"
  - "unordered_multiset.clear"
  - "unordered_multiset::clear"
  - "std.tr1.unordered_multiset.clear"
  - "unordered_set/std::tr1::unordered_multiset::clear"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "clear method [TR1]"
ms.assetid: 93980b55-42d0-4b1a-ac79-5828f3020a2e
caps.latest.revision: 20
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# unordered_multiset::clear
Removes all elements.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The member function calls [erase](../vs140/unordered_multiset--erase.md)<CodeContentPlaceHolder>2\</CodeContentPlaceHolder> [begin](../vs140/unordered_multiset--begin.md)<CodeContentPlaceHolder>3\</CodeContentPlaceHolder> [end](../vs140/unordered_multiset--end.md)<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **[c] [b] [a]**  
**size == 0**  
**empty() == true**  
 **[e] [d]**  
**size == 2**  
**empty() == false**   
## Requirements  
 **Header:** \<unordered_set>  
  
 **Namespace:** std  
  
## See Also  
 [\<unordered_set>](../vs140/-unordered_set-.md)   
 [unordered_multiset](../vs140/unordered_multiset-class.md)   
 [unordered_multiset::erase](../vs140/unordered_multiset--erase.md)