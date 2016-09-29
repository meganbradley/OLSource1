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
  
 `CMFCWindowsManagerDialog` is embedded inside the [CMDIFrameWndEx Class](../VS_csharp/cmdiframewndex-class.md). The `CMFCWindowsManagerDialog` is not a class that you should create manually. Instead, call the function [CMDIFrameWndEx::ShowWindowsDialog](../VS_csharp/cmdiframewndex-class.md#cmdiframewndex__showwindowsdialog), and it will create and display a `CMFCWindowsManagerDialog` object.  
  
## Example  
 The following example demonstrates how to construct a `CMFCWindowsManagerDialog` object by calling `CMDIFrameWndEx::ShowWindowsDialog`. This code snippet is part of the [Visual Studio Demo sample](../VS_csharp/visual-c---samples.md).  
  
 [!code[NVC_MFC_VisualStudioDemo#18](../VS_csharp/codesnippet/CPP/cmfcwindowsmanagerdialog-class_1.cpp)]  
  
## Inheritance Hierarchy  
 [CObject](../VS_csharp/cobject-class.md)  
  
 [CCmdTarget](../VS_csharp/ccmdtarget-class.md)  
  
 [CWnd](../VS_csharp/cwnd-class.md)  
  
 [CDialog](../VS_csharp/cdialog-class.md)  
  
 [CMFCWindowsManagerDialog](../VS_csharp/cmfcwindowsmanagerdialog-class.md)  
  
## Requirements  
 **Header:** afxWindowsManagerDialog.h  
  
##  <a name="cmfcwindowsmanagerdialog__cmfcwindowsmanagerdialog"></a>  CMFCWindowsManagerDialog::CMFCWindowsManagerDialog  
 Constructs a [CMFCWindowsManagerDialog](../VS_csharp/cmfcwindowsmanagerdialog-class.md) object.  
  
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
 For more information about visual managers, see [The Visualization Manager](../VS_csharp/visualization-manager.md).  
  
## See Also  
 [Hierarchy Chart](../VS_csharp/hierarchy-chart.md)   
 [Classes](../VS_csharp/mfc-classes.md)   
 [CMDIFrameWndEx Class](../VS_csharp/cmdiframewndex-class.md)   
 [CMDIFrameWndEx::ShowWindowsDialog](../VS_csharp/cmdiframewndex-class.md#cmdiframewndex__showwindowsdialog)