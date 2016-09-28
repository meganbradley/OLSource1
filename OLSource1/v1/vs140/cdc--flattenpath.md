---
title: "CDC::FlattenPath"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "FlattenPath"
  - "CDC::FlattenPath"
  - "CDC.FlattenPath"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FlattenPath method"
  - "CDC class, path functions"
ms.assetid: b37b47f9-c6c5-4da6-bd73-ea42a631a7fa
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::FlattenPath
Transforms any curves in the path selected into the current device context, and turns each curve into a sequence of lines.  
  
## Syntax  
  
```  
  
BOOL FlattenPath( );  
```  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::WidenPath](../vs140/cdc--widenpath.md)