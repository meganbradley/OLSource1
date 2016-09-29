---
title: "CListCtrl::GetItemText"
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
  - "CListCtrl::GetItemText"
  - "CListCtrl.GetItemText"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetItemText method"
ms.assetid: aaed3d21-e715-4152-ad32-e465c93784ef
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListCtrl::GetItemText
Retrieves the text of a list view item or subitem.  
  
## Syntax  
  
```  
  
      int GetItemText(  
   int nItem,  
   int nSubItem,  
   LPTSTR lpszText,  
   int nLen   
) const;  
CString GetItemText(  
   int nItem,  
   int nSubItem   
) const;  
```  
  
#### Parameters  
 `nItem`  
 The index of the item whose text is to be retrieved.  
  
 `nSubItem`  
 Specifies the subitem whose text is to be retrieved.  
  
 `lpszText`  
 Pointer to a string that is to receive the item text.  
  
 `nLen`  
 Length of the buffer pointed to by `lpszText`.  
  
## Return Value  
 The version returning `int` returns the length of the retrieved string.  
  
 The version returning a `CString` returns the item text.  
  
## Remarks  
 If `nSubItem` is zero, this function retrieves the item label; if `nSubItem` is nonzero, it retrieves the text of the subitem. For more information on the subitem argument, see the discussion of the [LVITEM](http://msdn.microsoft.com/library/windows/desktop/bb774760) structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListCtrl::GetItem](../vs140/clistctrl--getitem.md)