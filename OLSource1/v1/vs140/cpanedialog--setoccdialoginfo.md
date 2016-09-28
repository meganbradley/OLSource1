---
title: "CPaneDialog::SetOccDialogInfo"
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
  - "SetOccDialogInfo"
  - "CPaneDialog.SetOccDialogInfo"
  - "CPaneDialog::SetOccDialogInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetOccDialogInfo method"
ms.assetid: ee24c6e7-3bfb-4f5e-8236-28462c65adeb
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPaneDialog::SetOccDialogInfo
Specifies the template for a dialog box that is an OLE control container.  
  
## Syntax  
  
```  
virtual BOOL SetOccDialogInfo(  
   _AFX_OCC_DIALOG_INFO* pOccDialogInfo  
);  
```  
  
#### Parameters  
 [in] `pOccDialogInfo`  
 Pointer to a dialog box template that is used to create the dialog box object. The value of this parameter is subsequently passed into the [COccManager::CreateDlgControls](../vs140/coccmanager--createdlgcontrols.md) method.  
  
## Return Value  
 Always `TRUE`.  
  
## Remarks  
 This method supports the [COccManager](../vs140/coccmanager-class.md) class, which manages OLE control sites and ActiveX controls. The _AFX_OCC_DIALOG_INFO structure is defined in the afxocc.h header file.  
  
## Requirements  
 **Header:** afxpanedialog.h  
  
## See Also  
 [CPaneDialog Class](../vs140/cpanedialog-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [COccManager Class](../vs140/coccmanager-class.md)   
 [MFC ActiveX Controls](../vs140/mfc-activex-controls.md)