---
title: "unordered_set::find"
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
  - "std::tr1::unordered_set::find"
  - "std.tr1.unordered_set.find"
  - "unordered_set::find"
  - "unordered_set/std::tr1::unordered_set::find"
  - "unordered_set.find"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "find method [TR1]"
ms.assetid: cb499cb7-05d1-4b1c-81bd-cb7939c6dc7b
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unordered_set::find
Finds an element that matches a specified key.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Key value to search for.  
  
## Remarks  
 The member function returns [equal_range](../vs140/unordered_set--equal_range.md)<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **[c] [b] [a]**  
**find('A') == false**  
**find('b') == true: [b]**   
## Requirements  
 **Header:** \<unordered_set>  
  
 **Namespace:** std  
  
## See Also  
 [\<unordered_set>](../vs140/-unordered_set-.md)   
 [unordered_set](../vs140/unordered_set-class.md)   
 [unordered_set::equal_range](../vs140/unordered_set--equal_range.md)