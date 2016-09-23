---
title: "CSmartDockingInfo::m_clrToneSrc"
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
  - CSmartDockingInfo.m_clrToneSrc
  - m_clrToneSrc
  - CSmartDockingInfo::m_clrToneSrc
dev_langs: 
  - C++
helpviewer_keywords: 
  - m_clrToneSrc
  - CSmartDockingInfo class, data members
ms.assetid: b1a6c8ce-dbdf-4b13-a164-dab2e4c11e03
caps.latest.revision: 11
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CSmartDockingInfo::m_clrToneSrc
Specifies the color of smart docking marker bitmaps.  
  
## Syntax  
  
```  
COLORREF m_clrToneSrc;  
```  
  
## Remarks  
 Set this value only when you want to replace the color of a custom bitmap with another color. You do not have to set this value if you are changing the color of a standard (framework provided) marker.  
  
 Use `(COLORREF)-1` to leave a member of the smart docking group empty.  
  
## Requirements  
 **Header:** afxDockingManager.h  
  
## See Also  
 [CSmartDockingInfo Class](../vs140/csmartdockinginfo-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)