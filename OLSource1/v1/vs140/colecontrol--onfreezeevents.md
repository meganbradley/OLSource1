---
title: "COleControl::OnFreezeEvents"
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
  - "OnFreezeEvents"
  - "COleControl::OnFreezeEvents"
  - "COleControl.OnFreezeEvents"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnFreezeEvents method"
ms.assetid: 459a3116-a55e-4707-b691-3575126fbb8d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::OnFreezeEvents
Called by the framework after the container calls **IOleControl::FreezeEvents**.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **TRUE** if the control's event handling is frozen; otherwise **FALSE**.  
  
## Remarks  
 The default implementation does nothing.  
  
 Override this function if you want additional behavior when event handling is frozen or unfrozen.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)