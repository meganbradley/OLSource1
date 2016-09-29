---
title: "COleControl::FireDblClick"
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
  - "COleControl::FireDblClick"
  - "FireDblClick"
  - "COleControl.FireDblClick"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FireDblClick method"
ms.assetid: 6608cb8c-1bde-4ea1-aa00-7c0ee20a4c79
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::FireDblClick
Called by the framework when the mouse is double-clicked over an active control.  
  
## Syntax  
  
```  
  
void FireDblClick( );  
```  
  
## Remarks  
 If this event is defined as a custom event, you determine when the event is fired.  
  
 For automatic firing of a DblClick event to occur, the control's Event map must have a stock DblClick event defined.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::FireClick](../vs140/colecontrol--fireclick.md)   
 [COleControl::FireMouseDown](../vs140/colecontrol--firemousedown.md)   
 [COleControl::FireMouseUp](../vs140/colecontrol--firemouseup.md)