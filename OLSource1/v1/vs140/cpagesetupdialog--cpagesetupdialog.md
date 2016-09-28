---
title: "CPageSetupDialog::CPageSetupDialog"
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
  - "CPageSetupDialog.CPageSetupDialog"
  - "CPageSetupDialog::CPageSetupDialog"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CPageSetupDialog class, construction"
  - "CPageSetupDialog class, constructor"
ms.assetid: d9ee2f2f-4202-4608-a5ce-ef2b4dbfbfd8
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPageSetupDialog::CPageSetupDialog
Call this function to construct a `CPageSetupDialog` object.  
  
## Syntax  
  
```  
  
      CPageSetupDialog(  
   DWORD dwFlags = PSD_MARGINS | PSD_INWININIINTLMEASURE,  
   CWnd* pParentWnd = NULL   
);  
```  
  
#### Parameters  
 `dwFlags`  
 One or more flags you can use to customize the settings of the dialog box. The values can be combined using the bitwise-OR operator. These values have the following meanings:  
  
-   **PSD_DEFAULTMINMARGINS** Sets the minimum allowable widths for the page margins to be the same as the printer's minimums. This flag is ignored if the **PSD_MARGINS** and **PSD_MINMARGINS** flags are also specified.  
  
-   **PSD_INWININIINTLMEASURE** Not implemented.  
  
-   **PSD_MINMARGINS** Causes the system to use the values specified in the **rtMinMargin** member as the minimum allowable widths for the left, top, right, and bottom margins. The system prevents the user from entering a width that is less than the specified minimum. If **PSD_MINMARGINS** is not specified, the system sets the minimum allowable widths to those allowed by the printer.  
  
-   **PSD_MARGINS** Activates the margin control area.  
  
-   **PSD_INTHOUSANDTHSOFINCHES** Causes the units of the dialog box to be measured in 1/1000 of an inch.  
  
-   **PSD_INHUNDREDTHSOFMILLIMETERS** Causes the units of the dialog box to be measured in 1/100 of a millimeter.  
  
-   **PSD_DISABLEMARGINS** Disables the margin dialog box controls.  
  
-   **PSD_DISABLEPRINTER** Disables the Printer button.  
  
-   **PSD_NOWARNING** Prevents the warning message from being displayed when there is no default printer.  
  
-   **PSD_DISABLEORIENTATION** Disables the page orientation dialog control.  
  
-   **PSD_RETURNDEFAULT** Causes `CPageSetupDialog` to return [DEVMODE](http://msdn.microsoft.com/library/windows/desktop/dd183565) and [DEVNAMES](../vs140/devnames-structure.md) structures that are initialized for the system default printer without displaying a dialog box. It is assumed that both **hDevNames** and **hDevMode** are **NULL**; otherwise, the function returns an error. If the system default printer is supported by an old printer driver (earlier than Windows version 3.0), only **hDevNames** is returned; **hDevMode** is **NULL**.  
  
-   **PSD_DISABLEPAPER** Disables the paper selection control.  
  
-   **PSD_SHOWHELP** Causes the dialog box to show the Help button. The **hwndOwner** member must not be **NULL** if this flag is specified.  
  
-   **PSD_ENABLEPAGESETUPHOOK** Enables the hook function specified in **lpfnSetupHook**.  
  
-   **PSD_ENABLEPAGESETUPTEMPLATE** Causes the operating system to create the dialog box by using the dialog template box identified by **hInstance** and **lpSetupTemplateName**.  
  
-   **PSD_ENABLEPAGESETUPTEMPLATEHANDLE** Indicates that **hInstance** identifies a data block that contains a preloaded dialog box template. The system ignores **lpSetupTemplateName** if this flag is specified.  
  
-   **PSD_ENABLEPAGEPAINTHOOK** Enables the hook function specified in **lpfnPagePaintHook**.  
  
-   **PSD_DISABLEPAGEPAINTING** Disables the draw area of the dialog box.  
  
 `pParentWnd`  
 Pointer to the dialog box's parent or owner.  
  
## Remarks  
 Use the [DoModal](../vs140/cdialog--domodal.md) function to display the dialog box.  
  
## Example  
 [!code[NVC_MFCDocView#94](../vs140/codesnippet/CPP/cpagesetupdialog--cpagesetupdialog_1.cpp)]  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CPageSetupDialog Class](../vs140/cpagesetupdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPrintDialog Class](../vs140/cprintdialog-class.md)   
 [CPageSetupDialog Class](../vs140/cpagesetupdialog-class.md)