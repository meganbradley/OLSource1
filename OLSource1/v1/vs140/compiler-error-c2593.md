---
title: "Compiler Error C2593"
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
  - "C2593"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2593"
ms.assetid: 4a0fe9bb-2163-447d-91f6-1890ed8250f6
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2593
'operator identifier' is ambiguous  
  
 More than one possible operator is defined for an overloaded operator.  
  
 This error may be fixed if you use an explicit cast on one or more actual parameters.  
  
 The following sample generates C2593:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This error can be caused by serializing a floating-point variable using a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object. The compiler identifies the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> operator as ambiguous. The only primitive C++ types that <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> can serialize are the fixed-size types <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. All integer types must be cast to one of these types for serialization. Floating-point types must be archived using the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> member function.  
  
 The following example shows how to archive a floating-point variable (<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>) to archive <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>