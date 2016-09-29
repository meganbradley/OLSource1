---
title: "CWnd::Attach"
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
  - "CWnd.Attach"
  - "CWnd::Attach"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Attach method [MFC]"
ms.assetid: 942a5fe2-a845-49f5-854c-8b4176a07765
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::Attach
Attaches a Windows window to a `CWnd` object.  
  
## Syntax  
  
```  
  
      BOOL Attach(  
   HWND hWndNew   
);  
```  
  
#### Parameters  
 `hWndNew`  
 Specifies a handle to a Windows window.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Example  
 This example shows how to use Attach and Detach to map to the MDI client window.  
  
 [!code[NVC_MFCWindowing#67](../vs140/codesnippet/CPP/cwnd--attach_1.h)]  
  
 [!code[NVC_MFCWindowing#68](../vs140/codesnippet/CPP/cwnd--attach_2.cpp)]  
  
 [!code[NVC_MFCWindowing#69](../vs140/codesnippet/CPP/cwnd--attach_3.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::Detach](../vs140/cwnd--detach.md)   
 [CWnd::m_hWnd](../vs140/cwnd--m_hwnd.md)   
 [CWnd::SubclassWindow](../vs140/cwnd--subclasswindow.md)