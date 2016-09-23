---
title: "CMFCToolBarButton::OnContextHelp"
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
  - CMFCToolBarButton.OnContextHelp
  - CMFCToolBarButton::OnContextHelp
  - OnContextHelp
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnContextHelp method
ms.assetid: 55fe8b92-98a3-4bc5-a826-ddb094ce2ea8
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCToolBarButton::OnContextHelp
Called by the framework when the parent toolbar handles a `WM_HELPHITTEST` message.  
  
## Syntax  
  
```  
virtual BOOL OnContextHelp(  
   CWnd* pWnd  
);  
```  
  
#### Parameters  
 [in] `pWnd`  
 The parent window of the toolbar button.  
  
## Return Value  
 This method returns `FALSE`.  
  
## Remarks  
 The default implementation of this method does nothing and returns `FALSE`. Override this method to return a nonzero value if the button processes the help message.  
  
 For more information about the `WM_HELPHITTEST` message, see [TN028: Context-Sensitive Help Support](../vs140/tn028--context-sensitive-help-support.md).  
  
## Requirements  
 **Header:** afxtoolbarbutton.h  
  
## See Also  
 [CMFCToolBarButton Class](../vs140/cmfctoolbarbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [TN028: Context-Sensitive Help Support](../vs140/tn028--context-sensitive-help-support.md)