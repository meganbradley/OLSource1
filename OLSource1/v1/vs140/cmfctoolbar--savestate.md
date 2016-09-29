---
title: "CMFCToolBar::SaveState"
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
  - "CMFCToolBar.SaveState"
  - "CMFCToolBar::SaveState"
  - "SaveState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SaveState method"
ms.assetid: c37f210f-f90e-4f9e-863e-2e5981471c72
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::SaveState
Saves the state information for the toolbar in the Windows registry.  
  
## Syntax  
  
```  
virtual BOOL SaveState(  
   LPCTSTR lpszProfileName=NULL,  
   int nIndex=-1,  
   UINT uiID=(UINT)-1   
);  
```  
  
#### Parameters  
 [in] `lpszProfileName`  
 Specifies the relative path of the Windows registry key.  
  
 [in] `nIndex`  
 The control ID of the toolbar.  
  
 [in] `uiID`  
 The resource ID of the toolbar.  
  
## Return Value  
 Nonzero if the method succeeds; otherwise 0.  
  
## Remarks  
 The framework calls this method when it saves the application state to the registry. For more information, see [CWinAppEx::SaveState](../vs140/cwinappex--savestate.md).  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWinAppEx::SaveState](../vs140/cwinappex--savestate.md)