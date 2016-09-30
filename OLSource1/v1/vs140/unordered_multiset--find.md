---
title: "unordered_multiset::find"
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
  - "unordered_multiset.find"
  - "unordered_set/std::tr1::unordered_multiset::find"
  - "unordered_multiset::find"
  - "std.tr1.unordered_multiset.find"
  - "std::tr1::unordered_multiset::find"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "find method [TR1]"
ms.assetid: 8acbcfca-24d5-4d88-b58d-12dad1f0cac9
caps.latest.revision: 20
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# unordered_multiset::find
Finds an element that matches a specified key.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Key value to search for.  
  
## Remarks  
 The member function returns [equal_range](../vs140/unordered_multiset--equal_range.md)<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
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
 [unordered_multiset](../vs140/unordered_multiset-class.md)   
 [unordered_multiset::equal_range](../vs140/unordered_multiset--equal_range.md)