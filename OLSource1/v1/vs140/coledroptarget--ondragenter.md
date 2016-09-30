---
title: "COleDropTarget::OnDragEnter"
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
  - "COleDropTarget.OnDragEnter"
  - "DROPEFFECT_NONE"
  - "OnDragEnter"
  - "DROPEFFECT_MOVE"
  - "DROPEFFECT_COPY"
  - "COleDropTarget::OnDragEnter"
  - "DROPEFFECT_SCROLL"
  - "DROPEFFECT_LINK"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDragEnter method"
  - "DROPEFFECT_LINK"
  - "DROPEFFECT_COPY"
  - "DROPEFFECT_NONE"
  - "DROPEFFECT_SCROLL"
  - "DROPEFFECT_MOVE"
ms.assetid: 4dc4f489-c708-4043-b080-6e8b03342596
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDropTarget::OnDragEnter
Called by the framework when the cursor is first dragged into the window.  
  
## Syntax  
  
```  
  
      virtual DROPEFFECT OnDragEnter(  
   CWnd* pWnd,  
   COleDataObject* pDataObject,  
   DWORD dwKeyState,  
   CPoint point   
);  
```  
  
#### Parameters  
 `pWnd`  
 Points to the window the cursor is entering.  
  
 `pDataObject`  
 Points to the data object containing the data that can be dropped.  
  
 `dwKeyState`  
 Contains the state of the modifier keys. This is a combination of any number of the following: **MK_CONTROL**, **MK_SHIFT**, **MK_ALT**, **MK_LBUTTON**, **MK_MBUTTON**, and **MK_RBUTTON**.  
  
 `point`  
 Contains the current location of the cursor in client coordinates.  
  
## Return Value  
 The effect that would result if a drop were attempted at the location specified by `point`. It can be one or more of the following:  
  
-   `DROPEFFECT_NONE` A drop would not be allowed.  
  
-   `DROPEFFECT_COPY` A copy operation would be performed.  
  
-   `DROPEFFECT_MOVE` A move operation would be performed.  
  
-   `DROPEFFECT_LINK` A link from the dropped data to the original data would be established.  
  
-   `DROPEFFECT_SCROLL` A drag scroll operation is about to occur or is occurring in the target.  
  
## Remarks  
 Override this function to allow drop operations to occur in the window. The default implementation calls [CView::OnDragEnter](../vs140/cview--ondragenter.md), which simply returns `DROPEFFECT_NONE` by default.  
  
 For more information, see [IDropTarget::DragEnter](http://msdn.microsoft.com/library/windows/desktop/ms680106) in the[!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleDropTarget Class](../vs140/coledroptarget-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDropTarget::OnDragOver](../vs140/coledroptarget--ondragover.md)   
 [COleDropTarget::OnDragLeave](../vs140/coledroptarget--ondragleave.md)   
 [COleDropTarget::OnDrop](../vs140/coledroptarget--ondrop.md)   
 [COleDropTarget::OnDropEx](../vs140/coledroptarget--ondropex.md)   
 [CView::OnDragEnter](../vs140/cview--ondragenter.md)