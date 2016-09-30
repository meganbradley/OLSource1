---
title: "ALLOCATOR_DECL (&lt;allocators&gt;)"
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
  - "stdext::ALLOCATOR_DECL"
  - "ALLOCATOR_DECL"
  - "stdext.ALLOCATOR_DECL"
  - "allocators/stdext::ALLOCATOR_DECL"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ALLOCATOR_DECL macro"
ms.assetid: 419d0f0a-aaa8-444a-a166-0ec85c432a64
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ALLOCATOR_DECL (&lt;allocators&gt;)
Yields an allocator template class.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The macro yields a template definition <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and a specialization <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> which together define an allocator template class that uses the synchronization filter <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and a cache of type <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 For compilers that can compile rebind, the resulting template definition looks like this:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 For compilers that cannot compile rebind the resulting template definition looks like this:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<allocators>  
  
 **Namespace:** stdext  
  
## See Also  
 [\<allocators>](../vs140/-allocators-.md)