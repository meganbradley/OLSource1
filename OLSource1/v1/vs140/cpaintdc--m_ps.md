---
title: "CPaintDC::m_ps"
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
  - "LPPAINTSTRUCT"
  - "m_ps"
  - "CPaintDC::m_ps"
  - "CPaintDC.m_ps"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LPPAINTSTRUCT structure"
  - "CPaintDC class, data members"
  - "structs"
  - "PAINTSTRUCT structure"
  - "m_ps"
ms.assetid: be3bbd4c-7983-46bb-bfeb-8e98157a9bf5
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPaintDC::m_ps
`m_ps` is a public member variable of type [PAINTSTRUCT](../vs140/paintstruct-structure.md).  
  
## Syntax  
  
```  
  
PAINTSTRUCT m_ps;  
  
```  
  
## Remarks  
 It is the `PAINTSTRUCT` that is passed to and filled out by [CWnd::BeginPaint](../vs140/cwnd--beginpaint.md).  
  
 The `PAINTSTRUCT` contains information that the application uses to paint the client area of the window associated with a `CPaintDC` object.  
  
 Note that you can access the device-context handle through the `PAINTSTRUCT`. However, you can access the handle more directly through the `m_hDC` member variable that `CPaintDC` inherits from `CDC`.  
  
## Example  
 See the example for [CPaintDC::m_hWnd](../vs140/cpaintdc--m_hwnd.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CPaintDC Class](../vs140/cpaintdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)