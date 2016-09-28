---
title: "CAutoHideDockSite::GetAlignRect"
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
  - "CAutoHideDockSite.GetAlignRect"
  - "GetAlignRect"
  - "CAutoHideDockSite::GetAlignRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetAlignRect method"
ms.assetid: 5b69e6b4-4d01-4f08-81ca-9b7901c5da26
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAutoHideDockSite::GetAlignRect
Retrieves the size of the dock site in screen coordinates.  
  
## Syntax  
  
```  
void GetAlignRect(  
   CRect& rect  
) const;  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] `rect`|A reference to a rectangle. The method stores the size of the dock site in this rectangle.|  
  
## Remarks  
 The rectangle is adjusted for the offset margins so that they are not included.  
  
## Requirements  
 **Header:** afxautohidedocksite.h  
  
## See Also  
 [CAutoHideDockSite Class](../vs140/cautohidedocksite-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)