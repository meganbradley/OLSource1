---
title: "CDC::SetArcDirection"
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
  - "CDC::SetArcDirection"
  - "CDC.SetArcDirection"
  - "SetArcDirection"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetArcDirection method"
  - "CDC class, line-output functions"
ms.assetid: 52684208-cf55-490a-8ded-c2be64b19b5a
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::SetArcDirection
Sets the drawing direction to be used for arc and rectangle functions.  
  
## Syntax  
  
```  
  
      int SetArcDirection(  
   int nArcDirection   
);  
```  
  
#### Parameters  
 *nArcDirection*  
 Specifies the new arc direction. This parameter can be either of the following values:  
  
-   **AD_COUNTERCLOCKWISE** Figures drawn counterclockwise.  
  
-   **AD_CLOCKWISE** Figures drawn clockwise.  
  
## Return Value  
 Specifies the old arc direction, if successful; otherwise 0.  
  
## Remarks  
 The default direction is counterclockwise. The `SetArcDirection` function specifies the direction in which the following functions draw:  
  
|Arc|Pie|  
|---------|---------|  
|`ArcTo`|**Rectangle**|  
|`Chord`|`RoundRect`|  
|**Ellipse**||  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::GetArcDirection](../vs140/cdc--getarcdirection.md)   
 [SetArcDirection](http://msdn.microsoft.com/library/windows/desktop/dd162961)