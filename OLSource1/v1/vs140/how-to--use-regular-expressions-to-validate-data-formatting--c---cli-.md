---
title: "How to: Use Regular Expressions to Validate Data Formatting (C++-CLI)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "How to: Use Regular Expressions to Validate Data Formatting (C++/CLI)"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "strings [C++], formatting"
  - "data [C++], formatting"
  - "regular expressions [C++], validating data formatting"
ms.assetid: 225775c3-3efc-4734-bde2-1fdf73e3d397
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Use Regular Expressions to Validate Data Formatting (C++-CLI)
The following code example demonstrates the use of regular expressions to verify the formatting of a string. In the following code example, the string should contain a valid phone number. The following code example uses the string "\d{3}-\d{3}-\d{4}" to indicate that each field represents a valid phone number. The "d" in the string indicates a digit, and the argument after each "d" indicates the number of digits that must be present. In this case, the number is required to be separated by dashes.  
  
## Example  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [.NET Framework Regular Expressions](assetId:///521b3f6d-f869-42e1-93e5-158c54a6895d)   
 [.NET Programming in C++](../vs140/.net-programming-with-c---cli--visual-c---.md)