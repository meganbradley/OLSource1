---
title: "CMFCToolBar::RemoveStateFromRegistry"
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
  - "RemoveStateFromRegistry"
  - "CMFCToolBar::RemoveStateFromRegistry"
  - "CMFCToolBar.RemoveStateFromRegistry"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RemoveStateFromRegistry method"
ms.assetid: a4a7e5b0-63d4-41a6-a5da-b6b0229a8c3b
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::RemoveStateFromRegistry
Deletes the state information for the toolbar from the Windows registry.  
  
## Syntax  
  
```  
virtual BOOL RemoveStateFromRegistry(  
   LPCTSTR lpszProfileName=NULL,  
   int nIndex=-1,  
   UINT uiID=(UINT)-1   
);  
```  
  
#### Parameters  
 [in] `lpszProfileName`  
 Specifies the registry key where the state information is located.  
  
 [in] `nIndex`  
 The control ID of the toolbar.  
  
 [in] `uiID`  
 The resource ID of the toolbar. If this parameter is -1, this method uses the [CWnd::GetDlgCtrlID](../vs140/cwnd--getdlgctrlid.md) method to retrieve the resource ID.  
  
## Return Value  
 Nonzero if the method succeeds; otherwise 0.  
  
## Remarks  
 The framework calls this method when it deletes a user-defined toolbar.  
  
 Override this method if you store additional state information in the Windows registry.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::GetDlgCtrlID](../vs140/cwnd--getdlgctrlid.md)