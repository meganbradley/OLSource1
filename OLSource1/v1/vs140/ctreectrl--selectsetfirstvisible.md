---
title: "CTreeCtrl::SelectSetFirstVisible"
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
  - "TVM_SELECTITEM"
  - "SelectSetFirstVisible"
  - "CTreeCtrl::SelectSetFirstVisible"
  - "CTreeCtrl.SelectSetFirstVisible"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SelectSetFirstVisible method"
  - "TVM_SELECTITEM"
ms.assetid: 2857f8dc-a77b-483d-b6c2-46187078175b
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTreeCtrl::SelectSetFirstVisible
Call this function to scroll the tree view vertically so that the given item is the first visible item.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Handle of the tree item to be set as the first visible item.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 The function sends a message to the window with the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> message parameters.  
  
## Example  
 [!code[NVC_MFC_CTreeCtrl#28](../vs140/codesnippet/CPP/ctreectrl--selectsetfirstvisible_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CTreeCtrl Class](../vs140/ctreectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTreeCtrl::Select](../vs140/ctreectrl--select.md)   
 [CTreeCtrl::SelectItem](../vs140/ctreectrl--selectitem.md)   
 [CTreeCtrl::SelectDropTarget](../vs140/ctreectrl--selectdroptarget.md)