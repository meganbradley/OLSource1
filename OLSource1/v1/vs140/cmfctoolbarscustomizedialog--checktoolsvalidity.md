---
title: "CMFCToolBarsCustomizeDialog::CheckToolsValidity"
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
  - "CMFCToolBarsCustomizeDialog.CheckToolsValidity"
  - "CheckToolsValidity"
  - "CMFCToolBarsCustomizeDialog::CheckToolsValidity"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CheckToolsValidity method"
ms.assetid: a2f66fa0-6ad4-43a4-b415-f4d93531ad18
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarsCustomizeDialog::CheckToolsValidity
Verifies the validity of the list of user tools.  
  
## Syntax  
  
```  
virtual BOOL CheckToolsValidity(  
   const CObList& lstTools   
);  
```  
  
#### Parameters  
 [in] `lstTools`  
 The list of user-defined tools to check.  
  
## Return Value  
 Returns `TRUE` if the list of user-defined tools is valid; otherwise `FALSE`. The default implementation always returns `TRUE`.  
  
## Remarks  
 The framework calls this method to verify the validity of objects that represent user-defined tools returned by [CMFCToolBarsCustomizeDialog::CheckToolsValidity](../vs140/cmfctoolbarscustomizedialog--checktoolsvalidity.md).  
  
 Override the `CheckToolsValidity` method in a class derived from [CMFCToolBarsCustomizeDialog](../vs140/cmfctoolbarscustomizedialog-class.md) if you want to validate the user tools before the user closes the dialog box. If this method returns `FALSE` when the user clicks either the **Close** button in the upper-right corner of the dialog box or the button labeled **Close** in the lower-right corner of the dialog box, the dialog box displays the **Tools** tab instead of closing. If this method returns `FALSE` when the user clicks a tab to navigate away from the **Tools** tab, the navigation does not occur. You should display an appropriate message box to inform the user of the problem that caused validation to fail.  
  
## Requirements  
 **Header:** afxToolBarsCustomizeDialog.h  
  
## See Also  
 [CMFCToolBarsCustomizeDialog Class](../vs140/cmfctoolbarscustomizedialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)