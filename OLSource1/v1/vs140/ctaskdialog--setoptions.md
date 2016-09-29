---
title: "CTaskDialog::SetOptions"
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
  - "CTaskDialog::SetOptions"
  - "CTaskDialog.SetOptions"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetOptions method"
ms.assetid: 8ff81690-3bba-4546-806d-7af79d502355
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTaskDialog::SetOptions
Configures the options for the `CTaskDialog`.  
  
## Syntax  
  
```  
void SetOptions(  
   int nOptionFlag  
);  
```  
  
#### Parameters  
 [in] `nOptionFlag`  
 The set of flags to use for the `CTaskDialog`.  
  
## Remarks  
 This method clears all the current options for the `CTaskDialog`. To preserve the current options, you must retrieve them first with [CTaskDialog::GetOptions](../vs140/ctaskdialog--getoptions.md) and combine them with the options that you want to set.  
  
 The following table lists all the valid options.  
  
 `TDF_ENABLE_HYPERLINKS`  
 Enables hyperlinks in the `CTaskDialog`.  
  
 `TDF_USE_HICON_MAIN`  
 Configures the `CTaskDialog` to use a `HICON` for the main icon. The alternative is to use a `LPCWSTR`.  
  
 `TDF_USE_HICON_FOOTER`  
 Configures the `CTaskDialog` to use a `HICON` for the footer icon. The alternative is to use a `LPCWSTR`.  
  
 `TDF_ALLOW_DIALOG_CANCELLATION`  
 Enables the user to close the `CTaskDialog` by using the keyboard or by using the icon in the upper-right corner of the dialog box, even if the **Cancel** button is not enabled. If this flag is not set and the **Cancel** button is not enabled, the user cannot close the dialog box by using Alt+F4, the Escape key, or the title bar's close button.  
  
 `TDF_USE_COMMAND_LINKS`  
 Configures the `CTaskDialog` to use command button controls.  
  
 `TDF_USE_COMMAND_LINKS_NO_ICON`  
 Configures the `CTaskDialog` to use command button controls without displaying an icon next to the control. `TDF_USE_COMMAND_LINKS` overrides `TDF_USE_COMMAND_LINKS_NO_ICON`.  
  
 `TDF_EXPAND_FOOTER_AREA`  
 Indicates the expansion area is currently expanded.  
  
 `TDF_EXPANDED_BY_DEFAULT`  
 Determines whether the expansion area is expanded by default.  
  
 `TDF_VERIFICATION_FLAG_CHECKED`  
 Indicates the verification check box is currently selected.  
  
 `TDF_SHOW_PROGRESS_BAR`  
 Configures the `CTaskDialog` to display a progress bar.  
  
 `TDF_SHOW_MARQUEE_PROGRESS_BAR`  
 Configures the progress bar to be a marquee progress bar. If you enable this option, you must set `TDF_SHOW_PROGRESS_BAR` to have the expected behavior.  
  
 `TDF_CALLBACK_TIMER`  
 Indicates that the `CTaskDialog` callback interval is set to approximately 200 milliseconds.  
  
 `TDF_POSITION_RELATIVE_TO_WINDOW`  
 Configures the `CTaskDialog` to be centered relative to the parent window. If this flag is not enabled, the `CTaskDialog` is centered relative to the monitor.  
  
 `TDF_RTL_LAYOUT`  
 Configures the `CTaskDialog` for a right-to-left reading layout.  
  
 `TDF_NO_DEFAULT_RADIO_BUTTON`  
 Indicates that no radio button is selected when the `CTaskDialog` appears.  
  
 `TDF_CAN_BE_MINIMIZED`  
 Enables the user to minimize the `CTaskDialog`. To support this option, the `CTaskDialog` cannot be modal. MFC does not support this option because MFC does not support a modeless `CTaskDialog`.  
  
## Example  
 [!code[NVC_MFC_CTaskDialog#7](../vs140/codesnippet/CPP/ctaskdialog--setoptions_1.cpp)]  
  
## Requirements  
 **Header:** afxtaskdialog.h  
  
## See Also  
 [CTaskDialog Class](../vs140/ctaskdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTaskDialog::GetOptions](../vs140/ctaskdialog--getoptions.md)