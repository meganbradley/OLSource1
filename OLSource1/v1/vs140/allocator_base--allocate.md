---
title: "allocator_base::allocate"
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
  - "allocators/stdext::allocators::allocator_base::allocate"
  - "allocators.allocator_base.allocate"
  - "allocate"
  - "allocators::allocator_base::allocate"
  - "allocators/stdext::allocator_base::allocate"
  - "allocator_base::allocate"
  - "allocator_base.allocate"
  - "stdext::allocators::allocator_base::allocate"
  - "stdext.allocators.allocator_base.allocate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "allocate method"
ms.assetid: d04e4bbb-e1c2-4291-be64-057cbbc6cae8
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# allocator_base::allocate
Allocates a block of memory large enough to store at least some specified number of elements.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|The number of elements in the array to be allocated.|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|This parameter is ignored.|  
  
## Return Value  
 A pointer to the allocated object.  
  
## Remarks  
 The member function implements memory allocation for the user-defined allocator by returning the result of a call to the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> function of the synchronization filter of type Type<CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, otherwise by returning the result of a call to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> cast to type Type<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<allocators>  
  
 **Namespace:** stdext  
  
## See Also  
 [allocator_base](../vs140/allocator_base-class.md)