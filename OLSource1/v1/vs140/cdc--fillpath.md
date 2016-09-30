---
title: "CDC::FillPath"
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
  - "CDC.FillPath"
  - "CDC::FillPath"
  - "FillPath"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FillPath method"
  - "CDC class, path functions"
ms.assetid: 70f45fc4-09f4-4afd-af50-56a4a165a343
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::FillPath
Closes any open figures in the current path and fills the path's interior by using the current brush and polygon-filling mode.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
## Remarks  
 After its interior is filled, the path is discarded from the device context.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::BeginPath](../vs140/cdc--beginpath.md)   
 [CDC::SetPolyFillMode](../vs140/cdc--setpolyfillmode.md)   
 [CDC::StrokeAndFillPath](../vs140/cdc--strokeandfillpath.md)   
 [CDC::StrokePath](../vs140/cdc--strokepath.md)   
 [FillPath](http://msdn.microsoft.com/library/windows/desktop/dd162718)