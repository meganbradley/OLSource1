---
title: "ordered_message_processor::~ordered_message_processor Destructor"
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
  - "agents/concurrency::ordered_message_processor::~ordered_message_processor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "~ordered_message_processor, destructor"
ms.assetid: e1b432ba-41ef-4212-a60c-98409f78a34e
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ordered_message_processor::~ordered_message_processor Destructor
Destroys the `ordered_message_processor` object.  
  
## Syntax  
  
```  
virtual ~ordered_message_processor();  
```  
  
## Remarks  
 Waits for all outstanding asynchronous operations before destroying the processor.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [ordered_message_processor Class](../VS_csharp/ordered_message_processor-class.md)