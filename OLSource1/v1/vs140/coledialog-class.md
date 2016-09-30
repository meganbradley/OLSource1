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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[COleDialog::GetLastError](#coledialog__getlasterror)|Gets the error code returned by the dialog box.|  
  
## Remarks  
 The Microsoft Foundation Class Library provides several classes derived from <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>:  
  
-   [COleInsertDialog](../vs140/coleinsertdialog-class.md)  
  
-   [COleConvertDialog](../vs140/coleconvertdialog-class.md)  
  
-   [COleChangeIconDialog](../vs140/colechangeicondialog-class.md)  
  
-   [COleLinksDialog](../vs140/colelinksdialog-class.md)  
  
-   [COleBusyDialog](../vs140/colebusydialog-class.md)  
  
-   [COleUpdateDialog](../vs140/coleupdatedialog-class.md)  
  
-   [COlePasteSpecialDialog](../vs140/colepastespecialdialog-class.md)  
  
-   [COlePropertiesDialog](../vs140/colepropertiesdialog-class.md)  
  
-   [COleChangeSourceDialog](../vs140/colechangesourcedialog-class.md)  
  
 For more information about OLE-specific dialog boxes, see the article [Dialog Boxes in OLE](../vs140/dialog-boxes-in-ole.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CDialog](../vs140/cdialog-class.md)  
  
 [CCommonDialog](../vs140/ccommondialog-class.md)  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxodlgs.h  
  
##  \<a name="coledialog__getlasterror">\</a>  COleDialog::GetLastError  
 Call the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> member function to get additional error information when <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> returns **IDABORT**.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Return Value  
 The error codes returned by <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> depend on the specific dialog box displayed.  
  
### Remarks  
 See the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> member function in the derived classes for information about specific error messages.  
  
## See Also  
 [Base Class](../vs140/ccommondialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)