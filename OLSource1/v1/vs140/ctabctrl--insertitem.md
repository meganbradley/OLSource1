---
title: "CTabCtrl::InsertItem"
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
  - "CTabCtrl.InsertItem"
  - "TCIF_RTLREADING"
  - "TCIF_STATE"
  - "CTabCtrl::InsertItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "TCIF_IMAGE"
  - "TCIF_PARAM"
  - "InsertItem method"
  - "TCIF_RTLREADING"
  - "TCIF_STATE"
  - "TCIF_TEXT"
ms.assetid: bb483ef9-baed-413f-86c8-31864c522259
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTabCtrl::InsertItem
Inserts a new tab in an existing tab control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Zero-based index of the new tab.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to a [TCITEM](http://msdn.microsoft.com/library/windows/desktop/bb760554) structure that specifies the attributes of the tab.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Address of a null-terminated string that contains the text of the tab.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The zero-based index of an image to insert from an image list.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Specifies which <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> structure attributes to set. Can be zero or a combination of the following values:  
  
-   <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> The **pszText** member is valid.  
  
-   <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> member is valid.  
  
-   <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> The **lParam** member is valid.  
  
-   <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> The text of **pszText** is displayed using right-to-left reading order on Hebrew or Arabic systems.  
  
-   <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> The **dwState** member is valid.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 Application-defined data associated with the tab.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 Specifies values for the item's states. For more information, see [TCITEM](http://msdn.microsoft.com/library/windows/desktop/bb760554) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 *dwStateMask*  
 Specifies which states are to be set. For more information, see [TCITEM](http://msdn.microsoft.com/library/windows/desktop/bb760554) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Return Value  
 Zero-based index of the new tab if successful; otherwise – 1.  
  
## Example  
 [!code[NVC_MFC_CTabCtrl#5](../vs140/codesnippet/CPP/ctabctrl--insertitem_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CTabCtrl Class](../vs140/ctabctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTabCtrl::GetItem](../vs140/ctabctrl--getitem.md)   
 [CTabCtrl::SetItem](../vs140/ctabctrl--setitem.md)