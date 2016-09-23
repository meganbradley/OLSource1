---
title: "CDockablePaneAdapter::SaveState"
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
  - CDockablePaneAdapter::SaveState
  - CDockablePaneAdapter.SaveState
  - SaveState
dev_langs: 
  - C++
helpviewer_keywords: 
  - SaveState method
ms.assetid: 379c57c3-35ed-4607-9124-189d7c34709e
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDockablePaneAdapter::SaveState
Saves the state of the pane to the registry.  
  
## Syntax  
  
```  
virtual BOOL SaveState(  
   LPCTSTR lpszProfileName = NULL,  
   int nIndex = -1,  
   UINT uiID = (UINT) -1  
);  
```  
  
#### Parameters  
 [in] `lpszProfileName`  
 The profile name.  
  
 [in] `nIndex`  
 The profile index (defaults to the control ID of the window).  
  
 [in] `uiID`  
 The pane ID.  
  
## Return Value  
  
## Remarks  
  
## Requirements  
 **Header:** afxdockablepaneadapter.h  
  
## See Also  
 [CDockablePaneAdapter Class](../vs140/cdockablepaneadapter-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)