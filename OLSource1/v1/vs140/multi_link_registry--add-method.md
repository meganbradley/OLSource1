---
title: "multi_link_registry::add Method"
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
  - "agents/concurrency::multi_link_registry::add"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "add method"
ms.assetid: d73dccf7-b650-461d-9fc2-31228b28749f
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multi_link_registry::add Method
Adds a link to the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to a block to be added.  
  
## Remarks  
 The method throws an [invalid_link_target](../vs140/invalid_link_target-class.md) exception if the link is already present in the registry, or if a bound has already been set with the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> function and a link has since been removed.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [multi_link_registry Class](../vs140/multi_link_registry-class.md)