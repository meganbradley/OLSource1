---
title: "allocator_newdel Class"
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
  - "allocators::allocator_newdel"
  - "allocators/stdext::allocators::allocator_newdel"
  - "stdext.allocators.allocator_newdel"
  - "allocators/stdext::allocator_newdel"
  - "allocator_newdel"
  - "stdext::allocators::allocator_newdel"
  - "allocators.allocator_newdel"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "allocator_newdel class"
ms.assetid: 62666cd2-3afe-49f7-9dd1-9bbbb154da98
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# allocator_newdel Class
Implements an allocator that uses <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> to deallocate a memory block and <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to allocate a memory block.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|The type of elements allocated by the allocator.|  
  
## Remarks  
 The [ALLOCATOR_DECL](../vs140/-allocators--functions.md#allocator_decl) macro passes this class as the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> parameter in the following statement: <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** \<allocators>  
  
 **Namespace:** stdext  
  
## See Also  
 [\<allocators>](../vs140/-allocators-.md)