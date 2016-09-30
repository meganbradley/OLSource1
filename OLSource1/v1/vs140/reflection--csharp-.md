---
title: "Reflection (C#)"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
ms.assetid: f80a2362-953b-4e8e-9759-cd5f334190d4
caps.latest.revision: 7
---
# Reflection (C#)
Reflection provides objects (of type \<xref:System.Type*>) that describe assemblies, modules and types. You can use reflection to dynamically create an instance of a type, bind the type to an existing object, or get the type from an existing object and invoke its methods or access its fields and properties. If you are using attributes in your code, reflection enables you to access them. For more information, see [Extending Metadata Using Attributes](assetId:///30386922-1e00-4602-9ebf-526b271a8b87).  
  
 Here's a simple example of reflection using the static method <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> - inherited by all types from the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> base class - to obtain the type of a variable:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The output is:  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
 The following example uses reflection to obtain the full name of the loaded assembly.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The output is:  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
> [!NOTE]
>  The C# keywords <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> have no meaning in IL and are not used in the reflection APIs. The corresponding terms in IL are *Family* and *Assembly*. To identify an <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> method using reflection, use the \<xref:System.Reflection.MethodBase.IsAssembly*> property. To identify a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> method, use the \<xref:System.Reflection.MethodBase.IsFamilyOrAssembly*>.  
  
## Reflection Overview  
 Reflection is useful in the following situations:  
  
-   When you have to access attributes in your program's metadata. For more information, see [Retrieving Information Stored in Attributes](assetId:///37dfe4e3-7da0-48b6-a3d9-398981524e1c).  
  
-   For examining and instantiating types in an assembly.  
  
-   For building new types at runtime. Use classes in \<xref:System.Reflection.Emit*>.  
  
-   For performing late binding, accessing methods on types created at run time. See the topic [Dynamically Loading and Using Types](assetId:///db985bec-5942-40ec-b13a-771ae98623dc).  
  
## Related Sections  
 For more information:  
  
-   [Reflection Overview](assetId:///d1a58e7f-fb39-4d50-bf84-e3b8f9bf9775)  
  
-   [Viewing Type Information](assetId:///7e7303a9-4064-4738-b4e7-b75974ed70d2)  
  
-   [Reflection and Generic Types](assetId:///f7180fc5-dd41-42d4-8a8e-1b34288e06de)  
  
-   \<xref:System.Reflection.Emit*>  
  
-   [Retrieving Information Stored in Attributes](assetId:///37dfe4e3-7da0-48b6-a3d9-398981524e1c)  
  
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Assemblies in the Common Language Runtime](assetId:///2cfebe19-7436-49f1-bd99-3c4019f0b676)