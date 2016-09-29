---
title: "CConnectionPoint::GetNextConnection"
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
  - "GetNextConnection"
  - "CConnectionPoint.GetNextConnection"
  - "CConnectionPoint::GetNextConnection"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetNextConnection method"
ms.assetid: 16c2bc3f-5b8a-405b-857f-d2c50055ac9d
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CConnectionPoint::GetNextConnection
Retrieves a pointer to the connection element at `pos`.  
  
## Syntax  
  
```  
  
      LPUNKNOWN GetNextConnection(  
   POSITION& pos  
) const;  
```  
  
#### Parameters  
 `pos`  
 Specifies a reference to a **POSITION** value returned by a previous `GetNextConnection` or [GetStartPosition](../vs140/cconnectionpoint--getstartposition.md) call.  
  
## Return Value  
 A pointer to the connection element specified by `pos`, or NULL.  
  
## Remarks  
 This function is most useful for iterating through all the elements in the connection map. When iterating, skip any NULLs returned from this function.  
  
## Example  
 [!code[NVC_MFCConnectionPoints#4](../vs140/codesnippet/CPP/cconnectionpoint--getnextconnection_1.cpp)]  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [CConnectionPoint Class](../vs140/cconnectionpoint-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)