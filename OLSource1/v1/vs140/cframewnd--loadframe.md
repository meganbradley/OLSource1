---
title: "CFrameWnd::LoadFrame"
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
  - CFrameWnd.LoadFrame
  - LoadFrame
  - CFrameWnd::LoadFrame
dev_langs: 
  - C++
helpviewer_keywords: 
  - LoadFrame method
  - CFrameWnd class, initialization
ms.assetid: 60a7ac19-a640-4e72-9682-0bb51da5d80b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CFrameWnd::LoadFrame
Call to dynamically create a frame window from resource information.  
  
## Syntax  
  
```  
  
      virtual BOOL LoadFrame(  
   UINT nIDResource,  
   DWORD dwDefaultStyle = WS_OVERLAPPEDWINDOW | FWS_ADDTOTITLE,  
   CWnd* pParentWnd = NULL,  
   CCreateContext* pContext = NULL   
);  
```  
  
#### Parameters  
 `nIDResource`  
 The ID of shared resources associated with the frame window.  
  
 *dwDefaultStyle*  
 The frame's [style](../vs140/window-styles.md). Include the **FWS_ADDTOTITLE** style if you want the title bar to automatically display the name of the document represented in the window.  
  
 `pParentWnd`  
 A pointer to the frame's parent.  
  
 `pContext`  
 A pointer to a [CCreateContext](../vs140/ccreatecontext-structure.md) structure. This parameter can be **NULL**.  
  
## Remarks  
 Construct a `CFrameWnd` object in two steps. First, invoke the constructor, which constructs the `CFrameWnd` object, and then call `LoadFrame`, which loads the Windows frame window and associated resources and attaches the frame window to the `CFrameWnd` object. The `nIDResource` parameter specifies the menu, the accelerator table, the icon, and the string resource of the title for the frame window.  
  
 Use the **Create** member function rather than `LoadFrame` when you want to specify all of the frame window's creation parameters.  
  
 The framework calls `LoadFrame` when it creates a frame window using a document template object.  
  
 The framework uses the `pContext` argument to specify the objects to be connected to the frame window, including any contained view objects. You can set the `pContext` argument to **NULL** when you call `LoadFrame`.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CFrameWnd Class](../vs140/cframewnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDocTemplate Class](../vs140/cdoctemplate-class.md)   
 [CFrameWnd::Create](../vs140/cframewnd--create.md)   
 [CFrameWnd::CFrameWnd](../vs140/cframewnd--cframewnd.md)   
 [CWnd::PreCreateWindow](../vs140/cwnd--precreatewindow.md)