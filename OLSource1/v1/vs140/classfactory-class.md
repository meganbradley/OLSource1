---
title: "ClassFactory Class"
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
  - "module/Microsoft::WRL::ClassFactory"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ClassFactory class"
ms.assetid: f13e6bce-722b-4f18-b7cf-3ffa6345c1db
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ClassFactory Class
Implements the basic functionality of the IClassFactory interface.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The zeroth interface.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The first interface.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The second interface.  
  
## Remarks  
 Utilize <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to provide a user-defined factory implementation.  
  
 The following programming pattern demonstrates how to use the [Implements](../vs140/implements-structure.md) structure to specify more than three interfaces on a class factory.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[ClassFactory::ClassFactory Constructor](../vs140/classfactory--classfactory-constructor.md)||  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[ClassFactory::AddRef Method](../vs140/classfactory--addref-method.md)|Increments the reference count for the current ClassFactory object.|  
|[ClassFactory::LockServer Method](../vs140/classfactory--lockserver-method.md)|Increments or decrements the number of underlying objects that are tracked by the current ClassFactory object.|  
|[ClassFactory::QueryInterface Method](../vs140/classfactory--queryinterface-method.md)|Retrieves a pointer to the interface specified by parameter.|  
|[ClassFactory::Release Method](../vs140/classfactory--release-method.md)|Decrements the reference count for the current ClassFactory object.|  
  
## Inheritance Hierarchy  
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
 [RuntimeClassType Enumeration](../vs140/runtimeclasstype-enumeration.md)