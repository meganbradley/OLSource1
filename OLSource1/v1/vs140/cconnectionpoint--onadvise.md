---
title: "CConnectionPoint::OnAdvise"
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
  - "OnAdvise"
  - "CConnectionPoint::OnAdvise"
  - "CConnectionPoint.OnAdvise"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnAdvise method"
ms.assetid: 3d742fac-3f77-41a2-89b4-9ccf48e2bc72
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CConnectionPoint::OnAdvise
Called by the framework when a connection is being established or broken.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **TRUE**, if a connection is being established; otherwise **FALSE**.  
  
## Remarks  
 The default implementation does nothing.  
  
 Override this function if you want notification when sinks connect to or disconnect from your connection point.  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [CConnectionPoint Class](../vs140/cconnectionpoint-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)