---
title: "CWnd::PreSubclassWindow"
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
  - "PreSubclassWindow"
  - "CWnd::PreSubclassWindow"
  - "CWnd.PreSubclassWindow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "windows [C++], subclassing"
  - "PreSubclassWindow method"
  - "subclassing window classes"
  - "CWnd class, operations"
  - "subclassing windows"
ms.assetid: 3a85e9a4-9276-4d41-aba7-26a1260a3051
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::PreSubclassWindow
This member function is called by the framework to allow other necessary subclassing to occur before the window is subclassed.  
  
## Syntax  
  
```  
  
virtual void PreSubclassWindow( );  
  
```  
  
## Remarks  
 Overriding this member function allows for dynamic subclassing of controls. It is an advanced overridable.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::SubclassWindow](../vs140/cwnd--subclasswindow.md)   
 [CWnd::UnsubclassWindow](../vs140/cwnd--unsubclasswindow.md)   
 [CWnd::DefWindowProc](../vs140/cwnd--defwindowproc.md)   
 [CWnd::SubclassDlgItem](../vs140/cwnd--subclassdlgitem.md)   
 [CWnd::Attach](../vs140/cwnd--attach.md)   
 [CWnd::PreCreateWindow](../vs140/cwnd--precreatewindow.md)