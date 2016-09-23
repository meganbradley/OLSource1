---
title: "CMFCToolBar::m_dblLargeImageRatio"
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
  - CMFCToolBar.m_dblLargeImageRatio
  - CMFCToolBar::m_dblLargeImageRatio
  - m_dblLargeImageRatio
dev_langs: 
  - C++
helpviewer_keywords: 
  - CMFCToolBar class, data members
  - m_dblLargeImageRatio
ms.assetid: a336ecdb-e9be-4d3c-85c5-23670be87034
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCToolBar::m_dblLargeImageRatio
Specifies the ratio between the dimension (height or width) of large images and the dimension of regular images.  
  
## Syntax  
  
```  
AFX_IMPORT_DATA static double m_dblLargeImageRatio;  
```  
  
## Remarks  
 The default ratio is 2. You can change this value to make large toolbar images larger or smaller.  
  
 The framework uses this data member when you do not specify a set of large images. For example, if you provide only the set of small images with size 16x16 and want the large images to have the size 24x24, set this data member to 1.5.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)