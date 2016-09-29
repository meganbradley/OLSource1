---
title: "pointer_traits::pointer_to Method"
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
  - "memory/std::pointer_traits::pointer_to"
dev_langs: 
  - "C++"
ms.assetid: 4fb4c986-8e68-40e9-914e-1d8b10163775
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# pointer_traits::pointer_to Method
Static method that returns `Ptr::pointer_to(obj)`, if that function exists. Otherwise, it is not possible to convert an arbitrary reference to an object of class `Ptr`. If `Ptr` is a raw pointer, this method returns `addressof(obj)`.  
  
## Syntax  
  
```cpp  
static pointer pointer_to(element_type& obj);  
```  
  
## Requirements  
 **Header:** <memory\>  
  
 **Namespace:** std  
  
## See Also  
 [pointer_traits Struct](../vs140/pointer_traits-struct.md)