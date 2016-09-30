---
title: "dllexport, dllimport"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "dllimport_cpp"
  - "dllexport_cpp"
  - "dllexport"
  - "dllimport"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "dllexport __declspec keyword"
  - "__declspec keyword [C++], dllexport"
  - "dllimport __declspec keyword"
  - "__declspec keyword [C++], dllimport"
ms.assetid: ff95b645-ef55-4e72-b848-df44657b3208
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# dllexport, dllimport
**Microsoft Specific**  
  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and **dllimport** storage-class attributes are Microsoft-specific extensions to the C and C++ languages. You can use them to export and import functions, data, and objects to or from a DLL.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 These attributes explicitly define the DLL's interface to its client, which can be the executable file or another DLL. Declaring functions as <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> eliminates the need for a module-definition (.def) file, at least with respect to the specification of exported functions. The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> attribute replaces the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> keyword.  
  
 If a class is marked declspec(dllexport), any specializations of class templates in the class hierarchy are implicitly marked as declspec(dllexport). This means that class templates are explicitly instantiated and the class's members must be defined.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> of a function exposes the function with its decorated name. For C++ functions, this includes name mangling. For C functions or functions that are declared as <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, this includes platform-specific decoration that's based on the calling convention. For information on name decoration in C/C++ code, see [Decorated Names](../vs140/decorated-names.md). No name decoration is applied to exported C functions or C++ <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> functions using the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> calling convention.  
  
 To export an undecorated name, you can link by using a Module Definition (.def) file that defines the undecorated name in an EXPORTS section. For more information, see [EXPORTS](../vs140/exports.md). Another way to export an undecorated name is to use a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> directive in the source code.  
  
 When you declare <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> or **dllimport**, you must use [extended attribute syntax](../vs140/__declspec.md) and the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> keyword.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Alternatively, to make your code more readable, you can use macro definitions:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 For more information, see:  
  
-   [Definitions and Declarations](../vs140/definitions-and-declarations--c---.md)  
  
-   [Defining Inline C++ Functions with dllexport and dllimport](../vs140/defining-inline-c---functions-with-dllexport-and-dllimport.md)  
  
-   [General Rules and Limitations](../vs140/general-rules-and-limitations.md)  
  
-   [Using dllimport and dllexport in C++ Classes](../vs140/using-dllimport-and-dllexport-in-c---classes.md)  
  
 **END Microsoft Specific**  
  
## See Also  
 [__declspec](../vs140/__declspec.md)   
 [Keywords](../vs140/keywords--c---.md)