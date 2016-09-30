---
title: "CDockingManager::AddMiniFrame"
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
  - "CDockingManager::AddMiniFrame"
  - "CDockingManager.AddMiniFrame"
  - "AddMiniFrame"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddMiniFrame method"
ms.assetid: c1452ecc-ff21-4695-a673-d161bd869dad
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockingManager::AddMiniFrame
Adds a frame to the list of mini frames.  
  
## Syntax  
  
```  
virtual BOOL AddMiniFrame(  
   CPaneFrameWnd* pWnd  
);  
```  
  
#### Parameters  
 [in] `pWnd`  
 A pointer to a frame.  
  
## Return Value  
 `TRUE` if the frame is not in the list of mini frames and was added successfully; `FALSE` otherwise.  
  
## Requirements  
 **Header:** afxdockingmanager.h  
  
## See Also  
 [CDockingManager Class](../vs140/cdockingmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)