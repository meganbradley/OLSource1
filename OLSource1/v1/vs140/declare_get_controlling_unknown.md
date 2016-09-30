---
title: "DECLARE_GET_CONTROLLING_UNKNOWN"
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
  - "DECLARE_GET_CONTROLLING_UNKNOWN"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DECLARE_GET_CONTROLLING_UNKNOWN macro"
ms.assetid: 82b0199a-a9d5-4f95-a711-fa1ae18e1f77
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DECLARE_GET_CONTROLLING_UNKNOWN
Declares a virtual function `GetControllingUnknown`.  
  
## Syntax  
  
```  
  
DECLARE_GET_CONTROLLING_UNKNOWN( )  
  
```  
  
## Remarks  
 Add this macro to your object if you get the compiler error message that `GetControllingUnknown` is undefined (for example, in **CComAggregateCreator**).  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [Aggregation and Class Factory Macros](../vs140/aggregation-and-class-factory-macros.md)   
 [Macros](../vs140/atl-macros.md)   
 [DECLARE_AGGREGATABLE](../vs140/declare_aggregatable.md)