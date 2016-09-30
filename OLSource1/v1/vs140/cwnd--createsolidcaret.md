---
title: "CWnd::CreateSolidCaret"
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
  - "CreateSolidCaret"
  - "CWnd.CreateSolidCaret"
  - "CWnd::CreateSolidCaret"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateSolidCaret method"
ms.assetid: 9f857ae4-7612-4c47-8524-07179a5e7e97
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::CreateSolidCaret
Creates a solid rectangle for the system caret and claims ownership of the caret.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the width of the caret (in logical units). If this parameter is 0, the width is set to the system-defined window-border width.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the height of the caret (in logical units). If this parameter is 0, the height is set to the system-defined window-border height.  
  
## Remarks  
 The caret shape can be a line or block.  
  
 The parameters <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> specify the caret's width and height (in logical units); the exact width and height (in pixels) depend on the mapping mode.  
  
 The system's window-border width or height can be retrieved by the [GetSystemMetrics](http://msdn.microsoft.com/library/windows/desktop/ms724385) Windows function with the **SM_CXBORDER** and **SM_CYBORDER** indexes. Using the window-border width or height ensures that the caret will be visible on a high-resolution display.  
  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> member function automatically destroys the previous caret shape, if any, regardless of which window owns the caret. Once created, the caret is initially hidden. To show the caret, the [ShowCaret](../vs140/cwnd--showcaret.md) member function must be called.  
  
 The system caret is a shared resource. <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> should create a caret only when it has the input focus or is active. It should destroy the caret before it loses the input focus or becomes inactive.  
  
## Example  
 [!code[NVC_MFCWindowing#84](../vs140/codesnippet/CPP/cwnd--createsolidcaret_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [DestroyCaret](http://msdn.microsoft.com/library/windows/desktop/ms648400)   
 [GetSystemMetrics](http://msdn.microsoft.com/library/windows/desktop/ms724385)   
 [CWnd::ShowCaret](../vs140/cwnd--showcaret.md)   
 [CreateCaret](http://msdn.microsoft.com/library/windows/desktop/ms648399)