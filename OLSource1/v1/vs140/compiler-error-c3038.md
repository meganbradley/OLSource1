---
title: "Compiler Error C3038"
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
  - "C3038"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3038"
ms.assetid: 140ada3e-5636-43ef-a4ee-22a9f66a771f
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3038
'var' : variable in 'private' clause cannot be a reduction variable in enclosing context  
  
 Variables that appear in the [reduction](../vs140/reduction.md) clause of a parallel directive cannot be specified in a [private](../vs140/private--openmp-.md) clause on a work-sharing directive that binds to the parallel construct.  
  
 The following sample generates C3038:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>