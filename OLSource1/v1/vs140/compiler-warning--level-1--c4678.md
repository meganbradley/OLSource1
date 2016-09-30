---
title: "Compiler Warning (level 1) C4678"
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
  - "C4678"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4678"
ms.assetid: 0c588f34-595d-4e5c-9470-8723fca2cc06
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4678
base class 'base_type' is less accessible than 'derived_type'  
  
 A public type derives from a private type. If the public type is instantiated in a referenced assembly, members of the private base type will not be accessible.  
  
 C4678 is only reachable using **/clr:oldSyntax**. It is an error, using **/clr**, to have a base class that is less accessible that its derived class.  
  
 The following sample generates C4678:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>