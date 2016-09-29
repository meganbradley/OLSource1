---
title: "CConnectionPoint::GetMaxConnections"
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
  - "GetMaxConnections"
  - "CConnectionPoint.GetMaxConnections"
  - "CConnectionPoint::GetMaxConnections"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetMaxConnections method"
ms.assetid: f334d23e-b637-4281-a128-5e55d2b79d1a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CConnectionPoint::GetMaxConnections
Called by the framework to retrieve the maximum number of connections supported by the connection point.  
  
## Syntax  
  
```  
  
virtual int GetMaxConnections( );  
```  
  
## Return Value  
 The maximum number of connections supported by the control, or -1 if no limit.  
  
## Remarks  
 The default implementation returns -1, indicating no limit.  
  
 Override this function if you want to limit the number of sinks that can connect to your control.  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [CConnectionPoint Class](../vs140/cconnectionpoint-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CConnectionPoint::GetConnections](../vs140/cconnectionpoint--getconnections.md)