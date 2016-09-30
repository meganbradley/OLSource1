---
title: "Compiler Error C2316"
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
  - "C2316"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2316"
ms.assetid: 9ad08eb5-060b-4eb0-8d66-0dc134f7bf67
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2316
'exception' : cannot be caught as the destructor and/or copy constructor are inaccessible  
  
 An exception was caught by value or by reference but the copy constructor and/or the assignment operator were inaccessible.  
  
 This code was accepted by the previous version's compiler but now gives an error.  
  
## Example  
 The following sample generates C2316:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>