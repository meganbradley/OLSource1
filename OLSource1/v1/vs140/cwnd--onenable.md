---
title: "CWnd::OnEnable"
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
  - "OnEnable"
  - "CWnd.OnEnable"
  - "WM_ENABLE"
  - "CWnd::OnEnable"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "WM_ENABLE"
  - "OnEnable method"
ms.assetid: a5a63397-c8d8-485f-b287-d185a9316886
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnEnable
The framework calls this member function when an application changes the enabled state of the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies whether the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object has been enabled or disabled. This parameter is **TRUE** if the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> has been enabled; it is **FALSE** if the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> has been disabled.  
  
## Remarks  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is called before the [EnableWindow](../vs140/cwnd--enablewindow.md) member function returns, but after the window enabled state ([WS_DISABLED](../vs140/window-styles.md) style bit) has changed.  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::EnableWindow](../vs140/cwnd--enablewindow.md)   
 [WM_ENABLE](http://msdn.microsoft.com/library/windows/desktop/ms632621)