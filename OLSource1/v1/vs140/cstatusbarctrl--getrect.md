---
title: "CStatusBarCtrl::GetRect"
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
  - "CStatusBarCtrl::GetRect"
  - "CStatusBarCtrl.GetRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "status bar controls, bounding rectangle"
  - "GetRect method"
  - "CStatusBarCtrl class, attributes"
ms.assetid: 59e19c5b-6b51-4529-92da-5518ebb9719e
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStatusBarCtrl::GetRect
Retrieves the bounding rectangle of a part in a status bar control.  
  
## Syntax  
  
```  
  
      BOOL GetRect(  
   int nPane,  
   LPRECT lpRect   
) const;  
```  
  
#### Parameters  
 `nPane`  
 Zero-based index of the part whose bounding rectangle is to be retrieved.  
  
 `lpRect`  
 Address of a [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure that receives the bounding rectangle.  
  
## Return Value  
 Nonzero if successful; otherwise zero.  
  
## Example  
 [!code[NVC_MFC_CStatusBarCtrl#4](../vs140/codesnippet/CPP/cstatusbarctrl--getrect_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CStatusBarCtrl Class](../vs140/cstatusbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CStatusBarCtrl::GetParts](../vs140/cstatusbarctrl--getparts.md)