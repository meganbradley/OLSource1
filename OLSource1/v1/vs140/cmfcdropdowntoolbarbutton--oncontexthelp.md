---
title: "CMFCDropDownToolbarButton::OnContextHelp"
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
  - "CMFCDropDownToolbarButton::OnContextHelp"
  - "CMFCDropDownToolbarButton.OnContextHelp"
  - "OnContextHelp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnContextHelp method"
ms.assetid: 5e1a0122-5cc1-4edb-a39c-0d60e06828ea
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCDropDownToolbarButton::OnContextHelp
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
 Nonzero if the button processes the help message; otherwise 0.  
  
## Remarks  
 This method extends the base class implementation ([CMFCToolBarButton::OnContextHelp](../vs140/cmfctoolbarbutton--oncontexthelp.md)) by calling the [CMFCDropDownToolbarButton::OnClick](../vs140/cmfcdropdowntoolbarbutton--onclick.md) method with `bDelay` set to `FALSE`. This method returns the value that is returned by [CMFCDropDownToolbarButton::OnClick](../vs140/cmfcdropdowntoolbarbutton--onclick.md).  
  
 For more information about the `WM_HELPHITTEST message, see` [TN028: Context-Sensitive Help Support](../vs140/tn028--context-sensitive-help-support.md).  
  
## Requirements  
 **Header:** afxdropdowntoolbar.h  
  
## See Also  
 [CMFCToolBarButton Class](../vs140/cmfctoolbarbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCToolBarButton::OnContextHelp](../vs140/cmfctoolbarbutton--oncontexthelp.md)   
 [CMFCDropDownToolbarButton::OnClick](../vs140/cmfcdropdowntoolbarbutton--onclick.md)   
 [TN028: Context-Sensitive Help Support](../vs140/tn028--context-sensitive-help-support.md)