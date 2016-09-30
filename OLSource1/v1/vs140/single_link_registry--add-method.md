---
title: "single_link_registry::add Method"
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
  - "agents/concurrency::single_link_registry::add"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "add method"
ms.assetid: ccafd9a9-1cf3-4754-b357-6e2ee4d14f40
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# single_link_registry::add Method
Adds a link to the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to a block to be added.  
  
## Remarks  
 The method throws an [invalid_link_target](../vs140/invalid_link_target-class.md) exception if there is already a link in this registry.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [single_link_registry Class](../vs140/single_link_registry-class.md)