---
title: "CWnd::OnCtlColor"
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
  - "OnCtlColor"
  - "WM_CTLCOLOR"
  - "CWnd::OnCtlColor"
  - "CWnd.OnCtlColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "WM_CTLCOLOR notification"
  - "OnCtlColor method"
ms.assetid: e97957d7-7c6c-4ff6-b8f5-bc9fe2cd05b1
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnCtlColor
The framework calls this member function when a child control is about to be drawn.  
  
## Syntax  
  
```  
  
      afx_msg HBRUSH OnCtlColor(  
   CDC* pDC,  
   CWnd* pWnd,  
   UINT nCtlColor   
);  
```  
  
#### Parameters  
 `pDC`  
 Contains a pointer to the display context for the child window. May be temporary.  
  
 `pWnd`  
 Contains a pointer to the control asking for the color. May be temporary.  
  
 `nCtlColor`  
 Contains one of the following values, specifying the type of control:  
  
-   **CTLCOLOR_BTN** Button control  
  
-   **CTLCOLOR_DLG** Dialog box  
  
-   **CTLCOLOR_EDIT** Edit control  
  
-   **CTLCOLOR_LISTBOX** List-box control  
  
-   **CTLCOLOR_MSGBOX** Message box  
  
-   **CTLCOLOR_SCROLLBAR** Scroll-bar control  
  
-   **CTLCOLOR_STATIC** Static control  
  
## Return Value  
 `OnCtlColor` must return a handle to the brush that is to be used for painting the control background.  
  
## Remarks  
 Most controls send this message to their parent (usually a dialog box) to prepare the `pDC` for drawing the control using the correct colors.  
  
 To change the text color, call the `SetTextColor` member function with the desired red, green, and blue (RGB) values.  
  
 To change the background color of a single-line edit control, set the brush handle in both the **CTLCOLOR_EDIT** and **CTLCOLOR_MSGBOX** message codes, and call the [CDC::SetBkColor](../vs140/cdc--setbkcolor.md) function in response to the **CTLCOLOR_EDIT** code.  
  
 `OnCtlColor` will not be called for the list box of a drop-down combo box because the drop-down list box is actually a child of the combo box and not a child of the window. To change the color of the drop-down list box, create a `CComboBox` with an override of `OnCtlColor` that checks for **CTLCOLOR_LISTBOX** in the `nCtlColor` parameter. In this handler, the `SetBkColor` member function must be used to set the background color for the text.  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function. To add the following method to your dialog class, use the Visual Studio properties pane to add a message handler for WM_CTLCOLOR. Alternatively, you can manually add an ON_WM_CTLCOLOR() entry to the message map.  
  
## Example  
 [!code[NVC_MFCWindowing#107](../vs140/codesnippet/CPP/cwnd--onctlcolor_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::SetBkColor](../vs140/cdc--setbkcolor.md)