---
title: "CCheckListBox::GetCheck"
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
  - "CCheckListBox::GetCheck"
  - "CCheckListBox.GetCheck"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetCheck method"
ms.assetid: dd019fbd-5856-4e50-a108-1710f53f1dab
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CCheckListBox::GetCheck
Retrieves the state of the specified check box.  
  
## Syntax  
  
```  
int GetCheck(  
   int nIndex   
);  
```  
  
#### Parameters  
 `nIndex`  
 Zero-based index of a check box that is contained in the list box.  
  
## Return Value  
 The state of the specified check box. The following table lists possible values.  
  
|Value|Description|  
|-----------|-----------------|  
|`BST_CHECKED`|The check box is checked.|  
|`BST_UNCHECKED`|The check box is not checked.|  
|`BST_INDETERMINATE`|The check box state is indeterminate.|  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CCheckListBox Class](../vs140/cchecklistbox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CCheckListBox::OnGetCheckPosition](../vs140/cchecklistbox--ongetcheckposition.md)   
 [CCheckListBox::SetCheck](../vs140/cchecklistbox--setcheck.md)   
 [CCheckListBox::SetCheckStyle](../vs140/cchecklistbox--setcheckstyle.md)   
 [CCheckListBox::GetCheckStyle](../vs140/cchecklistbox--getcheckstyle.md)