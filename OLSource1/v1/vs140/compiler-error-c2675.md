---
title: "Compiler Error C2675"
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
  - "C2675"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2675"
ms.assetid: 4b92a12b-bff8-4dd5-a109-620065fc146c
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2675
unary 'operator' : 'type' does not define this operator or a conversion to a type acceptable to the predefined operator  
  
 C2675 can also occur when using a unary operator, and the type does not define the operator or a conversion to a type acceptable to the predefined operator. To use the operator, you must overload it for the specified type or define a conversion to a type for which the operator is defined.  
  
## Example  
 The following sample generates C2675.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>