---
title: "COccManager::IsLabelControl"
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
  - IsLabelControl
  - COccManager::IsLabelControl
  - COccManager.IsLabelControl
dev_langs: 
  - C++
helpviewer_keywords: 
  - COccManager class, operations
  - IsLabelControl method
ms.assetid: 99abfd0f-7c1c-442a-ab3c-553edf3fb2f1
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COccManager::IsLabelControl
Call this function to determine if the specified control is a label control.  
  
## Syntax  
  
```  
  
      static BOOL AFX_CDECL IsLabelControl(  
   CWnd* pWnd   
);  
static BOOL AFX_CDECL IsLabelControl(   
   COleControlSiteOrWnd* pWnd   
);  
```  
  
#### Parameters  
 `pWnd`  
 A pointer to the window containing the control.  
  
## Return Value  
 Nonzero if the control is a label; otherwise zero  
  
## Remarks  
 A label control is one that acts like a label for whatever control is next in the ordering.  
  
## Requirements  
 **Header:** afxocc.h  
  
## See Also  
 [COccManager Class](../vs140/coccmanager-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [OLEMISC](http://msdn.microsoft.com/library/windows/desktop/ms678497)