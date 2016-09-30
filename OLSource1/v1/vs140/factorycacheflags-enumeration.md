---
title: "FactoryCacheFlags Enumeration"
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
  - "module/Microsoft::WRL::FactoryCacheFlags"
dev_langs: 
  - "C++"
ms.assetid: 6f54258f-0144-4264-9608-414e5905f6fb
caps.latest.revision: 6
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# FactoryCacheFlags Enumeration
Determines whether factory objects are cached.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 By default, the factory caching policy is specified as the [ModuleType](../vs140/moduletype-enumeration.md) template parameter when you create a [Module](../vs140/module-class.md) object. To override this policy, specify a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> value when you create a factory object.  
  
|||  
|-|-|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|The caching policy of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object is used.|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Enables factory caching regardless of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> template parameter that is used to create a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object.|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Disables factory caching regardless of the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> template parameter that is used to create a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object.|  
  
## Requirements  
 **Header:** implements.h  
  
 **Namespace:** Microsoft::WRL  
  
## See Also  
 [Microsoft::WRL Namespace](../vs140/microsoft--wrl-namespace.md)