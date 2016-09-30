---
title: "allocator_traits::select_on_container_copy_construction Method"
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
  - "memory/std::allocator_traits::select_on_copy_container_construction"
dev_langs: 
  - "C++"
ms.assetid: 0491defb-742e-40df-a088-96053091abd0
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# allocator_traits::select_on_container_copy_construction Method
Static method that calls <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> on the specified allocator.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An allocator object.  
  
## Return Value  
 This method returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, if that type is well formed; otherwise it returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Remarks  
 This method is used to specify an allocator when the associated container is copy-constructed.  
  
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
## See Also  
 [allocator_traits Class](../vs140/allocator_traits-class.md)