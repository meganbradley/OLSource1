---
title: "CCheckListBox::SetCheckStyle"
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
  - CCheckListBox.SetCheckStyle
  - SetCheckStyle
  - CCheckListBox::SetCheckStyle
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetCheckStyle method
ms.assetid: 96c6128e-74cc-45a5-84be-68223f155afe
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CCheckListBox::SetCheckStyle
Call this function to set the style of check boxes in the checklist box.  
  
## Syntax  
  
```  
  
      void SetCheckStyle(  
   UINT nStyle   
);  
```  
  
#### Parameters  
 `nStyle`  
 Determines the style of check boxes in the checklist box.  
  
## Remarks  
 Valid styles are:  
  
-   **BS_CHECKBOX**  
  
-   **BS_AUTOCHECKBOX**  
  
-   **BS_AUTO3STATE**  
  
-   **BS_3STATE**  
  
 For information on these styles, see [Button Styles](../vs140/button-styles.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CCheckListBox Class](../vs140/cchecklistbox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CCheckListBox::SetCheck](../vs140/cchecklistbox--setcheck.md)   
 [CCheckListBox::GetCheck](../vs140/cchecklistbox--getcheck.md)   
 [CCheckListBox::GetCheckStyle](../vs140/cchecklistbox--getcheckstyle.md)