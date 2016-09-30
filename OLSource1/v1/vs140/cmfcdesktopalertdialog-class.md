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
The `CMFCDesktopAlertDialog` class is used together with the [CMFCDesktopAlertWnd Class](../vs140/cmfcdesktopalertwnd-class.md) to display a custom dialog in a popup window.  
  
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
  
3.  Call [CMFCDesktopAlertWnd::Create](../vs140/cmfcdesktopalertwnd-class.md#cmfcdesktopalertwnd__create) with the resource ID of the dialog template and a pointer to the runtime class information of the derived class as parameters.  
  
4.  Program the custom dialog to handle all notifications that are coming from the hosted controls, or program the hosted controls to handle these notifications directly.  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CDialog](../vs140/cdialog-class.md)  
  
 [CDialogEx](../vs140/cdialogex-class.md)  
  
 [CMFCDesktopAlertDialog](../vs140/cmfcdesktopalertdialog-class.md)  
  
## Requirements  
 **Header:** afxDesktopAlertDialog.h  
  
##  \<a name="cmfcdesktopalertdialog__createfromparams"></a>  CMFCDesktopAlertDialog::CreateFromParams  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
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
  
##  \<a name="cmfcdesktopalertdialog__getdlgsize"></a>  CMFCDesktopAlertDialog::GetDlgSize  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
```  
CSize GetDlgSize();  
```  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcdesktopalertdialog__hasfocus"></a>  CMFCDesktopAlertDialog::HasFocus  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
```  
BOOL HasFocus() const;  
```  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcdesktopalertdialog__pretranslatemessage"></a>  CMFCDesktopAlertDialog::PreTranslateMessage  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
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
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CMFCDesktopAlertWnd Class](../vs140/cmfcdesktopalertwnd-class.md)   
 [CMFCDesktopAlertWndInfo Class](../vs140/cmfcdesktopalertwndinfo-class.md)   
 [CDialogEx Class](../vs140/cdialogex-class.md)