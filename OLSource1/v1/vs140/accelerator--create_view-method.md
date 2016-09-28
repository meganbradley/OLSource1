---
title: "accelerator::create_view Method"
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
  - "amprt/Concurrency::accelerator::create_view"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "create_view method"
ms.assetid: 8f405e0f-74c0-4868-8a22-ab6cbde72598
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# accelerator::create_view Method
Creates and returns an `accelerator_view` object on this accelerator, using the specified queuing mode. When the queuing mode is not specified, the new `accelerator_view` uses the [queuing_mode::immediate](../vs140/queuing_mode-enumeration.md) queuing mode.  
  
## Syntax  
  
```  
accelerator_view create_view(  
   queuing_mode qmode = queuing_mode_automatic  
);  
```  
  
#### Parameters  
 `qmode`  
 The queuing mode.  
  
## Return Value  
 A new `accelerator_view` object on this accelerator, using the specified queuing mode.  
  
## Requirements  
 **Header:** amprt.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [accelerator Class](../vs140/accelerator-class.md)   
 [accelerator_view](../vs140/accelerator_view-class.md)