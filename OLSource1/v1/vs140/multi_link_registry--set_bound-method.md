---
title: "multi_link_registry::set_bound Method"
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
  - "agents/concurrency::multi_link_registry::set_bound"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "set_bound method"
ms.assetid: cc5eee15-6575-48e7-89de-abdb08753020
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multi_link_registry::set_bound Method
Sets an upper bound on the number of links that the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object can hold.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The maximum number of links that the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object can hold.  
  
## Remarks  
 After a bound is set, unlinking an entry will cause the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object to enter an immutable state where further calls to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> will throw an <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> exception.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [multi_link_registry Class](../vs140/multi_link_registry-class.md)