---
title: "declare_reachable"
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
  - "memory/std::declare_reachable"
  - "std::declare_reachable"
  - "declare_reachable"
  - "std.declare_reachable"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "declare_reachable"
  - "declare_reachable function"
ms.assetid: 9a02670f-f8ca-4581-8f8b-f0510830d5a5
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# declare_reachable
Informs garbage collection that the indicated address is to allocated storage and is reachable.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a reachable, allocated, valid storage area.  
  
## Remarks  
 If <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is not null, the function informs any garbage collector that <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is hereafter reachable (points to valid allocated storage).  
  
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
## See Also  
 [\<memory>](../vs140/-memory-.md)