---
title: "allocator_traits::construct Method"
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
  - "memory/std::allocator_traits::construct"
dev_langs: 
  - "C++"
ms.assetid: 3b19ee5c-8e68-4ddb-97d7-51184c715987
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# allocator_traits::construct Method
Static method that uses a specified allocator to construct an object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 An allocator object.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to the location where the object is to be constructed.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A list of arguments that is passed to the object constructor.  
  
## Remarks  
 The static member function calls <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, if that expression is well formed; otherwise it evaluates <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
## See Also  
 [allocator::construct](../vs140/allocator--construct.md)   
 [allocator_traits Class](../vs140/allocator_traits-class.md)