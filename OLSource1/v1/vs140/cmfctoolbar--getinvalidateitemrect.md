---
title: "CMFCToolBar::GetInvalidateItemRect"
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
  - "GetInvalidateItemRect"
  - "CMFCToolBar::GetInvalidateItemRect"
  - "CMFCToolBar.GetInvalidateItemRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetInvalidateItemRect method"
ms.assetid: 48a2eb26-edd5-43d9-ae75-eaec1b1f0fee
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::GetInvalidateItemRect
Retrieves the region of the client area that must be redrawn for the button at the given index.  
  
## Syntax  
  
```  
virtual void GetInvalidateItemRect(  
   int nIndex,  
   LPRECT lpRect  
) const;  
```  
  
#### Parameters  
 [in] `nIndex`  
 The index of the button for which to retrieve the client area.  
  
 [out] `lpRect`  
 A pointer to a `RECT` object that receives the region of the client area.  
  
## Remarks  
 The `lpRect` parameter must not be `NULL`. If no button exists at the provided index, `lpRect` receives a `RECT` object that is initialized to zero.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)