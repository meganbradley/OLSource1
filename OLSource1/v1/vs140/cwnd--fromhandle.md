---
title: "CWnd::FromHandle"
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
  - "CWnd.FromHandle"
  - "CWnd::FromHandle"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FromHandle method [MFC]"
ms.assetid: 36f0da28-eb61-4a44-868d-820ebad9e33c
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::FromHandle
Returns a pointer to a `CWnd` object when given a handle to a window. If a `CWnd` object is not attached to the handle, a temporary `CWnd` object is created and attached.  
  
## Syntax  
  
```  
  
      static CWnd* PASCAL FromHandle(  
   HWND hWnd   
);  
```  
  
#### Parameters  
 `hWnd`  
 An `HWND` of a Windows window.  
  
## Return Value  
 Returns a pointer to a `CWnd` object when given a handle to a window. If a `CWnd` object is not attached to the handle, a temporary `CWnd` object is created and attached.  
  
 The pointer may be temporary and should not be stored for later use.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::DeleteTempMap](../vs140/cwnd--deletetempmap.md)