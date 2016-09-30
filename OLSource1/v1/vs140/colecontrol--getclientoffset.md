---
title: "COleControl::GetClientOffset"
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
  - "COleControl::GetClientOffset"
  - "GetClientOffset"
  - "COleControl.GetClientOffset"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetClientOffset method"
ms.assetid: 4b52e200-7d08-49c7-8bae-b3f5db9c87cb
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::GetClientOffset
Retrieves the difference between the upper left corner of the control's rectangular area and the upper left corner of its client area.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *pdxOffset*  
 Pointer to the horizontal offset of the OLE control's client area.  
  
 *pdyOffset*  
 Pointer to the vertical offset of the OLE control's client area.  
  
## Remarks  
 The OLE control has a rectangular area within its container. The client area of the control is the control area excluding borders and scroll bars. The offset retrieved by <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is the difference between the upper left corner of the control's rectangular area and the upper left corner of its client area. If your control has non-client elements other than the standard borders and scrollbars, override this member function to specify the offset.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::ParentToClient](../vs140/colecontrol--parenttoclient.md)   
 [COleControl::ClientToParent](../vs140/colecontrol--clienttoparent.md)