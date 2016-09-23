---
title: "CMFCPopupMenu::SetMaxWidth"
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
  - SetMaxWidth
  - CMFCPopupMenu.SetMaxWidth
  - CMFCPopupMenu::SetMaxWidth
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetMaxWidth method
ms.assetid: c8297ded-3b6e-4635-b23f-3bace483db72
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCPopupMenu::SetMaxWidth
Set the maximum width for the pop-up menu.  
  
## Syntax  
  
```  
void SetMaxWidth(  
   int iMaxWidth   
);  
```  
  
#### Parameters  
 [in] `iMaxWidth`  
 The maximum width for the pop-up menu, in pixels.  
  
## Remarks  
 If the text associated with a menu command will not fit in the maximum width, it is truncated and the part that does not fit is replaced by three dots.  
  
## Requirements  
 **Header:** afxpopupmenu.h  
  
## See Also  
 [CMFCPopupMenu Class](../vs140/cmfcpopupmenu-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)