---
title: "CCheckListBox::SetCheck"
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
  - CCheckListBox.SetCheck
  - CCheckListBox::SetCheck
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetCheck method
ms.assetid: dae358f9-d989-48d7-aec0-18d3c33d9e89
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CCheckListBox::SetCheck
Sets the state of the specified check box.  
  
## Syntax  
  
```  
void SetCheck(  
   int nIndex,  
   int nCheck   
);  
```  
  
#### Parameters  
 `nIndex`  
 Zero-based index of a check box that is contained in the list box.  
  
 `nCheck`  
 The button state for the specified check box. See the Remarks section for possible values.  
  
## Remarks  
 The following table lists possible values for the `nCheck` parameter.  
  
|Value|Description|  
|-----------|-----------------|  
|**BST_CHECKED**|Select the specified check box.|  
|**BST_UNCHECKED**|Clear the specified check box.|  
|**BST_INDETERMINATE**|Set the specified check box state to indeterminate.<br /><br /> This state is only available if the check box style is `BS_AUTO3STATE` or `BS_3STATE`. For more information, see [Button Styles](../vs140/button-styles.md).|  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CCheckListBox Class](../vs140/cchecklistbox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CCheckListBox::SetCheckStyle](../vs140/cchecklistbox--setcheckstyle.md)   
 [CCheckListBox::GetCheck](../vs140/cchecklistbox--getcheck.md)   
 [CCheckListBox::GetCheckStyle](../vs140/cchecklistbox--getcheckstyle.md)