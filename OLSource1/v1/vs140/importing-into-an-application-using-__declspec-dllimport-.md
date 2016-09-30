---
title: "Importing into an Application Using __declspec(dllimport)"
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
  - "__declspec"
  - "dllimport"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "__declspec(dllimport) keyword [C++]"
  - "importing DLLs [C++], __declspec(dllimport)"
ms.assetid: edb4da4e-f83a-44cf-a668-9239d49dbe42
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Importing into an Application Using __declspec(dllimport)
A program that uses public symbols defined by a DLL is said to import them. When you create header files for applications that use your DLLs to build with, use **__declspec(dllimport)** on the declarations of the public symbols. The keyword **__declspec(dllimport)** works whether you export with .def files or with the **__declspec(dllexport)** keyword.  
  
 To make your code more readable, define a macro for **__declspec(dllimport)** and then use the macro to declare each imported symbol:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Using **__declspec(dllimport)** is optional on function declarations, but the compiler produces more efficient code if you use this keyword. However, you must use **__declspec(dllimport)** for the importing executable to access the DLL's public data symbols and objects. Note that the users of your DLL still need to link with an import library.  
  
 You can use the same header file for both the DLL and the client application. To do this, use a special preprocessor symbol that indicates whether you are building the DLL or building the client application. For example:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## What do you want to do?  
  
-   [Initialize a DLL](../vs140/initializing-a-dll.md)  
  
## What do you want to know more about?  
  
-   [Importing and exporting inline functions](../vs140/importing-and-exporting-inline-functions.md)  
  
-   [Mutual imports](../vs140/mutual-imports.md)  
  
## See Also  
 [Importing into an Application](../vs140/importing-into-an-application.md)