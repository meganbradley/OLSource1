---
title: "multimap::begin"
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
  - "std.multimap.begin"
  - "multimap::begin"
  - "begin"
  - "std::multimap::begin"
  - "multimap.begin"
  - "map/std::multimap::begin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "begin method, with specific classes"
ms.assetid: fb15df1a-076e-44e4-8a29-0e9cb9e512d5
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multimap::begin
Returns an iterator addressing the first element in the multimap.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A bidirectional iterator addressing the first element in the multimap or the location succeeding an empty multimap.  
  
## Remark  
 If the return value of **begin** is assigned to a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, the elements in the multimap object cannot be modified. If the return value of **begin** is assigned to an **iterator**, the elements in the multimap object can be modified.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The first element of m1 is 0**  
**First element of m1 is now 1**   
## Requirements  
 **Header:** \<map>  
  
 **Namespace:** std  
  
## See Also  
 [multimap Class](../vs140/multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)