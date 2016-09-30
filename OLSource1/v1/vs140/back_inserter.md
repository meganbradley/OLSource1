---
title: "back_inserter"
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
  - "std.back_inserter"
  - "std::back_inserter"
  - "iterator/std::back_inserter"
  - "back_inserter"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "back_inserter function"
  - "back_inserter"
ms.assetid: e7744787-699f-4dd9-b776-f7ad22116e0d
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# back_inserter
Creates an iterator that can insert elements at the back of a specified container.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The container into which the back insertion is to be executed.  
  
## Return Value  
 A <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> associated with the container object <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Remarks  
 Within the Standard Template Library, the argument must refer to one of the three sequence containers that have the member function <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>: [deque Class](../vs140/deque-class.md), [list Class](../vs140/list-class.md), or [vector Class](../vs140/vector-class.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The initial vector vec is: ( 0 1 2 ).**  
**After the insertions, the vector vec is: ( 0 1 2 30 40 500 600 ).**   
## Requirements  
 **Header:** \<iterator>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)