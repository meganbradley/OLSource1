---
title: "CListBox::GetItemHeight"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - GetItemHeight
  - CListBox.GetItemHeight
  - CListBox::GetItemHeight
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetItemHeight method
  - CListBox class, general operations
ms.assetid: 5bc2c9f6-8119-42de-a0a2-7e519d5bc112
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CListBox::GetItemHeight
Determines the height of items in a list box.  
  
## Syntax  
  
```  
  
      int GetItemHeight(  
   int nIndex   
) const;  
```  
  
#### Parameters  
 `nIndex`  
 Specifies the zero-based index of the item in the list box. This parameter is used only if the list box has the **LBS_OWNERDRAWVARIABLE** style; otherwise, it should be set to 0.  
  
## Return Value  
 The height, in pixels, of the items in the list box. If the list box has the [LBS_OWNERDRAWVARIABLE](../vs140/list-box-styles.md) style, the return value is the height of the item specified by `nIndex`. If an error occurs, the return value is **LB_ERR**.  
  
## Example  
 [!code[NVC_MFC_CListBox#17](../vs140/codesnippet/CPP/clistbox--getitemheight_1.cpp)]
  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CListBox Class](../vs140/clistbox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [LB_GETITEMHEIGHT](http://msdn.microsoft.com/library/windows/desktop/bb775204)   
 [CListBox::SetItemHeight](../vs140/clistbox--setitemheight.md)