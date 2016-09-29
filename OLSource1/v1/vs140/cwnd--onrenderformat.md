---
title: "CWnd::OnRenderFormat"
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
  - "OnRenderFormat"
  - "CWnd::OnRenderFormat"
  - "CWnd.OnRenderFormat"
  - "WM_RENDERFORMAT"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnRenderFormat method"
  - "WM_RENDERFORMAT"
ms.assetid: 48a79f20-514d-4a4d-b83d-33c4945d76ce
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnRenderFormat
The Clipboard owner's `OnRenderFormat` member function is called by the framework when a particular format with delayed rendering needs to be rendered.  
  
## Syntax  
  
```  
  
      afx_msg void OnRenderFormat(  
   UINT nFormat   
);  
```  
  
#### Parameters  
 `nFormat`  
 Specifies the Clipboard format.  
  
## Remarks  
 The receiver should render the data in that format and pass it to the Clipboard by calling the [SetClipboardData](http://msdn.microsoft.com/library/windows/desktop/ms649051) Windows function.  
  
 Do not call the `OpenClipboard` member function or the **CloseClipboard** Windows function from within `OnRenderFormat`.  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CloseClipboard](http://msdn.microsoft.com/library/windows/desktop/ms649035)   
 [CWnd::OpenClipboard](../vs140/cwnd--openclipboard.md)   
 [SetClipboardData](http://msdn.microsoft.com/library/windows/desktop/ms649051)   
 [WM_RENDERFORMAT](http://msdn.microsoft.com/library/windows/desktop/ms649030)