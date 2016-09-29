---
title: "DECLARE_CLASSFACTORY_EX"
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
  - "DECLARE_CLASSFACTORY_EX"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "default class factory, macros"
  - "class factories, changing default"
  - "DECLARE_CLASSFACTORY_EX macro"
ms.assetid: 4181ef00-0f30-4e19-b0ee-e7648062e926
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DECLARE_CLASSFACTORY_EX
Declares `cf` to be the class factory.  
  
## Syntax  
  
```  
  
      DECLARE_CLASSFACTORY_EX(   
   cf    
)  
```  
  
#### Parameters  
 `cf`  
 [in] The name of the class that implements your class factory object.  
  
## Remarks  
 The `cf` parameter must derive from [CComClassFactory](../vs140/ccomclassfactory-class.md) and override the `CreateInstance` method.  
  
 [CComCoClass](../vs140/ccomcoclass-class.md) includes the [DECLARE_CLASSFACTORY](../vs140/declare_classfactory.md) macro, which specifies `CComClassFactory` as the default class factory. However, by including the `DECLARE_CLASSFACTORY_EX` macro in your object's class definition, you override this default.  
  
## Example  
 [!code[NVC_ATL_COM#8](../vs140/codesnippet/CPP/declare_classfactory_ex_1.h)]  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [Aggregation and Class Factory Macros](../vs140/aggregation-and-class-factory-macros.md)   
 [Macros](../vs140/atl-macros.md)   
 [DECLARE_CLASSFACTORY2](../vs140/declare_classfactory2.md)   
 [DECLARE_CLASSFACTORY_AUTO_THREAD](../vs140/declare_classfactory_auto_thread.md)   
 [DECLARE_CLASSFACTORY_SINGLETON](../vs140/declare_classfactory_singleton.md)