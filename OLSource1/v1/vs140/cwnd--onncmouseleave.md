---
title: "CWnd::OnNcMouseLeave"
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
  - "CWnd::OnNcMouseLeave"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CWnd::OnNcMoucseLeave"
ms.assetid: b558a7a4-1b5c-47ff-93f4-a3a841704cbf
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnNcMouseLeave
The framework calls this member function when the cursor leaves the nonclient area of the window specified in a prior call to [TrackMouseEvent](http://msdn.microsoft.com/library/windows/desktop/ms646265).  
  
## Syntax  
  
```  
afx_msg void OnNcMouseLeave();  
```  
  
## Remarks  
 This method receives the [WM_NCMOUSELEAVE](http://msdn.microsoft.com/library/windows/desktop/ms645626) notification, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
 This method is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [WM_NCMOUSELEAVE](http://msdn.microsoft.com/library/windows/desktop/ms645626)