---
title: "DECLARE_POLY_AGGREGATABLE"
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
  - DECLARE_POLY_AGGREGATABLE
dev_langs: 
  - C++
helpviewer_keywords: 
  - DECLARE_POLY_AGGREGATABLE macro
ms.assetid: 7569e738-cfbc-4404-ba1d-78dcefa3bdb3
caps.latest.revision: 15
translation.priority.ht: 
  - de-de
  - ja-jp
---
# DECLARE_POLY_AGGREGATABLE
Specifies that an instance of **CComPolyObject <** *x* **>** is created when your object is created.  
  
## Syntax  
  
```  
  
      DECLARE_POLY_AGGREGATABLE(   
   x    
)  
```  
  
#### Parameters  
 *x*  
 [in] The name of the class object you are defining as aggregatable or not aggregatable.  
  
## Remarks  
 During creation, the value of the outer unknown is checked. If it is **NULL**, **IUnknown** is implemented for a nonaggregated object. If the outer unknown is not **NULL**, **IUnknown** is implemented for an aggregated object.  
  
 The advantage of using `DECLARE_POLY_AGGREGATABLE` is that you avoid having both `CComAggObject` and `CComObject` in your module to handle the aggregated and nonaggregated cases. A single `CComPolyObject` object handles both cases. This means only one copy of the vtable and one copy of the functions exist in your module. If your vtable is large, this can substantially decrease your module size. However, if your vtable is small, using `CComPolyObject` can result in a slightly larger module size because it is not optimized for an aggregated or nonaggregated object, as are `CComAggObject` and `CComObject`.  
  
 The `DECLARE_POLY_AGGREGATABLE` macro is automatically declared in your object if you use the ATL Control Wizard to create a full control.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [Aggregation and Class Factory Macros](../vs140/aggregation-and-class-factory-macros.md)   
 [Macros](../vs140/atl-macros.md)   
 [CComPolyObject Class](../vs140/ccompolyobject-class.md)   
 [CComAggObject Class](../vs140/ccomaggobject-class.md)   
 [CComObject Class](../vs140/ccomobject-class.md)