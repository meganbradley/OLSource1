---
title: "CDockingManager::OnActivateFrame"
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
  - "OnActivateFrame"
  - "CDockingManager::OnActivateFrame"
  - "CDockingManager.OnActivateFrame"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnActivateFrame method"
ms.assetid: 39e50cd9-6097-4921-b907-9cfc2321a561
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockingManager::OnActivateFrame
Called by the framework when the frame window is made active or is deactivated.  
  
## Syntax  
  
```  
virtual void OnActivateFrame(  
   BOOL bActivate  
);  
```  
  
#### Parameters  
 [in] `bActivate`  
 If `TRUE`, the frame window is made active; if `FALSE`, the frame window is deactivated.  
  
## Requirements  
 **Header:** afxdockingmanager.h  
  
## See Also  
 [CDockingManager Class](../vs140/cdockingmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)