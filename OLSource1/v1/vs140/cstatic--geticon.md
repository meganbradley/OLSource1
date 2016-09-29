---
title: "CStatic::GetIcon"
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
  - "CStatic::GetIcon"
  - "CStatic.GetIcon"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CStatic class, operations"
  - "GetIcon method"
ms.assetid: 04ab70ce-ccc1-4418-b047-c109fa6442e1
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStatic::GetIcon
Gets the handle of the icon, previously set with [SetIcon](../vs140/cstatic--seticon.md), that is associated with `CStatic`.  
  
## Syntax  
  
```  
  
HICON GetIcon( ) const;  
```  
  
## Return Value  
 A handle to the current icon, or **NULL** if no icon has been set.  
  
## Example  
 [!code[NVC_MFC_CStatic#6](../vs140/codesnippet/CPP/cstatic--geticon_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CStatic Class](../vs140/cstatic-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CStatic::SetIcon](../vs140/cstatic--seticon.md)   
 [STM_GETICON](http://msdn.microsoft.com/library/windows/desktop/bb760775)   
 [Icons](http://msdn.microsoft.com/library/windows/desktop/ms646973)