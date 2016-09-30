---
title: "InterfaceTraits::CanCastTo Method"
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
  - "implements/Microsoft::WRL::Details::InterfaceTraits::CanCastTo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CanCastTo method"
ms.assetid: 275847cb-69ea-42bf-910f-05ba6ef8b48d
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# InterfaceTraits::CanCastTo Method
Supports the WRL infrastructure and is not intended to be used directly from your code.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The name of a pointer to a type.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The interface ID of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 If this operation is successful, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> points to the interface specified by <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. Otherwise, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Return Value  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> if this operation is successful and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is cast to a pointer to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>; otherwise, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> .  
  
## Remarks  
 Indicates whether the specified pointer can be cast to a pointer to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
 For more information about <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, see the Public Typedefs section in [InterfaceTraits Structure](../vs140/interfacetraits-structure.md).  
  
## Requirements  
 **Header:** implements.h  
  
 **Namespace:** Microsoft::WRL::Details  
  
## See Also  
 [InterfaceTraits Structure](../vs140/interfacetraits-structure.md)   
 [Microsoft::WRL::Details Namespace](../vs140/microsoft--wrl--details-namespace.md)