---
title: "DECLARE_CLASSFACTORY_AUTO_THREAD"
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
  - "DECLARE_CLASSFACTORY_AUTO_THREAD"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "default class factory, macros"
  - "class factories, changing default"
  - "DECLARE_CLASSFACTORY_AUTO_THREAD macro"
ms.assetid: 19d7105e-03e8-4412-9f5e-5384c8a5e18f
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DECLARE_CLASSFACTORY_AUTO_THREAD
Declares [CComClassFactoryAutoThread](../vs140/ccomclassfactoryautothread-class.md) to be the class factory.  
  
## Syntax  
  
```  
  
DECLARE_CLASSFACTORY_AUTO_THREAD( )  
  
```  
  
## Remarks  
 [CComCoClass](../vs140/ccomcoclass-class.md) includes the [DECLARE_CLASSFACTORY](../vs140/declare_classfactory.md) macro, which specifies [CComClassFactory](../vs140/ccomclassfactory-class.md) as the default class factory. However, by including the `DECLARE_CLASSFACTORY_AUTO_THREAD` macro in your object's class definition, you override this default.  
  
 When you create objects in multiple apartments (in an out-of-proc server), add `DECLARE_CLASSFACTORY_AUTO_THREAD` to your class.  
  
## Example  
 [!code[NVC_ATL_COM#9](../vs140/codesnippet/CPP/declare_classfactory_auto_thread_1.h)]  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [Aggregation and Class Factory Macros](../vs140/aggregation-and-class-factory-macros.md)   
 [Macros](../vs140/atl-macros.md)   
 [DECLARE_CLASSFACTORY_EX](../vs140/declare_classfactory_ex.md)   
 [DECLARE_CLASSFACTORY2](../vs140/declare_classfactory2.md)   
 [DECLARE_CLASSFACTORY_SINGLETON](../vs140/declare_classfactory_singleton.md)