---
title: "CMFCPopupMenu::CMFCPopupMenu"
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
  - "CMFCPopupMenu.CMFCPopupMenu"
  - "CMFCPopupMenu::CMFCPopupMenu"
  - "CMFCPopupMenu"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCPopupMenu class, constructor"
ms.assetid: 24d19699-25bf-4085-b270-dc34c6a9b139
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPopupMenu::CMFCPopupMenu
Constructs a [CMFCPopupMenu](../vs140/cmfcpopupmenu-class.md) object.  
  
## Syntax  
  
```  
CMFCPopupMenu(  
   CMFCToolBarsMenuPropertyPage* pCustPage,  
   LPCTSTR lpszTitle   
);  
```  
  
#### Parameters  
 [in] `pCustPage`  
 A pointer to a customization page.  
  
 [in] `lpszTitle`  
 A string that contains the menu caption.  
  
## Remarks  
 This method allocates the resources for a `CMFCPopupMenu`. To create the pop-up menu item, call [CMFCPopupMenu::Create](../vs140/cmfcpopupmenu--create.md).  
  
## Requirements  
 **Header:** afxpopupmenu.h  
  
## See Also  
 [CMFCPopupMenu Class](../vs140/cmfcpopupmenu-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)