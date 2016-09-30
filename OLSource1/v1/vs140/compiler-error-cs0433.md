---
title: "Compiler Error CS0433"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "CS0433"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0433"
ms.assetid: efec174a-faa1-4b88-860b-7d9db9c82a02
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0433
The type TypeName1 exists in both TypeName2 and TypeName3  
  
 Two different assemblies referenced in your application contain the same namespace and type, which produces ambiguity.  
  
 To resolve this error, use the alias feature of the [/reference (Import Metadata) (C# Compiler Options)](../vs140/-reference--csharp-compiler-options-.md) compiler option or do not reference one of your assemblies.  
  
## Example  
 This code creates the DLL with the first copy of the ambiguous type.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 This code creates the DLL with the second copy of the ambiguous type.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 The following example generates CS0433.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Example  
 The following example shows how you can use the alias feature of the **/reference** compiler option to resolve this CS0433 error.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>