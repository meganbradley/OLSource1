---
title: "CAutoHideDockSite::SetOffsetRight"
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
  - "SetOffsetRight"
  - "CAutoHideDockSite.SetOffsetRight"
  - "CAutoHideDockSite::SetOffsetRight"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetOffsetRight method"
ms.assetid: 94c9ecaf-a6f4-4117-ba7f-be421a77162e
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAutoHideDockSite::SetOffsetRight
Sets the margin on the right side of the docking bar.  
  
## Syntax  
  
```  
void SetOffsetRight(  
   int nOffset   
);  
```  
  
#### Parameters  
 [in] `nOffset`  
 The new offset.  
  
## Remarks  
 [CMFCAutoHideBar](../vs140/cmfcautohidebar-class.md) objects are positioned statically on the [CAutoHideDockSite](../vs140/cautohidedocksite-class.md) object. This means that the user cannot manually change the location of the `CMFCAutoHideBar` objects. The `SetOffsetRight` method controls the spacing between the right side of the right-most `CMFCAutoHideBar` and the right side of the `CAutoHideDockSite`.  
  
## Requirements  
 **Header:** afxautohidedocksite.h  
  
## See Also  
 [CAutoHideDockSite Class](../vs140/cautohidedocksite-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)