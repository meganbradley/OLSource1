---
title: "How to: Use Regular Expressions for Simple Matching (C++-CLI)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "How to: Use Regular Expressions for Simple Matching (C++/CLI)"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "substrings, simple matches"
  - "searching, exact substring matches"
  - "strings [C++], exact substring matching"
  - "regular expressions [C++], simple matching"
  - "IsMatch method"
ms.assetid: 4661f6f3-0f6d-48f2-abe4-cb4770bf9bd5
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Use Regular Expressions for Simple Matching (C++-CLI)
The following code example uses regular expressions to look for exact substring matches. The search is performed by the static <xref:System.Text.RegularExpressions.Regex.IsMatch*> method, which takes two strings as input. The first is the string to be searched, and the second is the pattern to be searched for.  
  
## Example  
  
```  
// regex_simple.cpp  
// compile with: /clr  
#using <System.dll>  
  
using namespace System;  
using namespace System::Text::RegularExpressions;  
  
int main()  
{  
   array<String^>^ sentence =   
   {  
      "cow over the moon",  
      "Betsy the Cow",  
      "cowering in the corner",  
      "no match here"  
   };  
  
   String^ matchStr = "cow";  
   for (int i=0; i<sentence->Length; i++)  
   {  
      Console::Write( "{0,24}", sentence[i] );  
      if ( Regex::IsMatch( sentence[i], matchStr,  
                     RegexOptions::IgnoreCase ) )  
         Console::WriteLine("  (match for '{0}' found)", matchStr);  
      else  
         Console::WriteLine("");  
   }  
   return 0;  
}  
```  
  
## See Also  
 [.NET Framework Regular Expressions](assetId:///521b3f6d-f869-42e1-93e5-158c54a6895d)   
 [.NET Programming in C++](../vs140/.net-programming-with-c---cli--visual-c---.md)