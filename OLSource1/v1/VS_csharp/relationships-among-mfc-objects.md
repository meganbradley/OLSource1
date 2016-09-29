---
title: "Relationships Among MFC Objects"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MFC, relationships between key objects"
  - "objects [C++], relationships"
  - "relationships, MFC objects"
  - "MFC object relationships"
ms.assetid: 6e8f3b51-e80f-4d88-94c8-4c1e4ee163ad
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Relationships Among MFC Objects
To help put the document/view creation process in perspective, consider a running program: a document, the frame window used to contain the view, and the view associated with the document.  
  
-   A document keeps a list of the views of that document and a pointer to the document template that created the document.  
  
-   A view keeps a pointer to its document and is a child of its parent frame window.  
  
-   A document frame window keeps a pointer to its current active view.  
  
-   A document template keeps a list of its open documents.  
  
-   The application keeps a list of its document templates.  
  
-   Windows keeps track of all open windows so it can send messages to them.  
  
 These relationships are established during document/view creation. The following table shows how objects in a running program can access other objects. Any object can obtain a pointer to the application object by calling the global function [AfxGetApp](../VS_csharp/afxgetapp.md).  
  
### Gaining Access to Other Objects in Your Application  
  
|From object|How to access other objects|  
|-----------------|---------------------------------|  
|Document|Use [GetFirstViewPosition](../Topic/CDocument::GetFirstViewPosition.md) and [GetNextView](../Topic/CDocument::GetNextView.md) to access the document's view list.<br /><br /> Call [GetDocTemplate](../Topic/CDocument::GetDocTemplate.md) to get the document template.|  
|View|Call [GetDocument](../Topic/CView::GetDocument.md) to get the document.<br /><br /> Call [GetParentFrame](../Topic/CWnd::GetParentFrame.md) to get the frame window.|  
|Document frame window|Call [GetActiveView](../Topic/CFrameWnd::GetActiveView.md) to get the current view.<br /><br /> Call [GetActiveDocument](../Topic/CFrameWnd::GetActiveDocument.md) to get the document attached to the current view.|  
|MDI frame window|Call [MDIGetActive](../Topic/CMDIFrameWnd::MDIGetActive.md) to get the currently active [CMDIChildWnd](../VS_csharp/cmdichildwnd-class.md).|  
  
 Typically, a frame window has one view, but sometimes, as in splitter windows, the same frame window contains multiple views. The frame window keeps a pointer to the currently active view; the pointer is updated any time another view is activated.  
  
> [!NOTE]
>  A pointer to the main frame window is stored in the [m_pMainWnd](../Topic/CWinThread::m_pMainWnd.md) member variable of the application object. A call to `OnFileNew` in your override of the `InitInstance` member function of `CWinApp` sets `m_pMainWnd` for you. If you do not call `OnFileNew`, you must set the variable's value in `InitInstance` yourself. (SDI COM component (server) applications may not set the variable if /Embedding is on the command line.) Note that `m_pMainWnd` is now a member of class `CWinThread` rather than `CWinApp`.  
  
## See Also  
 [Document Templates and the Document/View Creation Process](../VS_csharp/document-templates-and-the-document-view-creation-process.md)   
 [Document Template Creation](../VS_csharp/document-template-creation.md)   
 [Document/View Creation](../VS_csharp/document-view-creation.md)   
 [Creating New Documents, Windows, and Views](../VS_csharp/creating-new-documents--windows--and-views.md)