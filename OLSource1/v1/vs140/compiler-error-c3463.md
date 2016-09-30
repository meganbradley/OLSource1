---
title: "Compiler Error C3463"
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
  - "C3463"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3463"
ms.assetid: 153efcc0-085c-4615-84ea-d22942618bdf
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3463
'type': type not allowed in attribute 'implements'  
  
 An invalid type was passed to the [implements (C++)](../vs140/implements--c---.md) attribute. For example, you can pass an interface to <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, but you cannot pass a pointer to an interface.  
  
## Example  
 The following sample generates C3463.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>