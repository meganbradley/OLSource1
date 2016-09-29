---
title: "Changing the Default Class Factory and Aggregation Model"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CComClassFactory class, making the default"
  - "aggregation [C++], using ATL"
  - "aggregation [C++], aggregation models"
  - "defaults [C++], aggregation model in ATL"
  - "default class factory"
  - "class factories, changing default"
  - "CComCoClass class, default class factory and aggregation model"
  - "default class factory, ATL"
  - "defaults [C++], class factory"
ms.assetid: 6e040e95-0f38-4839-8a8b-c9800dd47e8c
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Changing the Default Class Factory and Aggregation Model
ATL uses [CComCoClass](../VS_csharp/ccomcoclass-class.md) to define the default class factory and aggregation model for your object. `CComCoClass` specifies the following two macros:  
  
-   [DECLARE_CLASSFACTORY](../VS_csharp/declare_classfactory.md) Declares the class factory to be [CComClassFactory](../VS_csharp/ccomclassfactory-class.md).  
  
-   [DECLARE_AGGREGATABLE](../VS_csharp/declare_aggregatable.md) Declares that your object can be aggregated.  
  
 You can override either of these defaults by specifying another macro in your class definition. For example, to use [CComClassFactory2](../VS_csharp/ccomclassfactory2-class.md) instead of `CComClassFactory`, specify the [DECLARE_CLASSFACTORY2](../VS_csharp/declare_classfactory2.md) macro:  
  
 [!code[NVC_ATL_COM#2](../VS_csharp/codesnippet/CPP/changing-the-default-class-factory-and-aggregation-model_1.h)]  
  
 Two other macros that define a class factory are [DECLARE_CLASSFACTORY_AUTO_THREAD](../VS_csharp/declare_classfactory_auto_thread.md) and [DECLARE_CLASSFACTORY_SINGLETON](../VS_csharp/declare_classfactory_singleton.md).  
  
 ATL also uses the `typedef` mechanism to implement default behavior. For example, the `DECLARE_AGGREGATABLE` macro uses `typedef` to define a type called **_CreatorClass**, which is then referenced throughout ATL. Note that in a derived class, a `typedef` using the same name as the base class's `typedef` results in ATL using your definition and overriding the default behavior.  
  
## See Also  
 [Fundamentals of ATL COM Objects](../VS_csharp/fundamentals-of-atl-com-objects.md)   
 [Aggregation and Class Factory Macros](../VS_csharp/aggregation-and-class-factory-macros.md)