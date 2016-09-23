---
title: "CAutoHideDockSite::CanAcceptPane"
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
  - CAutoHideDockSite::CanAcceptPane
  - CanAcceptPane
  - CAutoHideDockSite.CanAcceptPane
dev_langs: 
  - C++
helpviewer_keywords: 
  - CanAcceptPane method
ms.assetid: c0bcaa16-6942-4d23-8101-86abb3a51e52
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CAutoHideDockSite::CanAcceptPane
Determines whether a base pane is a [CMFCAutoHideBar](../vs140/cmfcautohidebar-class.md) object or derived from `CMFCAutoHideBar`.  
  
## Syntax  
  
```  
virtual BOOL CanAcceptPane(  
   const CBasePane* pBar  
) const;  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] `pBar`|The base pane that the framework tests.|  
  
## Return Value  
 `TRUE` if `pBar` is derived from `CMFCAutoHideBar`; `FALSE` otherwise.  
  
## Remarks  
 If a base pane object is derived from `CMFCAutoHideBar`, it can contain a [CAutoHideDockSite](../vs140/cautohidedocksite-class.md).  
  
## Requirements  
 **Header:** afxautohidedocksite.h  
  
## See Also  
 [CAutoHideDockSite Class](../vs140/cautohidedocksite-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)