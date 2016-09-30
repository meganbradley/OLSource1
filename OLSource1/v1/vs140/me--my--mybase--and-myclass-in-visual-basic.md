---
title: "Me, My, MyBase, and MyClass in Visual Basic"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "MyClass"
  - "vb.Me"
  - "MyBase"
  - "vb.MyBase"
  - "Me"
  - "vb.MyClass"
  - "vb.This"
  - "vb.My"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "My object"
  - "self-reference, Me keyword"
  - "MyClass keyword, relationship to similar programming elements"
  - "Me keyword, relationship to similar programming elements"
  - "Me keyword, referring to the current instance of an object"
  - "Me keyword"
  - "self-reference"
  - "current instance, Me keyword"
  - "MyBase keyword, relationship to similar programming elements"
ms.assetid: f8e241ae-b1ed-4886-9aa0-08c632154029
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Me, My, MyBase, and MyClass in Visual Basic
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> in [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] have similar names, but different purposes. This topic describes each of these entities in order to distinguish them.  
  
## Me  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> keyword provides a way to refer to the specific instance of a class or structure in which the code is currently executing. <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> behaves like either an object variable or a structure variable referring to the current instance. Using <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is particularly useful for passing information about the currently executing instance of a class or structure to a procedure in another class, structure, or module.  
  
 For example, suppose you have the following procedure in a module.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 You can call this procedure and pass the current instance of the \<xref:System.Windows.Forms.Form*> class as an argument by using the following statement.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## My  
 The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> feature provides easy and intuitive access to a number of [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] classes, enabling the [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] user to interact with the computer, application, settings, resources, and so on.  
  
## MyBase  
 The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> keyword behaves like an object variable referring to the base class of the current instance of a class. <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is commonly used to access base class members that are overridden or shadowed in a derived class. <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is used to explicitly call a base class constructor from a derived class constructor.  
  
## MyClass  
 The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> keyword behaves like an object variable referring to the current instance of a class as originally implemented. <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is similar to <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, but all method calls on it are treated as if the method were <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
## See Also  
 [Inheritance Basics](../vs140/inheritance-basics--visual-basic-.md)