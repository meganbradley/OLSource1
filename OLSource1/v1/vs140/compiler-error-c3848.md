---
title: "Compiler Error C3848"
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
  - "C3848"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3848"
ms.assetid: 32d3ccef-01ec-4f8b-bbff-fb9b1a76b4c4
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3848
expression having type 'type' would lose some const-volatile qualifiers in order to call 'function'  
  
 A variable with a specified const-volatile type can only call member functions defined with same or greater const-volatile qualifications.  
  
 The following samples generate C3848:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>