---
title: "Compiler Error C2676"
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
  - "C2676"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2676"
ms.assetid: 838a5e34-c92f-4f65-a597-e150bf8cf737
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2676
binary 'operator' : 'type' does not define this operator or a conversion to a type acceptable to the predefined operator  
  
 To use the operator, you must overload it for the specified type or define a conversion to a type for which the operator is defined.  
  
## Example  
 The following sample generates C2676.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 C2676 can also occur if you attempt to do pointer arithmetic on the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> pointer of a reference type.  
  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> pointer is of type handle in a reference type. For more information, see [Semantics of the this Pointer in Value and Reference Types](../vs140/how-to--define-and-consume-classes-and-structs--c---cli-.md#BKMK_Semantics_of_the_this_pointer).  
  
 The following sample generates C2676.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>