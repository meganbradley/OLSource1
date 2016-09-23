---
title: "ITarget::supports_anonymous_source Method"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - agents/concurrency::ITarget::supports_anonymous_source
dev_langs: 
  - C++
helpviewer_keywords: 
  - supports_anonymous_source method
ms.assetid: 124b2eb1-fb15-4db8-b3eb-99ad89589e27
caps.latest.revision: 10
translation.priority.ht: 
  - de-de
  - ja-jp
---
# ITarget::supports_anonymous_source Method
When overridden in a derived class, returns true or false depending on whether the message block accepts messages offered by a source that is not linked to it. If the overridden method returns `true`, the target cannot postpone an offered message, as consumption of a postponed message at a later time requires the source to be identified in its sourse link registry.  
  
## Syntax  
  
```  
virtual bool supports_anonymous_source();  
```  
  
## Return Value  
 `true` if the block can accept message from a source that is not linked to it `false` otherwise.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [ITarget Class](../vs140/itarget-class.md)