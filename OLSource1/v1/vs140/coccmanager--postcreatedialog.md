---
title: "COccManager::PostCreateDialog"
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
  - "PostCreateDialog"
  - "COccManager::PostCreateDialog"
  - "COccManager.PostCreateDialog"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COccManager class, overridables"
  - "PostCreateDialog method"
ms.assetid: 6751215e-c37c-4492-8841-71e2c171d0a7
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COccManager::PostCreateDialog
Called by the framework to free memory allocated for the dialog template.  
  
## Syntax  
  
```  
  
      virtual void PostCreateDialog(  
   _AFX_OCC_DIALOG_INFO* pOccDialogInfo   
);  
```  
  
#### Parameters  
 `pOccDialogInfo`  
 An **_AFX_OCC_DIALOG_INFO** structure containing information on the dialog template and any ActiveX controls hosted by the dialog.  
  
## Remarks  
 This memory was allocated by a call to `SplitDialogTemplate`, and was used for any hosted ActiveX controls in the dialog box.  
  
 Override this function to customize the process of cleaning up any resources used by the dialog box object.  
  
## Requirements  
 **Header:** afxocc.h  
  
## See Also  
 [COccManager Class](../vs140/coccmanager-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COccManager::SplitDialogTemplate](../vs140/coccmanager--splitdialogtemplate.md)   
 [COccManager::PreCreateDialog](../vs140/coccmanager--precreatedialog.md)