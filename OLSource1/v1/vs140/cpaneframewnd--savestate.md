---
title: "CPaneFrameWnd::SaveState"
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
  - "CPaneFrameWnd.SaveState"
  - "SaveState"
  - "CPaneFrameWnd::SaveState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SaveState method"
ms.assetid: 5f6296ec-1034-4480-92d7-93ae3635647a
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPaneFrameWnd::SaveState
Saves the pane's state to the registry.  
  
## Syntax  
  
```  
virtual BOOL SaveState(  
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
 `TRUE` if the pane state was saved successfully; otherwise `FALSE`.  
  
## Requirements  
 **Header:** afxpaneframewnd.h  
  
## See Also  
 [CPaneFrameWnd Class](../vs140/cpaneframewnd-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CPaneFrameWnd::LoadState](../vs140/cpaneframewnd--loadstate.md)