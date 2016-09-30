---
title: "Compiler Error CS0058"
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
  - "CS0058"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0058"
ms.assetid: 9535da60-03b9-41ab-93e1-e57b6440fca9
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0058
Inconsistent accessibility: return type 'type' is less accessible than delegate 'delegate'  
  
 A public construct must return a publicly accessible object. For more information, see [Access Modifiers (C# Programmers Reference)](../vs140/access-modifiers--csharp-programming-guide-.md).  
  
 The following sample generates CS0058 because no access modifier is applied to MyClass and therefore it is given private accessibility by default:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [private (C# Programmer's Reference)](../vs140/private--csharp-reference-.md)