---
title: "CPaneFrameWnd::LoadState"
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
  - "CPaneFrameWnd.LoadState"
  - "CPaneFrameWnd::LoadState"
  - "LoadState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LoadState method"
ms.assetid: 369a5611-3a23-4840-a451-d52149596249
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPaneFrameWnd::LoadState
Loads the pane's state from the registry.  
  
## Syntax  
  
```  
virtual BOOL LoadState(  
   LPCTSTR lpszProfileName = NULL,  
   UINT uiID = (UINT) -1  
);  
```  
  
#### Parameters  
 [in] `lpszProfileName`  
 The profile name.  
  
 [in] `uiID`  
 The pane ID.  
  
## Return Value  
 `TRUE` if the pane state was loaded successfully; otherwise `FALSE`.  
  
## Requirements  
 **Header:** afxpaneframewnd.h  
  
## See Also  
 [CPaneFrameWnd Class](../vs140/cpaneframewnd-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CPaneFrameWnd::SaveState](../vs140/cpaneframewnd--savestate.md)