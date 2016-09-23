---
title: "CBaseTabbedPane::GetMinSize"
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
  - GetMinSize
  - CBaseTabbedPane.GetMinSize
  - CBaseTabbedPane::GetMinSize
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetMinSize method
ms.assetid: 2f5f01b5-f24d-4610-9524-0649fc9a5ae0
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CBaseTabbedPane::GetMinSize
Retrieves the minimum allowed size for the pane.  
  
## Syntax  
  
```  
virtual void GetMinSize(  
   CSize& size  
) const;  
```  
  
#### Parameters  
 [out] `size`  
 A `CSize` object that is filled with the minimum allowed size.  
  
## Remarks  
 If consistent handling of minimum pane sizes is active ([CPane::m_bHandleMinSize](../vs140/cpane--m_bhandleminsize.md)), `size` is filled with the minimum allowed size for the active tab. Otherwise, `size` is filled with the return value of [CPane::GetMinSize](../vs140/cpane--getminsize.md).  
  
## Requirements  
 **Header:** afxbasetabbedpane.h  
  
## See Also  
 [CBaseTabbedPane Class](../vs140/cbasetabbedpane-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)