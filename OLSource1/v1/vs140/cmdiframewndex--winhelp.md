---
title: "CMDIFrameWndEx::WinHelp"
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
  - "CMDIFrameWndEx::WinHelp"
  - "WinHelp"
  - "CMDIFrameWndEx.WinHelp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "WinHelp method"
ms.assetid: 15f5f0a4-cdb7-498b-a23c-13f327acb529
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMDIFrameWndEx::WinHelp
Called by the framework to initiate the WinHelp application or context help.  
  
## Syntax  
  
```  
virtual void WinHelp(  
   DWORD dwData,  
   UINT nCmd = HELP_CONTEXT  
);  
```  
  
#### Parameters  
 [in] `dwData`  
 Specifies data as required for the type of help specified by `nCmd`.  
  
 [in] `nCmd`  
 Specifies the type of help requested. For a list of possible values and how they affect the `dwData` parameter, see the [WinHelp Function](http://msdn.microsoft.com/library/windows/desktop/bb762267) in the Windows SDK.  
  
## Remarks  
 This method overrides [CWnd::WinHelp](../vs140/cwnd--winhelp.md).  
  
## Requirements  
 **Header:**  
  
## See Also  
 [CMDIFrameWndEx Class](../vs140/cmdiframewndex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)