---
title: "CConnectionPoint::GetStartPosition"
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
  - "CConnectionPoint.GetStartPosition"
  - "CConnectionPoint::GetStartPosition"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetStartPosition method"
ms.assetid: 5b13fe68-8c4a-49a4-805a-065d3cd66d3e
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CConnectionPoint::GetStartPosition
Starts a map iteration by returning a **POSITION** value that can be passed to a [GetNextConnection](../vs140/cconnectionpoint--getnextconnection.md) call.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A **POSITION** value that indicates a starting position for iterating the map; or **NULL** if the map is empty.  
  
## Remarks  
 The iteration sequence is not predictable; therefore, the "first element in the map" has no special significance.  
  
## Example  
 See the example for [CConnectionPoint::GetNextConnection](../vs140/cconnectionpoint--getnextconnection.md).  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [CConnectionPoint Class](../vs140/cconnectionpoint-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)