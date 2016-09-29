---
title: "CTreeCtrl::SetItemText"
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
  - "CTreeCtrl::SetItemText"
  - "CTreeCtrl.SetItemText"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetItemText method"
ms.assetid: f6a3e0e0-c92e-4ce1-a0f5-7838b00a5b64
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTreeCtrl::SetItemText
Sets the text of the item specified by `hItem`.  
  
## Syntax  
  
```  
  
      BOOL SetItemText(  
   HTREEITEM hItem,  
   LPCTSTR lpszItem   
);  
```  
  
#### Parameters  
 `hItem`  
 Handle of the item whose text is to be set.  
  
 `lpszItem`  
 Address of a string containing the new text for the item  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Example  
 [!code[NVC_MFC_CTreeCtrl#34](../vs140/codesnippet/CPP/ctreectrl--setitemtext_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CTreeCtrl Class](../vs140/ctreectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTreeCtrl::GetItemText](../vs140/ctreectrl--getitemtext.md)