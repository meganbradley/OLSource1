---
title: "C# Keywords"
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
  - "cs.keywords"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "keywords [C#]"
  - "C# language, keywords"
  - "Visual C#, keywords"
  - "@ keyword"
ms.assetid: e929b0f2-4b92-4d37-8060-23d323b098ad
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# C# Keywords
Keywords are predefined, reserved identifiers that have special meanings to the compiler. They cannot be used as identifiers in your program unless they include `@` as a prefix. For example, `@if` is a valid identifier but `if` is not because `if` is a keyword.  
  
 The first table in this topic lists keywords that are reserved identifiers in any part of a C# program. The second table in this topic lists the contextual keywords in C#. Contextual keywords have special meaning only in a limited program context and can be used as identifiers outside that context. Generally, as new keywords are added to the C# language, they are added as contextual keywords in order to avoid breaking programs written in earlier versions.  
  
|||||  
|-|-|-|-|  
|[abstract](../vs140/abstract--csharp-reference-.md)|[as](../vs140/as--csharp-reference-.md)|[base](../vs140/base--csharp-reference-.md)|[bool](../vs140/bool--csharp-reference-.md)|  
|[break](../vs140/break--csharp-reference-.md)|[byte](../vs140/byte--csharp-reference-.md)|[case](../vs140/switch--csharp-reference-.md)|[catch](../vs140/try-catch--csharp-reference-.md)|  
|[char](../vs140/char--csharp-reference-.md)|[checked](../vs140/checked--csharp-reference-.md)|[class](../vs140/class--csharp-reference-.md)|[const](../vs140/const--csharp-reference-.md)|  
|[continue](../vs140/continue--csharp-reference-.md)|[decimal](../vs140/decimal--csharp-reference-.md)|[default](../vs140/default--csharp-reference-.md)|[delegate](../vs140/delegate--csharp-reference-.md)|  
|[do](../vs140/do--csharp-reference-.md)|[double](../vs140/double--csharp-reference-.md)|[else](../vs140/if-else--csharp-reference-.md)|[enum](../vs140/enum--csharp-reference-.md)|  
|[event](../vs140/event--csharp-reference-.md)|[explicit](../vs140/explicit--csharp-reference-.md)|[extern](../vs140/extern--csharp-reference-.md)|[false](../vs140/false--csharp-reference-.md)|  
|[finally](../vs140/try-finally--csharp-reference-.md)|[fixed](../vs140/fixed-statement--csharp-reference-.md)|[float](../vs140/float--csharp-reference-.md)|[for](../vs140/for--csharp-reference-.md)|  
|[foreach](../vs140/foreach--in--csharp-reference-.md)|[goto](../vs140/goto--csharp-reference-.md)|[if](../vs140/if-else--csharp-reference-.md)|[implicit](../vs140/implicit--csharp-reference-.md)|  
|[in](../vs140/foreach--in--csharp-reference-.md)|[in (generic modifier)](../vs140/in--generic-modifier---csharp-reference-.md)|[int](../vs140/int--csharp-reference-.md)|[interface](../vs140/interface--csharp-reference-.md)|  
|[internal](../vs140/internal--csharp-reference-.md)|[is](../vs140/is--csharp-reference-.md)|[lock](../vs140/lock-statement--csharp-reference-.md)|[long](../vs140/long--csharp-reference-.md)|  
|[namespace](../vs140/namespace--csharp-reference-.md)|[new](../vs140/new--csharp-reference-.md)|[null](../vs140/null--csharp-reference-.md)|[object](../vs140/object--csharp-reference-.md)|  
|[operator](../vs140/operator--csharp-reference-2.md)|[out](../vs140/out--csharp-reference-.md)|[out (generic modifier)](../vs140/out--generic-modifier---csharp-reference-.md)|[override](../vs140/override--csharp-reference-.md)|  
|[params](../vs140/params--csharp-reference-.md)|[private](../vs140/private--csharp-reference-.md)|[protected](../vs140/protected--csharp-reference-.md)|[public](../vs140/public--csharp-reference-.md)|  
|[readonly](../vs140/readonly--csharp-reference-.md)|[ref](../vs140/ref--csharp-reference-.md)|[return](../vs140/return--csharp-reference-.md)|[sbyte](../vs140/sbyte--csharp-reference-.md)|  
|[sealed](../vs140/sealed--csharp-reference-.md)|[short](../vs140/short--csharp-reference-.md)|[sizeof](../vs140/sizeof--csharp-reference-.md)|[stackalloc](../vs140/stackalloc--csharp-reference-.md)|  
|[static](../vs140/static--csharp-reference-.md)|[string](../vs140/string--csharp-reference-.md)|[struct](../vs140/struct--csharp-reference-.md)|[switch](../vs140/switch--csharp-reference-.md)|  
|[this](../vs140/this--csharp-reference-.md)|[throw](../vs140/throw--csharp-reference-.md)|[true](../vs140/true--csharp-reference-.md)|[try](../vs140/try-catch--csharp-reference-.md)|  
|[typeof](../vs140/typeof--csharp-reference-.md)|[uint](../vs140/uint--csharp-reference-.md)|[ulong](../vs140/ulong--csharp-reference-.md)|[unchecked](../vs140/unchecked--csharp-reference-.md)|  
|[unsafe](../vs140/unsafe--csharp-reference-.md)|[ushort](../vs140/ushort--csharp-reference-.md)|[using](../vs140/using--csharp-reference-.md)|[virtual](../vs140/virtual--csharp-reference-.md)|  
|[void](../vs140/void--csharp-reference-.md)|[volatile](../vs140/volatile--csharp-reference-.md)|[while](../vs140/while--csharp-reference-.md)||  
  
## Contextual Keywords  
 A contextual keyword is used to provide a specific meaning in the code, but it is not a reserved word in C#. Some contextual keywords, such as `partial` and `where`, have special meanings in two or more contexts.  
  
||||  
|-|-|-|  
|[add](../vs140/add--csharp-reference-.md)|[alias](../vs140/extern-alias--csharp-reference-.md)|[ascending](../vs140/ascending--csharp-reference-.md)|  
|[async](../vs140/async--csharp-reference-.md)|[await](../vs140/await--csharp-reference-.md)|[descending](../vs140/descending--csharp-reference-.md)|  
|[dynamic](../vs140/dynamic--csharp-reference-.md)|[from](../vs140/from-clause--csharp-reference-.md)|[get](../vs140/get--csharp-reference-.md)|  
|[global](../vs140/global--csharp-reference-.md)|[group](../vs140/group-clause--csharp-reference-.md)|[into](../vs140/into--csharp-reference-.md)|  
|[join](../vs140/join-clause--csharp-reference-.md)|[let](../vs140/let-clause--csharp-reference-.md)|[orderby](../vs140/orderby-clause--csharp-reference-.md)|  
|[partial (type)](../vs140/partial--type---csharp-reference-.md)|[partial (method)](../vs140/partial--method---csharp-reference-.md)|[remove](../vs140/remove--csharp-reference-.md)|  
|[select](../vs140/select-clause--csharp-reference-.md)|[set](../vs140/set--csharp-reference-.md)|[value](../vs140/value--csharp-reference-.md)|  
|[var](../vs140/var--csharp-reference-.md)|[where (generic type constraint)](../vs140/where--generic-type-constraint---csharp-reference-.md)|[where (query clause)](../vs140/where-clause--csharp-reference-.md)|  
|[yield](../vs140/yield--csharp-reference-.md)||  
  
## See Also  
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)