---
title: "CPane::LoadState"
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
  - "CPane.LoadState"
  - "CPane::LoadState"
  - "LoadState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LoadState method"
ms.assetid: dc661fab-dc24-4dbf-a10e-b5c6e3ca4715
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPane::LoadState
Loads the state of the pane from the registry.  
  
## Syntax  
  
```  
virtual BOOL LoadState(  
   LPCTSTR lpszProfileName = NULL,  
   int nIndex = -1,  
   UINT uiID = (UINT) -1  
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
 `TRUE` if the pane state was loaded successfully; otherwise, `FALSE`.  
  
## Remarks  
 The framework calls this method to load the pane state from the registry. Override it in a derived class to load additional information that is saved by [CPane::SaveState](../vs140/cpane--savestate.md).  
  
 When you override this method, also call the base method, and return `FALSE` if the base method returns `FALSE`.  
  
## Requirements  
 **Header:** afxpane.h  
  
## See Also  
 [CPane Class](../vs140/cpane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)