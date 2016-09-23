---
title: "CMFCToolBarsCustomizeDialog::RemoveButton"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CMFCToolBarsCustomizeDialog::RemoveButton
  - CMFCToolBarsCustomizeDialog.RemoveButton
  - RemoveButton
dev_langs: 
  - C++
helpviewer_keywords: 
  - RemoveButton method
ms.assetid: 06b36c33-e70d-4934-8926-3dac359058b6
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCToolBarsCustomizeDialog::RemoveButton
Removes the button with the specified command ID from the specified category, or from all categories.  
  
## Syntax  
  
```  
int RemoveButton(  
   UINT uiCategoryId,  
   UINT uiCmdId   
);  
int RemoveButton(  
   LPCTSTR lpszCategory,  
   UINT uiCmdId   
);  
```  
  
#### Parameters  
 [in] `uiCategoryId`  
 Specifies the category ID from which to remove the button.  
  
 [in] `uiCmdId`  
 Specifies the command ID of the button.  
  
 [in] `lpszCategory`  
 Specifies the name of the category from which to remove the button.  
  
## Return Value  
 The zero-based index of the removed button, or -1 if the specified command ID was not found in the specified category. If `uiCategoryId` is -1, the return value is 0.  
  
## Remarks  
 To remove a button from all categories, call the first overload of this method and set `uiCategoryId` to -1.  
  
## Requirements  
 **Header:** afxToolBarsCustomizeDialog.h  
  
## See Also  
 [CMFCToolBarsCustomizeDialog Class](../vs140/cmfctoolbarscustomizedialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)