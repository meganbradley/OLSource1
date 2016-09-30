---
title: "CWnd::OnSetCursor"
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
  - "OnSetCursor"
  - "WM_SETCURSOR"
  - "CWnd::OnSetCursor"
  - "CWnd.OnSetCursor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "WM_SETCURSOR"
  - "OnSetCursor method"
ms.assetid: 72898ddb-9d5f-4277-9023-6dad34bf24b6
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnSetCursor
The framework calls this member function if mouse input is not captured and the mouse causes cursor movement within the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies a pointer to the window that contains the cursor. The pointer may be temporary and should not be stored for later use.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the [hit-test](../vs140/cwnd--onnchittest.md) area code. The hit test determines the cursor's location.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Specifies the mouse message number.  
  
## Return Value  
 Nonzero to halt further processing, or 0 to continue.  
  
## Remarks  
 The default implementation calls the parent window's <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> before processing. If the parent window returns **TRUE**, further processing is halted. Calling the parent window gives the parent window control over the cursor's setting in a child window.  
  
 The default implementation sets the cursor to an arrow if it is not in the client area or to the registered-class cursor if it is.  
  
 If <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is **HTERROR** and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is a mouse button-down message, the **MessageBeep** member function is called.  
  
 The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> parameter is 0 when <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> enters menu mode.  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::OnNcHitTest](../vs140/cwnd--onnchittest.md)   
 [WM_SETCURSOR](http://msdn.microsoft.com/library/windows/desktop/ms648382)   
 [How Do I: Change the Mouse Cursor in an Microsoft Foundation Class Application?](http://go.microsoft.com/fwlink/?LinkID=128044)