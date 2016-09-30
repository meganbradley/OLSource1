---
title: "unordered_multimap::find"
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
  - "std::tr1::unordered_multimap::find"
  - "unordered_multimap.find"
  - "unordered_map/std::tr1::unordered_multimap::find"
  - "std.tr1.unordered_multimap.find"
  - "unordered_multimap::find"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "find method [TR1]"
ms.assetid: 4b14681c-2393-4e70-bd33-8f22c0fe6bdc
caps.latest.revision: 20
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# unordered_multimap::find
Finds an element that matches a specified key.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Key value to search for.  
  
## Remarks  
 The member function returns [equal_range](../vs140/unordered_multimap--equal_range.md)<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **[c, 3] [b, 2] [a, 1]**  
**find('A') == false**  
**find('b') == true: [b, 2]**   
## Requirements  
 **Header:** \<unordered_map>  
  
 **Namespace:** std  
  
## See Also  
 [\<unordered_map>](../vs140/-unordered_map-.md)   
 [unordered_multimap](../vs140/unordered_multimap-class.md)   
 [unordered_multimap::equal_range](../vs140/unordered_multimap--equal_range.md)