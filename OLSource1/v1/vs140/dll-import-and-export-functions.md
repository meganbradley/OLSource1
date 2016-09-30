---
title: "DLL Import and Export Functions"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "DLLs [C++], importing"
  - "dllimport attribute [C++], storage-class attribute"
  - "DLL exports [C++]"
  - "declaring functions, with dllexport and dllimport"
  - "extended storage-class attributes"
  - "dllexport attribute [C++], storage-class attribute"
ms.assetid: 08d164b9-770a-4e14-afeb-c6f21d9e33e4
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DLL Import and Export Functions
**Microsoft Specific**  
  
 The most complete and up-to-date information on this topic can be found in [dllexport, dllimport](../vs140/dllexport--dllimport.md).  
  
 The **dllimport** and <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> storage-class modifiers are Microsoft-specific extensions to the C language. These modifiers explicitly define the DLL's interface to its client (the executable file or another DLL). Declaring functions as <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> eliminates the need for a module-definition (.DEF) file. You can also use the **dllimport** and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> modifiers with data and objects.  
  
 The **dllimport** and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> storage-class modifiers must be used with the extended attribute syntax keyword, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, as shown in this example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 For specific information about the syntax for extended storage-class modifiers, see [Extended Storage-Class Attributes](../vs140/c-extended-storage-class-attributes.md).  
  
 **END Microsoft Specific**  
  
## See Also  
 [C Function Definitions](../vs140/c-function-definitions.md)