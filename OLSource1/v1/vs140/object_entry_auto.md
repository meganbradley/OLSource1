---
title: "OBJECT_ENTRY_AUTO"
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
  - OBJECT_ENTRY_AUTO
dev_langs: 
  - C++
helpviewer_keywords: 
  - OBJECT_ENTRY_AUTO macro
ms.assetid: 5a0f4fa5-0905-43d2-b337-e22f979c9e4c
caps.latest.revision: 14
translation.priority.ht: 
  - de-de
  - ja-jp
---
# OBJECT_ENTRY_AUTO
Enters an ATL object into the object map, updates the registry, and creates an instance of the object.  
  
## Syntax  
  
```  
  
      OBJECT_ENTRY_AUTO(   
   clsid,   
   class    
)  
```  
  
#### Parameters  
 `clsid`  
 [in] The CLSID of a COM class implemented by the C++ class named `class`.  
  
 `class`  
 [in] The name of the C++ class implementing the COM class represented by `clsid`.  
  
## Remarks  
 Object entry macros are placed at global scope in the project to provide support for the registration, initialization, and creation of a class.  
  
 `OBJECT_ENTRY_AUTO` enters the function pointers of the creator class and class-factory creator class `CreateInstance` functions for this object into the auto-generated ATL object map. When [CAtlComModule::RegisterServer](../vs140/catlcommodule--registerserver.md) is called, it updates the system registry for each object in the object map.  
  
 The table below describes how the information added to the object map is obtained from the class given as the second parameter to this macro.  
  
|Information for|Obtained from|  
|---------------------|-------------------|  
|COM registration|[Registry Macros](../vs140/registry-macros.md)|  
|Class factory creation|[Class Factory Macros](../vs140/aggregation-and-class-factory-macros.md)|  
|Instance creation|[Aggregation Macros](../vs140/aggregation-and-class-factory-macros.md)|  
|Component category registration|[Category Macros](../vs140/category-macros.md)|  
|Class-level initialization and cleanup|[ObjectMain](../vs140/ccomobjectrootex--objectmain.md)|  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [Object Map Macros](../vs140/object-map-macros.md)   
 [Macros](../vs140/atl-macros.md)   
 [OBJECT_ENTRY_NON_CREATEABLE_EX_AUTO](../vs140/object_entry_non_createable_ex_auto.md)   
 [DECLARE_OBJECT_DESCRIPTION](../vs140/declare_object_description.md)   
 [Obsolete ATL Topics](assetId:///7af0223d-148e-4a4c-bf9c-3e916a3b67ec)   
 [OBJECT_ENTRY](assetId:///abd10ee2-54f0-4f94-9ec2-ddf8f4c8c8cd)   
 [OBJECT_ENTRY_NON_CREATEABLE](assetId:///9ccd7065-79d6-4fc6-a4df-ce313bdbd4dc)