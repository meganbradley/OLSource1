---
title: "Compiler Warning (level 4) C4913"
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
  - "C4913"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4913"
ms.assetid: b94aa52e-6029-4170-9134-017714931546
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 4) C4913
**user defined binary operator ',' exists but no overload could convert all operands, default built-in binary operator ',' used**  
  
 A call to the built-in comma operator occurred in a program that also had an overloaded comma operator; a conversion that you thought may have occurred did not.  
  
 The following code sample generates C4913:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>