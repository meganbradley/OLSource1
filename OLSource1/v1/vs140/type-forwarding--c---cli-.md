---
title: "Type Forwarding (C++-CLI)"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
H1: "Type Forwarding (C++/CLI)"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "type forwarding, Visual C++"
ms.assetid: ae730b69-0c27-41cc-84e1-3132783866ea
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Type Forwarding (C++-CLI)
*Type forwarding* allows you to move a type from one assembly (assembly A) into another assembly (assembly B), such that, it is not necessary to recompile clients that consume assembly A.  
  
## All Platforms  
 This feature is not supported in all runtimes.  
  
## Windows Runtime  
 This feature is not supported in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
### Requirements  
 Compiler option: **/ZW**  
  
## Common Language Runtime  
 The following code example demonstrates how to use type forwarding.  
  
### Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The assembly into which you are moving the type definition.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The type whose definition you are moving into another assembly.  
  
### Remarks  
 After a component (assembly) ships and is being used by client applications, you can use type forwarding to move a type from the component (assembly) into another assembly, ship the updated component (and any additional assemblies required), and the client applications will still work without being recompiled.  
  
 Type forwarding only works for components referenced by existing applications. When you rebuild an application, there must be the appropriate assembly references for any types used in the application.  
  
 When forwarding a type (Type A) from an assembly, you must add the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> attribute for that type, as well as an assembly reference. The assembly that you reference must contain one of the following:  
  
-   The definition for Type A.  
  
-   A <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> attribute for Type A, as well as an assembly reference.  
  
 Examples of types that can be forwarded include:  
  
-   ref classes  
  
-   value classes  
  
-   enums  
  
-   interfaces  
  
 You cannot forward the following types:  
  
-   Generic types  
  
-   Native types  
  
-   Nested types (if you want to forward a nested type, you should forward the enclosing type)  
  
 You can forward a type to an assembly authored in any language targeting the common language runtime.  
  
 So, if a source code file that is used to build assembly A.dll contains a type definition (<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>), and you wanted to move that type definition to assembly B.dll, you would:  
  
1.  Move the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> type definition to a source code file used to build B.dll.  
  
2.  Build assembly B.dll  
  
3.  Delete the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> type definition from the source code used to build A.dll, and replace it with the following:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
4.  Build assembly A.dll.  
  
5.  Use A.dll without recompiling client applications.  
  
### Requirements  
 Compiler option: **/clr**