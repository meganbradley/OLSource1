---
title: "Compiler Error C2344"
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
  - "C2344"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2344"
ms.assetid: a84c7b37-c84e-4345-8691-c23abb2dc193
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2344
align(#) : alignment must be power of two  
  
 When using the [align](../vs140/align--c---.md) keyword, the value you pass must be a power of two.  
  
 For example, the following code generates C2344 because 3 is not a power of two:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>