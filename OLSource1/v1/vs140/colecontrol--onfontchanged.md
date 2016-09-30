---
title: "COleControl::OnFontChanged"
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
  - "OnFontChanged"
  - "COleControl::OnFontChanged"
  - "COleControl.OnFontChanged"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnFontChanged method"
ms.assetid: 91a5fda5-d04f-48fd-bb6d-f0d0cb2d732d
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::OnFontChanged
Called by the framework when the stock Font property value has changed.  
  
## Syntax  
  
```  
  
virtual void OnFontChanged( );  
```  
  
## Remarks  
 The default implementation calls `COleControl::InvalidateControl`. If the control is subclassing a Windows control, the default implementation also sends a **WM_SETFONT** message to the control's window.  
  
 Override this function if you want notification after this property changes.  
  
## Example  
 [!code[NVC_MFCAxCtl#6](../vs140/codesnippet/CPP/colecontrol--onfontchanged_1.cpp)]  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::GetFont](../vs140/colecontrol--getfont.md)   
 [COleControl::InternalGetFont](../vs140/colecontrol--internalgetfont.md)   
 [COleControl::InvalidateControl](../vs140/colecontrol--invalidatecontrol.md)