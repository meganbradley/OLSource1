---
title: "Aggregation and Class Factory Macros"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "class factories, ATL macros"
  - "aggregation [C++], ATL macros"
ms.assetid: d99d379a-0eec-481f-8daa-252dac18f163
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Aggregation and Class Factory Macros
These macros provide ways of controlling aggregation and of declaring class factories.  
  
|||  
|-|-|  
|[DECLARE_AGGREGATABLE](../VS_csharp/declare_aggregatable.md)|Declares that your object can be aggregated (the default).|  
|[DECLARE_CLASSFACTORY](../VS_csharp/declare_classfactory.md)|Declares the class factory to be [CComClassFactory](../VS_csharp/ccomclassfactory-class.md), the ATL default class factory.|  
|[DECLARE_CLASSFACTORY_EX](../VS_csharp/declare_classfactory_ex.md)|Declares your class factory object to be the class factory.|  
|[DECLARE_CLASSFACTORY2](../VS_csharp/declare_classfactory2.md)|Declares [CComClassFactory2](../VS_csharp/ccomclassfactory2-class.md) to be the class factory.|  
|[DECLARE_CLASSFACTORY_AUTO_THREAD](../VS_csharp/declare_classfactory_auto_thread.md)|Declares [CComClassFactoryAutoThread](../VS_csharp/ccomclassfactoryautothread-class.md) to be the class factory.|  
|[DECLARE_CLASSFACTORY_SINGLETON](../VS_csharp/declare_classfactory_singleton.md)|Declares [CComClassFactorySingleton](../VS_csharp/ccomclassfactorysingleton-class.md) to be the class factory.|  
|[DECLARE_GET_CONTROLLING_UNKNOWN](../VS_csharp/declare_get_controlling_unknown.md)|Declares a virtual `GetControllingUnknown` function.|  
|[DECLARE_NOT_AGGREGATABLE](../VS_csharp/declare_not_aggregatable.md)|Declares that your object cannot be aggregated.|  
|[DECLARE_ONLY_AGGREGATABLE](../VS_csharp/declare_only_aggregatable.md)|Declares that your object must be aggregated.|  
|[DECLARE_POLY_AGGREGATABLE](../VS_csharp/declare_poly_aggregatable.md)|Checks the value of the outer unknown and declares your object aggregatable or not aggregatable, as appropriate.|  
|[DECLARE_PROTECT_FINAL_CONSTRUCT](../VS_csharp/declare_protect_final_construct.md)|Protects the outer object from deletion during construction of an inner object.|  
|[DECLARE_VIEW_STATUS](../VS_csharp/declare_view_status.md)|Specifies the **VIEWSTATUS** flags to the container.|  
  
## See Also  
 [Macros](../VS_csharp/atl-macros.md)