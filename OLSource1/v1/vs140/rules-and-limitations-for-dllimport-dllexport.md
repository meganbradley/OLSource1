---
title: "Rules and Limitations for dllimport-dllexport"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "Rules and Limitations for dllimport/dllexport"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "dllexport attribute [C++], limitations and rules"
  - "dllimport attribute [C++], limitations and rules"
  - "dllexport attribute [C++]"
ms.assetid: 274b735f-ab9c-4b07-8d0e-fdb65d664634
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Rules and Limitations for dllimport-dllexport
**Microsoft Specific**  
  
-   If you declare a function without the **dllimport** or <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> attribute, the function is not considered part of the DLL interface. Therefore, the definition of the function must be present in that module or in another module of the same program. To make the function part of the DLL interface, you must declare the definition of the function in the other module as <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. Otherwise, a linker error is generated when the client is built.  
  
-   If a single module in your program contains **dllimport** and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> declarations for the same function, the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> attribute takes precedence over the **dllimport** attribute. However, a compiler warning is generated. For example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
-   You cannot initialize a static data pointer with the address of a data object declared with the **dllimport** attribute. For example, the following code generates errors:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
-   Initializing a static function pointer with the address of a function declared with **dllimport** sets the pointer to the address of the DLL import thunk (a code stub that transfers control to the function) rather than the address of the function. This assignment does not generate an error message:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
-   Because a program that includes the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> attribute in the declaration of an object must provide the definition for that object, you can initialize a global or local static function pointer with the address of a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> function. Similarly, you can initialize a global or local static data pointer with the address of a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> data object. For example:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 **END Microsoft Specific**  
  
## See Also  
 [DLL Import and Export Functions](../vs140/dll-import-and-export-functions.md)