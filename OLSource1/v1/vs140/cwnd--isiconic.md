---
title: "CWnd::IsIconic"
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
  - "CWnd::IsIconic"
  - "CWnd.IsIconic"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsIconic method"
ms.assetid: f2057b31-2dc9-4a23-9118-2963d6917f1f
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::IsIconic
Specifies whether `CWnd` is minimized (iconic).  
  
## Syntax  
  
```  
  
BOOL IsIconic( ) const;  
```  
  
## Return Value  
 Nonzero if `CWnd` is minimized; otherwise 0.  
  
## Example  
 [!code[NVC_MFCWindowing#101](../vs140/codesnippet/CPP/cwnd--isiconic_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [IsIconic](http://msdn.microsoft.com/library/windows/desktop/ms633527)