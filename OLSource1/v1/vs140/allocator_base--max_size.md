---
title: "allocator_base::max_size"
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
  - "allocator_base::max_size"
  - "stdext.allocator_base.max_size"
  - "allocators/stdext::allocator_base::max_size"
  - "allocator_base.max_size"
  - "stdext::allocator_base::max_size"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "max_size method"
ms.assetid: 4739f5fa-42f4-4c19-954c-4e4e9c350e0d
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# allocator_base::max_size
Returns the number of elements of type <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> that could be allocated by an object of class allocator before the free memory is used up.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The number of elements that could be allocated.  
  
## Remarks  
 This member function is implemented for the user-defined allocator by returning <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, otherwise <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<allocators>  
  
 **Namespace:** stdext  
  
## See Also  
 [allocator_base Class](../vs140/allocator_base-class.md)