---
title: "Access of shared member through an instance; qualifying expression will not be evaluated"
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
  - "vbc42025"
  - "BC42025"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "BC42025"
ms.assetid: db3337e5-c349-42bf-86df-d9c1e00952a5
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Access of shared member through an instance; qualifying expression will not be evaluated
An instance variable of a class or structure is used to access a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> variable, property, procedure, or event defined in that class or structure. This warning can also occur if an instance variable is used to access an implicitly shared member of a class or structure, such as a constant or enumeration, or a nested class or structure.  
  
 The purpose of sharing a member is to create only a single copy of that member and make that single copy available to every instance of the class or structure in which it is declared. It is consistent with this purpose to access a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> member through the name of its class or structure, rather than through a variable that holds an individual instance of that class or structure.  
  
 Accessing a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> member through an instance variable can make your code more difficult to understand by obscuring the fact that the member is <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. Furthermore, if such access is part of an expression that performs other actions, such as a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> procedure that returns an instance of the shared member, [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] bypasses the expression and any other actions it would otherwise perform.  
  
 For more information and an example, see [Shared (Visual Basic)](../vs140/shared--visual-basic-.md).  
  
 By default, this message is a warning. For more information about hiding warnings or treating warnings as errors, see [Configuring Warnings in Visual Basic](../vs140/configuring-warnings-in-visual-basic.md).  
  
 **Error ID:** BC42025  
  
### To correct this error  
  
-   Use the name of the class or structure that defines the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> member to access it, as shown in the following example.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
    > [!NOTE]
    >  Be alert for the effects of scope when two programming elements have the same name. In the previous example, if you declare an instance by using <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, the compiler treats a call to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> as an access of the method through the class name, and no warning occurs.  
  
## See Also  
 [Shared (Visual Basic)](../vs140/shared--visual-basic-.md)   
 [Scope in Visual Basic](../vs140/scope-in-visual-basic.md)