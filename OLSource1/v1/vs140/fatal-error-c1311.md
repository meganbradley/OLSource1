---
title: "Fatal Error C1311"
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
  - "C1311"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C1311"
ms.assetid: 6590a06c-ce9d-4f17-8f62-c809343143b8
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Fatal Error C1311
COFF format cannot statically initialize 'var' with number byte(s) of an address  
  
 An address whose value is not known at compile time cannot be statically assigned to a variable whose type has storage of less than four bytes.  
  
 This error can occur on code that is otherwise valid C++.  
  
 The following example shows one condition that might cause C1311.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>