---
title: "Adding Items to the Header Control"
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
  - "controls [MFC], header"
  - "CHeaderCtrl class, adding items"
  - "header controls, adding items to"
ms.assetid: 2e9a28b1-7302-4a93-8037-c5a4183e589a
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Adding Items to the Header Control
After creating your header control ([CHeaderCtrl](../vs140/cheaderctrl-class.md)) in its parent window, add as many "header items" as you need: usually one per column.  
  
### To add a header item  
  
1.  Prepare an [HD_ITEM](http://msdn.microsoft.com/library/windows/desktop/bb775247) structure.  
  
2.  Call [CHeaderCtrl::InsertItem](../vs140/cheaderctrl--insertitem.md), passing the structure.  
  
3.  Repeat steps 1 and 2 for additional items.  
  
 For more information, see [Adding an Item to a Header Control](http://msdn.microsoft.com/library/windows/desktop/bb775238) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## See Also  
 [Using CHeaderCtrl](../vs140/using-cheaderctrl.md)   
 [Controls (MFC)](../vs140/controls--mfc-.md)