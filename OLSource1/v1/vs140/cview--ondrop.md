---
title: "CView::OnDrop"
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
  - "CView::OnDrop"
  - "OnDrop"
  - "CView.OnDrop"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "drop effect"
  - "DROPEFFECT_LINK"
  - "DROPEFFECT_COPY"
  - "CView class, OLE overridables"
  - "mouse, position"
  - "OnDrop method"
  - "DROPEFFECT_MOVE"
  - "dropping objects"
  - "drop target"
ms.assetid: dfd10d4a-fa25-4b8e-9f7d-8b7f93273f11
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CView::OnDrop
Called by the framework when the user releases a data object over a valid drop target.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Points to the [COleDataObject](../vs140/coledataobject-class.md) that is dropped into the drop target.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The drop effect that the user has requested.  
  
-   <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> Creates a copy of the data object being dropped.  
  
-   <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> Moves the data object to the current mouse location.  
  
-   <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> Creates a link between a data object and its server.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The current mouse position relative to the view client area.  
  
## Return Value  
 Nonzero if the drop was successful; otherwise 0.  
  
## Remarks  
 The default implementation does nothing and returns **FALSE**.  
  
 Override this function to implement the effect of an OLE drop into the client area of the view. The data object can be examined via <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> for Clipboard data formats and data dropped at the specified point.  
  
> [!NOTE]
>  The framework does not call this function if there is an override to [OnDropEx](../vs140/cview--ondropex.md) in this view class.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CView Class](../vs140/cview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CView::OnDragEnter](../vs140/cview--ondragenter.md)   
 [CView::OnDragOver](../vs140/cview--ondragover.md)   
 [CView::OnDropEx](../vs140/cview--ondropex.md)   
 [CView::OnDragLeave](../vs140/cview--ondragleave.md)   
 [COleDropTarget::OnDrop](../vs140/coledroptarget--ondrop.md)