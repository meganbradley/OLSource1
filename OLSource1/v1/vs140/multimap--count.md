---
title: "multimap::count"
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
  - "multimap.count"
  - "multimap::count"
  - "std.multimap.count"
  - "std::multimap::count"
  - "count"
  - "map/std::multimap::count"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "count method"
ms.assetid: a7041f78-33ca-4f4a-9d57-967fdfbfc8f5
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multimap::count
Returns the number of elements in a multimap whose keys match a parameter-specified key.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The key of the elements to be matched from the multimap.  
  
## Return Value  
 The number of elements whose sort keys match the parameter key; 0 if the multimap doesn't contain an element with a matching key.  
  
## Remarks  
 The member function returns the number of elements in the range  
  
 [<CodeContentPlaceHolder>3\</CodeContentPlaceHolder> (_*Key* ), <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> (\_*Key* ) )  
  
 that have a key value <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Example  
 The following example demonstrates the use of the multimap::count member function.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The number of elements in m1 with a sort key of 1 is: 2.**  
**The number of elements in m1 with a sort key of 2 is: 2.**  
**The number of elements in m1 with a sort key of 3 is: 0.**   
## Requirements  
 **Header:** \<map>  
  
 **Namespace:** std  
  
## See Also  
 [multimap Class](../vs140/multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)