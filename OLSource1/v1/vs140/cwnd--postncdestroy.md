---
title: "CWnd::PostNcDestroy"
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
  - "CWnd.PostNcDestroy"
  - "CWnd::PostNcDestroy"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "destroying windows"
  - "CWnd class, overridables"
  - "PostNcDestroy method"
  - "cleanup"
ms.assetid: ecdb0263-0b5b-4ce6-8128-025f2fc6c54b
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::PostNcDestroy
Called by the default [OnNcDestroy](../vs140/cwnd--onncdestroy.md) member function after the window has been destroyed.  
  
## Syntax  
  
```  
  
virtual void PostNcDestroy( );  
```  
  
## Remarks  
 Derived classes can use this function for custom cleanup such as the deletion of the **this** pointer.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::OnNcDestroy](../vs140/cwnd--onncdestroy.md)