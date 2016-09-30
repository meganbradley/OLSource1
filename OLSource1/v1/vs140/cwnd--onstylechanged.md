---
title: "CWnd::OnStyleChanged"
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
  - "WM_STYLECHANGED"
  - "OnStyleChanged"
  - "CWnd::OnStyleChanged"
  - "CWnd.OnStyleChanged"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnStyleChanged method"
  - "WM_STYLECHANGED"
  - "styles, changing"
ms.assetid: f03eeeee-3cd9-4ba2-ae76-6b1a2a825711
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnStyleChanged
The framework calls this member function after the [SetWindowLong](http://msdn.microsoft.com/library/windows/desktop/ms633591) function has changed one or more of the window's styles.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies whether the window's extended or nonextended styles have changed. This parameter can be a combination of the following values:  
  
-   **GWL_EXSTYLE** The window's extended styles have changed.  
  
-   **GWL_STYLE** The window's nonextended styles have changed.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Points to a [STYLESTRUCT](http://msdn.microsoft.com/library/windows/desktop/ms632607) structure that contains the new styles for the window. An application can examine the styles, but it can not change them.  
  
## Remarks  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [WM_STYLECHANGED](http://msdn.microsoft.com/library/windows/desktop/ms632648)