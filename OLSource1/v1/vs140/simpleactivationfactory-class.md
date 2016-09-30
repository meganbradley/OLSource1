---
title: "SimpleActivationFactory Class"
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
  - "module/Microsoft::WRL::SimpleActivationFactory"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SimpleActivationFactory class"
ms.assetid: aff768e0-0038-4fd7-95d2-ad7d308da41c
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# SimpleActivationFactory Class
Provides a fundamental mechanism to create a Windows Runtime or classic COM base class.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A base class.  
  
## Remarks  
 The base class must provide a default constructor.  
  
 The following code example demonstrates how to use SimpleActivationFactory with the [ActivatableClassWithFactoryEx](../vs140/activatableclass-macros.md) macro.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[SimpleActivationFactory::ActivateInstance Method](../vs140/simpleactivationfactory--activateinstance-method.md)|Creates an instance of the specified interface.|  
|[SimpleActivationFactory::GetRuntimeClassName Method](../vs140/simpleactivationfactory--getruntimeclassname-method.md)|Gets the runtime class name of an instance of the class specified by the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> class template parameter.|  
|[SimpleActivationFactory::GetTrustLevel Method](../vs140/simpleactivationfactory--gettrustlevel-method.md)|Gets the trust level of an instance of the class specified by the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> class template parameter.|  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** module.h  
  
 **Namespace:** Microsoft::WRL  
  
## See Also  
 [WRL Namespace](../vs140/microsoft--wrl-namespace.md)