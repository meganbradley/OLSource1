---
title: "CMFCDropDownFrame::SetAutoDestroy"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CMFCDropDownFrame::SetAutoDestroy
  - SetAutoDestroy
  - CMFCDropDownFrame.SetAutoDestroy
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetAutoDestroy method
ms.assetid: dcfc452c-bbc7-438f-acc1-1bf8acd21754
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCDropDownFrame::SetAutoDestroy
Sets whether the child drop-down toolbar window is destroyed automatically.  
  
## Syntax  
  
```  
void SetAutoDestroy(  
    BOOL bAutoDestroy = TRUE  
);  
```  
  
#### Parameters  
 [in] `bAutoDestroy`  
 `TRUE` to automatically destroy the associated drop-down toolbar window; otherwise, `FALSE`.  
  
## Remarks  
 If `bAutoDestroy` is `TRUE`, then the `CMFCDropDownFrame` destructor destroys the associated drop-down toolbar window. The default value is `TRUE`.  
  
## Requirements  
 **Header:** afxdropdowntoolbar.h  
  
## See Also  
 [CMFCDropDownFrame Class](../vs140/cmfcdropdownframe-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)