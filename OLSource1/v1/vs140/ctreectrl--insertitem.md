---
title: "CTreeCtrl::InsertItem"
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
  - "TVI_FIRST"
  - "TV_INSERTSTRUCT"
  - "TVI_LAST"
  - "CTreeCtrl.InsertItem"
  - "TVI_SORT"
  - "CTreeCtrl::InsertItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "TVI_LAST"
  - "InsertItem method"
  - "TV_INSERTSTRUCT"
  - "TVI_SORT"
  - "TVI_FIRST"
ms.assetid: 3a75e023-b33d-48bf-97fe-80f59e5beeaa
caps.latest.revision: 20
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTreeCtrl::InsertItem
Call this function to insert a new item in a tree view control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *lpInsertStruct*  
 A pointer to a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> that specifies the attributes of the tree view item to be inserted.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Integer specifying which attributes to set. See the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Address of a string containing the item's text.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Index of the item's image in the tree view control's image list.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Index of the item's selected image in the tree view control's image list.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Specifies values for the item's states. See Tree View Control Item States in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for a list of appropriate states.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Specifies which states are to be set. See the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 A 32-bit application-specific value associated with the item.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 Handle of the inserted item's parent.  
  
 *hInsertAfter*  
 Handle of the item after which the new item is to be inserted.  
  
## Return Value  
 Handle of the new item if successful; otherwise **NULL**.  
  
## Remarks  
 The example shows situations in which you might want to use each version of the function when inserting a tree control item.  
  
## Example  
 [!code[NVC_MFC_CTreeCtrl#27](../vs140/codesnippet/CPP/ctreectrl--insertitem_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CTreeCtrl Class](../vs140/ctreectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTreeCtrl::DeleteItem](../vs140/ctreectrl--deleteitem.md)   
 [CTreeCtrl::HitTest](../vs140/ctreectrl--hittest.md)   
 [CTreeCtrl::SelectDropTarget](../vs140/ctreectrl--selectdroptarget.md)   
 [CTreeCtrl::GetItem](../vs140/ctreectrl--getitem.md)   
 [Tree View Control Reference](http://msdn.microsoft.com/library/windows/desktop/bb759988)