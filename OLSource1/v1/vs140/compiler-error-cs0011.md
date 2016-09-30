---
title: "Compiler Error CS0011"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "CS0011"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0011"
ms.assetid: 892553d7-a516-4631-84cd-94db5722c90d
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0011
The base class or interface 'class' in assembly 'assembly' referenced by type 'type' could not be resolved  
  
 A class that was imported from a file with **/reference**, is derived from a class or implements an interface that is not found. This can occur if a required DLL is not also included in the compilation with **/reference**.  
  
 For more information, see [Add Reference Dialog Box](assetId:///2feb0fe2-0805-4cc9-8cba-b0315849dfb7) and [/reference (Import Metadata) (C# Compiler Options)](../vs140/-reference--csharp-compiler-options-.md).  
  
## Example  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 The second file creates a DLL that defines a class <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> that is derived from the class <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> that was created in the previous example.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 The third file replaces the DLL created by the first step, and omits the definition of the inner class <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Example  
 Finally, the fourth file references the class <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> defined in the second example, which is derived from class <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, and which is now missing.  
  
 The following sample generates CS0011.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [Add Reference Dialog Box](assetId:///2feb0fe2-0805-4cc9-8cba-b0315849dfb7)   
 [/reference (Import Metadata) (C# Compiler Options)](../vs140/-reference--csharp-compiler-options-.md)