---
title: "target_block::remove_sources Method"
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
  - "agents/concurrency::target_block::remove_sources"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "remove_sources method"
ms.assetid: d03b7174-9f59-47d0-ad4e-35338e70d023
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# target_block::remove_sources Method
Unlinks all sources after waiting for outstanding asynchronous send operations to complete.  
  
## Syntax  
  
```  
void remove_sources();  
```  
  
## Remarks  
 All target blocks should call this routine to remove the sources in their destructor.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [target_block Class](../VS_csharp/target_block-class.md)