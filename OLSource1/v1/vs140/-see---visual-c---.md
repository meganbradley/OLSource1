---
title: "&lt;see&gt; (Visual C++)"
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
  - "<see>"
  - "see"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "<see> C++ XML tag"
  - "see C++ XML tag"
ms.assetid: 20ef66f4-b278-45cf-8613-63919edf5720
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;see&gt; (Visual C++)
The <see\> tag lets you specify a link from within text. Use [<seealso\>](../vs140/-seealso---visual-c---.md) to indicate text that you might want to appear in a See Also section.  
  
## Syntax  
  
```  
<see cref="member"/>  
```  
  
#### Parameters  
 `member`  
 A reference to a member or field that is available to be called from the current compilation environment.  Enclose the name in single or double quotation marks.  
  
 The compiler checks that the given code element exists and resolves `member` to the element name in the output XML.  The compiler issues a warning if it does not find `member`.  
  
## Remarks  
 Compile with [/doc](../vs140/-doc--process-documentation-comments---c-c---.md) to process documentation comments to a file.  
  
 See [<summary\>](../vs140/-summary---visual-c---.md) for an example of using <see\>.  
  
 The Visual C++ compiler will attempt to resolve cref references in one pass through the documentation comments.  Therefore, if using the C++ lookup rules, a symbol is not found by the compiler the reference will be marked as unresolved. See [<seealso\> (C++)](../vs140/-seealso---visual-c---.md) for more information.  
  
## Example  
 The following sample shows how you can make cref reference to a generic type, such that, the compiler will resolve the reference.  
  
```  
// xml_see_cref_example.cpp  
// compile with: /LD /clr /doc  
// the following cref shows how to specify the reference, such that,  
// the compiler will resolve the reference  
/// <see cref="C{T}">  
/// </see>  
ref class A {};  
  
// the following cref shows another way to specify the reference,   
// such that, the compiler will resolve the reference  
/// <see cref="C < T >"/>  
  
// the following cref shows how to hard-code the reference  
/// <see cref="T:C`1">  
/// </see>  
ref class B {};  
  
/// <see cref="A">  
/// </see>  
/// <typeparam name="T"></typeparam>  
generic<class T>  
ref class C {};  
```  
  
## See Also  
 [XML Documentation](../vs140/xml-documentation--visual-c---.md)