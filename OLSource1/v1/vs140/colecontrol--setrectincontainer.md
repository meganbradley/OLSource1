---
title: "COleControl::SetRectInContainer"
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
  - "SetRectInContainer"
  - "COleControl.SetRectInContainer"
  - "COleControl::SetRectInContainer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetRectInContainer method"
ms.assetid: 443f3114-b5c8-4279-9baf-cb3735bd8ee2
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::SetRectInContainer
Sets the coordinates of the control's rectangle relative to the container, expressed in device units.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a rectangle containing the control's new coordinates relative to the container.  
  
## Return Value  
 Nonzero if the call was successful; otherwise 0.  
  
## Remarks  
 If the control is open, it is resized; otherwise the container's **OnPosRectChanged** function is called.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::GetRectInContainer](../vs140/colecontrol--getrectincontainer.md)   
 [COleControl::GetControlSize](../vs140/colecontrol--getcontrolsize.md)