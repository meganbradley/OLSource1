---
title: "front_inserter"
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
  - "std::front_inserter"
  - "front_inserter"
  - "iterator/std::front_inserter"
  - "std.front_inserter"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "front_inserter function"
  - "front_inserter"
ms.assetid: 236f3f00-77aa-47ba-9eff-c1c91e784172
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# front_inserter
Creates an iterator that can insert elements at the front of a specified container.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The container object whose front is having an element inserted.  
  
## Return Value  
 A <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> associated with the container object <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Remarks  
 The member function [front_insert_iterator](../vs140/front_insert_iterator--front_insert_iterator.md) of the front_insert_iterator class may also be used.  
  
 Within the Standard Template Library, the argument must refer to one of the two sequence containers that have the member function <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>: [deque Class](../vs140/deque-class.md) or [list Class](../vs140/list-class.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The list L is:**  
 **( -1 0 1 2 3 4 5 6 7 8 ).**  
**After the front insertions, the list L is:**  
 **( 200 100 -1 0 1 2 3 4 5 6 7 8 ).**   
## Requirements  
 **Header:** \<iterator>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)