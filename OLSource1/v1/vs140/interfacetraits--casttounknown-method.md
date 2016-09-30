---
title: "InterfaceTraits::CastToUnknown Method"
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
  - "implements/Microsoft::WRL::Details::InterfaceTraits::CastToUnknown"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CastToUnknown method"
ms.assetid: aca47fa0-3c60-47f2-a73c-258f7160adff
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# InterfaceTraits::CastToUnknown Method
Supports the WRL infrastructure and is not intended to be used directly from your code.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The type of parameter <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Pointer to type <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Return Value  
 Pointer to the IUnknown from which <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is derived.  
  
## Remarks  
 Casts the specified pointer to a pointer to IUnknown.  
  
 For more information about <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, see the Public Typedefs section in [InterfaceTraits Structure](../vs140/interfacetraits-structure.md).  
  
## Requirements  
 **Header:** implements.h  
  
 **Namespace:** Microsoft::WRL::Details  
  
## See Also  
 [InterfaceTraits Structure](../vs140/interfacetraits-structure.md)   
 [Microsoft::WRL::Details Namespace](../vs140/microsoft--wrl--details-namespace.md)