---
title: "CWnd::OnActivateApp"
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
  - "WM_ACTIVATEAPP"
  - "CWnd::OnActivateApp"
  - "OnActivateApp"
  - "CWnd.OnActivateApp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnActivateApp method"
  - "WM_ACTIVATEAPP"
ms.assetid: ba569282-c3d7-48f3-9e34-5a8a7386fe10
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnActivateApp
The framework calls this member function to all top-level windows of the task being activated and for all top-level windows of the task being deactivated.  
  
## Syntax  
  
```  
  
      afx_msg void OnActivateApp(  
   BOOL bActive,  
   DWORD dwThreadID  
);  
```  
  
#### Parameters  
 `bActive`  
 Specifies whether the `CWnd` is being activated or deactivated. **TRUE** means the `CWnd` is being activated. **FALSE** means the `CWnd` is being deactivated.  
  
 *dwThreadID*  
 Specifies the value of the thread ID. If `bActive` is **TRUE**, *dwThreadID* identifies the thread that owns the `CWnd` being deactivated. If `bActive` is **FALSE**, *dwThreadID* identifies the thread that owns the `CWnd` being activated.  
  
## Remarks  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [WM_ACTIVATEAPP](http://msdn.microsoft.com/library/windows/desktop/ms632614)