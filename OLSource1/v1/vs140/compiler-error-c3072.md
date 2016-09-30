---
title: "Compiler Error C3072"
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
  - "C3072"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3072"
ms.assetid: cdd5cb6b-c478-4698-adfa-c40188d34a18
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3072
operator 'operator' cannot be applied to an instance of a ref class  
  
 use the unary '<CodeContentPlaceHolder>1\</CodeContentPlaceHolder> ' operator to convert an instance of a ref class to a handle type  
  
 A CLR type requires CLR operators, not native (or standard) operators.  For more information, see [% (Tracking Reference)](../vs140/tracking-reference-operator--c---component-extensions-.md).  
  
## Example  
 The following sample generates C3072.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>