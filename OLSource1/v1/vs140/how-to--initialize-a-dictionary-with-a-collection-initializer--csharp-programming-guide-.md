---
title: "How to: Initialize a Dictionary with a Collection Initializer (C# Programming Guide)"
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
  - "collection initializers [C#], with Dictionary"
ms.assetid: 25283922-f8ee-40dc-a639-fac30804ec71
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Initialize a Dictionary with a Collection Initializer (C# Programming Guide)
A <xref:System.Collections.Generic.Dictionary`2*> contains a collection of key/value pairs. Its <xref:System.Collections.Generic.Dictionary`2.Add*> method takes two parameters, one for the key and one for the value. To initialize a <xref:System.Collections.Generic.Dictionary`2*>, or any collection whose `Add` method takes multiple parameters, enclose each set of parameters in braces as shown in the following example.  
  
## Example  
 In the following code example, a <xref:System.Collections.Generic.Dictionary`2*> is initialized with instances of type `StudentName`.  
  
 [!code[csProgGuideLINQ#34](../vs140/codesnippet/CSharp/how-to--initialize-a-dictionary-with-a-collection-initializer--csharp-programming-guide-_1.cs)]  
  
 Note the two pairs of braces in each element of the collection. The innermost braces enclose the object initializer for the `StudentName`, and the outermost braces enclose the initializer for the key/value pair that will be added to the `students`<xref:System.Collections.Generic.Dictionary`2*>. Finally, the whole collection initializer for the dictionary is enclosed in braces.  
  
## Compiling the Code  
 To run this code, copy and paste the class into a Visual C# console application project that has been created in [!INCLUDE[vs_current_short](../vs140/includes/vs_current_short_md.md)]. By default, this project targets version 3.5 of the [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)], and it has a reference to System.Core.dll and a using directive for System.Linq. If one or more of these requirements are missing from the project, you can add them manually. For more information, see [How To: Create a LINQ Project](../Topic/How%20to:%20Create%20a%20LINQ%20Project_deleted.md).  
  
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Object and Collection Initializers (C# Programming Guide)](../vs140/object-and-collection-initializers--csharp-programming-guide-.md)