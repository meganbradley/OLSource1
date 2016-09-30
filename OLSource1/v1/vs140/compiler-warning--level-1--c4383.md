---
title: "Compiler Warning (level 1) C4383"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "C4383"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4383"
ms.assetid: 96c0e52d-874e-4b57-a154-0e49b6a00fae
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4383
'instance_dereference_operator' : the meaning of dereferencing a handle can change, when a user-defined 'operator' operator exists; write the operator as a static function to be explicit about the operand  
  
 When you add a user-defined instance override of the dereference operator in a managed type, you potentially override the ability of the type's dereference operator to return the handle's object. Consider writing a static, user-defined dereference operator.  
  
 For more information, see [^ (Handle to Object on Managed Heap)](../vs140/handle-to-object-operator--^----c---component-extensions-.md) and [% (Tracking Reference)](../vs140/tracking-reference-operator--c---component-extensions-.md).  
  
 Also, an instance operator is not available to other language compilers via referenced metadata. For more information, see [User-Defined Operators](../vs140/user-defined-operators--c---cli-.md).  
  
## Example  
 The following sample generates C4383.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>