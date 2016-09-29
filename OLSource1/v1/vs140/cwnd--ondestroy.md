---
title: "CWnd::OnDestroy"
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
  - "CWnd::OnDestroy"
  - "WM_DESTROY"
  - "CWnd.OnDestroy"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDestroy method"
  - "WM_DESTROY"
ms.assetid: 1cfc8ce5-1aba-4da6-bb5b-fe81d52dcda4
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnDestroy
The framework calls this member function to inform the `CWnd` object that it is being destroyed.  
  
## Syntax  
  
```  
  
afx_msg void OnDestroy( );  
```  
  
## Remarks  
 `OnDestroy` is called after the `CWnd` object is removed from the screen.  
  
 `OnDestroy` is called first for the `CWnd` being destroyed, then for the child windows of `CWnd` as they are destroyed. It can be assumed that all child windows still exist while `OnDestroy` runs.  
  
 If the `CWnd` object being destroyed is part of the Clipboard-viewer chain (set by calling the [SetClipboardViewer](../vs140/cwnd--setclipboardviewer.md) member function), the `CWnd` must remove itself from the Clipboard-viewer chain by calling the [ChangeClipboardChain](../vs140/cwnd--changeclipboardchain.md) member function before returning from the `OnDestroy` function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::ChangeClipboardChain](../vs140/cwnd--changeclipboardchain.md)   
 [CWnd::DestroyWindow](../vs140/cwnd--destroywindow.md)   
 [CWnd::SetClipboardViewer](../vs140/cwnd--setclipboardviewer.md)