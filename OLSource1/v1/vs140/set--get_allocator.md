---
title: "set::get_allocator"
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
  - "std.set.get_allocator"
  - "set/std::set::get_allocator"
  - "get_allocator"
  - "std::set::get_allocator"
  - "set.get_allocator"
  - "set::get_allocator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "get_allocator method"
ms.assetid: 276f8a19-5f63-47ce-ba3c-cefb0d74aa3a
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# set::get_allocator
Returns a copy of the allocator object used to construct the set.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The allocator used by the set to manage memory, which is the template parameter <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 For more information on <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, see the Remarks section of the [set Class](../vs140/set-class.md) topic.  
  
## Remarks  
 Allocators for the set class specify how the class manages storage. The default allocators supplied with STL container classes is sufficient for most programming needs. Writing and using your own allocator class is an advanced C++ topic.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Sample Output  
 The following output is for x86.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<set>  
  
 **Namespace:** std  
  
## See Also  
 [set Class](../vs140/set-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)