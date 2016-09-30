---
title: "Compiler Warning (level 4) C4487"
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
  - "C4487"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4487"
ms.assetid: 796144cf-cd3c-4edc-b6a4-96192b7eb4f0
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 4) C4487
'derived_class_function' : matches inherited non-virtual method 'base_class_function' but is not explicitly marked 'new'  
  
 A function in a derived class has the same signature as a non-virtual base class function. C4487 reminds you that the derived class function does not override the base class function. Explicitly mark the derived class function as <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> to resolve this warning.  
  
 For more information, see [new (new slot in vtable)](../vs140/new--new-slot-in-vtable----c---component-extensions-.md).  
  
## Example  
 The following sample generates C4487.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>