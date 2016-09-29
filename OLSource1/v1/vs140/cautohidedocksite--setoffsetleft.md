---
title: "CAutoHideDockSite::SetOffsetLeft"
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
  - "CAutoHideDockSite::SetOffsetLeft"
  - "CAutoHideDockSite.SetOffsetLeft"
  - "SetOffsetLeft"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetOffsetLeft method"
ms.assetid: 6c815f52-a8dd-4435-926a-12a307084a98
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAutoHideDockSite::SetOffsetLeft
Sets the margin on the left side of the docking bar.  
  
## Syntax  
  
```  
void SetOffsetLeft(  
   int nOffset   
);  
```  
  
#### Parameters  
 [in] `nOffset`  
 The new offset.  
  
## Remarks  
 [CMFCAutoHideBar](../vs140/cmfcautohidebar-class.md) objects are positioned statically on the [CAutoHideDockSite](../vs140/cautohidedocksite-class.md) object. This means that the user cannot manually change the location of `CMFCAutoHideBar` objects. The `SetOffsetLeft` method controls the spacing between the left side of the left-most `CMFCAutoHideBar` and the left side of the `CAutoHideDockSite`.  
  
## Requirements  
 **Header:** afxautohidedocksite.h  
  
## See Also  
 [CAutoHideDockSite Class](../vs140/cautohidedocksite-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)