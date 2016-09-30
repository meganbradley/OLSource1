---
title: "Compiler Error C2274"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "C2274"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2274"
ms.assetid: 8e874903-f499-45ef-8291-f821eee4cc1c
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2274
'type' : illegal as right side of '.' operator  
  
 A type appears as the right operand of a member-access (.) operator.  
  
 This error can be caused by trying to access a user-defined type conversion. Use the keyword <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> between the period and <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 The following sample generates C2286:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>