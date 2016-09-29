---
title: "COleControl::ReleaseCapture"
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
  - "COleControl::ReleaseCapture"
  - "COleControl.ReleaseCapture"
  - "ReleaseCapture"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ReleaseCapture method"
ms.assetid: 57555bc0-6a01-43f2-9932-ac1e164e1967
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::ReleaseCapture
Releases mouse capture.  
  
## Syntax  
  
```  
  
BOOL ReleaseCapture( );  
```  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 If the control currently has the mouse capture, the capture is released. Otherwise, this function has no effect.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::SetCapture](../vs140/colecontrol--setcapture.md)   
 [COleControl::GetCapture](../vs140/colecontrol--getcapture.md)