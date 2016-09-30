---
title: "CreateActivationFactory Function"
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
  - "module/Microsoft::WRL::Details::CreateActivationFactory"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateActivationFactory function"
ms.assetid: a1a53e04-6757-4faf-a4c8-ecf06e43b959
caps.latest.revision: 6
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CreateActivationFactory Function
Creates a factory that produces instances of the specified class that can be activated by the Windows Runtime.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A combination of one or more [RuntimeClassType](../vs140/runtimeclasstype-enumeration.md) enumeration values.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to a [CreatorMap](../vs140/creatormap-structure.md) that contains initialization and registration information about parameter <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Reference to an interface ID.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 If this operation completes successfully, a pointer to an activation factory.  
  
## Return Value  
 S_OK if successful; otherwise, an HRESULT that indicates the error.  
  
## Remarks  
 An assert error is emitted if template parameter <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> doesn't derive from interface IActivationFactory.  
  
## Requirements  
 **Header:** module.h  
  
 **Namespace:** Microsoft::WRL  
  
## See Also  
 [Details Namespace](../vs140/microsoft--wrl--wrappers--details-namespace.md)