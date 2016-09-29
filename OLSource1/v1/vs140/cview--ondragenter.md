---
title: "CView::OnDragEnter"
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
  - "DROPEFFECT_NONE"
  - "OnDragEnter"
  - "DROPEFFECT_MOVE"
  - "DROPEFFECT_COPY"
  - "CView.OnDragEnter"
  - "DROPEFFECT_SCROLL"
  - "CView::OnDragEnter"
  - "DROPEFFECT_LINK"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "drop type"
  - "dragging"
  - "OnDragEnter method"
  - "DROPEFFECT_LINK"
  - "DROPEFFECT_COPY"
  - "DROPEFFECT_NONE"
  - "CView class, OLE overridables"
  - "DROPEFFECT_SCROLL"
  - "types [C++], drop"
  - "DROPEFFECT_MOVE"
ms.assetid: fbee6a3a-fbfb-464a-a237-e9bd3c639585
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CView::OnDragEnter
Called by the framework when the mouse first enters the non-scrolling region of the drop target window.  
  
## Syntax  
  
```  
  
      virtual DROPEFFECT OnDragEnter(  
   COleDataObject* pDataObject,  
   DWORD dwKeyState,  
   CPoint point   
);  
```  
  
#### Parameters  
 `pDataObject`  
 Points to the [COleDataObject](../vs140/coledataobject-class.md) being dragged into the drop area of the view.  
  
 `dwKeyState`  
 Contains the state of the modifier keys. This is a combination of any number of the following: **MK_CONTROL**, **MK_SHIFT**, **MK_ALT**, **MK_LBUTTON**, **MK_MBUTTON**, and **MK_RBUTTON**.  
  
 `point`  
 The current mouse position relative to the client area of the view.  
  
## Return Value  
 A value from the `DROPEFFECT` enumerated type, which indicates the type of drop that would occur if the user dropped the object at this position. The type of drop usually depends on the current key state indicated by `dwKeyState`. A standard mapping of keystates to `DROPEFFECT` values is:  
  
-   `DROPEFFECT_NONE` The data object cannot be dropped in this window.  
  
-   `DROPEFFECT_LINK` for **MK_CONTROL &#124; MK_SHIFT** Creates a linkage between the object and its server.  
  
-   `DROPEFFECT_COPY` for **MK_CONTROL** Creates a copy of the dropped object.  
  
-   `DROPEFFECT_MOVE` for **MK_ALT** Creates a copy of the dropped object and delete the original object. This is typically the default drop effect, when the view can accept this data object.  
  
 For more information, see the MFC Advanced Concepts sample [OCLIENT](../vs140/visual-c---samples.md).  
  
## Remarks  
 Default implementation is to do nothing and return `DROPEFFECT_NONE`.  
  
 Override this function to prepare for future calls to the [OnDragOver](../vs140/cview--ondragover.md) member function. Any data required from the data object should be retrieved at this time for later use in the `OnDragOver` member function. The view should also be updated at this time to give the user visual feedback. For more information, see the article [Drag and Drop: Implementing a Drop Target](../vs140/drag-and-drop--implementing-a-drop-target.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CView Class](../vs140/cview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CView::OnDragOver](../vs140/cview--ondragover.md)   
 [CView::OnDrop](../vs140/cview--ondrop.md)   
 [CView::OnDropEx](../vs140/cview--ondropex.md)   
 [CView::OnDragLeave](../vs140/cview--ondragleave.md)   
 [COleDropTarget::OnDragEnter](../vs140/coledroptarget--ondragenter.md)