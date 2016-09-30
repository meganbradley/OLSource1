---
title: "Compiler Warning (level 1) C4806"
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
  - "C4806"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4806"
ms.assetid: 79eb74cd-b925-4b5b-84e1-8ae6f33e38b3
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4806
'operation' : unsafe operation: no value of type 'type' promoted to type 'type' can equal the given constant  
  
 This message warns against code such as <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> has type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. The promotion rules cause <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to be promoted to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. This is legal, but it can never be **true**. The following sample generates C4806:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>