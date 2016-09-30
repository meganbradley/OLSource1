---
title: "CMFCToolBarMenuButton::SaveBarState"
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
  - "CMFCToolBarMenuButton::SaveBarState"
  - "CMFCToolBarMenuButton.SaveBarState"
  - "SaveBarState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SaveBarState method"
ms.assetid: 496a7d34-c8a5-499a-b20a-d9a0da261536
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarMenuButton::SaveBarState
[!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The framework calls this method when it creates a toolbar button as the result of a drag-and-drop operation. This method calls the [CMFCPopupMenu::SaveState](../vs140/cmfcpopupmenu--savestate.md) method of the top-level pop-up menu, which causes the parent button of the pop-up menu to recreate its menu.  
  
## Requirements  
 **Header:** afxtoolbarmenubutton.h  
  
## See Also  
 [CMFCToolBarMenuButton Class](../vs140/cmfctoolbarmenubutton-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCPopupMenu::SaveState](../vs140/cmfcpopupmenu--savestate.md)