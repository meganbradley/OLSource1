---
title: "COleControl::SetControlSize"
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
  - "COleControl::SetControlSize"
  - "SetControlSize"
  - "COleControl.SetControlSize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetControlSize method"
ms.assetid: 87b0b3bc-12dd-4c10-98fa-32c67c7bcfa7
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::SetControlSize
Sets the size of the OLE control window and notifies the container that the control site is changing.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the new width of the control in pixels.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the new height of the control in pixels.  
  
## Return Value  
 Nonzero if the call was successful; otherwise 0.  
  
## Remarks  
 This function should not be used in your control's constructor.  
  
 Note that all coordinates for control windows are relative to the upper-left corner of the control.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::GetControlSize](../vs140/colecontrol--getcontrolsize.md)   
 [COleControl::GetRectInContainer](../vs140/colecontrol--getrectincontainer.md)