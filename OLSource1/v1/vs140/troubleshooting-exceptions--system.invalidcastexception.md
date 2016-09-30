---
title: "Troubleshooting Exceptions: System.InvalidCastException"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "JScript"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "InvalidCastException class"
ms.assetid: a855dfe1-5c06-45a6-9c2f-c9e799ccf8f0
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Troubleshooting Exceptions: System.InvalidCastException
An \<xref:System.InvalidCastException*> exception is thrown when a failure occurs during an explicit reference conversion. Reference conversions are conversions from one reference type to another. While they may change the type of the reference, they never change the type or value of the conversion's target. Casting objects from one type to another is a frequent cause for this exception.  
  
## Associated Tips  
 **Check source types against destination types to make sure the conversion is valid.**  
 For information on conversions supported by the system, see \<xref:System.Convert*>.  
  
## Remarks  
 For an explicit reference conversion to be successful, the source value must be Null (<CodeContentPlaceHolder>0\</CodeContentPlaceHolder> in Visual Basic), or the object type referenced by the source argument must be convertible to the destination type by an implicit reference conversion.  
  
 When a Visual Basic 6.0 application with a call to a custom event in a user control is upgraded to a newer version of Visual Basic and run, this exception may occur with the additional information, "Specified cast is not valid." To address this error, find the following line of code in <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>:  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
 And replace it with:  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
## See Also  
 \<xref:System.InvalidCastException*>   
 [How to: Find Out More About an Exception with the Exception Assistant](../vs140/how-to--use-the-exception-assistant.md)   
 [How to: Convert an Object to Another Type in Visual Basic](../vs140/how-to--convert-an-object-to-another-type-in-visual-basic.md)   
 [Converting Strings to .NET Framework Data Types](assetId:///65455ef3-9120-412c-819b-d0f59f88ac09)   
 [How to: Implement User-Defined Conversions Between Structs (C# Programmers Reference)](../vs140/how-to--implement-user-defined-conversions-between-structs--csharp-programming-guide-.md)