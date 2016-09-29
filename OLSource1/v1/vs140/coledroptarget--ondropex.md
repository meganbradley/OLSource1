---
title: "COleDropTarget::OnDropEx"
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
  - "COleDropTarget::OnDropEx"
  - "OnDropEx"
  - "COleDropTarget.OnDropEx"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDropEx method"
  - "drop effect"
  - "DROPEFFECT_LINK"
  - "right mouse-button drag and drop"
  - "DROPEFFECT_COPY"
  - "drag and drop, drop target"
  - "DROPEFFECT_NONE"
  - "DROPEFFECT_SCROLL"
  - "COleDropTarget class, overridables"
  - "DROPEFFECT_MOVE"
  - "dropping objects"
ms.assetid: 5daaa790-6fbc-49a3-b5bd-73b089189d88
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDropTarget::OnDropEx
Called by the framework when a drop operation is to occur.  
  
## Syntax  
  
```  
  
      virtual DROPEFFECT OnDropEx(  
   CWnd* pWnd,  
   COleDataObject* pDataObject,  
   DROPEFFECT dropDefault,  
   DROPEFFECT dropList,  
   CPoint point   
);  
```  
  
#### Parameters  
 `pWnd`  
 Points to the window the cursor is currently over.  
  
 `pDataObject`  
 Points to the data object that contains the data to be dropped.  
  
 `dropDefault`  
 The effect that the user chose for the default drop operation based on the current key state. It can be `DROPEFFECT_NONE`. Drop effects are discussed in the Remarks section.  
  
 `dropList`  
 A list of the drop effects that the drop source supports. Drop effect values can be combined using the bitwise OR (**&#124;**) operation. Drop effects are discussed in the Remarks section.  
  
 `point`  
 Contains the location of the cursor, in pixels, relative to the screen.  
  
## Return Value  
 The drop effect that resulted from the drop attempt at the location specified by `point`. Drop effects are discussed in the Remarks section.  
  
## Remarks  
 The framework first calls this function. If it does not handle the drop, the framework then calls [OnDrop](../vs140/coledroptarget--ondrop.md). Typically, you will override [OnDropEx](../vs140/cview--ondropex.md) in the view class to support right mouse-button drag and drop. Typically, the view class [OnDrop](../vs140/cview--ondrop.md) is used to handle the case of support for simple drag and drop.  
  
 The default implementation of `COleDropTarget::OnDropEx` calls [CView::OnDropEx](../vs140/cview--ondropex.md). By default, [CView::OnDropEx](../vs140/cview--ondropex.md) simply returns a dummy value to indicate the [OnDrop](../vs140/coledroptarget--ondrop.md) member function should be called.  
  
 Drop effects describe the action associated with a drop operation. See the following list of drop effects:  
  
-   `DROPEFFECT_NONE` A drop would not be allowed.  
  
-   `DROPEFFECT_COPY` A copy operation would be performed.  
  
-   `DROPEFFECT_MOVE` A move operation would be performed.  
  
-   `DROPEFFECT_LINK` A link from the dropped data to the original data would be established.  
  
-   `DROPEFFECT_SCROLL` Indicates that a drag scroll operation is about to occur or is occurring in the target.  
  
 For more information, see [IDropTarget::Drop](http://msdn.microsoft.com/library/windows/desktop/ms687242) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleDropTarget Class](../vs140/coledroptarget-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDropTarget::OnDragOver](../vs140/coledroptarget--ondragover.md)   
 [COleDropTarget::OnDragEnter](../vs140/coledroptarget--ondragenter.md)