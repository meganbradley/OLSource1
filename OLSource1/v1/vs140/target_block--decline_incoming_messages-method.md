---
title: "target_block::decline_incoming_messages Method"
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
  - "agents/concurrency::target_block::decline_incoming_messages"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "decline_incoming_messages method"
ms.assetid: eac8f71a-0e19-4e09-86b4-fe6b8bdcd2d7
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# target_block::decline_incoming_messages Method
Indicates to the block that new messages should be declined.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 This method is called by the destructor to ensure that new messages are declined while destruction is in progress.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [target_block Class](../vs140/target_block-class.md)