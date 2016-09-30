---
title: "How to: Create a C-C++ Union by Using Attributes (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "How to: Create a C/C++ Union by Using Attributes (Visual Basic)"
dev_langs: 
  - "VB"
ms.assetid: 9352a7e4-c0da-4d07-aa14-55ed43736fcb
caps.latest.revision: 8
---
# How to: Create a C-C++ Union by Using Attributes (Visual Basic)
By using attributes you can customize how structs are laid out in memory. For example, you can create what is known as a union in C/C++ by using the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> attributes.  
  
## Example  
 In this code segment, all of the fields of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> start at the same location in memory.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 The following is another example where fields start at different explicitly set locations.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The two integer fields, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, share the same memory locations as <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. This sort of control over struct layout is useful when using platform invocation.  
  
## See Also  
 \<xref:System.Reflection*>   
 \<xref:System.Attribute*>   
 [Visual Basic Programming Guide](../vs140/visual-basic-programming-guide.md)   
 [Extending Metadata Using Attributes](assetId:///30386922-1e00-4602-9ebf-526b271a8b87)   
 [Reflection (Visual Basic)](../vs140/reflection--visual-basic-.md)   
 [Attributes (Visual Basic)](../vs140/attributes--visual-basic-1.md)   
 [Creating Custom Attributes (Visual Basic)](../vs140/creating-custom-attributes--visual-basic-.md)   
 [Accessing Attributes by Using Reflection (Visual Basic)](../vs140/accessing-attributes-by-using-reflection--visual-basic-.md)