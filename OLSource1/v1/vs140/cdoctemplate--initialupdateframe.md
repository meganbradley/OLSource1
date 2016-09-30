---
title: "CDocTemplate::InitialUpdateFrame"
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
  - "CDocTemplate.InitialUpdateFrame"
  - "InitialUpdateFrame"
  - "CDocTemplate::InitialUpdateFrame"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "InitialUpdateFrame method"
  - "updates"
  - "frame windows, updating"
  - "CDocTemplate class, operations"
  - "updates, frame window"
ms.assetid: a84ad3ae-f919-4f60-9198-87cd38396289
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDocTemplate::InitialUpdateFrame
Initializes the frame window, and optionally makes it visible.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The frame window that needs the initial update.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The document to which the frame is associated. Can be **NULL**.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Indicates whether the frame should become visible and active.  
  
## Remarks  
 Call **IntitialUpdateFrame** after creating a new frame with <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. Calling this function causes the views in that frame window to receive their <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> calls. Also, if there was not previously an active view, the primary view of the frame window is made active; the primary view is a view with a child ID of **AFX_IDW_PANE_FIRST**. Finally, the frame window is made visible if <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is non-zero. If <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is zero, the current focus and visible state of the frame window will remain unchanged.  
  
 It is not necessary to call this function when using the framework's implementation of File New and File Open.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDocTemplate Class](../vs140/cdoctemplate-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CView::OnInitialUpdate](../vs140/cview--oninitialupdate.md)   
 [CFrameWnd::SetActiveView](../vs140/cframewnd--setactiveview.md)   
 [CDocTemplate::CreateNewFrame](../vs140/cdoctemplate--createnewframe.md)