---
title: "CMFCToolBarsCustomizeDialog::FillAllCommandsList"
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
  - "CMFCToolBarsCustomizeDialog.FillAllCommandsList"
  - "FillAllCommandsList"
  - "CMFCToolBarsCustomizeDialog::FillAllCommandsList"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FillAllCommandsList method"
ms.assetid: 4a2b5e96-7b2a-4b22-b30a-e567748e4017
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarsCustomizeDialog::FillAllCommandsList
Populates the provided <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object with the commands in the **All Commands** category.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [out] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A reference to the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object to populate.  
  
## Remarks  
 The **All Commands** category contains the commands of all categories. The [CMFCToolBarsCustomizeDialog::AddButton](../vs140/cmfctoolbarscustomizedialog--addbutton.md) method adds the command that is associated with the provided button to the **All Commands** category for you.  
  
 This method clears the contents of the provided <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object before populating it with the commands in the **All Commands** category.  
  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> class uses this method to populate the double-click event list box.  
  
## Requirements  
 **Header:** afxtoolbarscustomizedialog.h  
  
## See Also  
 [CMFCToolBarsCustomizeDialog Class](../vs140/cmfctoolbarscustomizedialog-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCToolBarsCustomizeDialog::AddButton](../vs140/cmfctoolbarscustomizedialog--addbutton.md)