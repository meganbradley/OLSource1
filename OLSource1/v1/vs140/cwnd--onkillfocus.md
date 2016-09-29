---
title: "CWnd::OnKillFocus"
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
  - "CWnd::OnKillFocus"
  - "WM_KILLFOCUS"
  - "CWnd.OnKillFocus"
  - "OnKillFocus"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "WM_KILLFOCUS"
  - "OnKillFocus method"
ms.assetid: 0f9cf641-8220-4040-827f-9be1f2c5b5c1
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnKillFocus
The framework calls this member function immediately before losing the input focus.  
  
## Syntax  
  
```  
  
      afx_msg void OnKillFocus(  
   CWnd* pNewWnd   
);  
```  
  
#### Parameters  
 *pNewWnd*  
 Specifies a pointer to the window that receives the input focus (may be **NULL** or may be temporary).  
  
## Remarks  
 If the `CWnd` object is displaying a caret, the caret should be destroyed at this point.  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::SetFocus](../vs140/cwnd--setfocus.md)   
 [WM_KILLFOCUS](http://msdn.microsoft.com/library/windows/desktop/ms646282)