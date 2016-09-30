---
title: "cref Attribute (C# Programming Guide)"
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
  - "cref [C#]"
ms.assetid: 66a6b0e5-b961-4504-a461-3a4cf481fc8b
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# cref Attribute (C# Programming Guide)
The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> attribute in an XML documentation tag means "code reference." It specifies that the inner text of the tag is a code element, such as a type, method, or property. Documentation tools like [Sandcastle](http://go.microsoft.com/fwlink/?LinkId=124061) use the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> attributes to automatically generate hyperlinks to the page where the type or member is documented.  
  
## Example  
 The following example shows <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> attributes used in [\<see>](../vs140/-see---csharp-programming-guide-.md) tags.  
  
 [!code[csProgGuideDocComments#3](../vs140/codesnippet/CSharp/cref-attribute--csharp-programming-guide-_1.cs)]  
  
 When compiled, the program produces the following XML file. Notice that the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> attribute for the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> method, for example, has been transformed by the compiler to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. The "M:" prefix means "method" and is a convention that is recognized by documentation tools such as Sandcastle. For a complete list of prefixes, see [Processing the XML File (C# Programming Guide)](../vs140/processing-the-xml-file--csharp-programming-guide-.md).  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [XML Documentation Comments (C# Programming Guide)](../vs140/xml-documentation-comments--csharp-programming-guide-.md)   
 [Recommended Tags for Documentation Comments (C# Programming Guide)](../vs140/recommended-tags-for-documentation-comments--csharp-programming-guide-.md)