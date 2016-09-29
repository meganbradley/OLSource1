---
title: "CTaskDialog::SetExpansionArea"
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
  - "CTaskDialog::SetExpansionArea"
  - "CTaskDialog.SetExpansionArea"
  - "SetExpansionArea"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetExpansionArea method"
ms.assetid: 60f47da5-0000-4e77-93e7-cf6eb028e8ca
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTaskDialog::SetExpansionArea
Updates the expansion area of the `CTaskDialog`.  
  
## Syntax  
  
```  
void SetExpansionArea(  
   const CString& strExpandedInformation,  
   const CString& strCollapsedLabel = _T(""),  
   const CString& strExpandedLabel = _T("")  
);  
```  
  
#### Parameters  
 [in] `strExpandedInformation`  
 The string that the `CTaskDialog` displays in the main body of the dialog box when the user clicks the expansion button.  
  
 [in] `strCollapsedLabel`  
 The string that the `CTaskDialog` displays next to the expansion button when the expanded area is collapsed.  
  
 [in] `strExpandedLabel`  
 The string that the `CTaskDialog` displays next to the expansion button when the expanded area is displayed.  
  
## Remarks  
 The expansion area of the [CTaskDialog Class](../vs140/ctaskdialog-class.md) enables you to provide additional information to the user. The expansion area is in the main part of the `CTaskDialog`, located immediately underneath the title and content string.  
  
 When the `CTaskDialog` is first displayed, it does not show the expanded information and puts `strCollapsedLabel` next to the expansion button. When the user clicks the expansion button, the `CTaskDialog` displays `strExpandedInformation` and changes the label to `strExpandedLabel`.  
  
## Example  
 [!code[NVC_MFC_CTaskDialog#7](../vs140/codesnippet/CPP/ctaskdialog--setexpansionarea_1.cpp)]  
  
## Requirements  
 **Header:** afxtaskdialog.h  
  
## See Also  
 [CTaskDialog Class](../vs140/ctaskdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTaskDialog::CTaskDialog](../vs140/ctaskdialog--ctaskdialog.md)