---
title: "CMFCToolBar::GetAllButtons"
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
  - "CMFCToolBar::GetAllButtons"
  - "CMFCToolBar.GetAllButtons"
  - "GetAllButtons"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetAllButtons method"
ms.assetid: c047b205-990c-495f-92ba-ff8bb5cebe48
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::GetAllButtons
Returns a read-only list of buttons in a toolbar.  
  
## Syntax  
  
```  
const CObList& GetAllButtons() const;  
```  
  
## Return Value  
 A constant reference to a [CObList](../vs140/coblist-class.md) object, which contains a collection of [CMFCToolBarButton Class](../vs140/cmfctoolbarbutton-class.md) objects.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)