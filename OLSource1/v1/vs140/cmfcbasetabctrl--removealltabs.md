---
title: "CMFCBaseTabCtrl::RemoveAllTabs"
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
  - RemoveAllTabs
  - CMFCBaseTabCtrl.RemoveAllTabs
  - CMFCBaseTabCtrl::RemoveAllTabs
dev_langs: 
  - C++
helpviewer_keywords: 
  - RemoveAllTabs method
ms.assetid: f227533f-3b94-4b38-a91a-887ba9939a97
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCBaseTabCtrl::RemoveAllTabs
Removes all the tabs from the tab control.  
  
## Syntax  
  
```  
virtual void RemoveAllTabs();  
```  
  
## Remarks  
 If [CMFCBaseTabCtrl::m_bAutoDestroyWindow](../vs140/cmfcbasetabctrl--m_bautodestroywindow.md) is `TRUE`, the framework deletes all the [CWnd](../vs140/cwnd-class.md) objects attached to the removed tabs.  
  
## Requirements  
 **Header:** afxbasetabctrl.h  
  
## See Also  
 [CMFCBaseTabCtrl Class](../vs140/cmfcbasetabctrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)