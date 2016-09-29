---
title: "CMFCToolBarsCustomizeDialog::OnAfterChangeTool"
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
  - "CMFCToolBarsCustomizeDialog.OnAfterChangeTool"
  - "OnAfterChangeTool"
  - "CMFCToolBarsCustomizeDialog::OnAfterChangeTool"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnAfterChangeTool method"
ms.assetid: b937e3cc-6ca0-4b1d-ac2d-34c8447c6930
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarsCustomizeDialog::OnAfterChangeTool
Responds to a change in a user tool immediately after it occurs.  
  
## Syntax  
  
```  
virtual void OnAfterChangeTool(  
   CUserTool* pSelTool   
);  
```  
  
#### Parameters  
 [in, out] `pSelTool`  
 A pointer to the user tool object that has been changed.  
  
## Remarks  
 This method is called by the framework when a user changes the properties of a user-defined tool. The default implementation does nothing. Override this method in a class derived from [CMFCToolBarsCustomizeDialog](../vs140/cmfctoolbarscustomizedialog-class.md) to perform processing after a change to a user tool occurs.  
  
## Requirements  
 **Header:** afxToolBarsCustomizeDialog.h  
  
## See Also  
 [CMFCToolBarsCustomizeDialog Class](../vs140/cmfctoolbarscustomizedialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)