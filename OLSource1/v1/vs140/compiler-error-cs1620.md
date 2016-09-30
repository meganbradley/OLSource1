---
title: "Compiler Error CS1620"
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
  - "CS1620"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1620"
ms.assetid: 13933976-218a-4fe2-8fde-5b9af522e2e5
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1620
Argument 'number' must be passed with the 'keyword' keyword  
  
 This error occurs if you are passing an argument to a function that takes a [ref](../vs140/ref--csharp-reference-.md) or [out](../vs140/out--csharp-reference-.md) parameter and you don't include the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> keyword at the point of call, or you include the wrong keyword. The error text indicates the appropriate keyword to use and which argument caused the failure.  
  
 The following sample generates CS1620:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>