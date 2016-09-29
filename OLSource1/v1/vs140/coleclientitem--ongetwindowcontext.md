---
title: "COleClientItem::OnGetWindowContext"
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
  - "COleClientItem::OnGetWindowContext"
  - "OnGetWindowContext"
  - "COleClientItem.OnGetWindowContext"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnGetWindowContext method"
  - "COleClientItem class, overridables"
ms.assetid: 8d42f33f-170e-4230-ab6d-69bd74ad5063
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleClientItem::OnGetWindowContext
Called by the framework when an item is activated in place.  
  
## Syntax  
  
```  
  
      virtual BOOL OnGetWindowContext(  
   CFrameWnd** ppMainFrame,  
   CFrameWnd** ppDocFrame,  
   LPOLEINPLACEFRAMEINFO lpFrameInfo   
);  
```  
  
#### Parameters  
 `ppMainFrame`  
 Pointer to a pointer to the main frame window.  
  
 `ppDocFrame`  
 Pointer to a pointer to the document frame window.  
  
 `lpFrameInfo`  
 Pointer to an [OLEINPLACEFRAMEINFO](http://msdn.microsoft.com/library/windows/desktop/ms693737) structure that will receive frame window information.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 This function is used to retrieve information about the OLE item's parent window.  
  
 If the container is an MDI application, the default implementation returns a pointer to the [CMDIFrameWnd](../vs140/cmdiframewnd-class.md) object in `ppMainFrame` and a pointer to the active [CMDIChildWnd](../vs140/cmdichildwnd-class.md) object in `ppDocFrame`. If the container is an SDI application, the default implementation returns a pointer to the [CFrameWnd](../vs140/cframewnd-class.md) object in `ppMainFrame` and returns **NULL** in `ppDocFrame`. The default implementation also fills in the members of `lpFrameInfo`.  
  
 Override this function only if the default implementation does not suit your application; for example, if your application has a user-interface paradigm that differs from SDI or MDI. This is an advanced overridable.  
  
 For more information, see [IOleInPlaceSite::GetWindowContext](http://msdn.microsoft.com/library/windows/desktop/ms694366) and the [OLEINPLACEFRAMEINFO](http://msdn.microsoft.com/library/windows/desktop/ms693737) structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleClientItem Class](../vs140/coleclientitem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)