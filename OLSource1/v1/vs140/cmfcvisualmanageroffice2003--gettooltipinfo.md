---
title: "CMFCVisualManagerOffice2003::GetToolTipInfo"
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
  - GetToolTipInfo
  - CMFCVisualManagerOffice2003.GetToolTipInfo
  - CMFCVisualManagerOffice2003::GetToolTipInfo
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetToolTipInfo method
ms.assetid: b5d4a3e9-e005-4ad7-8b42-8ab681b771a6
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCVisualManagerOffice2003::GetToolTipInfo
Called by the framework to get tooltip information.  
  
## Syntax  
  
```  
virtual BOOL GetToolTipInfo(  
   CMFCToolTipInfo& params,  
   UINT nType = (UINT)(-1)  
);  
```  
  
#### Parameters  
 [out] `params`  
 A reference to a [CMFCToolTipInfo](../vs140/cmfctooltipinfo-class.md) object where this method returns tooltip information.  
  
 [in] `nType`  
 Type information for the tooltip information to be returned.  
  
## Return Value  
 Returns `TRUE` if tooltip information is returned, and `FALSE` otherwise.  
  
## Remarks  
  
## Requirements  
 **Header:** afxvisualmanageroffice2003.h  
  
## See Also  
 [CMFCVisualManagerOffice2003 Class](../vs140/cmfcvisualmanageroffice2003-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)