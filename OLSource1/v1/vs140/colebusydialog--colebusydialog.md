---
title: "COleBusyDialog::COleBusyDialog"
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
  - "COleBusyDialog"
  - "COleBusyDialog.COleBusyDialog"
  - "COleBusyDialog::COleBusyDialog"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleBusyDialog class, constructor"
ms.assetid: 82cffb1d-18a6-4a34-ba05-31a1c6dffe42
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleBusyDialog::COleBusyDialog
This function only constructs a `COleBusyDialog` object.  
  
## Syntax  
  
```  
  
      explicit COleBusyDialog(  
   HTASK htaskBusy,  
   BOOL bNotResponding = FALSE,  
   DWORD dwFlags = 0,  
   CWnd* pParentWnd = NULL   
);  
```  
  
#### Parameters  
 *htaskBusy*  
 Handle to the server task that is busy.  
  
 *bNotResponding*  
 If **TRUE**, call the Not Responding dialog box instead of the Server Busy dialog box. The wording in the Not Responding dialog box is slightly different than the wording in the Server Busy dialog box, and the Cancel button is disabled.  
  
 `dwFlags`  
 Creation flag. Can contain zero or more of the following values combined with the bitwise-OR operator:  
  
-   **BZ_DISABLECANCELBUTTON** Disable the Cancel button when calling the dialog box.  
  
-   **BZ_DISABLESWITCHTOBUTTON** Disable the Switch To button when calling the dialog box.  
  
-   **BZ_DISABLERETRYBUTTON** Disable the Retry button when calling the dialog box.  
  
 `pParentWnd`  
 Points to the parent or owner window object (of type `CWnd`) to which the dialog object belongs. If it is **NULL**, the parent window of the dialog object is set to the main application window.  
  
## Remarks  
 To display the dialog box, call [DoModal](../vs140/colebusydialog--domodal.md).  
  
 For more information, see the [OLEUIBUSY](http://msdn.microsoft.com/library/windows/desktop/ms682493) structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxodlgs.h  
  
## See Also  
 [COleBusyDialog Class](../vs140/colebusydialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleBusyDialog::DoModal](../vs140/colebusydialog--domodal.md)