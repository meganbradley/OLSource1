---
title: "CWnd::IsWindowEnabled"
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
  - "CWnd.IsWindowEnabled"
  - "IsWindowEnabled"
  - "CWnd::IsWindowEnabled"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsWindowEnabled method"
ms.assetid: 82e6237c-ca15-4676-bbb2-573e329d4e71
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::IsWindowEnabled
Specifies whether `CWnd` is enabled for mouse and keyboard input.  
  
## Syntax  
  
```  
  
BOOL IsWindowEnabled( ) const;  
```  
  
## Return Value  
 Nonzero if `CWnd` is enabled; otherwise 0.  
  
## Example  
 [!code[NVC_MFCWindowing#102](../vs140/codesnippet/CPP/cwnd--iswindowenabled_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [IsWindowEnabled](http://msdn.microsoft.com/library/windows/desktop/ms646303)