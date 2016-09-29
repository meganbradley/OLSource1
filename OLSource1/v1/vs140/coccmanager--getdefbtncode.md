---
title: "COccManager::GetDefBtnCode"
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
  - "COccManager::GetDefBtnCode"
  - "COccManager.GetDefBtnCode"
  - "GetDefBtnCode"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COccManager class, operations"
  - "GetDefBtnCode method"
ms.assetid: d5fee038-de0d-4044-8762-cf7d4a316809
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COccManager::GetDefBtnCode
Call this function to determine if the control is a default push button.  
  
## Syntax  
  
```  
  
      static DWORD AFX_CDECL GetDefBtnCode(  
   CWnd* pWnd   
);  
```  
  
#### Parameters  
 `pWnd`  
 The window object containing the button control.  
  
## Return Value  
 One of the following values:  
  
-   **DLGC_DEFPUSHBUTTON** Control is the default button in the dialog.  
  
-   **DLGC_UNDEFPUSHBUTTON** Control is not the default button in the dialog.  
  
-   **0** Control is not a button.  
  
## Requirements  
 **Header:** afxocc.h  
  
## See Also  
 [COccManager Class](../vs140/coccmanager-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)