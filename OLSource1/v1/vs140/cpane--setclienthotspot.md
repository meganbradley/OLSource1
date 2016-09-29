---
title: "CPane::SetClientHotSpot"
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
  - "CPane.SetClientHotSpot"
  - "CPane::SetClientHotSpot"
  - "SetClientHotSpot"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetClientHotSpot method"
ms.assetid: 1ae72fa7-d670-418e-a49b-4c9fffd6e678
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPane::SetClientHotSpot
Sets the *hot spot* for the pane.  
  
## Syntax  
  
```  
void SetClientHotSpot(  
   const CPoint& ptNew  
);  
```  
  
#### Parameters  
 [in] `ptNew`  
 A `CPoint` object that specifies the new hot spot.  
  
## Remarks  
 The *hot spot* is the point on the pane that the user selects and holds to move the pane. A hot spot is used for smooth animation when the pane is dragged from a docked position.  
  
## Requirements  
 **Header:** afxpane.h  
  
## See Also  
 [CPane Class](../vs140/cpane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPane::GetClientHotSpot](../vs140/cpane--getclienthotspot.md)