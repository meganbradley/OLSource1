---
title: "CDrawingManager::DrawLine, CDrawingManager::DrawLineA"
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
  - "CDrawingManager::DrawLine"
  - "DrawLine"
  - "CDrawingManager::DrawLineA"
  - "CDrawingManager.DrawLine"
  - "DrawLineA"
  - "CDrawingManager.DrawLineA"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DrawLine method"
  - "DrawLineA method"
ms.assetid: 2cf2a208-6591-4d66-ac98-112ac0be31b0
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDrawingManager::DrawLine, CDrawingManager::DrawLineA
Draws a line.  
  
## Syntax  
  
```  
void DrawLine(  
   int x1,  
   int y1,  
   int x2,  
   int y2,  
   COLORREF clrLine  
);  
  
void DrawLineA(  
   double x1,  
   double y1,  
   double x2,  
   double y2,  
   COLORREF clrLine  
);  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] `x1`|The x coordinate where the line starts.|  
|[in] `y1`|The y coordinate where the line starts.|  
|[in] `x2`|The x coordinate where the line ends.|  
|[in] `y2`|The y coordinate where the line ends.|  
|[in] `clrLine`|The color of the line.|  
  
## Remarks  
 This method fails if `clrLine` equals -1.  
  
## Requirements  
 **Header:** afxdrawmanager.h  
  
## See Also  
 [CDrawingManager Class](../vs140/cdrawingmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)