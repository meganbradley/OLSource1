---
title: "CConnectionPoint::GetContainer"
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
  - "GetContainer"
  - "CConnectionPoint.GetContainer"
  - "CConnectionPoint::GetContainer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetContainer method"
ms.assetid: bdc5322c-475c-407f-9a54-c2cef6892c14
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CConnectionPoint::GetContainer
Called by the framework to retrieve the **IConnectionPointContainer** for the connection point.  
  
## Syntax  
  
```  
  
virtual LPCONNECTIONPOINTCONTAINER GetContainer();  
```  
  
## Return Value  
 If successful, a pointer to the container; otherwise **NULL**.  
  
## Remarks  
 This function is typically implemented by the `BEGIN_CONNECTION_PART` macro.  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [CConnectionPoint Class](../vs140/cconnectionpoint-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [BEGIN_CONNECTION_PART](../vs140/begin_connection_part.md)