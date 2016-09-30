---
title: "Accessing Attributes by Using Reflection (Visual Basic)"
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
ms.assetid: c56e41da-5433-464f-a7bf-2a722e78bc9f
caps.latest.revision: 3
---
# Accessing Attributes by Using Reflection (Visual Basic)
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
 [Visual Basic Programming Guide](../vs140/visual-basic-programming-guide.md)   
 [Retrieving Information Stored in Attributes](assetId:///37dfe4e3-7da0-48b6-a3d9-398981524e1c)   
 [Reflection (Visual Basic)](../vs140/reflection--visual-basic-.md)   
 [Attributes (Visual Basic)](../vs140/attributes--visual-basic-1.md)   
 [Creating Custom Attributes (Visual Basic)](../vs140/creating-custom-attributes--visual-basic-.md)