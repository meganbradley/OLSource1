---
title: "COleDropTarget::OnDragLeave"
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
  - "COleDropTarget.OnDragLeave"
  - "COleDropTarget::OnDragLeave"
  - "OnDragLeave"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleDropTarget class, overridables"
  - "OnDragLeave method"
ms.assetid: fe555e6a-0bdf-42fe-8412-fc187c6bc73c
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDropTarget::OnDragLeave
Called by the framework when the cursor leaves the window while a dragging operation is in effect.  
  
## Syntax  
  
```  
  
      virtual void OnDragLeave(  
   CWnd* pWnd   
);  
```  
  
#### Parameters  
 `pWnd`  
 Points to the window the cursor is leaving.  
  
## Remarks  
 Override this function if you want special behavior when the drag operation leaves the specified window. The default implementation of this function calls [CView::OnDragLeave](../vs140/cview--ondragleave.md).  
  
 For more information, see [IDropTarget::DragLeave](http://msdn.microsoft.com/library/windows/desktop/ms680110) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleDropTarget Class](../vs140/coledroptarget-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDropTarget::OnDragEnter](../vs140/coledroptarget--ondragenter.md)   
 [COleDropTarget::OnDragOver](../vs140/coledroptarget--ondragover.md)   
 [COleDropTarget::OnDrop](../vs140/coledroptarget--ondrop.md)   
 [COleDropTarget::OnDropEx](../vs140/coledroptarget--ondropex.md)