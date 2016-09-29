---
title: "CBasePane::LoadState"
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
  - "CBasePane::LoadState"
  - "CBasePane.LoadState"
  - "LoadState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LoadState method"
ms.assetid: 679d4e89-a658-4da1-90c1-0c2ef266cf61
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBasePane::LoadState
Loads the pane's state from the registry.  
  
## Syntax  
  
```  
virtual BOOL LoadState(  
   LPCTSTR lpszProfileName=NULL,  
   int nIndex=-1,  
   UINT uiID=(UINT)-1  
);  
```  
  
#### Parameters  
 [in] `lpszProfileName`  
 Profile name.  
  
 [in] `nIndex`  
 Profile index.  
  
 [in] `uiID`  
 Pane ID.  
  
## Return Value  
 `TRUE` if the pane state was loaded successfully; otherwise `FALSE`.  
  
## Remarks  
 The framework calls this method to load the pane state from the registry. Override it in a derived class to load additional information saved by [CBasePane::SaveState](../vs140/cbasepane--savestate.md).  
  
## Requirements  
 **Header:** afxbasepane.h  
  
## See Also  
 [CBasePane Class](../vs140/cbasepane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CBasePane::SaveState](../vs140/cbasepane--savestate.md)