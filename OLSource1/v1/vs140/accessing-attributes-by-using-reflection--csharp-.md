---
title: "Accessing Attributes by Using Reflection (C#)"
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
ms.assetid: dce3a696-4ceb-489a-b5e4-322a83052f18
caps.latest.revision: 7
---
# Accessing Attributes by Using Reflection (C#)
The fact that you can define custom attributes and place them in your source code would be of little value without some way of retrieving that information and acting on it. By using reflection, you can retrieve the information that was defined with custom attributes. The key method is <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, which returns an array of objects that are the run-time equivalents of the source code attributes. This method has several overloaded versions. For more information, see \<xref:System.Attribute*>.  
  
 An attribute specification such as:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 is conceptually equivalent to this:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 However, the code is not executed until <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is queried for attributes. Calling <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> on <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> causes an <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object to be constructed and initialized as above. If the class has other attributes, other attribute objects are constructed similarly. <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> then returns the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object and any other attribute objects in an array. You can then iterate over this array, determine what attributes were applied based on the type of each array element, and extract information from the attribute objects.  
  
## Example  
 Here is a complete example. A custom attribute is defined, applied to several entities, and retrieved via reflection.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 \<xref:System.Reflection*>   
 \<xref:System.Attribute*>   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Retrieving Information Stored in Attributes](assetId:///37dfe4e3-7da0-48b6-a3d9-398981524e1c)   
 [Reflection (C#)](../vs140/reflection--csharp-.md)   
 [Attributes (C#)](../vs140/attributes--csharp-.md)   
 [Creating Custom Attributes (C#)](../vs140/creating-custom-attributes--csharp-.md)