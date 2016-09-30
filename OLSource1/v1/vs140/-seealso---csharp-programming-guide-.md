---
title: "&lt;seealso&gt; (C# Programming Guide)"
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
  - "cref"
  - "<seealso>"
  - "seealso"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "cref [C#], see also"
  - "seealso C# XML tag"
  - "cref [C#]"
  - "cross-references [C#], tags"
  - "<seealso> C# XML tag"
ms.assetid: 8e157f3f-f220-4fcf-9010-88905b080b18
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;seealso&gt; (C# Programming Guide)
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 cref = " <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>"  
 A reference to a member or field that is available to be called from the current compilation environment. The compiler checks that the given code element exists and passes <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to the element name in the output XML.<CodeContentPlaceHolder>3\</CodeContentPlaceHolder> must appear within double quotation marks (" ").  
  
 For information on how to create a cref reference to a generic type, see [\<see> (C# Programmer's Reference)](../vs140/-see---csharp-programming-guide-.md).  
  
## Remarks  
 The \<seealso> tag lets you specify the text that you might want to appear in a See Also section. Use [\<see>](../vs140/-see---csharp-programming-guide-.md) to specify a link from within text.  
  
 Compile with [/doc](../vs140/-doc--csharp-compiler-options-.md) to process documentation comments to a file.  
  
## Example  
 See [\<summary>](../vs140/-summary---csharp-programming-guide-.md) for an example of using \<seealso>.  
  
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Recommended Tags for Documentation Comments](../vs140/recommended-tags-for-documentation-comments--csharp-programming-guide-.md)