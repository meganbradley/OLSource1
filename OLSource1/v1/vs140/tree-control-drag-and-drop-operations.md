---
title: "Tree Control Drag-and-Drop Operations"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CTreeCtrl class, drag and drop operations"
  - "drag and drop, CTreeCtrl"
  - "tree controls, drag and drop operations"
ms.assetid: 3cf78b4c-4579-4fe1-9bc9-c5ab876e4af1
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Tree Control Drag-and-Drop Operations
A tree control ([CTreeCtrl](../vs140/ctreectrl-class.md)) sends a notification when the user starts to drag an item. The control sends a [TVN_BEGINDRAG](http://msdn.microsoft.com/library/windows/desktop/bb773504) notification message when the user begins dragging an item with the left mouse button and a [TVN_BEGINRDRAG](http://msdn.microsoft.com/library/windows/desktop/bb773509) notification message when the user begins dragging with the right button. You can prevent a tree control from sending these notifications by giving the tree control the **TVS_DISABLEDRAGDROP** style.  
  
 You obtain an image to display during a drag operation by calling the [CreateDragImage](../vs140/ctreectrl--createdragimage.md) member function. The tree control creates a dragging bitmap based on the label of the item being dragged. Then the tree control creates an image list, adds the bitmap to it, and returns a pointer to the [CImageList](../vs140/cimagelist-class.md) object.  
  
 You must provide the code that actually drags the item. This typically involves using the dragging capabilities of the image list functions and processing the [WM_MOUSEMOVE](http://msdn.microsoft.com/library/windows/desktop/ms645616) and [WM_LBUTTONUP](http://msdn.microsoft.com/library/windows/desktop/ms645608) (or [WM_RBUTTONUP](http://msdn.microsoft.com/library/windows/desktop/ms646243)) messages sent after the drag operation has begun. For more information about the image list functions, see [CImageList](../vs140/cimagelist-class.md) in the *MFC Reference* and [Image Lists](http://msdn.microsoft.com/library/windows/desktop/bb761389) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. For more information about dragging a tree control item, see [Dragging the Tree View Item](http://msdn.microsoft.com/library/windows/desktop/bb760017), also in the [!INCLUDE[winsdkshort](../vs140/includes/winsdkshort_md.md)].  
  
 If items in a tree control are to be the targets of a drag-and-drop operation, you need to know when the mouse cursor is on a target item. You can find out by calling the [HitTest](../vs140/ctreectrl--hittest.md) member function. You specify either a point and integer, or the address of a [TVHITTESTINFO](http://msdn.microsoft.com/library/windows/desktop/bb773448) structure that contains the current coordinates of the mouse cursor. When the function returns, the integer or structure contains a flag indicating the location of the mouse cursor relative to the tree control. If the cursor is over an item in the tree control, the structure contains the handle of the item as well.  
  
 You can indicate that an item is the target of a drag-and-drop operation by calling the [SetItem](../vs140/ctreectrl--setitem.md) member function to set the state to the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> value. An item that has this state is drawn in the style used to indicate a drag-and-drop target.  
  
## See Also  
 [Using CTreeCtrl](../vs140/using-ctreectrl.md)   
 [Controls (MFC)](../vs140/controls--mfc-.md)