---
title: "CListBox::SetItemHeight"
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
  - "CListBox.SetItemHeight"
  - "CListBox::SetItemHeight"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CListBox class, general operations"
  - "SetItemHeight method"
ms.assetid: 1d255403-79ea-4130-a799-3b8fdab408d8
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListBox::SetItemHeight
Sets the height of items in a list box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the zero-based index of the item in the list box. This parameter is used only if the list box has the **LBS_OWNERDRAWVARIABLE** style; otherwise, it should be set to 0.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the height, in pixels, of the item.  
  
## Return Value  
 **LB_ERR** if the index or height is invalid.  
  
## Remarks  
 If the list box has the [LBS_OWNERDRAWVARIABLE](../vs140/list-box-styles.md) style, this function sets the height of the item specified by <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. Otherwise, this function sets the height of all items in the list box.  
  
## Example  
 [!code[NVC_MFC_CListBox#36](../vs140/codesnippet/CPP/clistbox--setitemheight_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CListBox Class](../vs140/clistbox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListBox::GetItemHeight](../vs140/clistbox--getitemheight.md)   
 [LB_SETITEMHEIGHT](http://msdn.microsoft.com/library/windows/desktop/bb761348)