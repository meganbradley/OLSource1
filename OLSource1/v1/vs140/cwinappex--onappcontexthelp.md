---
title: "CWinAppEx::OnAppContextHelp"
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
  - "OnAppContextHelp"
  - "CWinAppEx::OnAppContextHelp"
  - "CWinAppEx.OnAppContextHelp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnAppContextHelp method"
ms.assetid: 6a58142b-fecc-4644-94c7-f25ce6241fc3
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinAppEx::OnAppContextHelp
The framework calls this method when the user requests context help for the **Customization** dialog box.  
  
## Syntax  
  
```  
virtual void OnAppContextHelp(  
   CWnd* pWndControl,  
   const DWORD dwHelpIDArray[]   
);  
```  
  
#### Parameters  
 [in] `pWndControl`  
 A pointer to a window object for which the user invoked context help.  
  
 [in] `dwHelpIDArray[]`  
 A reserved value.  
  
## Remarks  
 This method is currently reserved for future use. The default implementation does nothing and it is currently not called by the framework.  
  
## Requirements  
 **Header:** afxwinappex.h  
  
## See Also  
 [CWinAppEx Class](../vs140/cwinappex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)