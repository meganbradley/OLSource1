---
title: "single_assignment::value Method"
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
  - "agents/concurrency::single_assignment::value"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "value method"
ms.assetid: d19aefe6-689a-4d67-8c6d-6d58e0f3a9b2
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# single_assignment::value Method
Gets a reference to the current payload of the message being stored in the `single_assignment` messaging block.  
  
## Syntax  
  
```  
_Type const & value();  
```  
  
## Return Value  
 The payload of the stored message.  
  
## Remarks  
 This method will wait until a message arrives if no message is currently stored in the `single_assignment` messaging block.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [single_assignment Class](../vs140/single_assignment-class.md)