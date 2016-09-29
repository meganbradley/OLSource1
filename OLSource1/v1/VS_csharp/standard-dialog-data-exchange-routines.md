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
|[DDX_CBIndex](../VS_csharp/ddx_cbindex.md)|Initializes or retrieves the index of the current selection of a combo box control.|  
|[DDX_CBString](../VS_csharp/ddx_cbstring.md)|Initializes or retrieves the current contents of the edit field of a combo box control.|  
|[DDX_CBStringExact](../VS_csharp/ddx_cbstringexact.md)|Initializes or retrieves the current contents of the edit field of a combo box control.|  
|[DDX_Check](../VS_csharp/ddx_check.md)|Initializes or retrieves the current state of a check box control.|  
|[DDX_Control](../VS_csharp/ddx_control.md)|Subclasses a given control within a dialog box.|  
|[DDX_DateTimeCtrl](../VS_csharp/ddx_datetimectrl.md)|Initializes or retrieves date and/or time data of a date and time picker control.|  
|[DDX_IPAddress](../VS_csharp/ddx_ipaddress.md)|Initializes or retrieves the current value of an IP address control.|  
|[DDX_LBIndex](../VS_csharp/ddx_lbindex.md)|Initializes or retrieves the index of the current selection of a list box control.|  
|[DDX_LBString](../VS_csharp/ddx_lbstring.md)|Initializes or retrieves the current selection within a list box control.|  
|[DDX_LBStringExact](../VS_csharp/ddx_lbstringexact.md)|Initializes or retrieves the current selection within a list box control.|  
|[DDX_MonthCalCtrl](../VS_csharp/ddx_monthcalctrl.md)|Initializes or retrieves the current value of a month calendar control.|  
|[DDX_Radio](../VS_csharp/ddx_radio.md)|Initializes or retrieves the 0-based index of the radio control that is currently checked within a radio control group.|  
|[DDX_Scroll](../VS_csharp/ddx_scroll.md)|Initializes or retrieves the current position of a scroll control's thumb.|  
|[DDX_Slider](../VS_csharp/ddx_slider.md)|Initializes or retrieves the current position of a slider control's thumb.|  
|[DDX_Text](../VS_csharp/ddx_text.md)|Initializes or retrieves the current value of an edit control.|  
  
## See Also  
 [Standard Dialog Data Validation Routines](../VS_csharp/standard-dialog-data-validation-routines.md)   
 [Macros and Globals](../VS_csharp/mfc-macros-and-globals.md)