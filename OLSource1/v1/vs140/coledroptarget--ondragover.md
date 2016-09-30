---
title: "COleDropTarget::OnDragOver"
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
  - "OnDragOver"
  - "COleDropTarget.OnDragOver"
  - "COleDropTarget::OnDragOver"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DROPEFFECT_LINK"
  - "OnDragOver method"
  - "DROPEFFECT_COPY"
  - "DROPEFFECT_NONE"
  - "DROPEFFECT_SCROLL"
  - "DROPEFFECT_MOVE"
ms.assetid: d50c6fed-01ee-46ed-8b4f-0e4c00aeb174
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDropTarget::OnDragOver
Called by the framework when the cursor is dragged over the window.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Points to the window that the cursor is over.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Points to the data object that contains the data to be dropped.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Contains the state of the modifier keys. This is a combination of any number of the following: **MK_CONTROL**, **MK_SHIFT**, **MK_ALT**, **MK_LBUTTON**, **MK_MBUTTON**, and **MK_RBUTTON**.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Contains the current location of the cursor in client coordinates.  
  
## Return Value  
 The effect that would result if a drop were attempted at the location specified by <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. It can be one or more of the following:  
  
-   <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> A drop would not be allowed.  
  
-   <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> A copy operation would be performed.  
  
-   <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> A move operation would be performed.  
  
-   <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> A link from the dropped data to the original data would be established.  
  
-   <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> Indicates that a drag scroll operation is about to occur or is occurring in the target.  
  
## Remarks  
 This function should be overridden to allow drop operations to occur in the window. The default implementation of this function calls [CView::OnDragOver](../vs140/cview--ondragover.md), which returns <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> by default. Because this function is called frequently during a drag-and-drop operation, it should be optimized as much as possible.  
  
 For more information, see [IDropTarget::DragOver](http://msdn.microsoft.com/library/windows/desktop/ms680129) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFCOleContainer#21](../vs140/codesnippet/CPP/coledroptarget--ondragover_1.cpp)]  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleDropTarget Class](../vs140/coledroptarget-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDropTarget::OnDragEnter](../vs140/coledroptarget--ondragenter.md)   
 [COleDropTarget::OnDragLeave](../vs140/coledroptarget--ondragleave.md)   
 [COleDropTarget::OnDrop](../vs140/coledroptarget--ondrop.md)   
 [COleDropTarget::OnDropEx](../vs140/coledroptarget--ondropex.md)