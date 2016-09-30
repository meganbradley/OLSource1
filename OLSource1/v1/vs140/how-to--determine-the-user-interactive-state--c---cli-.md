---
title: "How to: Determine the User Interactive State (C++-CLI)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "How to: Determine the User Interactive State (C++/CLI)"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Visual C++, user interactive state"
  - "user interactive state"
ms.assetid: 9f52323e-38b8-4a41-9b1d-052012ad839b
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Determine the User Interactive State (C++-CLI)
The following code example demonstrates how to determine whether code is being run in a user-interactive context. If \<xref:System.Environment.UserInteractive*> is false, then the code is running as a service process or from inside a Web application, in which case you should not attempt to interact with the user.  
  
## Example  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Windows Operations in C++](../vs140/windows-operations--c---cli-.md)   
 [.NET Programming in C++](../vs140/.net-programming-with-c---cli--visual-c---.md)