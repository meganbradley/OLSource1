---
title: "allocator::allocate"
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
  - "std.allocator.allocate"
  - "allocate"
  - "allocator.allocate"
  - "allocator::allocate"
  - "std::allocator::allocate"
  - "memory/std::allocator::allocate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "allocate function"
ms.assetid: eef27be7-dc10-407c-b0e9-40daa8d0e940
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# allocator::allocate
Allocates a block of memory large enough to store at least some specified number of elements.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The number of elements for which sufficient storage is to be allocated.  
  
 *_Hint*  
 A const pointer that may assist the allocator object satisfy the request for storage by locating the address of an object allocated prior to the request.  
  
## Return Value  
 A pointer to the allocated object or null if memory was not allocated.  
  
## Remarks  
 The member function allocates storage for an array of count elements of type **Type**, by calling operator new(<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>). It returns a pointer to the allocated object. The hint argument helps some allocators in improving locality of reference; a valid choice is the address of an object earlier allocated by the same allocator object and not yet deallocated. To supply no hint, use a null pointer argument instead.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **0 1 2 3 4 5 6 7 8 9**    
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
## See Also  
 [allocator Class](../vs140/allocator-class.md)