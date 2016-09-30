---
title: "How to: Access Members of an Object (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "members, accessing"
  - "object variables, accessing members"
ms.assetid: a0072514-6a79-4dd6-8d03-ca8c13e61ddc
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Access Members of an Object (Visual Basic)
When you have an object variable that refers to an object, you often want to work with the members of that object, such as its methods, properties, fields, and events. For example, once you have created a new \<xref:System.Windows.Forms.Form*> object, you might want to set its \<xref:System.Windows.Forms.Control.Text*> property or call its \<xref:System.Windows.Forms.Control.Focus*> method.  
  
## Accessing Members  
 You access an object's members through the variable that refers to it.  
  
#### To access members of an object  
  
-   Use the member-access operator (<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>) between the object variable name and the member name.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
     If the member is [Shared (Visual Basic)](../vs140/shared--visual-basic-.md), you do not need a variable to access it.  
  
## Accessing Members of an Object of Known Type  
 If you know the type of an object at compile time, you can use *early binding* for a variable that refers to it.  
  
#### To access members of an object for which you know the type at compile time  
  
1.  Declare the object variable to be of the type of the object you intend to assign to the variable.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
     With <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, you can assign only \<xref:System.Windows.Forms.Form*> objects (or objects of a type derived from \<xref:System.Windows.Forms.Form*>) to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. If you have defined a class or structure with a widening <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> conversion to \<xref:System.Windows.Forms.Form*>, you can also assign that class or structure to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
2.  Use the member-access operator (<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>) between the object variable name and the member name.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
     You can access all of the methods and properties specific to the \<xref:System.Windows.Forms.Form*> class, no matter what the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> setting is.  
  
## Accessing Members of an Object of Unknown Type  
 If you do not know the type of an object at compile time, you must use *late binding* for any variable that refers to it.  
  
#### To access members of an object for which you do not know the type at compile time  
  
1.  Declare the object variable to be of the [Object Data Type](../vs140/object-data-type.md). (Declaring a variable as <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is the same as declaring it as \<xref:System.Object*?displayProperty=fullName>.)  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
     With <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, you can access only the members that are defined on the \<xref:System.Object*> class.  
  
2.  Use the member-access operator (<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>) between the object variable name and the member name.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
     To be able to access the members of any object you assign to the object variable, you must set <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. When you do this, the compiler cannot guarantee that a given member is exposed by the object you assign to the variable. If the object does not expose a member you attempt to access, a \<xref:System.MemberAccessException*> exception occurs.  
  
## See Also  
 \<xref:System.Object*>   
 \<xref:System.Windows.Forms.Form*>   
 \<xref:System.MemberAccessException*>   
 [Object Variables in Visual Basic](../vs140/object-variables-in-visual-basic.md)   
 [Object Variable Declaration](../vs140/object-variable-declaration--visual-basic-.md)   
 [Object Data Type](../vs140/object-data-type.md)   
 [Option Strict Statement](../vs140/option-strict-statement.md)