---
title: "CAutoHideDockSite::m_nExtraSpace"
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
  - "m_nExtraSpace"
  - "CAutoHideDockSite::m_nExtraSpace"
  - "CAutoHideDockSite.m_nExtraSpace"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_nExtraSpace"
  - "CAutoHideDockSite class, data members"
ms.assetid: dd4be432-7319-4716-ab52-0617f608d6ba
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAutoHideDockSite::m_nExtraSpace
The size of the space between the edges of the [CAutoHideDockSite Class](../vs140/cautohidedocksite-class.md) and the [CMFCAutoHideBar Class](../vs140/cmfcautohidebar-class.md) objects.  
  
## Syntax  
  
```  
static int m_nExtraSpace;  
```  
  
## Remarks  
 When a `CMFCAutoHideBar` is docked at a `CAutoHideDockSite`, it should not occupy the whole dock site. This global variable controls the extra space between the left or top border of the `CMFCAutoHideBar` and the corresponding `CAutoHideDockSite` edge. Whether the top or left edge is used depends on the current alignment.  
  
## Requirements  
 **Header:** afxautohidedocksite.h  
  
## See Also  
 [CAutoHideDockSite Class](../vs140/cautohidedocksite-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)