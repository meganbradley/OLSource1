---
title: "CStatusBarCtrl::GetParts"
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
  - "CStatusBarCtrl::GetParts"
  - "GetParts"
  - "CStatusBarCtrl.GetParts"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetParts method"
  - "status bar controls, parts in"
  - "CStatusBarCtrl class, attributes"
ms.assetid: 9d1c345d-f4f9-4b2e-be23-f8e296729928
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStatusBarCtrl::GetParts
Retrieves a count of the parts in a status bar control.  
  
## Syntax  
  
```  
  
      int GetParts(  
   int nParts,  
   int* pParts   
) const;  
```  
  
#### Parameters  
 `nParts`  
 Number of parts for which to retrieve coordinates. If this parameter is greater than the number of parts in the control, the message retrieves coordinates for existing parts only.  
  
 *pParts*  
 Address of an integer array having the same number of elements as the number of parts specified by `nParts`. Each element in the array receives the client coordinate of the right edge of the corresponding part. If an element is set to – 1, the position of the right edge for that part extends to the right edge of the status bar.  
  
## Return Value  
 The number of parts in the control if successful, or zero otherwise.  
  
## Remarks  
 This member function also retrieves the coordinate of the right edge of the given number of parts.  
  
## Example  
 [!code[NVC_MFC_CStatusBarCtrl#3](../vs140/codesnippet/CPP/cstatusbarctrl--getparts_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CStatusBarCtrl Class](../vs140/cstatusbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CStatusBarCtrl::GetBorders](../vs140/cstatusbarctrl--getborders.md)   
 [CStatusBarCtrl::SetParts](../vs140/cstatusbarctrl--setparts.md)