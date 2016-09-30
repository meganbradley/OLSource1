---
title: "freelist::pop"
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
  - "stdext.freelist.pop"
  - "freelist::pop"
  - "freelist.pop"
  - "stdext::freelist::pop"
  - "allocators/stdext::freelist::pop"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "pop method"
ms.assetid: b9ca6e37-d996-455d-b44b-cbd8903bc316
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# freelist::pop
Removes the first memory block from the free list.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Returns a pointer to the memory block removed from the list.  
  
## Remarks  
 The member function returns <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> if the list is empty. Otherwise, it removes the first memory block from the list.  
  
## Requirements  
 **Header:** \<allocators>  
  
 **Namespace:** stdext  
  
## See Also  
 [freelist Class](../vs140/freelist-class.md)