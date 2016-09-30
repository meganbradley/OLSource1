---
title: "unordered_set::clear"
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
  - "unordered_set::clear"
  - "unordered_set.clear"
  - "std.tr1.unordered_set.clear"
  - "unordered_set/std::tr1::unordered_set::clear"
  - "std::tr1::unordered_set::clear"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "clear method [TR1]"
ms.assetid: 40506306-519d-4b11-b46c-8765ee26c4cb
caps.latest.revision: 19
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# unordered_set::clear
Removes all elements.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The member function calls [erase](../vs140/unordered_set--erase.md)<CodeContentPlaceHolder>2\</CodeContentPlaceHolder> [begin](../vs140/unordered_set--begin.md)<CodeContentPlaceHolder>3\</CodeContentPlaceHolder> [end](../vs140/unordered_set--end.md)<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
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
 [unordered_set](../vs140/unordered_set-class.md)   
 [unordered_set::erase](../vs140/unordered_set--erase.md)