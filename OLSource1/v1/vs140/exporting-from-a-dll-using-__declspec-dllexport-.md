---
title: "Exporting from a DLL Using __declspec(dllexport)"
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
  - "dllexport"
  - "__declspec"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "__declspec(dllexport) keyword [C++]"
  - "names [C++], DLL exports by"
  - "export directives [C++]"
  - "exporting DLLs [C++], __declspec(dllexport) keyword"
ms.assetid: a35e25e8-7263-4a04-bad4-00b284458679
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Exporting from a DLL Using __declspec(dllexport)
Microsoft introduced **__export** in the 16-bit compiler version of Visual C++ to allow the compiler to generate the export names automatically and place them in a .lib file. This .lib file can then be used just like a static .lib to link with a DLL.  
  
 In newer compiler versions, you can export data, functions, classes, or class member functions from a DLL using the **__declspec(dllexport)** keyword. **__declspec(dllexport)** adds the export directive to the object file so you do not need to use a .def file.  
  
 This convenience is most apparent when trying to export decorated C++ function names. Because there is no standard specification for name decoration, the name of an exported function might change between compiler versions. If you use **__declspec(dllexport)**, recompiling the DLL and dependent .exe files is necessary only to account for any naming convention changes.  
  
 Many export directives, such as ordinals, NONAME, and PRIVATE, can be made only in a .def file, and there is no way to specify these attributes without a .def file. However, using **__declspec(dllexport)** in addition to using a .def file does not cause build errors.  
  
 To export functions, the **__declspec(dllexport)** keyword must appear to the left of the calling-convention keyword, if a keyword is specified. For example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 To export all of the public data members and member functions in a class, the keyword must appear to the left of the class name as follows:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
> [!NOTE]
>  <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> cannot be applied to a function with the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> calling convention.  
  
 When building your DLL, you typically create a header file that contains the function prototypes and/or classes you are exporting and add **__declspec(dllexport)** to the declarations in the header file. To make your code more readable, define a macro for **__declspec(dllexport)** and use the macro with each symbol you are exporting:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **__declspec(dllexport)** stores function names in the DLL's export table. If you want to optimize the table's size, see [Exporting Functions from a DLL by Ordinal Rather Than by Name](../vs140/exporting-functions-from-a-dll-by-ordinal-rather-than-by-name.md).  
  
> [!NOTE]
>  When porting DLL source code from Win16 to Win32, replace each instance of **__export** with **__declspec(dllexport)**.  
  
 As a reference, search through the Win32 Winbase.h header file. It contains examples of **__declspec(dllimport)** usage.  
  
## What do you want to do?  
  
-   [Export from a DLL using .def files](../vs140/exporting-from-a-dll-using-def-files.md)  
  
-   [Export and import using AFX_EXT_CLASS](../vs140/exporting-and-importing-using-afx_ext_class.md)  
  
-   [Export C++ functions for use in C-language executables](../vs140/exporting-c---functions-for-use-in-c-language-executables.md)  
  
-   [Export C functions for use in C or C++-language executables](../vs140/exporting-c-functions-for-use-in-c-or-c---language-executables.md)  
  
-   [Determine which exporting method to use](../vs140/determining-which-exporting-method-to-use.md)  
  
-   [Import into an application using __declspec(dllimport)](../vs140/importing-into-an-application-using-__declspec-dllimport-.md)  
  
-   [Initialize a DLL](../vs140/initializing-a-dll.md)  
  
## What do you want to know more about?  
  
-   [The __declspec keyword](../vs140/__declspec.md)  
  
-   [Importing and exporting inline functions](../vs140/importing-and-exporting-inline-functions.md)  
  
-   [Mutual imports](../vs140/mutual-imports.md)  
  
## See Also  
 [Exporting from a DLL](../vs140/exporting-from-a-dll.md)