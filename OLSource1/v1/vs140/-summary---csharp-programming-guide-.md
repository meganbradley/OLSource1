---
title: "&lt;summary&gt; (C# Programming Guide)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "<summary>"
  - "summary"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "<summary> C# XML tag"
  - "summary C# XML tag"
ms.assetid: b4c43d92-2067-4eac-a59a-d32f5248c08b
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;summary&gt; (C# Programming Guide)
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A summary of the object.  
  
## Remarks  
 The \<summary> tag should be used to describe a type or a type member. Use [\<remarks>](../vs140/-remarks---csharp-programming-guide-.md) to add supplemental information to a type description. Use the [cref Attribute](../vs140/cref-attribute--csharp-programming-guide-.md) to enable documentation tools such as [Sandcastle](http://go.microsoft.com/fwlink/?LinkId=124061) to create internal hyperlinks to documentation pages for code elements.  
  
 The text for the \<summary> tag is the only source of information about the type in IntelliSense, and is also displayed in the Object Browser Window.  
  
 Compile with [/doc](../vs140/-doc--csharp-compiler-options-.md) to process documentation comments to a file. To create the final documentation based on the compiler-generated file, you can create a custom tool, or use a tool such as [Sandcastle](http://go.microsoft.com/fwlink/?LinkId=124061).  
  
## Example  
 [!code[csProgGuideDocComments#12](../vs140/codesnippet/CSharp/-summary---csharp-programming-guide-_1.cs)]  
  
 The previous example produces the following XML file.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 The following example shows how to make a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> reference to a generic type.  
  
 [!code[csProgGuideDocComments#11](../vs140/codesnippet/CSharp/-summary---csharp-programming-guide-_2.cs)]  
  
 The previous example produces the following XML file.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Recommended Tags for Documentation Comments](../vs140/recommended-tags-for-documentation-comments--csharp-programming-guide-.md)