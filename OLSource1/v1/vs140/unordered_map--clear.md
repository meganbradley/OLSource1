---
title: "unordered_map::clear"
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
  - "std.tr1.unordered_map.clear"
  - "std::tr1::unordered_map::clear"
  - "unordered_map/std::tr1::unordered_map::clear"
  - "unordered_map::clear"
  - "unordered_map.clear"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "clear method [TR1]"
ms.assetid: b9e17ddb-2c17-4f3b-b97d-bd81df12ec85
caps.latest.revision: 19
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# unordered_map::clear
Removes all elements.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The member function calls [erase](../vs140/unordered_map--erase.md)<CodeContentPlaceHolder>2\</CodeContentPlaceHolder> [begin](../vs140/unordered_map--begin.md)<CodeContentPlaceHolder>3\</CodeContentPlaceHolder> [end](../vs140/unordered_map--end.md)<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
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
 [unordered_map](../vs140/unordered_map-class.md)   
 [unordered_map::erase](../vs140/unordered_map--erase.md)