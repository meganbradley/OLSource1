---
title: "DECLARE_PROTECT_FINAL_CONSTRUCT"
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
  - "DECLARE_PROTECT_FINAL_CONSTRUCT"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DECLARE_PROTECT_FINAL_CONSTRUCT macro"
ms.assetid: 2d2e5ddc-057a-43ca-87c8-d3477a8193a0
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DECLARE_PROTECT_FINAL_CONSTRUCT
Protects your object from being deleted if (during [FinalConstruct](../Topic/CComObjectRootEx::FinalConstruct.md)) the internal aggregated object increments the reference count then decrements the count to 0.  
  
## Syntax  
  
```  
  
DECLARE_PROTECT_FINAL_CONSTRUCT( )  
  
```  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [Aggregation and Class Factory Macros](../VS_csharp/aggregation-and-class-factory-macros.md)   
 [Macros](../VS_csharp/atl-macros.md)