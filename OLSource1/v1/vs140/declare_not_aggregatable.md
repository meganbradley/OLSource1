---
title: "DECLARE_NOT_AGGREGATABLE"
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
  - DECLARE_NOT_AGGREGATABLE
dev_langs: 
  - C++
helpviewer_keywords: 
  - aggregation [C++], changing default
  - DECLARE_NOT_AGGREGATABLE macro
ms.assetid: 2a116c7c-bab8-4f2a-a9ad-03d7aba0f762
caps.latest.revision: 15
translation.priority.ht: 
  - de-de
  - ja-jp
---
# DECLARE_NOT_AGGREGATABLE
Specifies that your object cannot be aggregated.  
  
## Syntax  
  
```  
  
      DECLARE_NOT_AGGREGATABLE(   
   x    
)  
```  
  
#### Parameters  
 *x*  
 [in] The name of the class object you are defining as not aggregatable.  
  
## Remarks  
 `DECLARE_NOT_AGGREGATABLE` causes `CreateInstance` to return an error (**CLASS_E_NOAGGREGATION**) if an attempt is made to aggregate onto your object.  
  
 By default, [CComCoClass](../vs140/ccomcoclass-class.md) contains the [DECLARE_AGGREGATABLE](../vs140/declare_aggregatable.md) macro, which specifies that your object can be aggregated. To override this default behavior, include `DECLARE_NOT_AGGREGATABLE` in your class definition.  
  
## Example  
 [!code[NVC_ATL_Windowing#121](../vs140/codesnippet/CPP/declare_not_aggregatable_1.h)]
  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [Aggregation and Class Factory Macros](../vs140/aggregation-and-class-factory-macros.md)   
 [Macros](../vs140/atl-macros.md)   
 [DECLARE_ONLY_AGGREGATABLE](../vs140/declare_only_aggregatable.md)