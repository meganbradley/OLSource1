---
title: "Creating Custom Attributes (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
ms.assetid: 5c9ef584-6c7c-496b-92a9-6e42f8d9ca28
caps.latest.revision: 3
---
# Creating Custom Attributes (Visual Basic)
You can create your own custom attributes by defining an attribute class, a class that derives directly or indirectly from \<xref:System.Attribute*>, which makes identifying attribute definitions in metadata fast and easy. Suppose you want to tag types with the name of the programmer who wrote the type. You might define a custom <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> attribute class:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The class name is the attribute's name, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. It is derived from <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, so it is a custom attribute class. The constructor's parameters are the custom attribute's positional parameters. In this example, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is a positional parameter. Any public read-write fields or properties are named parameters. In this case, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is the only named parameter. Note the use of the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> attribute to make the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> attribute valid only on class and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> declarations.  
  
 You could use this new attribute as follows:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> has a named parameter, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, with which you can make a custom attribute single-use or multiuse. In the following code example, a multiuse attribute is created.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 In the following code example, multiple attributes of the same type are applied to a class.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
> [!NOTE]
>  If your attribute class contains a property, that property must be read-write.  
  
## See Also  
 \<xref:System.Reflection*>   
 [Visual Basic Programming Guide](../vs140/visual-basic-programming-guide.md)   
 [Writing Custom Attributes](assetId:///97216f69-bde8-49fd-ac40-f18c500ef5dc)   
 [Reflection (Visual Basic)](../vs140/reflection--visual-basic-.md)   
 [Attributes (Visual Basic)](../vs140/attributes--visual-basic-1.md)   
 [Accessing Attributes by Using Reflection (Visual Basic)](../vs140/accessing-attributes-by-using-reflection--visual-basic-.md)   
 [AttributeUsage (Visual Basic)](../vs140/attributeusage--visual-basic-.md)