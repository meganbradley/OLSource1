---
title: "How to: Parse Strings Using the Split Method (C++-CLI)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "How to: Parse Strings Using the Split Method (C++/CLI)"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "parsing strings [C++]"
  - "examples [C++], strings"
  - "regular expressions [C++], parsing strings"
  - "Split method, parsing strings"
  - "strings [C++], parsing"
ms.assetid: d52d2539-5ebb-4716-86b3-07314dd7e4bd
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Parse Strings Using the Split Method (C++-CLI)
The following code example demonstrates using the <xref:System.String.Split*?displayProperty=fullName> method to extract each word from a string. A string containing multiple types of word delineators is constructed and then parsed by calling <xref:System.String.Split*> with a list of the delineators. Then, each word in the sentence is displayed separately.  
  
## Example  
  
```  
// regex_split.cpp  
// compile with: /clr  
using namespace System;  
  
int main()  
{  
   String^ delimStr = " ,.:\t";  
   Console::WriteLine( "delimiter : '{0}'", delimStr );  
   array<Char>^ delimiter = delimStr->ToCharArray( );  
   array<String^>^ words;  
   String^ line = "one\ttwo three:four,five six seven";  
  
   Console::WriteLine( "text : '{0}'", line );  
   words = line->Split( delimiter );  
   Console::WriteLine( "Number of Words : {0}", words->Length );  
   for (int word=0; word<words->Length; word++)  
      Console::WriteLine( "{0}", words[word] );  
  
   return 0;  
}  
```  
  
## See Also  
 [.NET Framework Regular Expressions](assetId:///521b3f6d-f869-42e1-93e5-158c54a6895d)   
 [.NET Programming in C++](../vs140/.net-programming-with-c---cli--visual-c---.md)