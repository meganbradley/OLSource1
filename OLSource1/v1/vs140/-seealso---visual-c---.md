---
title: "&lt;seealso&gt; (Visual C++)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "<seealso>"
  - "seealso"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "seealso C++ XML tag"
  - "<seealso> C++ XML tag"
ms.assetid: cb33d100-9c50-4485-8d0c-573429eff155
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;seealso&gt; (Visual C++)
The \<seealso> tag lets you specify the text that you might want to appear in a See Also section. Use [\<see>](../vs140/-see---visual-c---.md) to specify a link from within text.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A reference to a member or field that is available to be called from the current compilation environment.  Enclose the name in single or double quotation marks.  
  
 The compiler checks that the given code element exists and resolves <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to the element name in the output XML.  The compiler issues a warning if it does not find <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 For information on how to create a cref reference to a generic type, see [\<see> (C++)](../vs140/-see---visual-c---.md).  
  
## Remarks  
 Compile with [/doc](../vs140/-doc--process-documentation-comments---c-c---.md) to process documentation comments to a file.  
  
 See [\<summary> (C++)](../vs140/-summary---visual-c---.md) for an example of using \<seealso>.  
  
 The Visual C++ compiler will attempt to resolve cref references in one pass through the documentation comments.  Therefore, if using the C++ lookup rules, a symbol is not found by the compiler the reference will be marked as unresolved.  
  
## Example  
 In the following sample, an unresolved symbol is referenced in a cref. The XML comment for the cref to B::Test will be <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, whereas the reference to A::Test is well-formed <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [XML Documentation](../vs140/xml-documentation--visual-c---.md)