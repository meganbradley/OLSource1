---
title: "CMFCPropertyGridCtrl::EndEditItem"
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
  - "CMFCPropertyGridCtrl.EndEditItem"
  - "CMFCPropertyGridCtrl::EndEditItem"
  - "EndEditItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EndEditItem method"
ms.assetid: 0a697a75-e3d8-40ec-ae8e-742f9476dcd7
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPropertyGridCtrl::EndEditItem
Called by the framework when the user finishes modifying a property.  
  
## Syntax  
  
```  
virtual BOOL EndEditItem(  
   BOOL bUpdateData=TRUE   
);  
```  
  
#### Parameters  
 [in] `bUpdateData`  
 `TRUE` to specify that the modified property data must be validated when the edit operation is complete; otherwise, `FALSE`. The default value is `TRUE`.  
  
## Return Value  
 `TRUE` if the edit operation ends successfully; `FALSE` if the modified property data is not valid or if the editing operation should continue.  
  
## Remarks  
  
## Requirements  
 **Header:** afxpropertygridctrl.h  
  
## See Also  
 [CMFCPropertyGridCtrl Class](../vs140/cmfcpropertygridctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)