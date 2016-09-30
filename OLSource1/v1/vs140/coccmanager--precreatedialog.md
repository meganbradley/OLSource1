---
title: "COccManager::PreCreateDialog"
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
  - "COccManager::PreCreateDialog"
  - "COccManager.PreCreateDialog"
  - "PreCreateDialog"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COccManager class, overridables"
  - "PreCreateDialog method"
ms.assetid: 4e5cee6d-1cf9-4a5c-bbb6-a48ae2f45f50
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COccManager::PreCreateDialog
Called by the framework to process a dialog template for ActiveX controls before creating the actual dialog box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 An **_AFX_OCC_DIALOG_INFO** structure containing information on the dialog template and any ActiveX controls hosted by the dialog.  
  
 *pOrigTemplate*  
 A pointer to the dialog template to be used in creating the dialog box.  
  
## Return Value  
 A pointer to a dialog template structure used to create the dialog box.  
  
## Remarks  
 The default behavior makes a call to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, determining if there are any ActiveX controls present and then returns the resultant dialog template.  
  
 Override this function to customize the process of creating a dialog box hosting ActiveX controls.  
  
## Requirements  
 **Header:** afxocc.h  
  
## See Also  
 [COccManager Class](../vs140/coccmanager-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COccManager::SplitDialogTemplate](../vs140/coccmanager--splitdialogtemplate.md)   
 [COccManager::PostCreateDialog](../vs140/coccmanager--postcreatedialog.md)