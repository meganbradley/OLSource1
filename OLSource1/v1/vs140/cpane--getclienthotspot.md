---
title: "CPane::GetClientHotSpot"
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
  - CPane.GetClientHotSpot
  - CPane::GetClientHotSpot
  - GetClientHotSpot
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetClientHotSpot method
ms.assetid: 6e23326f-dbd4-4802-bb22-0a3acae50c3a
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CPane::GetClientHotSpot
Returns the *hot spot* for the pane.  
  
## Syntax  
  
```  
CPoint GetClientHotSpot() const;  
```  
  
## Return Value  
  
## Remarks  
 The *hot spot* is the point on the pane that the user selects and holds to move the pane. A hot spot is used for smooth animation when the pane is moved from a docked position.  
  
## Requirements  
 **Header:** afxpane.h  
  
## See Also  
 [CPane Class](../vs140/cpane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPane::SetClientHotSpot](../vs140/cpane--setclienthotspot.md)