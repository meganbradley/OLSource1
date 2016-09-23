---
title: "DECLARE_ONLY_AGGREGATABLE"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - DECLARE_ONLY_AGGREGATABLE
dev_langs: 
  - C++
helpviewer_keywords: 
  - aggregation [C++], changing default
  - DECLARE_ONLY_AGGREGATABLE macro
ms.assetid: a54220df-4330-4e4d-b7fb-8b63dd62d337
caps.latest.revision: 15
translation.priority.ht: 
  - de-de
  - ja-jp
---
# DECLARE_ONLY_AGGREGATABLE
Specifies that your object must be aggregated.  
  
## Syntax  
  
```  
  
      DECLARE_ONLY_AGGREGATABLE(   
   x    
)  
```  
  
#### Parameters  
 *x*  
 [in] The name of the class object you are defining as only aggregatable.  
  
## Remarks  
 `DECLARE_ONLY_AGGREGATABLE` causes an error (**E_FAIL**) if an attempt is made to **CoCreate** your object as nonaggregated object.  
  
 By default, [CComCoClass](../vs140/ccomcoclass-class.md) contains the [DECLARE_AGGREGATABLE](../vs140/declare_aggregatable.md) macro, which specifies that your object can be aggregated. To override this default behavior, include `DECLARE_ONLY_AGGREGATABLE` in your class definition.  
  
## Example  
 [!code[NVC_ATL_Windowing#125](../vs140/codesnippet/CPP/declare_only_aggregatable_1.h)]
  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [Aggregation and Class Factory Macros](../vs140/aggregation-and-class-factory-macros.md)   
 [Macros](../vs140/atl-macros.md)   
 [DECLARE_NOT_AGGREGATABLE](../vs140/declare_not_aggregatable.md)