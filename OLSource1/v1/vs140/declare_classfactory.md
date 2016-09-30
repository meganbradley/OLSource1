---
title: "DECLARE_CLASSFACTORY"
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
  - "DECLARE_CLASSFACTORY"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DECLARE_CLASSFACTORY macro"
  - "CComClassFactory class, defining default"
ms.assetid: 51a6b925-07c0-4d3a-9174-0b8c808975e4
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DECLARE_CLASSFACTORY
Declares [CComClassFactory](../vs140/ccomclassfactory-class.md) to be the class factory.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 [CComCoClass](../vs140/ccomcoclass-class.md) uses this macro to declare the default class factory for your object.  
  
## Example  
 [!code[NVC_ATL_COM#55](../vs140/codesnippet/CPP/declare_classfactory_1.h)]  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [Aggregation and Class Factory Macros](../vs140/aggregation-and-class-factory-macros.md)   
 [Macros](../vs140/atl-macros.md)   
 [DECLARE_CLASSFACTORY_EX](../vs140/declare_classfactory_ex.md)   
 [DECLARE_CLASSFACTORY2](../vs140/declare_classfactory2.md)   
 [DECLARE_CLASSFACTORY_AUTO_THREAD](../vs140/declare_classfactory_auto_thread.md)   
 [DECLARE_CLASSFACTORY_SINGLETON](../vs140/declare_classfactory_singleton.md)