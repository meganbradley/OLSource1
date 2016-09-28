---
title: "CFolderPickerDialog Class"
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
  - "afxdlgs/CFolderPickerDialog"
  - "CFolderPickerDialog"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CFolderPickerDialog class"
ms.assetid: 8db01684-dd1d-4e9c-989e-07a2318a8156
caps.latest.revision: 22
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFolderPickerDialog Class
CFolderPickerDialog class implements CFileDialog in the folder picker mode.  
  
## Syntax  
  
```  
class CFolderPickerDialog : public CFileDialog;  
```  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CFolderPickerDialog::~CFolderPickerDialog](#cfolderpickerdialog__~cfolderpickerdialog)|Destructor.|  
|[CFolderPickerDialog::CFolderPickerDialog](#cfolderpickerdialog__cfolderpickerdialog)|Constructor.|  
  
## Remarks  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CDialog](../vs140/cdialog-class.md)  
  
 [CCommonDialog](../vs140/ccommondialog-class.md)  
  
 [CFileDialog](../vs140/cfiledialog-class.md)  
  
 `CFolderPickerDialog`  
  
## Requirements  
 **Header:** afxdlgs.h  
  
##  <a name="cfolderpickerdialog__cfolderpickerdialog"></a>  CFolderPickerDialog::CFolderPickerDialog  
 Constructor.  
  
```  
explicit CFolderPickerDialog(  
   LPCTSTR lpszFolder = NULL,  
   DWORD dwFlags = 0,  
   CWnd* pParentWnd = NULL,  
   DWORD dwSize = 0  
);  
```  
  
### Parameters  
 `lpszFolder`  
 Initial folder.  
  
 `dwFlags`  
 A combination of one or more flags that allow you to customize the dialog box.  
  
 `pParentWnd`  
 A pointer to the dialog box object's parent or owner window.  
  
 `dwSize`  
 The size of the OPENFILENAME structure.  
  
### Remarks  
  
##  <a name="cfolderpickerdialog___dtorcfolderpickerdialog"></a>  CFolderPickerDialog::~CFolderPickerDialog  
 Destructor.  
  
```  
virtual ~CFolderPickerDialog();  
```  
  
### Remarks  
  
## See Also  
 [Classes](../vs140/mfc-classes.md)