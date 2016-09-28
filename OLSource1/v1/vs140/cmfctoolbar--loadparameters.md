---
title: "CMFCToolBar::LoadParameters"
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
  - "CMFCToolBar.LoadParameters"
  - "LoadParameters"
  - "CMFCToolBar::LoadParameters"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LoadParameters method"
ms.assetid: 1366d1cf-0058-4b09-811b-571f0c5ea10a
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::LoadParameters
Loads global toolbar options from the Windows registry.  
  
## Syntax  
  
```  
static BOOL LoadParameters(  
   LPCTSTR lpszProfileName=NULL   
);  
```  
  
#### Parameters  
 [in] `lpszProfileName`  
 Specifies the relative path of the Windows registry key.  
  
## Return Value  
 Nonzero if the method succeeds; otherwise 0.  
  
## Remarks  
 This method loads global parameters such as the menu animation type, the menu shadow style, and whether to display large icons from the Windows registry.  
  
 The [CWinAppEx::LoadState](../vs140/cwinappex--loadstate.md) method calls this method as a part of the initialization process of the application.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWinAppEx::LoadState](../vs140/cwinappex--loadstate.md)