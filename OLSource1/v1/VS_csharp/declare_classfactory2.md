---
title: "DECLARE_CLASSFACTORY2"
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
  - "DECLARE_CLASSFACTORY2"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "default class factory, macros"
  - "CComClassFactory2 class, defining default"
  - "DECLARE_CLASSFACTORY2 macro"
  - "class factories, changing default"
ms.assetid: 38a6c969-7297-4bb1-9ba6-1fe2d355b285
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DECLARE_CLASSFACTORY2
Declares [CComClassFactory2](../VS_csharp/ccomclassfactory2-class.md) to be the class factory.  
  
## Syntax  
  
```  
  
      DECLARE_CLASSFACTORY2(   
   lic    
)  
```  
  
#### Parameters  
 *lic*  
 [in] A class that implements `VerifyLicenseKey`, `GetLicenseKey`, and `IsLicenseValid`.  
  
## Remarks  
 [CComCoClass](../VS_csharp/ccomcoclass-class.md) includes the [DECLARE_CLASSFACTORY](../VS_csharp/declare_classfactory.md) macro, which specifies [CComClassFactory](../VS_csharp/ccomclassfactory-class.md) as the default class factory. However, by including the `DECLARE_CLASSFACTORY2` macro in your object's class definition, you override this default.  
  
## Example  
 [!code[NVC_ATL_COM#2](../VS_csharp/codesnippet/CPP/declare_classfactory2_1.h)]  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [Aggregation and Class Factory Macros](../VS_csharp/aggregation-and-class-factory-macros.md)   
 [Macros](../VS_csharp/atl-macros.md)   
 [DECLARE_CLASSFACTORY_EX](../VS_csharp/declare_classfactory_ex.md)   
 [DECLARE_CLASSFACTORY_AUTO_THREAD](../VS_csharp/declare_classfactory_auto_thread.md)   
 [DECLARE_CLASSFACTORY_SINGLETON](../VS_csharp/declare_classfactory_singleton.md)