---
title: "COleDropSource::GiveFeedback"
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
  - COleDropSource::GiveFeedback
  - GiveFeedback
  - COleDropSource.GiveFeedback
dev_langs: 
  - C++
helpviewer_keywords: 
  - GiveFeedback method
  - COleDropSource class, overridables
ms.assetid: 75fa3c35-4a7a-43ef-b4ac-083cc8d1f6aa
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COleDropSource::GiveFeedback
Called by the framework after calling [COleDropTarget::OnDragOver](../vs140/coledroptarget--ondragover.md) or [COleDropTarget::DragEnter](../vs140/coledroptarget--ondragenter.md).  
  
## Syntax  
  
```  
  
      virtual SCODE GiveFeedback(  
   DROPEFFECT dropEffect   
);  
```  
  
#### Parameters  
 `dropEffect`  
 The effect you would like to display to the user, usually indicating what would happen if a drop occurred at this point with the selected data. Typically, this is the value returned by the most recent call to [CView::OnDragEnter](../vs140/cview--ondragenter.md) or [CView::OnDragOver](../vs140/cview--ondragover.md). It can be one or more of the following:  
  
-   `DROPEFFECT_NONE` A drop would not be allowed.  
  
-   `DROPEFFECT_COPY` A copy operation would be performed.  
  
-   `DROPEFFECT_MOVE` A move operation would be performed.  
  
-   `DROPEFFECT_LINK` A link from the dropped data to the original data would be established.  
  
-   `DROPEFFECT_SCROLL` A drag scroll operation is about to occur or is occurring in the target.  
  
## Return Value  
 Returns **DRAGDROP_S_USEDEFAULTCURSORS** if dragging is in progress, **NOERROR** if it is not.  
  
## Remarks  
 Override this function to provide feedback to the user about what would happen if a drop occurred at this point. The default implementation uses the OLE default cursors. For more information on drag-and-drop operations using OLE, see the article [Drag and Drop (OLE)](../vs140/drag-and-drop--ole-.md).  
  
 For more information, see [IDropSource::GiveFeedback](http://msdn.microsoft.com/library/windows/desktop/ms693723), [IDropTarget::DragOver](http://msdn.microsoft.com/library/windows/desktop/ms680129), and [IDropTarget::DragEnter](http://msdn.microsoft.com/library/windows/desktop/ms680106) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleDropSource Class](../vs140/coledropsource-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CView::OnDragEnter](../vs140/cview--ondragenter.md)   
 [CView::OnDragOver](../vs140/cview--ondragover.md)