---
title: "source_block::wait_for_outstanding_async_sends Method"
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
  - "agents/concurrency::source_block::wait_for_outstanding_async_sends"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "wait_for_outstanding_async_sends method"
ms.assetid: 1f8ca2c1-e2bb-4318-b569-2eafa6fb7a27
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# source_block::wait_for_outstanding_async_sends Method
Waits for all asynchronous propagations to complete. This propagator-specific spin wait is used in destructors of message blocks to make sure that all asynchronous propagations have time to finish before destroying the block.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [source_block Class](../vs140/source_block-class.md)