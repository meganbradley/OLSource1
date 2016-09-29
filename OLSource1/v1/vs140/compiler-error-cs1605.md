---
title: "Compiler Error CS1605"
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
  - "CS1605"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1605"
ms.assetid: a202d3a9-9777-4902-a7b9-1628640f9433
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1605
Cannot pass 'var' as a ref or out argument because it is read-only  
  
 A variable passed as a [ref](../vs140/ref--csharp-reference-.md) or [out](../vs140/out--csharp-reference-.md) parameter is expected to be modified in the called method. Therefore, it is not possible to pass a read-only parameter as `ref` or `out`.