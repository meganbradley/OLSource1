---
title: "CFrameWnd::OnSetPreviewMode"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CFrameWnd.OnSetPreviewMode
  - OnSetPreviewMode
  - CFrameWnd::OnSetPreviewMode
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnSetPreviewMode method
  - CFrameWnd class, overridables
ms.assetid: da27d6b0-94ec-4d8b-ab3a-672e571cc65e
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CFrameWnd::OnSetPreviewMode
Call this member function to set the application's main frame window into and out of print-preview mode.  
  
## Syntax  
  
```  
  
      virtual void OnSetPreviewMode(  
   BOOL bPreview,  
   CPrintPreviewState* pState   
);  
```  
  
#### Parameters  
 *bPreview*  
 Specifies whether or not to place the application in print-preview mode. Set to **TRUE** to place in print preview, **FALSE** to cancel preview mode.  
  
 `pState`  
 A pointer to a **CPrintPreviewState** structure.  
  
## Remarks  
 The default implementation disables all standard toolbars and hides the main menu and the main client window. This turns MDI frame windows into temporary SDI frame windows.  
  
 Override this member function to customize the hiding and showing of control bars and other frame window parts during print preview. Call the base class implementation from within the overridden version.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CFrameWnd Class](../vs140/cframewnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)