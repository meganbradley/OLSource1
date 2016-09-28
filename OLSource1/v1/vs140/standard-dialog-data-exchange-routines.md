---
title: "Standard Dialog Data Exchange Routines"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "standard dialog, data exchange routines"
ms.assetid: c6adb7f3-f9af-4cc5-a9ea-315c5b60ad1a
caps.latest.revision: 10
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Standard Dialog Data Exchange Routines
This topic lists the standard dialog data exchange (DDX) routines used for common MFC dialog controls.  
  
> [!NOTE]
>  The standard dialog data exchange routines are defined in the header file afxdd_.h. However, applications should include afxwin.h.  
  
### DDX Functions  
  
|||  
|-|-|  
|[DDX_CBIndex](../vs140/ddx_cbindex.md)|Initializes or retrieves the index of the current selection of a combo box control.|  
|[DDX_CBString](../vs140/ddx_cbstring.md)|Initializes or retrieves the current contents of the edit field of a combo box control.|  
|[DDX_CBStringExact](../vs140/ddx_cbstringexact.md)|Initializes or retrieves the current contents of the edit field of a combo box control.|  
|[DDX_Check](../vs140/ddx_check.md)|Initializes or retrieves the current state of a check box control.|  
|[DDX_Control](../vs140/ddx_control.md)|Subclasses a given control within a dialog box.|  
|[DDX_DateTimeCtrl](../vs140/ddx_datetimectrl.md)|Initializes or retrieves date and/or time data of a date and time picker control.|  
|[DDX_IPAddress](../vs140/ddx_ipaddress.md)|Initializes or retrieves the current value of an IP address control.|  
|[DDX_LBIndex](../vs140/ddx_lbindex.md)|Initializes or retrieves the index of the current selection of a list box control.|  
|[DDX_LBString](../vs140/ddx_lbstring.md)|Initializes or retrieves the current selection within a list box control.|  
|[DDX_LBStringExact](../vs140/ddx_lbstringexact.md)|Initializes or retrieves the current selection within a list box control.|  
|[DDX_MonthCalCtrl](../vs140/ddx_monthcalctrl.md)|Initializes or retrieves the current value of a month calendar control.|  
|[DDX_Radio](../vs140/ddx_radio.md)|Initializes or retrieves the 0-based index of the radio control that is currently checked within a radio control group.|  
|[DDX_Scroll](../vs140/ddx_scroll.md)|Initializes or retrieves the current position of a scroll control's thumb.|  
|[DDX_Slider](../vs140/ddx_slider.md)|Initializes or retrieves the current position of a slider control's thumb.|  
|[DDX_Text](../vs140/ddx_text.md)|Initializes or retrieves the current value of an edit control.|  
  
## See Also  
 [Standard Dialog Data Validation Routines](../vs140/standard-dialog-data-validation-routines.md)   
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)