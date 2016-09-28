---
title: "CWnd::OnClipboardUpdate"
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
  - "CWnd::OnClipboardUpdate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CWnd::OnClipboardUpdate"
ms.assetid: 247bd741-2128-47c8-bc27-1f798fe9130e
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnClipboardUpdate
The framework calls this member function when the contents of the clipboard have changed.  
  
## Syntax  
  
```  
afx_msg void OnClipboardUpdate();  
```  
  
## ParametersRemarks  
 This method receives the [WM_CLIPBOARDUPDATE](http://msdn.microsoft.com/library/windows/desktop/ms649021) notification, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
 This method is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [WM_CLIPBOARDUPDATE](http://msdn.microsoft.com/library/windows/desktop/ms649021)