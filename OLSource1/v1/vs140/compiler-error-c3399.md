---
title: "Compiler Error C3399"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "C3399"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3399"
ms.assetid: 306ad199-d150-4f6c-bcf1-24a7948b93be
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3399
'type' : cannot provide arguments when creating an instance of a generic parameter  
  
 When you specify the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> constraint, you specify that the constraint type will have a parameterless constructor. Therefore, it is an error to attempt to instantiate that type and pass a parameter.  
  
 See [Constraints](../vs140/constraints-on-generic-type-parameters--c---cli-.md) for more information.  
  
## Example  
 The following sample generates C3399.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>