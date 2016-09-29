---
title: "CONNECTION_IID"
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
  - "CONNECTION_IID"
  - "AFXDISP/CONNECTION_IID"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CONNECTION_IID macro"
ms.assetid: 4ad29be2-cdf2-4d98-907b-92e57f583c2a
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CONNECTION_IID
Use between the `BEGIN_CONNECTION_PART` and `END_CONNECTION_PART` macros to define an interface ID for a connection point supported by your OLE control.  
  
## Syntax  
  
```  
  
CONNECTION_IID(  
iid )  
```  
  
#### Parameters  
 `iid`  
 The interface ID of the interface called by the connection point.  
  
## Remarks  
 The `iid` argument is an interface ID used to identify the interface that the connection point will call on its connected sinks. For example:  
  
 [!code[NVC_MFCConnectionPoints#10](../VS_csharp/codesnippet/CPP/connection_iid_1.h)]  
  
 specifies a connection point that calls the `ISinkInterface` interface.  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [Macros and Globals](../VS_csharp/mfc-macros-and-globals.md)   
 [BEGIN_CONNECTION_PART](../VS_csharp/begin_connection_part.md)   
 [DECLARE_CONNECTION_MAP](../VS_csharp/declare_connection_map.md)   
 [END_CONNECTION_PART](../VS_csharp/end_connection_part.md)