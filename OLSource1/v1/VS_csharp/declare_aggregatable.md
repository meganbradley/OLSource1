---
title: "DECLARE_AGGREGATABLE"
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
  - "DECLARE_AGGREGATABLE"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DECLARE_AGGREGATABLE macro"
ms.assetid: e7e568d7-04e0-4226-b5dc-224deed229ab
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DECLARE_AGGREGATABLE
Specifies that your object can be aggregated.  
  
## Syntax  
  
```  
  
      DECLARE_AGGREGATABLE(   
   x    
)  
```  
  
#### Parameters  
 *x*  
 [in] The name of the class you are defining as aggregatable.  
  
## Remarks  
 [CComCoClass](../VS_csharp/ccomcoclass-class.md) contains this macro to specify the default aggregation model. To override this default, specify either the [DECLARE_NOT_AGGREGATABLE](../VS_csharp/declare_not_aggregatable.md) or [DECLARE_ONLY_AGGREGATABLE](../VS_csharp/declare_only_aggregatable.md) macro in your class definition.  
  
## Example  
 [!code[NVC_ATL_Windowing#121](../VS_csharp/codesnippet/CPP/declare_aggregatable_1.h)]  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [Aggregation and Class Factory Macros](../VS_csharp/aggregation-and-class-factory-macros.md)   
 [Macros](../VS_csharp/atl-macros.md)