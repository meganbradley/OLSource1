---
title: "CMFCToolBar::OnSetDefaultButtonText"
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
  - "CMFCToolBar::OnSetDefaultButtonText"
  - "OnSetDefaultButtonText"
  - "CMFCToolBar.OnSetDefaultButtonText"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnSetDefaultButtonText method"
ms.assetid: 595fff15-812d-46cd-be8a-07a06480cace
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::OnSetDefaultButtonText
Restores the text of a toolbar button to its default state.  
  
## Syntax  
  
```  
virtual BOOL OnSetDefaultButtonText(  
   CMFCToolBarButton* pButton   
);  
```  
  
#### Parameters  
 [in] `pButton`  
 Points to a button, whose text is being set.  
  
## Return Value  
 `TRUE` ifthe text was successfully restored; otherwise `FALSE`.  
  
## Remarks  
 Override this method to process notifications that the text of a toolbar button is being changed to its default.  
  
 The default implementation loads the text of a button from the application resources.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)