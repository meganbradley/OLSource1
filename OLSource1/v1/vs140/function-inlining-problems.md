---
title: "Function Inlining Problems"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "/Ob1 C++ compiler option"
  - "inline functions, problems"
  - "-Ob1 C++ compiler option"
  - "/Ob2 C++ compiler option"
  - "-Ob2 C++ compiler option"
  - "function inlining problems"
ms.assetid: 65d59943-4b3c-4a43-aeb6-dccbf7686740
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Function Inlining Problems
If you are using function inlining, you must:  
  
-   Have the inline functions implemented in the header file you include.  
  
-   Have inlining turned ON in the header file.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 And then,  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 If you are using the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> compiler directive, make sure you have a value of 2 or greater set. A value of zero will turn off inlining. Also make sure you are using the **/Ob1** or **/Ob2** compiler options.  
  
 Mixing inline and non-inline compile options on different modules can sometimes cause problems. If a C++ library is created with function inlining turned on ([/Ob1](../vs140/-ob--inline-function-expansion-.md) or [/Ob2](../vs140/-ob--inline-function-expansion-.md)) but the corresponding header file describing the functions has inlining turned off (no option), you will get error LNK2001. The functions do not get inlined into the code from the header file, but since they are not in the library file there is no address to resolve the reference.  
  
 Similarly, a project that uses function inlining yet defines the functions in a .cpp file rather than in the header file will also get LNK2019. The header file is included everywhere deemed appropriate, but the functions are only inlined when the .cpp file passes through the compiler; therefore, the linker sees the functions as unresolved externals when used in other modules.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 and then,  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 and then,  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## See Also  
 [Linker Tools Error LNK2019](../vs140/linker-tools-error-lnk2019.md)