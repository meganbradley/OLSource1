---
title: "CContainedWindowT::m_pfnSuperWindowProc"
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
  - "CContainedWindow::m_pfnSuperWindowProc"
  - "m_pfnSuperWindowProc"
  - "CContainedWindow.m_pfnSuperWindowProc"
  - "ATL::CContainedWindowT::m_pfnSuperWindowProc"
  - "CContainedWindowT.m_pfnSuperWindowProc"
  - "CContainedWindowT::m_pfnSuperWindowProc"
  - "ATL.CContainedWindowT.m_pfnSuperWindowProc"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_pfnSuperWindowProc"
ms.assetid: 12d97efd-e53e-4a6d-aa39-c288c8be63c7
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CContainedWindowT::m_pfnSuperWindowProc
If the contained window is subclassed, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> points to the original window procedure of the window class.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 If the contained window is superclassed, meaning it is based on a window class that modifies an existing class, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> points to the existing window class's window procedure.  
  
 The [DefWindowProc](../vs140/ccontainedwindowt--defwindowproc.md) method sends message information to the window procedure saved in <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CContainedWindowT Class](../vs140/ccontainedwindowt-class.md)   
 [CContainedWindowT::Create](../vs140/ccontainedwindowt--create.md)   
 [CContainedWindowT::SubclassWindow](../vs140/ccontainedwindowt--subclasswindow.md)