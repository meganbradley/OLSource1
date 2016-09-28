---
title: "CWnd::CreateAccessibleProxy"
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
  - "CWnd.CreateAccessibleProxy"
  - "CreateAccessibleProxy"
  - "CWnd::CreateAccessibleProxy"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateAccessibleProxy method"
ms.assetid: 095b0e4f-df94-4005-bb84-35a7e7aa0214
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::CreateAccessibleProxy
Creates an Active Accessibility proxy for the specified object.  
  
## Syntax  
  
```  
  
      virtual HRESULT CreateAccessibleProxy(  
   WPARAM wParam,  
   LPARAM lParam,  
   LRESULT *pResult  
);  
```  
  
#### Parameters  
 `wParam`  
 Identifies the object accessed by the Active Accessibility proxy. Can be one of the following values  
  
|Value|Meaning|  
|-----------|-------------|  
|**OBJID_CLIENT**|Refers to the window's client area.|  
  
 `lParam`  
 Provides additional message-dependent information.  
  
 `pResult`  
 A pointer to an **LRESULT** that stores the result code.  
  
## Remarks  
 Creates an Active Accessibility proxy for the specified object.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [WM_GETOBJECT](http://msdn.microsoft.com/library/windows/desktop/dd373892)   
 [LresultFromObject](http://msdn.microsoft.com/library/windows/desktop/dd318557)