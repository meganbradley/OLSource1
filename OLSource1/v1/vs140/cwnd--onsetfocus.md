---
title: "CWnd::OnSetFocus"
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
  - "WM_SETFOCUS"
  - "OnSetFocus"
  - "CWnd.OnSetFocus"
  - "CWnd::OnSetFocus"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "WM_SETFOCUS"
  - "OnSetFocus method"
ms.assetid: f0b362a1-7a7c-4b41-aaae-7c7bfebda967
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnSetFocus
The framework calls this member function after gaining the input focus.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *pOldWnd*  
 Contains the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object that loses the input focus (may be **NULL**). The pointer may be temporary and should not be stored for later use.  
  
## Remarks  
 To display a caret, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> should call the appropriate caret functions at this point.  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [WM_SETFOCUS](http://msdn.microsoft.com/library/windows/desktop/ms646283)