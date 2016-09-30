---
title: "allocator::deallocate"
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
  - "std.allocator.deallocate"
  - "memory/std::allocator::deallocate"
  - "deallocate"
  - "allocator::deallocate"
  - "std::allocator::deallocate"
  - "allocator.deallocate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "deallocate method"
ms.assetid: 8228bf56-a124-466a-86a6-567e7f46a778
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# allocator::deallocate
Frees a specified number of objects from storage beginning at a specified position.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to the first object to be deallocated from storage.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The number of objects to be deallocated from storage.  
  
## Remarks  
 The member function frees storage for the array of count objects of type **Type** beginning at <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, by calling <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>(<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>). The pointer <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> must have been returned earlier by a call to [allocate](../vs140/allocator--allocate.md) for an allocator object that compares equal to **\*this**, allocating an array object of the same size and type. <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> never throws an exception.  
  
## Example  
 For an example using the member function, see [allocator::allocate](../vs140/allocator--allocate.md).  
  
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
## See Also  
 [allocator Class](../vs140/allocator-class.md)