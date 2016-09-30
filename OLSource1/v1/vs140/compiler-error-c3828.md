---
title: "Compiler Error C3828"
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
  - "C3828"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3828"
ms.assetid: 8d9cee75-9504-4bc8-88b6-2413618a3f45
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3828
'object type': placement arguments not allowed while creating instances of managed or WinRTclasses  
  
 When creating an object of a managed type or Windows Runtime type, you cannot use the placement form of operator [gcnew](../vs140/ref-new--gcnew---c---component-extensions-.md) or [new](../vs140/new-operator--c---.md).  
  
 The following sample generates C3828 and shows how to fix it:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>