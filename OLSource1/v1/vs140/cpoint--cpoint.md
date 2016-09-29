---
title: "CPoint::CPoint"
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
  - "CPoint.CPoint"
  - "CPoint::CPoint"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CPoint class, constructor"
  - "CPoint class, construction/destruction"
ms.assetid: 8a165dd3-5cf5-4ad2-a738-674856d5fe80
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPoint::CPoint
Constructs a `CPoint` object.  
  
## Syntax  
  
```  
CPoint( ) throw( );   
CPoint(  
    int initX,  
    int initY   
) throw( );  
CPoint(  
    POINT initPt   
) throw( );  
CPoint(  
    SIZE initSize   
) throw( );  
CPoint(  
    LPARAM dwPoint   
) throw( );  
```  
  
#### Parameters  
 `initX`  
 Specifies the value of the `x` member of `CPoint`.  
  
 `initY`  
 Specifies the value of the `y` member of `CPoint`.  
  
 `initPt`  
 [POINT](../vs140/point-structure.md) structure or `CPoint` that specifies the values used to initialize `CPoint`.  
  
 `initSize`  
 [SIZE](http://msdn.microsoft.com/library/windows/desktop/dd145106) structure or [CSize](../vs140/csize-class.md) that specifies the values used to initialize `CPoint`.  
  
 `dwPoint`  
 Sets the `x` member to the low-order word of `dwPoint` and the `y` member to the high-order word of `dwPoint`.  
  
## Remarks  
 If no arguments are given, `x` and `y` members are set to 0.  
  
## Example  
  
```  
  
CPoint   ptTopLeft(0,0);  
  
// works from a POINT, too  
  
POINT   ptHere;  
ptHere.x = 35;  
ptHere.y = 95;  
  
CPoint   ptMFCHere(ptHere);  
  
// works from A SIZE  
  
SIZE   sHowBig;  
sHowBig.cx = 300;  
sHowBig.cy = 10;  
  
CPoint ptMFCBig(sHowBig);  
  
// or from a DWORD  
  
DWORD   dwSize;  
dwSize = MAKELONG(35, 95);  
  
CPoint ptFromDouble(dwSize);  
ASSERT(ptFromDouble == ptMFCHere);     
```  
  
## Requirements  
 Header: atltypes.h  
  
## See Also  
 [CPoint Class](../vs140/cpoint-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)