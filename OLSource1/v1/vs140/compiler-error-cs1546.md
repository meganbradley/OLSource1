---
title: "Compiler Error CS1546"
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
  - "CS1546"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1546"
ms.assetid: 15fe2cdc-954f-4c67-80fd-9903c464f361
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1546
Property, indexer, or event 'property' is not supported by the language; try directly calling accessor method 'accessor'  
  
 Your code is consuming an object that has a default indexed property and tried to use the indexed syntax. To resolve this error, call the property's accessor method. For more information on indexers and properties, see [Indexers](../vs140/indexers--csharp-programming-guide-.md).  
  
 The following sample generates CS1546.  
  
## Example  
 This code sample consists of a .cpp file, which compiles to a .dll, and a .cs file, which uses that .dll. The following code is for the .dll file, and defines a property to be accessed by the code in the .cs file.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 This is the C# file.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>