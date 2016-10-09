---
title: "C# Keywords"
ms.custom: na
ms.date: "10/03/2016"
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
caps.latest.revision: 22
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# C# Keywords
Keywords are predefined, reserved identifiers that have special meanings to the compiler. They cannot be used as identifiers in your program unless they include `@` as a prefix. For example, `@if` is a valid identifier but `if` is not because `if` is a keyword.  
  
 The first table in this topic lists keywords that are reserved identifiers in any part of a C# program. The second table in this topic lists the contextual keywords in C#. Contextual keywords have special meaning only in a limited program context and can be used as identifiers outside that context. Generally, as new keywords are added to the C# language, they are added as contextual keywords in order to avoid breaking programs written in earlier versions.  
  
|||||  
|-|-|-|-|  
|[abstract](../VS_csharp/abstract--csharp-reference-.md)|[as](../VS_csharp/as--csharp-reference-.md)|[base](../VS_csharp/base--csharp-reference-.md)|[bool](../VS_csharp/bool--csharp-reference-.md)|  
|[break](../VS_csharp/break--csharp-reference-.md)|[byte](../VS_csharp/byte--csharp-reference-.md)|[case](../VS_csharp/switch--csharp-reference-.md)|[catch](../VS_csharp/try-catch--csharp-reference-.md)|  
|[char](../VS_csharp/char--csharp-reference-.md)|[checked](../VS_csharp/checked--csharp-reference-.md)|[class](../VS_csharp/class--csharp-reference-.md)|[const](../VS_csharp/const--csharp-reference-.md)|  
|[continue](../VS_csharp/continue--csharp-reference-.md)|[decimal](../VS_csharp/decimal--csharp-reference-.md)|[default](../VS_csharp/default--csharp-reference-.md)|[delegate](../VS_csharp/delegate--csharp-reference-.md)|  
|[do](../VS_csharp/do--csharp-reference-.md)|[double](../VS_csharp/double--csharp-reference-.md)|[else](../VS_csharp/if-else--csharp-reference-.md)|[enum](../VS_csharp/enum--csharp-reference-.md)|  
|[event](../VS_csharp/event--csharp-reference-.md)|[explicit](../VS_csharp/explicit--csharp-reference-.md)|[extern](../VS_csharp/extern--csharp-reference-.md)|[false](../VS_csharp/false--csharp-reference-.md)|  
|[finally](../VS_csharp/try-finally--csharp-reference-.md)|[fixed](../VS_csharp/fixed-statement--csharp-reference-.md)|[float](../VS_csharp/float--csharp-reference-.md)|[for](../VS_csharp/for--csharp-reference-.md)|  
|[foreach](../VS_csharp/foreach--in--csharp-reference-.md)|[goto](../VS_csharp/goto--csharp-reference-.md)|[if](../VS_csharp/if-else--csharp-reference-.md)|[implicit](../VS_csharp/implicit--csharp-reference-.md)|  
|[in](../VS_csharp/foreach--in--csharp-reference-.md)|[in (generic modifier)](../VS_csharp/in--generic-modifier---csharp-reference-.md)|[int](../VS_csharp/int--csharp-reference-.md)|[interface](../VS_csharp/interface--csharp-reference-.md)|  
|[internal](../VS_csharp/internal--csharp-reference-.md)|[is](../VS_csharp/is--csharp-reference-.md)|[lock](../VS_csharp/lock-statement--csharp-reference-.md)|[long](../VS_csharp/long--csharp-reference-.md)|  
|[namespace](../VS_csharp/namespace--csharp-reference-.md)|[new](../VS_csharp/new--csharp-reference-.md)|[null](../VS_csharp/null--csharp-reference-.md)|[object](../VS_csharp/object--csharp-reference-.md)|  
|[operator](../VS_csharp/operator--csharp-reference-2.md)|[out](../VS_csharp/out--csharp-reference-.md)|[out (generic modifier)](../VS_csharp/out--generic-modifier---csharp-reference-.md)|[override](../VS_csharp/override--csharp-reference-.md)|  
|[params](../VS_csharp/params--csharp-reference-.md)|[private](../VS_csharp/private--csharp-reference-.md)|[protected](../VS_csharp/protected--csharp-reference-.md)|[public](../VS_csharp/public--csharp-reference-.md)|  
|[readonly](../VS_csharp/readonly--csharp-reference-.md)|[ref](../VS_csharp/ref--csharp-reference-.md)|[return](../VS_csharp/return--csharp-reference-.md)|[sbyte](../VS_csharp/sbyte--csharp-reference-.md)|  
|[sealed](../VS_csharp/sealed--csharp-reference-.md)|[short](../VS_csharp/short--csharp-reference-.md)|[sizeof](../VS_csharp/sizeof--csharp-reference-.md)|[stackalloc](../VS_csharp/stackalloc--csharp-reference-.md)|  
|[static](../VS_csharp/static--csharp-reference-.md)|[string](../VS_csharp/string--csharp-reference-.md)|[struct](../VS_csharp/struct--csharp-reference-.md)|[switch](../VS_csharp/switch--csharp-reference-.md)|  
|[this](../VS_csharp/this--csharp-reference-.md)|[throw](../VS_csharp/throw--csharp-reference-.md)|[true](../VS_csharp/true--csharp-reference-.md)|[try](../VS_csharp/try-catch--csharp-reference-.md)|  
|[typeof](../VS_csharp/typeof--csharp-reference-.md)|[uint](../VS_csharp/uint--csharp-reference-.md)|[ulong](../VS_csharp/ulong--csharp-reference-.md)|[unchecked](../VS_csharp/unchecked--csharp-reference-.md)|  
|[unsafe](../VS_csharp/unsafe--csharp-reference-.md)|[ushort](../VS_csharp/ushort--csharp-reference-.md)|[using](../VS_csharp/using--csharp-reference-.md)|[virtual](../VS_csharp/virtual--csharp-reference-.md)|  
|[void](../VS_csharp/void--csharp-reference-.md)|[volatile](../VS_csharp/volatile--csharp-reference-.md)|[while](../VS_csharp/while--csharp-reference-.md)||  
  
