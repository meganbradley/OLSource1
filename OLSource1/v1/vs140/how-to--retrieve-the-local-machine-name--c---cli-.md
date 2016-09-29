---
title: "How to: Retrieve the Local Machine Name (C++-CLI)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "How to: Retrieve the Local Machine Name (C++/CLI)"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "computer name, retrieving"
  - "machine name, retrieving"
  - "computer name"
ms.assetid: 6c7acb9a-3f9b-43b2-a756-bd4fb859e697
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Retrieve the Local Machine Name (C++-CLI)
The following code example demonstrates the retrieval of the local machine name (the name of the computer as it appears on a network). You can accomplish this by getting the <xref:System.Environment.MachineName*> string, which is defined in the <xref:System.Environment*> namespace.  
  
## Example  
  
```  
// machine_name.cpp  
// compile with: /clr  
using namespace System;  
  
int main()   
{  
   Console::WriteLine("\nMachineName: {0}", Environment::MachineName);  
   return 0;  
}  
```  
  
## See Also  
 [Windows Operations in C++](../vs140/windows-operations--c---cli-.md)   
 [.NET Programming in C++](../vs140/.net-programming-with-c---cli--visual-c---.md)