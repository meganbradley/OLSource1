---
title: "Compiler Error C3420"
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
  - "C3420"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3420"
ms.assetid: 99b53c77-f36b-4574-9199-b53111becccb
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3420
'finalizer' : a finalizer cannot be virtual  
  
 A finalizer can only be called non-virtually from its enclosing type. Therefore, it is an error to declare a virtual finalizer.  
  
 For more information, see [Destructors and Finalizers](../vs140/destructors-and-finalizers-in-visual-c--.md).  
  
## Example  
 The following sample generates C3420.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>