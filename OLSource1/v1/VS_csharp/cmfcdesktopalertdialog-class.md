---
title: "CMFCDesktopAlertDialog Class"
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
  - "CMFCDesktopAlertDialog"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCDesktopAlertDialog class"
ms.assetid: a53c60aa-9607-485b-b826-ec64962075f6
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCDesktopAlertDialog Class
The `CMFCDesktopAlertDialog` class is used together with the [CMFCDesktopAlertWnd Class](../VS_csharp/cmfcdesktopalertwnd-class.md) to display a custom dialog in a popup window.  
  
## Syntax  
  
```  
class CMFCDesktopAlertDialog : public CDialogEx  
```  
  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCDesktopAlertDialog::CreateFromParams](#cmfcdesktopalertdialog__createfromparams)||  
|[CMFCDesktopAlertDialog::GetDlgSize](#cmfcdesktopalertdialog__getdlgsize)||  
|[CMFCDesktopAlertDialog::HasFocus](#cmfcdesktopalertdialog__hasfocus)||  
|[CMFCDesktopAlertDialog::PreTranslateMessage](#cmfcdesktopalertdialog__pretranslatemessage)|(Overrides `CDialogEx::PreTranslateMessage`.)|  
  
### Remarks  
 Perform the following steps to display a custom dialog in a popup window:  
  
1.  Derive a class from `CMFCDesktopAlertDialog`.  
  
2.  Create a child dialog template in the resources of the project.  
  
3.  Call [CMFCDesktopAlertWnd::Create](../VS_csharp/cmfcdesktopalertwnd-class.md#cmfcdesktopalertwnd__create) with the resource ID of the dialog template and a pointer to the runtime class information of the derived class as parameters.  
  
4.  Program the custom dialog to handle all notifications that are coming from the hosted controls, or program the hosted controls to handle these notifications directly.  
  
## Inheritance Hierarchy  
 [CObject](../VS_csharp/cobject-class.md)  
  
 [CCmdTarget](../VS_csharp/ccmdtarget-class.md)  
  
 [CWnd](../VS_csharp/cwnd-class.md)  
  
 [CDialog](../VS_csharp/cdialog-class.md)  
  
 [CDialogEx](../VS_csharp/cdialogex-class.md)  
  
 [CMFCDesktopAlertDialog](../VS_csharp/cmfcdesktopalertdialog-class.md)  
  
## Requirements  
 **Header:** afxDesktopAlertDialog.h  
  
##  <a name="cmfcdesktopalertdialog__createfromparams"></a>  CMFCDesktopAlertDialog::CreateFromParams  
 [!INCLUDE[cpp_fp_under_construction](../VS_csharp/includes/cpp_fp_under_construction_md.md)]  
  
```  
BOOL CreateFromParams(  
   CMFCDesktopAlertWndInfo& params,  
   CMFCDesktopAlertWnd* pParent  
);  
```  
  
### Parameters  
 [in] `params`  
  [in] `pParent`  
  
### Return Value  
  
### Remarks  
  
##  <a name="cmfcdesktopalertdialog__getdlgsize"></a>  CMFCDesktopAlertDialog::GetDlgSize  
 [!INCLUDE[cpp_fp_under_construction](../VS_csharp/includes/cpp_fp_under_construction_md.md)]  
  
```  
CSize GetDlgSize();  
```  
  
### Return Value  
  
### Remarks  
  
##  <a name="cmfcdesktopalertdialog__hasfocus"></a>  CMFCDesktopAlertDialog::HasFocus  
 [!INCLUDE[cpp_fp_under_construction](../VS_csharp/includes/cpp_fp_under_construction_md.md)]  
  
```  
BOOL HasFocus() const;  
```  
  
### Return Value  
  
### Remarks  
  
##  <a name="cmfcdesktopalertdialog__pretranslatemessage"></a>  CMFCDesktopAlertDialog::PreTranslateMessage  
 [!INCLUDE[cpp_fp_under_construction](../VS_csharp/includes/cpp_fp_under_construction_md.md)]  
  
```  
virtual BOOL PreTranslateMessage(  
   MSG* pMsg  
);  
```  
  
### Parameters  
 [in] `pMsg`  
  
### Return Value  
  
### Remarks  
  
## See Also  
 [Hierarchy Chart](../VS_csharp/hierarchy-chart.md)   
 [Classes](../VS_csharp/mfc-classes.md)   
 [CMFCDesktopAlertWnd Class](../VS_csharp/cmfcdesktopalertwnd-class.md)   
 [CMFCDesktopAlertWndInfo Class](../VS_csharp/cmfcdesktopalertwndinfo-class.md)   
 [CDialogEx Class](../VS_csharp/cdialogex-class.md)