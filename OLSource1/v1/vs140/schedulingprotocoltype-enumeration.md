---
title: "SchedulingProtocolType Enumeration"
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
  - "concrt/concurrency::SchedulingProtocolType"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SchedulingProtocolType enumeration"
ms.assetid: a4bb87b9-bec3-4918-bb06-1993c53e1069
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# SchedulingProtocolType Enumeration
Used by the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> policy to describe which scheduling algorithm will be utilized for the scheduler. For more information on available scheduler policies, see [PolicyElementKey Enumeration](../vs140/policyelementkey-enumeration.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Values  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|The scheduler prefers to round-robin through schedule groups after executing each task. Unblocked contexts are typically scheduled in a first-in-first-out (FIFO) fashion. Virtual processors do not cache unblocked contexts.|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|The scheduler prefers to continue to work on tasks within the current schedule group before moving to another schedule group. Unblocked contexts are cached per virtual-processor and are typically scheduled in a last-in-first-out (LIFO) fashion by the virtual processor which unblocked them.|  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [SchedulerPolicy Class](../vs140/schedulerpolicy-class.md)   
 [PolicyElementKey Enumeration](../vs140/policyelementkey-enumeration.md)