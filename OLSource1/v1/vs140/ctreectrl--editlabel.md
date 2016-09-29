---
title: "CTreeCtrl::EditLabel"
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
  - "CTreeCtrl::EditLabel"
  - "CTreeCtrl.EditLabel"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EditLabel method"
ms.assetid: e7771782-cb3a-43fc-9ce1-94a3c96616be
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTreeCtrl::EditLabel
Call this function to begin in-place editing of the specified item's text.  
  
## Syntax  
  
```  
  
      CEdit* EditLabel(  
   HTREEITEM hItem   
);  
```  
  
#### Parameters  
 `hItem`  
 Handle of the tree item to be edited.  
  
## Return Value  
 If successful, a pointer to the `CEdit` object that is used to edit the item text; otherwise **NULL**.  
  
## Remarks  
 The editing is accomplished by replacing the text of the item with a single-line edit control containing the text.  
  
## Example  
 [!code[NVC_MFC_CTreeCtrl#5](../vs140/codesnippet/CPP/ctreectrl--editlabel_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CTreeCtrl Class](../vs140/ctreectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTreeCtrl::GetEditControl](../vs140/ctreectrl--geteditcontrol.md)