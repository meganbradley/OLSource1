---
title: "Extracting a Library Member"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "Lib"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LIB [C++], extracting library members"
  - "EXTRACT library manager option"
  - "libraries, extracting members"
  - "-EXTRACT library manager option"
  - "extracting library members"
  - "/EXTRACT library manager option"
ms.assetid: a2c5c2a1-9b7e-489a-a9a4-1dec694e1fc5
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Extracting a Library Member
You can use LIB to create an object (.obj) file that contains a copy of a member of an existing library. To extract a copy of a member, use the following syntax:  
  
```  
LIB library /EXTRACT:member /OUT:objectfile  
```  
  
 This command creates an .obj file called *objectfile* that contains a copy of a `member` of a *library*. The `member` name is case sensitive. You can extract only one member in a single command. The /OUT option is required; there is no default output name. If a file called *objectfile* already exists in the specified directory (or the current directory, if no directory is specified with *objectfile*), the extracted *objectfile* replaces the existing file.  
  
## See Also  
 [LIB Reference](../vs140/lib-reference.md)