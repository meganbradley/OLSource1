---
title: "COccManager::IsMatchingMnemonic"
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
  - "IsMatchingMnemonic"
  - "COccManager.IsMatchingMnemonic"
  - "COccManager::IsMatchingMnemonic"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COccManager class, operations"
  - "IsMatchingMnemonic method"
ms.assetid: d64edcd0-ca68-49e8-81f2-a688a90f5478
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COccManager::IsMatchingMnemonic
Call this function to determine if the current mnemonic matches that represented by the control.  
  
## Syntax  
  
```  
  
      static BOOL AFX_CDECL IsMatchingMnemonic(  
   CWnd* pWnd,  
   LPMSG lpMsg   
);  
static BOOL AFX_CDECL IsMatchingMnemonic(   
COleControlSiteOrWnd* pWnd,   
   LPMSG lpMsg   
);  
```  
  
#### Parameters  
 `pWnd`  
 A pointer to the window containing the control.  
  
 `lpMsg`  
 A pointer to the message containing the mnemonic to match.  
  
## Return Value  
 Nonzero if the mnemonic matches the control; otherwise zero  
  
## Remarks  
  
## Requirements  
 **Header:** afxocc.h  
  
## See Also  
 [COccManager Class](../vs140/coccmanager-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)