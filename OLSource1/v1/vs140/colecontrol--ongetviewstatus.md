---
title: "COleControl::OnGetViewStatus"
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
  - "COleControl::OnGetViewStatus"
  - "OnGetViewStatus"
  - "COleControl.OnGetViewStatus"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnGetViewStatus method"
ms.assetid: 36eb5169-41b3-49ad-bafb-e2fbbc74ad6a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::OnGetViewStatus
Called by the framework in response to a container's **IViewObjectEx::GetViewStatus** request.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 One of the values of the **VIEWSTATUS** enumeration if successful; otherwise 0. Possible values are any combination of the following:  
  
 **VIEWSTATUS_OPAQUE**  
 Object is completely opaque. If this bit is not set, the object contains transparent parts. This bit applies only to content-related aspects and not to <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 **VIEWSTATUS_SOLIDBKGND**  
 Object has a solid background (consisting in a solid color, not a brush pattern). This bit is meaningful only if **VIEWSTATUS_OPAQUE** is set and applies only to content-related aspects and not to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 **VIEWSTATUS_DVASPECTOPAQUE**  
 Object supports **DVASPECT_OPAQUE**. All **IViewObjectEx** methods that take a drawing aspect as a parameter can be called with this aspect.  
  
 **VIEWSTATUS_DVASPECTTRANSPARENT**  
 Object supports **DVASPECT_TRANSPARENT**. All **IViewObjectEx** methods that take a drawing aspect as a parameter can be called with this aspect.  
  
## Remarks  
 Override this function if your control uses two-pass drawing. The default implementation returns **VIEWSTATUS_OPAQUE**.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [DVASPECT](http://msdn.microsoft.com/library/windows/desktop/ms690318)