---
title: "CWnd::OnCreate"
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
  - "CWnd::OnCreate"
  - "CWnd.OnCreate"
  - "WM_CREATE"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CREATESTRUCT"
  - "OnCreate method"
  - "WM_CREATE"
ms.assetid: f18422cb-350e-4a0f-a234-2575a3b1980a
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnCreate
The framework calls this member function when an application requests that the Windows window be created by calling the [Create](../vs140/cwnd--create.md) or [CreateEx](../vs140/cwnd--createex.md) member function.  
  
## Syntax  
  
```  
  
      afx_msg int OnCreate(  
   LPCREATESTRUCT lpCreateStruct   
);  
```  
  
#### Parameters  
 `lpCreateStruct`  
 Points to a [CREATESTRUCT](../vs140/createstruct-structure.md) structure that contains information about the `CWnd` object being created.  
  
## Return Value  
 `OnCreate` must return 0 to continue the creation of the `CWnd` object. If the application returns –1, the window will be destroyed.  
  
## Remarks  
 The `CWnd` object receives this call after the window is created but before it becomes visible. `OnCreate` is called before the **Create** or `CreateEx` member function returns.  
  
 Override this member function to perform any needed initialization of a derived class.  
  
 The `CREATESTRUCT` structure contains copies of the parameters used to create the window.  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::CreateEx](../vs140/cwnd--createex.md)   
 [CWnd::OnNcCreate](../vs140/cwnd--onnccreate.md)   
 [WM_CREATE](http://msdn.microsoft.com/library/windows/desktop/ms632619)   
 [CWnd::Default](../vs140/cwnd--default.md)   
 [CWnd::FromHandle](../vs140/cwnd--fromhandle.md)