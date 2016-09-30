---
title: "Compiler Error C2682"
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
  - "C2682"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2682"
ms.assetid: 30c6a7c4-f5f7-4fe8-81a8-c48938521ab4
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2682
cannot use casting_operator to convert from 'type1' to 'type2'  
  
 A casting operator tried to convert between incompatible types. For example, you cannot use the [dynamic_cast](../vs140/dynamic_cast-operator.md) operator to convert a pointer to a reference. The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> operator cannot be used to cast away qualifiers. All qualifiers on the types must match.  
  
 You can use the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> operator to remove attributes such as <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 The following sample generates C2682:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The following sample generates C2682:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>