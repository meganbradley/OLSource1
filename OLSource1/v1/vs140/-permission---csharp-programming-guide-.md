---
title: "&lt;permission&gt; (C# Programming Guide)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - permission
  - <permission>
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - <permission> C# XML tag
  - permission C# XML tag
ms.assetid: 769e93fe-8404-443f-bf99-577aa42b6a49
caps.latest.revision: 16
translation.priority.ht: 
  - de-de
  - ja-jp
---
# &lt;permission&gt; (C# Programming Guide)
## Syntax  
  
```  
<permission cref="member">description</permission>  
```  
  
#### Parameters  
 cref = " `member`"  
 A reference to a member or field that is available to be called from the current compilation environment. The compiler checks that the given code element exists and translates `member` to the canonical element name in the output XML. *member* must appear within double quotation marks (" ").  
  
 For information on how to create a cref reference to a generic type, see [<see\> (C# Programmer's Reference)](../vs140/-see---csharp-programming-guide-.md).  
  
 `description`  
 A description of the access to the member.  
  
## Remarks  
 The <permission\> tag lets you document the access of a member. The <xref:System.Security.PermissionSet?qualifyHint=False> class lets you specify access to a member.  
  
 Compile with [/doc](../vs140/-doc--csharp-compiler-options-.md) to process documentation comments to a file.  
  
## Example  
 [!code[csProgGuideDocComments#8](../vs140/codesnippet/CSharp/-permission---csharp-programming-guide-_1.cs)]
  
  
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Recommended Tags for Documentation Comments](../vs140/recommended-tags-for-documentation-comments--csharp-programming-guide-.md)