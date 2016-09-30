---
title: "Compiler Error C2678"
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
  - "C2678"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2678"
ms.assetid: 1f0a4e26-b429-44f5-9f94-cb66441220c8
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2678
binary 'operator' : no operator defined which takes a left-hand operand of type 'type' (or there is no acceptable conversion)  
  
 To use the operator, you must overload it for the specified type or define a conversion to a type for which the operator is defined.  
  
## Example  
 C2678 can occur when the left-hand operand is const-qualified but the operator is defined to take a non-const argument.  
  
 The following sample generates C2678 and shows how to fix it:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 C2678 can also occur if you do not pin a native member before calling a member function on it.  
  
 The following sample generates C2678 and shows how to fix it.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 The following sample generates C2678 and shows how to fix it.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>