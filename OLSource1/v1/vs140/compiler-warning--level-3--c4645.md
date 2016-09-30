---
title: "Compiler Warning (level 3) C4645"
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
  - "C4645"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4645"
ms.assetid: fd7c1ddf-f0d0-4e10-bab9-ccb4c3476298
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 3) C4645
function declared with __declspec(noreturn) has a return statement  
  
 A [return](../vs140/return-statement-in-program-termination--c---.md) statement was found in a function that is marked with the [noreturn](../vs140/noreturn.md) <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> modifier. The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> statement was ignored.  
  
 The following sample generates C4645:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>