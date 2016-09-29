---
title: "CWnd::CreateGrayCaret"
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
  - "CWnd::CreateGrayCaret"
  - "CWnd.CreateGrayCaret"
  - "CreateGrayCaret"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateGrayCaret method"
ms.assetid: aa2f24f1-9304-4b81-9f6d-222b12f8dbb2
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::CreateGrayCaret
Creates a gray rectangle for the system caret and claims ownership of the caret.  
  
## Syntax  
  
```  
  
      void CreateGrayCaret(  
   int nWidth,  
   int nHeight   
);  
```  
  
#### Parameters  
 `nWidth`  
 Specifies the width of the caret (in logical units). If this parameter is 0, the width is set to the system-defined window-border width.  
  
 `nHeight`  
 Specifies the height of the caret (in logical units). If this parameter is 0, the height is set to the system-defined window-border height.  
  
## Remarks  
 The caret shape can be a line or a block.  
  
 The parameters `nWidth` and `nHeight` specify the caret's width and height (in logical units); the exact width and height (in pixels) depend on the mapping mode.  
  
 The system's window-border width or height can be retrieved by the [GetSystemMetrics](http://msdn.microsoft.com/library/windows/desktop/ms724385) Windows function with the **SM_CXBORDER** and **SM_CYBORDER** indexes. Using the window-border width or height ensures that the caret will be visible on a high-resolution display.  
  
 The `CreateGrayCaret` member function automatically destroys the previous caret shape, if any, regardless of which window owns the caret. Once created, the caret is initially hidden. To show the caret, the [ShowCaret](../vs140/cwnd--showcaret.md) member function must be called.  
  
 The system caret is a shared resource. `CWnd` should create a caret only when it has the input focus or is active. It should destroy the caret before it loses the input focus or becomes inactive.  
  
## Example  
 [!code[NVC_MFCWindowing#83](../vs140/codesnippet/CPP/cwnd--creategraycaret_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [DestroyCaret](http://msdn.microsoft.com/library/windows/desktop/ms648400)   
 [GetSystemMetrics](http://msdn.microsoft.com/library/windows/desktop/ms724385)   
 [CWnd::ShowCaret](../vs140/cwnd--showcaret.md)   
 [CreateCaret](http://msdn.microsoft.com/library/windows/desktop/ms648399)