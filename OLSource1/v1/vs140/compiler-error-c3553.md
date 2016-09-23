---
title: "Compiler Error C3553"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - C3553
dev_langs: 
  - C++
helpviewer_keywords: 
  - C3553
ms.assetid: 7f84bf37-6419-4ad3-ab30-64266100b930
caps.latest.revision: 8
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error C3553
decltype expects an expression not a type  
  
 The `decltype()` keyword requires an expression as an argument, not the name of a type. For example, the last statement in the following code fragment yields error C3553.  
  
 `int x = 0;`  
  
 `decltype(x+1);`  
  
 `decltype(int); // C3553`