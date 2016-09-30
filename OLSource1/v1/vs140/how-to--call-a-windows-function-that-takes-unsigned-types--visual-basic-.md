---
title: "How to: Call a Windows Function that Takes Unsigned Types (Visual Basic)"
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
  - "Windows functions, calling"
  - "unsigned data types"
  - "UShort data type, using"
  - "functions [Visual Basic], calling Windows functions"
  - "ULong data type, using"
  - "UInteger data type, using"
  - "data types [Visual Basic], using"
  - "unsigned types"
  - "data types [Visual Basic], unsigned"
  - "data types [Visual Basic], numeric"
  - "unsigned types, using"
ms.assetid: c2c0e712-8dc2-43b9-b4c6-345fbb02e7ce
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Call a Windows Function that Takes Unsigned Types (Visual Basic)
If you are consuming a class, module, or structure that has members of unsigned integer types, you can access these members with [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)].  
  
### To call a Windows function that takes an unsigned type  
  
1.  Use a [Declare Statement](../vs140/declare-statement.md) to tell [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] which library holds the function, what its name is in that library, what its calling sequence is, and how to convert strings when calling it.  
  
2.  In the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> statement, use <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> as appropriate for each parameter with an unsigned type.  
  
3.  Consult the documentation for the Windows function you are calling to find the names and values of the constants it uses. Many of these are defined in the WinUser.h file.  
  
4.  Declare the necessary constants in your code. Many Windows constants are 32-bit unsigned values, and you should declare these <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
5.  Call the function in the normal way. The following example calls the Windows function <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, which takes an unsigned integer argument.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
     You can test the function <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> with the following code.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
    > [!CAUTION]
    >  The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> data types are not part of the [Common Language Specification](assetId:///4f0b77d0-4844-464f-af73-6e06bedeafc6) (CLS), so CLS-compliant code cannot consume a component that uses them.  
  
    > [!IMPORTANT]
    >  Making a call to unmanaged code, such as the Windows application programming interface (API), exposes your code to potential security risks.  
  
    > [!IMPORTANT]
    >  Calling the Windows API requires unmanaged code permission, which might affect its execution in partial-trust situations. For more information, see \<xref:System.Security.Permissions.SecurityPermission*> and [Code Access Permissions](assetId:///e5ae402f-6dda-4732-bbe8-77296630f675).  
  
## See Also  
 [Data Types](../vs140/data-type-summary--visual-basic-.md)   
 [Integer Data Type](../vs140/integer-data-type--visual-basic-.md)   
 [UInteger Data Type](../vs140/uinteger-data-type.md)   
 [Declare Statement](../vs140/declare-statement.md)   
 [Walkthrough: Calling Windows APIs](../vs140/walkthrough--calling-windows-apis--visual-basic-.md)