---
title: "COleControl::OnSetObjectRects"
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
  - "OnSetObjectRects"
  - "COleControl::OnSetObjectRects"
  - "COleControl.OnSetObjectRects"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnSetObjectRects method"
ms.assetid: 19a57b88-aa17-4e43-a7f5-aed4c226939a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::OnSetObjectRects
Called by the framework to implement a call to [IOleInPlaceObject::SetObjectRects](http://msdn.microsoft.com/library/windows/desktop/ms683767).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *lpRectPos*  
 A pointer to a [RECT](../vs140/rect-structure.md) structure indicating the control's new position and size relative to the container.  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> structure indicating a rectangular area to which the control is to be clipped.  
  
## Return Value  
 Nonzero if the repositioning was accepted; otherwise 0.  
  
## Remarks  
 The default implementation automatically handles the repositioning and resizing of the control window and returns **TRUE**.  
  
 Override this function to alter the default behavior of this function.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)