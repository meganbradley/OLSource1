---
title: "How to: Create a New Method for an Enumeration (C# Programming Guide)"
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
  - "enumerations [C#]"
  - "extension methods [C#], for enums"
  - "enum extensibility [C#]"
ms.assetid: 100106f9-1e54-462c-8ebe-3892fe23b6eb
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Create a New Method for an Enumeration (C# Programming Guide)
You can use extension methods to add functionality specific to a particular enum type.  
  
## Example  
 In the following example, the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> enumeration represents the possible letter grades that a student may receive in a class. An extension method named <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is added to the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> type so that each instance of that type now "knows" whether it represents a passing grade or not.  
  
 [!code[csProgGuideExtensionMethods#2](../vs140/codesnippet/CSharp/how-to--create-a-new-method-for-an-enumeration--csharp-programming-guide-_1.cs)]  
  
 Note that the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> class also contains a static variable that is updated dynamically and that the return value of the extension method reflects the current value of that variable. This demonstrates that, behind the scenes, extension methods are invoked directly on the static class in which they are defined.  
  
## Compiling the Code  
 To run this code, copy and paste it into a Visual C# console application project that has been created in [!INCLUDE[vs_current_short](../vs140/includes/vs_current_short_md.md)]. By default, this project targets version 3.5 of the [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)], and it has a reference to System.Core.dll and a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> directive for System.Linq. If one or more of these requirements are missing from the project, you can add them manually. For more information, see [How To: Create a LINQ Project](../Topic/How%20to:%20Create%20a%20LINQ%20Project_deleted.md).  
  
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Extension Methods (C# Programming Guide)](../vs140/extension-methods--csharp-programming-guide-.md)