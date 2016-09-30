---
title: "allocator_traits::destroy Method"
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
  - "memory/std::allocator_traits::destroy"
dev_langs: 
  - "C++"
ms.assetid: c2569333-4212-461f-b0b5-9e01ea37ada5
caps.latest.revision: 8
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# allocator_traits::destroy Method
Static method that uses a specified allocator to call the destructor on an object without deallocating its memory.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 An allocator object.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to the location of the object.  
  
## Remarks  
 This method calls <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, if that expression is well formed; otherwise it evaluates <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
## See Also  
 [allocator::destroy](../vs140/allocator--destroy.md)   
 [allocator_traits Class](../vs140/allocator_traits-class.md)