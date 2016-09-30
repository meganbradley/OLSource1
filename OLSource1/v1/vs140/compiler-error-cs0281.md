---
title: "Compiler Error CS0281"
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
  - "CS0281"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0281"
ms.assetid: 3b886510-6e4d-45bc-b885-3ab7f6b6b2c6
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0281
Friend access was granted to 'AssemblyName1', but the output assembly is named 'AssemblyName2'. Try adding a reference to 'AssemblyName1' or changing the output assembly name to match.  
  
 Friend access is a new common language runtime (CLR) feature that enables an assembly to see another assembly's non-public types. This error occurs when the assembly granting friend access specifies the wrong name for the grantee assembly. For more information, see [Friend Assemblies (C# Programmer's Reference)](../vs140/friend-assemblies--csharp-and-visual-basic-.md).  
  
## Example  
 The following sequence of code samples will generate CS0281.  
  
 The files used to create the strong named assemblies are generated as follows:  
  
-   sn -d CS0281.snk  
  
-   sn -k CS0281.snk  
  
-   sn -i CS0281.snk CS0281.snk  
  
-   sn -pc CS0281.snk key.publickey  
  
-   sn -tp key.publickey  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 The following sample generates CS0281.  
  
 Notice that this sample creates an output file with the same name as the output file in the first sample. To resolve, do not change the assembly attributes of the component and add class C.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>