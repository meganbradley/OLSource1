---
title: "&lt;include&gt; (C# Programming Guide)"
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
  - "include"
  - "<include>"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "<include> C# XML tag"
  - "include C# XML tag"
ms.assetid: a8a70302-6196-4643-bd09-ef33f411f18f
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;include&gt; (C# Programming Guide)
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The name of the XML file containing the documentation. The file name can be qualified with a path. Enclose <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> in single quotation marks (' ').  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The path of the tags in <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> that leads to the tag <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. Enclose the path in single quotation marks (' ').  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The name specifier in the tag that precedes the comments; <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> will have an <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 The ID for the tag that precedes the comments. Enclose the ID in double quotation marks (" ").  
  
## Remarks  
 The \<include> tag lets you refer to comments in another file that describe the types and members in your source code. This is an alternative to placing documentation comments directly in your source code file. By putting the documentation in a separate file, you can apply source control to the documentation separately from the source code. One person can have the source code file checked out and someone else can have the documentation file checked out.  
  
 The \<include> tag uses the XML XPath syntax. Refer to XPath documentation for ways to customize your \<include> use.  
  
## Example  
 This is a multifile example. The first file, which uses \<include>, is listed below:  
  
 [!code[csProgGuideDocComments#5](../vs140/codesnippet/CSharp/-include---csharp-programming-guide-_1.cs)]  
  
 The second file, xml_include_tag.doc, contains the following documentation comments:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Program Output  
 The following output is generated when you compile the Test and Test2 classes with the following command line: <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> In Visual Studio, you specify the XML doc comments option in the Build pane of the Project Designer. When the C# compiler sees the \<inclue> tag, it will search for documentation comments in xml_include_tag.doc instead of the current source file. The compiler then generates DocFileName.xml, and this is the file that is consumed by documentation tools such as [Sandcastle](http://go.microsoft.com/fwlink/?LinkId=124061) to produce the final documentation.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Recommended Tags for Documentation Comments](../vs140/recommended-tags-for-documentation-comments--csharp-programming-guide-.md)