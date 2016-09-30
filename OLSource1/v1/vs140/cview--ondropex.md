---
title: "CView::OnDropEx"
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
  - "OnDropEx"
  - "CView.OnDropEx"
  - "CView::OnDropEx"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDropEx method"
  - "drop effect"
  - "DROPEFFECT_LINK"
  - "right mouse-button drag and drop"
  - "DROPEFFECT_COPY"
  - "DROPEFFECT_NONE"
  - "CView class, OLE overridables"
  - "DROPEFFECT_SCROLL"
  - "mouse, position"
  - "DROPEFFECT_MOVE"
  - "dropping objects"
  - "drop target"
ms.assetid: f722c2c3-0918-4481-b91b-d44534962370
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CView::OnDropEx
Called by the framework when the user releases a data object over a valid drop target.  
  
## Syntax  
  
```  
  
      virtual DROPEFFECT OnDropEx(  
   COleDataObject* pDataObject,  
   DROPEFFECT dropDefault,  
   DROPEFFECT dropList,  
   CPoint point   
);  
```  
  
#### Parameters  
 `pDataObject`  
 Points to the [COleDataObject](../vs140/coledataobject-class.md) that is dropped into the drop target.  
  
 `dropDefault`  
 The effect that the user chose for the default drop operation based on the current key state. It may be `DROPEFFECT_NONE`. Drop effects are discussed in the Remarks section.  
  
 `dropList`  
 A list of the drop effects that the drop source supports. Drop effect values can be combined using the bitwise OR (**&#124;**) operation. Drop effects are discussed in the Remarks section.  
  
 `point`  
 The current mouse position relative to the view client area.  
  
## Return Value  
 The drop effect that resulted from the drop attempt at the location specified by `point`. This must be one of the values indicated by *dropEffectList*. Drop effects are discussed in the Remarks section.  
  
## Remarks  
 The default implementation is to do nothing and return a dummy value ( -1 ) to indicate that the framework should call the [OnDrop](../vs140/cview--ondrop.md) handler.  
  
 Override this function to implement the effect of an right mouse-button drag and drop. Right mouse-button drag and drop typically displays a menu of choices when the right mouse-button is released.  
  
 Your override of `OnDropEx` should query for the right mouse-button. You can call [GetKeyState](http://msdn.microsoft.com/library/windows/desktop/ms646301) or store the right mouse-button state from your [OnDragEnter](../vs140/cview--ondragenter.md) handler.  
  
-   If the right mouse-button is down, your override should display a popup menu which offers the drop effects support by the drop source.  
  
    -   Examine `dropList` to determine the drop effects supported by the drop source. Enable only these actions on the popup menu.  
  
    -   Use [SetMenuDefaultItem](http://msdn.microsoft.com/library/windows/desktop/ms647996) to set the default action based on `dropDefault`.  
  
    -   Finally, take the action indicated by the user selection from the popup menu.  
  
-   If the right mouse-button is not down, your override should process this as a standard drop request. Use the drop effect specified in `dropDefault`. Alternately, your override can return the dummy value ( -1 ) to indicate that `OnDrop` will handle this drop operation.  
  
 Use `pDataObject` to examine the `COleDataObject` for Clipboard data format and data dropped at the specified point.  
  
 Drop effects describe the action associated with a drop operation. See the following list of drop effects:  
  
-   `DROPEFFECT_NONE` A drop would not be allowed.  
  
-   `DROPEFFECT_COPY` A copy operation would be performed.  
  
-   `DROPEFFECT_MOVE` A move operation would be performed.  
  
-   `DROPEFFECT_LINK` A link from the dropped data to the original data would be established.  
  
-   `DROPEFFECT_SCROLL` Indicates that a drag scroll operation is about to occur or is occurring in the target.  
  
 For more information on setting the default menu command, see [SetMenuDefaultItem](http://msdn.microsoft.com/library/windows/desktop/ms647996) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] and [CMenu::GetSafeHmenu](../vs140/cmenu--getsafehmenu.md) in this volume.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CView Class](../vs140/cview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CView::OnDragEnter](../vs140/cview--ondragenter.md)   
 [CView::OnDragOver](../vs140/cview--ondragover.md)   
 [CView::OnDrop](../vs140/cview--ondrop.md)   
 [CView::OnDragLeave](../vs140/cview--ondragleave.md)   
 [COleDropTarget::OnDropEx](../vs140/coledroptarget--ondropex.md)