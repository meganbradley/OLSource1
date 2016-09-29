---
title: "CDockingManager::OnMoveMiniFrame"
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
  - "OnMoveMiniFrame"
  - "CDockingManager::OnMoveMiniFrame"
  - "CDockingManager.OnMoveMiniFrame"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnMoveMiniFrame method"
ms.assetid: 977c3537-0faf-429f-aa96-9194959ddde7
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockingManager::OnMoveMiniFrame
Called by the framework to move a mini-frame window.  
  
## Syntax  
  
```  
virtual BOOL OnMoveMiniFrame(  
   CWnd* pFrame  
);  
```  
  
#### Parameters  
 [in] `pFrame`  
 A pointer to a mini-frame window.  
  
## Return Value  
 `TRUE` if the method succeeds; otherwise `FALSE`.  
  
## Requirements  
 **Header:** afxdockingmanager.h  
  
## See Also  
 [CDockingManager Class](../vs140/cdockingmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)