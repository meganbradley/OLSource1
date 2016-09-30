---
title: "CView::OnDragOver"
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
  - "CView.OnDragOver"
  - "CView::OnDragOver"
  - "OnDragOver"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "dragging"
  - "drop effect"
  - "DROPEFFECT_LINK"
  - "OnDragOver method"
  - "DROPEFFECT_COPY"
  - "drag and drop, drop target"
  - "DROPEFFECT_NONE"
  - "CView class, OLE overridables"
  - "DROPEFFECT_SCROLL"
  - "mouse, position"
  - "DROPEFFECT_MOVE"
ms.assetid: 8ff44539-018a-4692-9dc3-48b8a2f1d140
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CView::OnDragOver
Called by the framework during a drag operation when the mouse is moved over the drop target window.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Points to the [COleDataObject](../vs140/coledataobject-class.md) being dragged over the drop target.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Contains the state of the modifier keys. This is a combination of any number of the following: **MK_CONTROL**, **MK_SHIFT**, **MK_ALT**, **MK_LBUTTON**, **MK_MBUTTON**, and **MK_RBUTTON**.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The current mouse position relative to the view client area.  
  
## Return Value  
 A value from the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> enumerated type, which indicates the type of drop that would occur if the user dropped the object at this position. The type of drop often depends on the current key state as indicated by <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. A standard mapping of keystates to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> values is:  
  
-   <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> The data object cannot be dropped in this window.  
  
-   <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> for **MK_CONTROL &#124; MK_SHIFT** Creates a linkage between the object and its server.  
  
-   <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> for **MK_CONTROL** Creates a copy of the dropped object.  
  
-   <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> for **MK_ALT** Creates a copy of the dropped object and delete the original object. This is typically the default drop effect, when the view can accept the data object.  
  
 For more information, see the MFC Advanced Concepts sample [OCLIENT](../vs140/visual-c---samples.md).  
  
## Remarks  
 The default implementation is to do nothing and return <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
 Override this function to give the user visual feedback during the drag operation. Since this function is called continuously, any code contained within it should be optimized as much as possible. For more information, see the article [Drag and Drop: Implementing a Drop Target](../vs140/drag-and-drop--implementing-a-drop-target.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CView Class](../vs140/cview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CView::OnDragEnter](../vs140/cview--ondragenter.md)   
 [CView::OnDrop](../vs140/cview--ondrop.md)   
 [CView::OnDropEx](../vs140/cview--ondropex.md)   
 [CView::OnDragLeave](../vs140/cview--ondragleave.md)   
 [COleDropTarget::OnDragOver](../vs140/coledroptarget--ondragover.md)