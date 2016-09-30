---
title: "How to: Retrieve the Current Username (C++-CLI)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "How to: Retrieve the Current Username (C++/CLI)"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "current user names"
  - "user names, retrieving"
  - "UserName string"
ms.assetid: 91679571-d029-41f5-b657-1460c81c608a
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Retrieve the Current Username (C++-CLI)
The following code example demonstrates the retrieval of the current user name (the name of the user logged into Windows). The name is stored in the \<xref:System.Environment.UserName*> string, which is defined in the \<xref:System.Environment*> namespace.  
  
## Example  
  
```  
// username.cpp  
// compile with: /clr  
using namespace System;  
  
int main()   
{  
   Console::WriteLine("\nCurrent user: {0}", Environment::UserName);  
   return 0;  
}  
```  
  
## See Also  
 [Windows Operations in C++](../vs140/windows-operations--c---cli-.md)   
 [.NET Programming in C++](../vs140/.net-programming-with-c---cli--visual-c---.md)