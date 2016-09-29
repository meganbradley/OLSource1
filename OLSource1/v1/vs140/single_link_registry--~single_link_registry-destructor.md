---
title: "single_link_registry::~single_link_registry Destructor"
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
  - "agents/concurrency::single_link_registry::~single_link_registry"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "~single_link_registry, destructor"
ms.assetid: 33410fa9-c4f2-40e0-b604-93b993601d1b
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# single_link_registry::~single_link_registry Destructor
Destroys the `single_link_registry` object.  
  
## Syntax  
  
```  
virtual ~single_link_registry();  
```  
  
## Remarks  
 The method throws an [invalid_operation](../vs140/invalid_operation-class.md) exception if it is called before the link is removed.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [single_link_registry Class](../vs140/single_link_registry-class.md)