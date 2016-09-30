---
title: "Compiler Error C3057"
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
  - "C3057"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3057"
ms.assetid: b0b2ba88-9c74-4bec-bf60-8fc72eade34c
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3057
'symbol' : dynamic initialization of 'threadprivate' symbols is not currently supported  
  
 The initialized value of a symbol used in a [threadprivate](../vs140/threadprivate.md) clause must be known at compile time.  
  
 The following sample generates C3057:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The following sample generates C3057:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>