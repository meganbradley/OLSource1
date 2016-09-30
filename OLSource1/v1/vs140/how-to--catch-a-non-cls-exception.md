---
title: "How to: Catch a non-CLS Exception"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "exceptions [C#], non-CLS"
ms.assetid: db4630b3-5240-471a-b3a7-c7ff6ab31e8d
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Catch a non-CLS Exception
Some .NET languages, including C++/CLI, allow objects to throw exceptions that do not derive from \<xref:System.Exception*>. Such exceptions are called *non-CLS exceptions* or *non-Exceptions*. In [!INCLUDE[csprcs](../vs140/includes/csprcs_md.md)] you cannot throw non-CLS exceptions, but you can catch them in two ways:  
  
-   Within a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> block as a \<xref:System.Runtime.CompilerServices.RuntimeWrappedException*>.  
  
     By default, a [!INCLUDE[csprcs](../vs140/includes/csprcs_md.md)] assembly catches non-CLS exceptions as wrapped exceptions. Use this method if you need access to the original exception, which can be accessed through the \<xref:System.Runtime.CompilerServices.RuntimeWrappedException.WrappedException*> property. The procedure later in this topic explains how to catch exceptions in this manner.  
  
-   Within a general catch block (a catch block without an exception type specified) that is put after a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> block.  
  
     Use this method when you want to perform some action (such as writing to a log file) in response to non-CLS exceptions, and you do not need access to the exception information. By default the common language runtime wraps all exceptions. To disable this behavior, add this assembly-level attribute to your code, typically in the AssemblyInfo.cs file: <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
### To catch a non-CLS exception  
  
1.  Within a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, use the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> keyword to test whether <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> can be cast to a \<xref:System.Runtime.CompilerServices.RuntimeWrappedException*>.  
  
2.  Access the original exception through the \<xref:System.Runtime.CompilerServices.RuntimeWrappedException.WrappedException*> property.  
  
## Example  
 The following example shows how to catch a non-CLS exception that was thrown from a class library written in C++/CLR. Note that in this example, the [!INCLUDE[csprcs](../vs140/includes/csprcs_md.md)] client code knows in advance that the exception type being thrown is a \<xref:System.String*?displayProperty=fullName>. You can cast the \<xref:System.Runtime.CompilerServices.RuntimeWrappedException.WrappedException*> property back its original type as long as that type is accessible from your code.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 \<xref:System.Runtime.CompilerServices.RuntimeWrappedException*>   
 [Exceptions and Exception Handling](../vs140/exceptions-and-exception-handling--csharp-programming-guide-.md)