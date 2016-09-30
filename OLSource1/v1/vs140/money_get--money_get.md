---
title: "money_get::money_get"
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
  - "std.money_get.money_get"
  - "money_get.money_get"
  - "std::money_get::money_get"
  - "money_get"
  - "xlocmon/std::money_get::money_get"
  - "money_get::money_get"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "money_get class, constructor"
  - "money_get method"
ms.assetid: 6f4512be-b198-4b0e-b9c5-04f64d1fb6e3
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# money_get::money_get
The constructor for objects of type `money_get` that are used to extract numerical values from sequences representing monetary values.  
  
## Syntax  
  
```  
  
      explicit money  
      _  
      get(  
   size_t _Refs = 0  
);  
```  
  
#### Parameters  
 `_Refs`  
 Integer value used to specify the type of memory management for the object.  
  
## Remarks  
 The possible values for the `_Refs` parameter and their significance are:  
  
-   0: The lifetime of the object is managed by the locales that contain it.  
  
-   1: The lifetime of the object must be manually managed.  
  
-   \> 0: These values are not defined.  
  
 No direct examples are possible, because the destructor is protected.  
  
 The constructor initializes its base object with **locale::**[facet](../vs140/facet-class.md)(**_***Refs*).  
  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [money_get Class](../vs140/money_get-class.md)