---
title: "CDockingManager::FindDockSite"
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
  - "FindDockSite"
  - "CDockingManager.FindDockSite"
  - "CDockingManager::FindDockSite"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FindDockSite method"
ms.assetid: 863c0e14-ae3d-4fe6-9ce7-38aa2ca8085e
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockingManager::FindDockSite
Retrieves the bar pane that is at the specified position and that has the specified alignment.  
  
## Syntax  
  
```  
virtual CDockSite* FindDockSite(  
   DWORD dwAlignment,  
   BOOL bOuter  
);  
```  
  
#### Parameters  
 [in] `dwAlignment`  
 The alignment of the bar pane.  
  
 [in] `bOuter`  
 If `TRUE`, retrieve the bar in the head position in the list of control bars. Otherwise, retrieve the bar in the tail position in the list of control bars.  
  
## Return Value  
 The docking pane that has the specified alignment; `NULL` otherwise.  
  
## Requirements  
 **Header:** afxdockingmanager.h  
  
## See Also  
 [CDockingManager Class](../vs140/cdockingmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)