---
title: "Compiler Error CS1061"
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
  - "CS1061"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1061"
ms.assetid: 10ba0509-d541-43da-acf5-eaa7987e41d4
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1061
'type' does not contain a definition for 'member' and no extension method 'name' accepting a first argument of type 'type' could be found (are you missing a using directive or an assembly reference?).  
  
 This error occurs when you try to call a method or access a class member that does not exist.  
  
## Example  
 The following example generates CS1061 because <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> does not have a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> method. It does have a method that is called <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. Perhaps that is what the author of this source code meant to write.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Classes and Structs (C# Programming Guide)](../vs140/classes-and-structs--csharp-programming-guide-.md)   
 [Extension Methods (C# Programming Guide)](../vs140/extension-methods--csharp-programming-guide-.md)