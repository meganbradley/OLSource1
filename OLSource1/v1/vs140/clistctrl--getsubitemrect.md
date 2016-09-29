---
title: "CListCtrl::GetSubItemRect"
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
  - "CListCtrl.GetSubItemRect"
  - "CListCtrl::GetSubItemRect"
  - "GetSubItemRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LVIR_LABEL"
  - "GetSubItemRect method"
  - "LVIR_BOUNDS"
  - "LVIR_ICON"
ms.assetid: a4c37931-d702-48ea-ab51-e5b84bd27806
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListCtrl::GetSubItemRect
Retrieves the bounding rectangle of an item in a list view control.  
  
## Syntax  
  
```  
  
      BOOL GetSubItemRect(  
   int iItem,  
   int iSubItem,  
   int nArea,  
   CRect& ref   
);  
```  
  
#### Parameters  
 *iItem*  
 Index of the subitem's parent item.  
  
 *iSubItem*  
 The one-based index of the subitem.  
  
 *nArea*  
 Determines the portion of the bounding rectangle (of the list view subitem) to be retrieved. The portion (icon, label, or both) of the bounding rectangle is specified by applying the bitwise OR operator to one or more of the following values:  
  
-   `LVIR_BOUNDS` Returns the bounding rectangle of the entire item, including the icon and label.  
  
-   `LVIR_ICON` Returns the bounding rectangle of the icon or small icon.  
  
-   `LVIR_LABEL` Returns the bounding rectangle of the entire item, including the icon and label. This is identical to `LVIR_BOUNDS`.  
  
 `ref`  
 Reference to a [CRect](../vs140/crect-class.md) object that contains the coordinates of the subitem's bounding rectangle.  
  
## Return Value  
 Nonzero if successful; otherwise zero.  
  
## Remarks  
 This member function implements the behavior of the Win32 macro, [ListView_GetSubItemRect](http://msdn.microsoft.com/library/windows/desktop/bb775004), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)