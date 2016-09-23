---
title: "CSmartDockingInfo::m_sizeTotal"
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
  - m_sizeTotal
  - CSmartDockingInfo.m_sizeTotal
  - CSmartDockingInfo::m_sizeTotal
dev_langs: 
  - C++
helpviewer_keywords: 
  - m_sizeTotal
  - CSmartDockingInfo class, data members
ms.assetid: 0c02c1a7-a0b2-44fa-a846-3423e175e128
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CSmartDockingInfo::m_sizeTotal
Specifies the total size of a bounding rectangle that encloses all smart docking markers in the central group.  
  
## Syntax  
  
```  
CSize m_sizeTotal;  
```  
  
## Remarks  
 Set `m_sizeTotal` to the size of the bounding rectangle of the central group marker. You are required to specify this value if you are using custom bitmaps for markers.  
  
## Requirements  
 **Header:** afxDockingManager.h  
  
## See Also  
 [CSmartDockingInfo Class](../vs140/csmartdockinginfo-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)