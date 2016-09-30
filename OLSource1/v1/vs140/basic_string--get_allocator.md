---
title: "basic_string::get_allocator"
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
  - "get_allocator"
  - "std.basic_string.get_allocator"
  - "basic_string.get_allocator"
  - "basic_string::get_allocator"
  - "std::basic_string::get_allocator"
  - "xstring/std::basic_string::get_allocator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "get_allocator method"
ms.assetid: 9c292a69-8650-4ff6-85af-193679ee3cb4
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_string::get_allocator
Returns a copy of the allocator object used to construct the string.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The allocator used by the string.  
  
## Remarks  
 The member function returns the stored allocator object.  
  
 Allocators for the string class specify how the class manages storage. The default allocators supplied with container classes are sufficient for most programming needs. Writing and using your own allocator class is an advanced C++ topic.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [basic_string Class](../vs140/basic_string-class.md)