## Contextual Keywords  
 A contextual keyword is used to provide a specific meaning in the code, but it is not a reserved word in C#. Some contextual keywords, such as `partial` and `where`, have special meanings in two or more contexts.  
  
||||  
|-|-|-|  
|[add](../VS_csharp/add--csharp-reference-.md)|[alias](../VS_csharp/extern-alias--csharp-reference-.md)|[ascending](../VS_csharp/ascending--csharp-reference-.md)|  
|[async](../VS_csharp/async--csharp-reference-.md)|[await](../VS_csharp/await--csharp-reference-.md)|[descending](../VS_csharp/descending--csharp-reference-.md)|  
|[dynamic](../VS_csharp/dynamic--csharp-reference-.md)|[from](../VS_csharp/from-clause--csharp-reference-.md)|[get](../VS_csharp/get--csharp-reference-.md)|  
|[global](../VS_csharp/global--csharp-reference-.md)|[group](../VS_csharp/group-clause--csharp-reference-.md)|[into](../VS_csharp/into--csharp-reference-.md)|  
|[join](../VS_csharp/join-clause--csharp-reference-.md)|[let](../VS_csharp/let-clause--csharp-reference-.md)|[orderby](../VS_csharp/orderby-clause--csharp-reference-.md)|  
|[partial (type)](../VS_csharp/partial--type---csharp-reference-.md)|[partial (method)](../VS_csharp/partial--method---csharp-reference-.md)|[remove](../VS_csharp/remove--csharp-reference-.md)|  
|[select](../VS_csharp/select-clause--csharp-reference-.md)|[set](../VS_csharp/set--csharp-reference-.md)|[value](../VS_csharp/value--csharp-reference-.md)|  
|[var](../VS_csharp/var--csharp-reference-.md)|[where (generic type constraint)](../VS_csharp/where--generic-type-constraint---csharp-reference-.md)|[where (query clause)](../VS_csharp/where-clause--csharp-reference-.md)|  
|[yield](../VS_csharp/yield--csharp-reference-.md)||  
  
## See Also  
 [C# Reference](../VS_csharp/csharp-reference.md)   
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)