---
title: "CWnd::OnMouseActivate"
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
  - "CWnd::OnMouseActivate"
  - "WM_MOUSEACTIVATE"
  - "CWnd.OnMouseActivate"
  - "OnMouseActivate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "WM_MOUSEACTIVATE"
  - "OnMouseActivate method"
ms.assetid: 4343cede-c508-4624-94e3-35a2e178e950
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnMouseActivate
The framework calls this member function when the cursor is in an inactive window and the user presses a mouse button.  
  
## Syntax  
  
```  
  
      afx_msg int OnMouseActivate(  
   CWnd* pDesktopWnd,  
   UINT nHitTest,  
   UINT message   
);  
```  
  
#### Parameters  
 *pDesktopWnd*  
 Specifies a pointer to the top-level parent window of the window being activated. The pointer may be temporary and should not be stored.  
  
 `nHitTest`  
 Specifies the [hit-test](../vs140/cwnd--onnchittest.md) area code. A hit test is a test that determines the location of the cursor.  
  
 `message`  
 Specifies the mouse message number.  
  
## Return Value  
 Specifies whether to activate the `CWnd` and whether to discard the mouse event. It must be one of the following values:  
  
-   **MA_ACTIVATE** Activate `CWnd` object.  
  
-   **MA_NOACTIVATE** Do not activate `CWnd` object.  
  
-   **MA_ACTIVATEANDEAT** Activate `CWnd` object and discard the mouse event.  
  
-   **MA_NOACTIVATEANDEAT** Do not activate `CWnd` object and discard the mouse event.  
  
## Remarks  
 The default implementation passes this message to the parent window before any processing occurs. If the parent window returns **TRUE**, processing is halted.  
  
 For a description of the individual hit-test area codes, see the [OnNcHitTest](../vs140/cwnd--onnchittest.md) member function  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Example  
 [!code[NVC_MFCAxCtl#9](../vs140/codesnippet/CPP/cwnd--onmouseactivate_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::OnNcHitTest](../vs140/cwnd--onnchittest.md)   
 [CWnd::OnMouseActivate](#_mfc_cwnd.3a3a.onmouseactivate)