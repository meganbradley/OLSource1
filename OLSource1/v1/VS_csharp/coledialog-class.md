---
title: "COleDialog Class"
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
  - "COleDialog"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OLE dialog boxes, base class"
  - "dialog boxes, OLE"
  - "COleDialog class"
ms.assetid: b1ed0aca-3914-4b00-af34-4a4fb491aec7
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDialog Class
Provides functionality common to dialog boxes for OLE.  
  
## Syntax  
  
```  
class COleDialog : public CCommonDialog  
```  
  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[COleDialog::GetLastError](#coledialog__getlasterror)|Gets the error code returned by the dialog box.|  
  
## Remarks  
 The Microsoft Foundation Class Library provides several classes derived from `COleDialog`:  
  
-   [COleInsertDialog](../VS_csharp/coleinsertdialog-class.md)  
  
-   [COleConvertDialog](../VS_csharp/coleconvertdialog-class.md)  
  
-   [COleChangeIconDialog](../VS_csharp/colechangeicondialog-class.md)  
  
-   [COleLinksDialog](../VS_csharp/colelinksdialog-class.md)  
  
-   [COleBusyDialog](../VS_csharp/colebusydialog-class.md)  
  
-   [COleUpdateDialog](../VS_csharp/coleupdatedialog-class.md)  
  
-   [COlePasteSpecialDialog](../VS_csharp/colepastespecialdialog-class.md)  
  
-   [COlePropertiesDialog](../VS_csharp/colepropertiesdialog-class.md)  
  
-   [COleChangeSourceDialog](../VS_csharp/colechangesourcedialog-class.md)  
  
 For more information about OLE-specific dialog boxes, see the article [Dialog Boxes in OLE](../VS_csharp/dialog-boxes-in-ole.md).  
  
## Inheritance Hierarchy  
 [CObject](../VS_csharp/cobject-class.md)  
  
 [CCmdTarget](../VS_csharp/ccmdtarget-class.md)  
  
 [CWnd](../VS_csharp/cwnd-class.md)  
  
 [CDialog](../VS_csharp/cdialog-class.md)  
  
 [CCommonDialog](../VS_csharp/ccommondialog-class.md)  
  
 `COleDialog`  
  
## Requirements  
 **Header:** afxodlgs.h  
  
##  <a name="coledialog__getlasterror"></a>  COleDialog::GetLastError  
 Call the `GetLastError` member function to get additional error information when `DoModal` returns **IDABORT**.  
  
```  
UINT GetLastError( ) const;  
  
```  
  
### Return Value  
 The error codes returned by `GetLastError` depend on the specific dialog box displayed.  
  
### Remarks  
 See the `DoModal` member function in the derived classes for information about specific error messages.  
  
## See Also  
 [Base Class](../VS_csharp/ccommondialog-class.md)   
 [Hierarchy Chart](../VS_csharp/hierarchy-chart.md)