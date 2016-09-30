---
title: "CListCtrl::InsertItem"
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
  - "CListCtrl::InsertItem"
  - "CListCtrl.InsertItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LVIF_TEXT"
  - "InsertItem method"
  - "LVIF_STATE"
ms.assetid: 1c43f981-6be7-4533-a2d9-92aa73a03ef0
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListCtrl::InsertItem
Inserts an item into the list view control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to an [LVITEM](http://msdn.microsoft.com/library/windows/desktop/bb774760) structure that specifies the item's attributes, as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Index of the item to be inserted.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Address of a string containing the item's label, or <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if the item is a callback item. For information on callback items, see [CListCtrl::GetCallbackMask](../vs140/clistctrl--getcallbackmask.md).  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Index of the item's image, or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> if the item is a callback item. For information on callback items, see [CListCtrl::GetCallbackMask](../vs140/clistctrl--getcallbackmask.md).  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> parameter specifies which item attributes passed as parameters are valid. It can be one or more of the mask values described in [LVITEM Structure](http://msdn.microsoft.com/library/windows/desktop/bb774760) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. The valid values can be combined with the bitwise OR operator.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Indicates the item's state, state image, and overlay image. See the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] topics [LVITEM Structure](http://msdn.microsoft.com/library/windows/desktop/bb774760) for more information and [List-View Item States](http://msdn.microsoft.com/library/windows/desktop/bb774733) for a list of valid flags.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Indicates which bits of the state member will be retrieved or modified. See [LVITEM Structure](http://msdn.microsoft.com/library/windows/desktop/bb774760) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 A 32-bit application-specific value associated with the item. If this parameter is specified, you must set the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> attribute <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
## Return Value  
 The index of the new item if successful or -1 otherwise.  
  
## Remarks  
 Calling this method may cause the **LVM_INSERTITEM** message to be sent to your control window. The associated message handler for the control may fail to set the item text under certain conditions (such as using window styles such as **LVS_OWNERDRAW**). For more information on these conditions, refer to [LVM_INSERTITEM](http://msdn.microsoft.com/library/windows/desktop/bb761107) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CListCtrl#42](../vs140/codesnippet/CPP/clistctrl--insertitem_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListCtrl::DeleteItem](../vs140/clistctrl--deleteitem.md)   
 [CListCtrl::DeleteAllItems](../vs140/clistctrl--deleteallitems.md)   
 [LVM_INSERTITEM](http://msdn.microsoft.com/library/windows/desktop/bb761107)