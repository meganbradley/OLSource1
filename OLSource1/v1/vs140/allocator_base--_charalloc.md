---
title: "allocator_base::_Charalloc"
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
  - "stdext.allocator_base._Charalloc"
  - "stdext::allocator_base::_Charalloc"
  - "allocators/stdext::allocator_base::_Charalloc"
  - "allocator_base._Charalloc"
  - "allocator_base::_Charalloc"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "_Charalloc method"
ms.assetid: be045d89-f566-42ab-aece-281f1ef81323
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# allocator_base::_Charalloc
Allocates storage for an array of type <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|The number of elements in the array to be allocated.|  
  
## Return Value  
 A pointer to the allocated object.  
  
## Remarks  
 This member function is used by containers when compiled with a compiler that cannot compile rebind. It implements <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> for the user-defined allocator by returning the result of a call to the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> function of the synchronization filter.  
  
## Requirements  
 **Header:** \<allocators>  
  
 **Namespace:** stdext  
  
## See Also  
 [allocator_base Class](../vs140/allocator_base-class.md)