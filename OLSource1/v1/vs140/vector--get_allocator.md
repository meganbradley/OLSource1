---
title: "vector::get_allocator"
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
  - "std::vector::get_allocator"
  - "vector.get_allocator"
  - "get_allocator"
  - "vector::get_allocator"
  - "std.vector.get_allocator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "get_allocator method"
ms.assetid: 1570bc99-914a-486b-8846-fb0a6ed289a4
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# vector::get_allocator
Returns a copy of the allocator object used to construct the vector.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The allocator used by the vector.  
  
## Remarks  
 Allocators for the vector class specify how the class manages storage. The default allocators supplied with STL container classes are sufficient for most programming needs. Writing and using your own allocator class is an advanced C++ topic.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<vector>  
  
 **Namespace:** std  
  
## See Also  
 [vector Class](../vs140/vector-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)