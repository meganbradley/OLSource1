---
title: "Compiler Warning (level 1) C4620"
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
  - "C4620"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4620"
ms.assetid: fed29934-b797-47e8-bbea-c7e5f8dd6e93
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4620
no postfix form of 'operator ++' found for type 'type', using prefix form  
  
 There is no postfix increment operator defined for the given type. The compiler used the overloaded prefix operator.  
  
 This warning can be avoided by defining a postfix <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> operator. Create a two-argument version of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> operator as shown here:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>