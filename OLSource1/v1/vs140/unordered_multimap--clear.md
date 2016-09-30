---
title: "unordered_multimap::clear"
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
  - "unordered_map/std::tr1::unordered_multimap::clear"
  - "unordered_multimap.clear"
  - "std::tr1::unordered_multimap::clear"
  - "unordered_multimap::clear"
  - "std.tr1.unordered_multimap.clear"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "clear method [TR1]"
ms.assetid: e624a9fe-ab11-4015-8ab6-913cff34e7ed
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unordered_multimap::clear
Removes all elements.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The member function calls [erase](../vs140/unordered_multimap--erase.md)<CodeContentPlaceHolder>2\</CodeContentPlaceHolder> [begin](../vs140/unordered_multimap--begin.md)<CodeContentPlaceHolder>3\</CodeContentPlaceHolder> [end](../vs140/unordered_multimap--end.md)<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **[c, 3] [b, 2] [a, 1]**  
**size == 0**  
**empty() == true**  
 **[e, 5] [d, 4]**  
**size == 2**  
**empty() == false**   
## Requirements  
 **Header:** \<unordered_map>  
  
 **Namespace:** std  
  
## See Also  
 [\<unordered_map>](../vs140/-unordered_map-.md)   
 [unordered_multimap](../vs140/unordered_multimap-class.md)   
 [unordered_multimap::erase](../vs140/unordered_multimap--erase.md)