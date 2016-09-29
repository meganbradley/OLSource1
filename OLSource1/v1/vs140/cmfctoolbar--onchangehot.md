---
title: "CMFCToolBar::OnChangeHot"
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
  - "CMFCToolBar::OnChangeHot"
  - "CMFCToolBar.OnChangeHot"
  - "OnChangeHot"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnChangeHot method"
ms.assetid: 578b9550-db41-4b19-a6fb-b5a2b8127efd
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::OnChangeHot
Called by the framework when a user selects a button on the toolbar.  
  
## Syntax  
  
```  
virtual void OnChangeHot(  
   int iHot   
);  
```  
  
#### Parameters  
 [in] `iHot`  
 Specifies the index of the toolbar button that is selected; or -1 if no toolbar button is selected.  
  
## Remarks  
 Override this method to process notifications that the user selected a button on a toolbar.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)