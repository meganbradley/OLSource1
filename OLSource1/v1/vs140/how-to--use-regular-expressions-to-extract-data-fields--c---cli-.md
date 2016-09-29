---
title: "How to: Use Regular Expressions to Extract Data Fields (C++-CLI)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "How to: Use Regular Expressions to Extract Data Fields (C++/CLI)"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "strings [C++], extracting data from"
  - "formatted strings [C++]"
  - "regular expressions [C++], extracting data fields"
  - "data [C++], extracting from strings"
ms.assetid: b581d9b6-630e-48fa-94fe-20b0f7b89b06
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Use Regular Expressions to Extract Data Fields (C++-CLI)
The following code example demonstrates the use of regular expressions to extract data from a formatted string. The following code example uses the <xref:System.Text.RegularExpressions.Regex*> class to specify a pattern that corresponds to an e-mail address. This patter includes field identifiers that can be used to retrieve the user and host name portions of each e-mail address. The <xref:System.Text.RegularExpressions.Match*> class is used to perform the actual pattern matching. If the given e-mail address is valid, the user name and host names are extracted and displayed.  
  
## Example  
  
```  
// Regex_extract.cpp  
// compile with: /clr  
#using <System.dll>  
  
using namespace System;  
using namespace System::Text::RegularExpressions;  
  
int main()  
{  
    array<String^>^ address=  
    {  
        "jay@southridgevideo.com",  
        "barry@adatum.com",  
        "treyresearch.net",  
        "karen@proseware.com"  
    };  
  
    Regex^ emailregex = gcnew Regex("(?<user>[^@]+)@(?<host>.+)");  
  
    for (int i=0; i<address->Length; i++)  
    {  
        Match^ m = emailregex->Match( address[i] );  
        Console::Write("\n{0,25}", address[i]);  
  
        if ( m->Success )   
        {  
            Console::Write("   User='{0}'",   
            m->Groups["user"]->Value);  
            Console::Write("   Host='{0}'",   
            m->Groups["host"]->Value);  
        }  
        else   
            Console::Write("   (invalid email address)");  
        }  
  
    Console::WriteLine("");  
    return 0;  
}  
```  
  
## See Also  
 [.NET Framework Regular Expressions](assetId:///521b3f6d-f869-42e1-93e5-158c54a6895d)   
 [.NET Programming in C++](../vs140/.net-programming-with-c---cli--visual-c---.md)