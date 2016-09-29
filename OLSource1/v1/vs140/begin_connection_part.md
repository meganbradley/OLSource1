---
title: "BEGIN_CONNECTION_PART"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "AFXDISP/BEGIN_CONNECTION_PART"
  - "BEGIN_CONNECTION_PART"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "BEGIN_CONNECTION_PART macro"
ms.assetid: b9588d3e-e582-4f53-b1ab-b7ebb4380dbb
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# BEGIN_CONNECTION_PART
Use the `BEGIN_CONNECTION_PART` macro to begin the definition of additional connection points beyond the event and property notification connection points.  
  
## Syntax  
  
```  
  
BEGIN_CONNECTION_PART(  
theClass  
,   
localClass )  
```  
  
#### Parameters  
 `theClass`  
 Specifies the name of the control class whose connection point this is.  
  
 *localClass*  
 Specifies the name of the local class that implements the connection point.  
  
## Remarks  
 In the declaration (.h) file that defines the member functions for your class, start the connection point with the `BEGIN_CONNECTION_PART` macro, then add the `CONNECTION_IID` macro and any other member functions you wish to implement, and complete the connection point map with the `END_CONNECTION_PART` macro.  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [BEGIN_CONNECTION_MAP](../vs140/begin_connection_map.md)   
 [END_CONNECTION_PART](../vs140/end_connection_part.md)   
 [DECLARE_CONNECTION_MAP](../vs140/declare_connection_map.md)