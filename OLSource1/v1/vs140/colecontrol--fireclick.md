---
title: "COleControl::FireClick"
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
  - "COleControl.FireClick"
  - "FireClick"
  - "COleControl::FireClick"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FireClick method"
ms.assetid: 9f9e490d-eb6e-49c9-8ca7-b2f9a166a2ed
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::FireClick
Called by the framework when the mouse is clicked over an active control.  
  
## Syntax  
  
```  
  
void FireClick( );  
```  
  
## Remarks  
 If this event is defined as a custom event, you determine when the event is fired.  
  
 For automatic firing of a Click event to occur, the control's Event map must have a stock Click event defined.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::FireDblClick](../vs140/colecontrol--firedblclick.md)   
 [COleControl::FireMouseDown](../vs140/colecontrol--firemousedown.md)   
 [COleControl::FireMouseUp](../vs140/colecontrol--firemouseup.md)