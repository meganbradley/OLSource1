---
title: "join_type Enumeration"
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
  - "agents/concurrency::join_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "join_type enumeration"
ms.assetid: 75b0a0a2-caad-444f-83f6-7faf61456e8b
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# join_type Enumeration
The type of a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> messaging block.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Values  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Greedy <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> messaging blocks immediately accept a message upon propagation. This is more efficient, but has the possibility for live-lock, depending on the network configuration.|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Non-greedy <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> messaging blocks postpone messages and try and consume them after all have arrived. These are guaranteed to work, but slower.|  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)