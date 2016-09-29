---
title: "CDockingManager::AutoHidePane"
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
  - "AutoHidePane"
  - "CDockingManager::AutoHidePane"
  - "CDockingManager.AutoHidePane"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AutoHidePane method"
ms.assetid: 2ee61e93-2d85-416d-b159-ba287d0ec1cd
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockingManager::AutoHidePane
Creates an autohide toolbar.  
  
## Syntax  
  
```  
CMFCAutoHideToolBar* AutoHidePane(  
   CDockablePane* pBar,  
   CMFCAutoHideToolBar* pCurrAutoHideToolBar = NULL  
);  
```  
  
#### Parameters  
 [in] `pBar`  
 A pointer to the bar pane.  
  
 [in] `pCurrAutoHideToolBar`  
 A pointer to an auto hide toolbar.  
  
## Return Value  
 `NULL` if the auto hide toolbar was not created; otherwise a pointer to the new toolbar.  
  
## Requirements  
 **Header:** afxdockingmanager.h  
  
## See Also  
 [CDockingManager Class](../vs140/cdockingmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)