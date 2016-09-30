---
title: "message_status Enumeration"
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
  - "agents/concurrency::message_status"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "message_status enumeration"
ms.assetid: e5e05af0-734d-4063-ae32-f6356382f313
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# message_status Enumeration
The valid responses for an offer of a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object to a block.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Values  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|The target accepted the message.|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|The target did not accept the message.|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|The target tried to accept the message, but it was no longer available.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|The target postponed the message.|  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)