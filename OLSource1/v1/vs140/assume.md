---
title: "ASSUME"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "ASSUME"
  - "_assume_cpp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ASSUME directive"
ms.assetid: cd162070-aee9-4c65-babc-005c6cc73d7c
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ASSUME
Enables error checking for register values.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 After an <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is put into effect, the assembler watches for changes to the values of the given registers. **ERROR** generates an error if the register is used. **NOTHING** removes register error checking. You can combine different kinds of assumptions in one statement.  
  
## See Also  
 [Directives Reference](../vs140/directives-reference.md)