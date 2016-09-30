---
title: "Compiler Error CS0202"
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
  - "CS0202"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0202"
ms.assetid: 7088850f-c206-4b95-9586-a0fa3d876c0c
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0202
foreach requires that the return type 'type' of 'type.GetEnumerator()' must have a suitable public MoveNext method and public Current property  
  
 A \<xref:System.Collections.IEnumerable.GetEnumerator*> function, used to enable the use of foreach statements, cannot return a pointer or array; it must return an instance of a class that is able to act as an enumerator. The proper requirements to serve as an enumerator include a public Current property and a public MoveNext method.  
  
> [!NOTE]
>  In C# 2.0, the compiler will automatically generate Current and MoveNext for you. For more information, see the code example in [Generic Interfaces (C# Programmers Reference)](../vs140/generic-interfaces--csharp-programming-guide-.md).  
  
 The following sample generates CS0202:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>