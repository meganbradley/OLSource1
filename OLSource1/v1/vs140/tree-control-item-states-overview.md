---
title: "Tree Control Item States Overview"
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
  - "states, CTreeCtrl items"
  - "tree controls, item states overview"
  - "CTreeCtrl class, item states"
ms.assetid: 2db11ae0-0d87-499d-8c1f-5e0dbe9e94c8
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Tree Control Item States Overview
Each item in a tree control ([CTreeCtrl](../vs140/ctreectrl-class.md)) has a current state. For example, an item can be selected, disabled, expanded, and so on. For the most part, the tree control automatically sets an item's state to reflect user actions, such as selection of an item. However, you can also set an item's state by using the [SetItemState](../vs140/ctreectrl--setitemstate.md) member function and retrieve the current state of an item by using the [GetItemState](../vs140/ctreectrl--getitemstate.md) member function. For a complete list of item states, see [Tree-View Control Constants](http://msdn.microsoft.com/library/windows/desktop/bb759985) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 An item's current state is specified by the `nState` parameter. A tree control might change an item's state to reflect a user action, such as selecting the item or setting the focus to the item. In addition, an application might change an item's state to disable or hide the item or to specify an overlay image or state image.  
  
 When you specify or change an item's state, the `nStateMask` parameter specifies which state bits to set, and the `nState` parameter contains the new values for those bits. For example, the following example changes the current state of a parent item (specified by `hParentItem`) in a `CTreeCtrl` object (`m_treeCtrl`) to **TVIS_EXPANDPARTIAL**:  
  
 [!code[NVC_MFCControlLadenDialog#71](../vs140/codesnippet/CPP/tree-control-item-states-overview_1.cpp)]  
  
 Another example of changing the state would be to set an item's overlay image. To accomplish this, `nStateMask` must include the `TVIS_OVERLAYMASK` value, and `nState` must include the one-based index of the overlay image shifted left eight bits by using the [INDEXTOOVERLAYMASK](http://msdn.microsoft.com/library/windows/desktop/bb761408) macro. The index can be 0 to specify no overlay image. The overlay image must have been added to the tree control's list of overlay images by a previous call to the [CImageList::SetOverlayImage](../vs140/cimagelist--setoverlayimage.md) function. The function specifies the one-based index of the image to add; this is the index used with the **INDEXTOOVERLAYMASK** macro. A tree control can have up to four overlay images.  
  
 To set an item's state image, `nStateMask` must include the `TVIS_STATEIMAGEMASK` value, and `nState` must include the one-based index of the state image shifted left 12 bits by using the [INDEXTOSTATEIMAGEMASK](http://msdn.microsoft.com/library/windows/desktop/bb775597) macro. The index can be 0 to specify no state image. For more information about overlay and state images, see [Tree Control Image Lists](../vs140/tree-control-image-lists.md).  
  
## See Also  
 [Using CTreeCtrl](../vs140/using-ctreectrl.md)   
 [Controls (MFC)](../vs140/controls--mfc-.md)