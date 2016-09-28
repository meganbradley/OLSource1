---
title: "CWnd::FromHandlePermanent"
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
  - "CWnd.FromHandlePermanent"
  - "CWnd::FromHandlePermanent"
  - "FromHandlePermanent"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FromHandlePermanent method"
ms.assetid: 7daeab1d-405c-45a2-b89c-d2db985375fc
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::FromHandlePermanent
Returns a pointer to a `CWnd` object when given a handle to a window.  
  
## Syntax  
  
```  
  
      static CWnd* PASCAL FromHandlePermanent(  
   HWND hWnd   
);  
```  
  
#### Parameters  
 `hWnd`  
 An `HWND` of a Windows window.  
  
## Return Value  
 A pointer to a `CWnd` object.  
  
## Remarks  
 If a `CWnd` object is not attached to the handle, **NULL** is returned.  
  
 This function, unlike [FromHandle](../vs140/cwnd--fromhandle.md), does not create temporary objects.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::FromHandle](../vs140/cwnd--fromhandle.md)