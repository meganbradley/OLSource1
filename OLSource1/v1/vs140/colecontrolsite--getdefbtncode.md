---
title: "COleControlSite::GetDefBtnCode"
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
  - COleControlSite::GetDefBtnCode
  - COleControlSite.GetDefBtnCode
  - GetDefBtnCode
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetDefBtnCode method
  - COleControlSite class, operations
ms.assetid: 5bb96925-6146-4bb9-9bbc-2e11fdbf482f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COleControlSite::GetDefBtnCode
Determines if the control is a default push button.  
  
## Syntax  
  
```  
  
DWORD GetDefBtnCode( );  
  
```  
  
## Return Value  
 Can be one of the following values:  
  
-   **DLGC_DEFPUSHBUTTON** Control is the default button in the dialog.  
  
-   **DLGC_UNDEFPUSHBUTTON** Control is not the default button in the dialog.  
  
-   **0** Control is not a button.  
  
## Requirements  
 **Header:** afxocc.h  
  
## See Also  
 [COleControlSite Class](../vs140/colecontrolsite-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)