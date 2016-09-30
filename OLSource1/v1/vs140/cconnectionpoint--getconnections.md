---
title: "CConnectionPoint::GetConnections"
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
  - "CConnectionPoint::GetConnections"
  - "GetConnections"
  - "CConnectionPoint.GetConnections"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetConnections method"
ms.assetid: a92da2f3-e0a4-4ed0-b503-ba4d54352783
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CConnectionPoint::GetConnections
Call this function to retrieve all active connections for a connection point.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A pointer to an array of active connections (sinks). Some of the pointers in the array may be NULL. Each non-NULL pointer in this array can be safely converted to a pointer to the sink interface using a cast operator.  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [CConnectionPoint Class](../vs140/cconnectionpoint-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CConnectionPoint::GetMaxConnections](../vs140/cconnectionpoint--getmaxconnections.md)