---
title: "CONNECTION_PART"
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
  - "CONNECTION_PART"
  - "AFXDISP/CONNECTION_PART"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CONNECTION_PART macro"
ms.assetid: c0ee38b4-29af-4833-a0cd-8f25d9d5d588
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CONNECTION_PART
Maps a connection point for your OLE control to a specific interface ID.  
  
## Syntax  
  
```  
  
CONNECTION_PART(  
theClass  
,   
iid  
,   
localClass )  
```  
  
#### Parameters  
 `theClass`  
 Specifies the name of the control class whose connection point this is.  
  
 `iid`  
 The interface ID of the interface called by the connection point.  
  
 *localClass*  
 Specifies the name of the local class that implements the connection point.  
  
## Remarks  
 For example:  
  
 [!code[NVC_MFCConnectionPoints#2](../VS_csharp/codesnippet/CPP/connection_part_1.cpp)]  
  
 implements a connection map, with a connection point, that calls the `IID_ISinkInterface` interface .  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [Macros and Globals](../VS_csharp/mfc-macros-and-globals.md)   
 [BEGIN_CONNECTION_PART](../VS_csharp/begin_connection_part.md)   
 [DECLARE_CONNECTION_MAP](../VS_csharp/declare_connection_map.md)   
 [BEGIN_CONNECTION_MAP](../VS_csharp/begin_connection_map.md)   
 [CONNECTION_IID](../VS_csharp/connection_iid.md)