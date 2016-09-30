---
title: "COccManager::SplitDialogTemplate"
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
  - "SplitDialogTemplate"
  - "COccManager.SplitDialogTemplate"
  - "COccManager::SplitDialogTemplate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SplitDialogTemplate method"
  - "COccManager class, overridables"
ms.assetid: 9b904622-d64f-44d2-a73e-babcdb84b42c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COccManager::SplitDialogTemplate
Called by the framework to split the ActiveX controls from common dialog controls.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to the dialog template to be examined.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A list of pointers to dialog box items that are ActiveX controls.  
  
## Return Value  
 A pointer to a dialog template structure containing only non-ActiveX controls. If no ActiveX controls are present, **NULL** is returned.  
  
## Remarks  
 If any ActiveX controls are found, the template is analyzed and a new template, containing only non-ActiveX controls, is created. Any ActiveX controls found during this process are added to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 If there are no ActiveX controls in the template, **NULL** is returned*.*  
  
> [!NOTE]
>  Memory allocated for the new template is freed in the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> function.  
  
 Override this function to customize this process.  
  
## Requirements  
 **Header:** afxocc.h  
  
## See Also  
 [COccManager Class](../vs140/coccmanager-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COccManager::PostCreateDialog](../vs140/coccmanager--postcreatedialog.md)   
 [COccManager::PreCreateDialog](../vs140/coccmanager--precreatedialog.md)