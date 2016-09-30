---
title: "CMFCWindowsManagerDialog Class"
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
  - "CMFCWindowsManagerDialog"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCWindowsManagerDialog class"
ms.assetid: 35b4b0db-33c4-4b22-94d8-5e3396341340
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCWindowsManagerDialog Class
The `CMFCWindowsManagerDialog` object enables a user to manage MDI child windows in a MDI application.  
  
## Syntax  
  
```  
class CMFCWindowsManagerDialog : public CDialog  
```  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCWindowsManagerDialog::CMFCWindowsManagerDialog](#cmfcwindowsmanagerdialog__cmfcwindowsmanagerdialog)|Constructs a `CMFCWindowsManagerDialog` object.|  
  
## Remarks  
 The `CMFCWindowsManagerDialog` contains a list of MDI child windows that are currently open in the application. The user can manually control the state of the MDI child windows by using this dialog box.  
  
 `CMFCWindowsManagerDialog` is embedded inside the [CMDIFrameWndEx Class](../vs140/cmdiframewndex-class.md). The `CMFCWindowsManagerDialog` is not a class that you should create manually. Instead, call the function [CMDIFrameWndEx::ShowWindowsDialog](../vs140/cmdiframewndex-class.md#cmdiframewndex__showwindowsdialog), and it will create and display a `CMFCWindowsManagerDialog` object.  
  
## Example  
 The following example demonstrates how to construct a `CMFCWindowsManagerDialog` object by calling `CMDIFrameWndEx::ShowWindowsDialog`. This code snippet is part of the [Visual Studio Demo sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_VisualStudioDemo#18](../vs140/codesnippet/CPP/cmfcwindowsmanagerdialog-class_1.cpp)]  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CDialog](../vs140/cdialog-class.md)  
  
 [CMFCWindowsManagerDialog](../vs140/cmfcwindowsmanagerdialog-class.md)  
  
## Requirements  
 **Header:** afxWindowsManagerDialog.h  
  
##  \<a name="cmfcwindowsmanagerdialog__cmfcwindowsmanagerdialog"></a>  CMFCWindowsManagerDialog::CMFCWindowsManagerDialog  
 Constructs a [CMFCWindowsManagerDialog](../vs140/cmfcwindowsmanagerdialog-class.md) object.  
  
```  
CMFCWindowsManagerDialog(  
   CMDIFrameWndEx* pMDIFrame,  
   BOOL bHelpButton = FALSE  
);  
```  
  
### Parameters  
 [in] `pMDIFrame`  
 A pointer to the parent or owner window.  
  
 [in] `bHelpButton`  
 A Boolean parameter that specifies whether the framework displays a **Help** button.  
  
### Remarks  
 For more information about visual managers, see [The Visualization Manager](../vs140/visualization-manager.md).  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CMDIFrameWndEx Class](../vs140/cmdiframewndex-class.md)   
 [CMDIFrameWndEx::ShowWindowsDialog](../vs140/cmdiframewndex-class.md#cmdiframewndex__showwindowsdialog)