---
title: "COleControl::GetClientRect"
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
  - "COleControl::GetClientRect"
  - "COleControl.GetClientRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetClientRect method"
ms.assetid: 396a8c98-e63e-4245-8ef6-cd91e25952ec
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::GetClientRect
Retrieves the size of the control's client area.  
  
## Syntax  
  
```  
  
      virtual void GetClientRect(  
   LPRECT lpRect   
) const;  
```  
  
#### Parameters  
 `lpRect`  
 Pointer to a `RECT` structure containing the dimensions of the windowless control's client area; that is, the control's size minus window borders, frames, scroll bars, and so on. The `lpRect` parameter indicates the size of the control's client rectangle, not its position.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)