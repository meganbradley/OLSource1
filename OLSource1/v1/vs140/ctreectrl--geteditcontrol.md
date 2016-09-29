---
title: "CTreeCtrl::GetEditControl"
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
  - "CTreeCtrl::GetEditControl"
  - "CTreeCtrl.GetEditControl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetEditControl method"
ms.assetid: e4f476f9-4ae8-4518-ad97-1434e9cc7e4f
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTreeCtrl::GetEditControl
Call this function to retrieve the handle of the edit control being used to edit a tree view item's text.  
  
## Syntax  
  
```  
  
CEdit* GetEditControl( ) const;  
```  
  
## Return Value  
 A pointer to the edit control used to edit the item text, if successful; otherwise **NULL**.  
  
## Example  
 [!code[NVC_MFC_CTreeCtrl#10](../vs140/codesnippet/CPP/ctreectrl--geteditcontrol_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CTreeCtrl Class](../vs140/ctreectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTreeCtrl::EditLabel](../vs140/ctreectrl--editlabel.md)