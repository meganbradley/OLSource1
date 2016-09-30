---
title: "How to: Create a C-C++ Union by Using Attributes (C#)"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "How to: Create a C/C++ Union by Using Attributes (C#)"
dev_langs: 
  - "CSharp"
ms.assetid: 85f35e56-26e0-4d31-9f3a-89bd4005e71a
caps.latest.revision: 7
---
# How to: Create a C-C++ Union by Using Attributes (C#)
By using attributes you can customize how structs are laid out in memory. For example, you can create what is known as a union in C/C++ by using the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> attributes.  
  
## Example  
 In this code segment, all of the fields of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> start at the same location in memory.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 The following is another example where fields start at different explicitly set locations.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The two integer fields, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, share the same memory locations as <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. This sort of control over struct layout is useful when using platform invocation.  
  
## See Also  
 \<xref:System.Reflection*>   
 \<xref:System.Attribute*>   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Extending Metadata Using Attributes](assetId:///30386922-1e00-4602-9ebf-526b271a8b87)   
 [Reflection (C#)](../vs140/reflection--csharp-.md)   
 [Attributes (C#)](../vs140/attributes--csharp-.md)   
 [Creating Custom Attributes (C#)](../vs140/creating-custom-attributes--csharp-.md)   
 [Accessing Attributes by Using Reflection (C#)](../vs140/accessing-attributes-by-using-reflection--csharp-.md)