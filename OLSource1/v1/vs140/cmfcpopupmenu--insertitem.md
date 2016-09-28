---
title: "CMFCPopupMenu::InsertItem"
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
  - "CMFCPopupMenu.InsertItem"
  - "CMFCPopupMenu::InsertItem"
  - "InsertItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "InsertItem method"
ms.assetid: 2c933eec-1e9f-4c53-8636-2f873e3686f4
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPopupMenu::InsertItem
Inserts a new item into the pop-up menu at the specified location.  
  
## Syntax  
  
```  
int InsertItem(  
   const CMFCToolBarMenuButton& button,  
   int iInsertA = -1  
);  
```  
  
#### Parameters  
 [in] `button`  
 A reference to the menu item to add.  
  
 [in] `iInsertAt`  
 The zero-based index for the new item. If `iInsertAt` is -1, the item is added to the end of the menu.  
  
## Return Value  
 The zero-based index of the position where the item was inserted. -1 if the method fails.  
  
## Remarks  
 This method will fail if you provide an invalid value for `iInsertAt`, such as an integer larger than the number of items currently on the pop-up menu.  
  
## Requirements  
 **Header:** afxpopupmenu.h  
  
## See Also  
 [CMFCPopupMenu Class](../vs140/cmfcpopupmenu-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)