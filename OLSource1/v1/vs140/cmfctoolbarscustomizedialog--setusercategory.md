---
title: "CMFCToolBarsCustomizeDialog::SetUserCategory"
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
  - "CMFCToolBarsCustomizeDialog::SetUserCategory"
  - "CMFCToolBarsCustomizeDialog.SetUserCategory"
  - "SetUserCategory"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetUserCategory method"
ms.assetid: 307489e8-35c8-4942-ad1e-42b9a7c88522
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarsCustomizeDialog::SetUserCategory
Specifies which category in the list of categories on the **Commands** page is the user category. You must call this function before you call [CMFCToolBarsCustomizeDialog::Create](../vs140/cmfctoolbarscustomizedialog--create.md).  
  
## Syntax  
  
```  
BOOL SetUserCategory(  
   LPCTSTR lpszCategory   
);  
```  
  
#### Parameters  
 [in] `lpszCategory`  
 The name of the category.  
  
## Return Value  
 `TRUE` if the method is successful; otherwise `FALSE`.  
  
## Remarks  
 The user category setting is not currently used by the framework.  
  
## Requirements  
 **Header:** afxToolBarsCustomizeDialog.h  
  
## See Also  
 [CMFCToolBarsCustomizeDialog Class](../vs140/cmfctoolbarscustomizedialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)