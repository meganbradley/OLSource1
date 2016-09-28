---
title: "CMFCRibbonButtonsGroup::GetButton"
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
  - "CMFCRibbonButtonsGroup.GetButton"
  - "CMFCRibbonButtonsGroup::GetButton"
  - "GetButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetButton method"
ms.assetid: d5821e23-2315-4ab3-91c8-0888dd327b89
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonButtonsGroup::GetButton
Returns a pointer to the button that is located at a specified index.  
  
## Syntax  
  
```  
CMFCRibbonBaseElement* GetButton(  
   int i   
) const;  
```  
  
#### Parameters  
 [in] `i`  
 A zero-based index of a button to return.  
  
## Return Value  
 A pointer to the button that is located at the specified index. `NULL` if the specified index is out of range.  
  
## Remarks  
  
## Requirements  
 **Header:** afxribbonbuttonsgroup.h  
  
## See Also  
 [CMFCRibbonButtonsGroup Class](../vs140/cmfcribbonbuttonsgroup-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)