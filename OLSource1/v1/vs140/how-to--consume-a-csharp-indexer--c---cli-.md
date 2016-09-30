---
title: "How to: Consume a C# Indexer (C++-CLI)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "get-started-article"
H1: "How to: Consume a C# Indexer (C++/CLI)"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C++, indexers"
  - "indexers, consuming C#"
ms.assetid: 5a11850c-a1a2-4a0a-b95e-f6dc5a87f439
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Consume a C# Indexer (C++-CLI)
Visual C++ does not contain indexers; it has indexed properties. To consume a C# indexer, access the indexer as if it were an indexed property.  
  
 For more information about indexers, see:  
  
-   [Indexers](../vs140/indexers--csharp-programming-guide-.md)  
  
-   [How to: Use Indexed Properties](../vs140/how-to--use-indexed-properties.md)  
  
## Example  
 The following C# program defines an indexer.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 This Visual C++ program consumes the indexer.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Element #0 = 21**  
**Element #1 = 0**  
**Element #2 = 0**  
**Element #3 = 0**  
**Element #4 = 0**  
**Element #5 = 0**  
**Element #6 = 0**  
**Element #7 = 0**  
**Element #8 = 0**  
**Element #9 = 0**  
**Element #10 = 0**   
## See Also  
 [Interoperability with other .NET languages in C++](../vs140/interoperability-with-other-.net-languages--c---cli-.md)