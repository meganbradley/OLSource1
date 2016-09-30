---
title: "General Rules and Limitations"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
dev_langs: 
  - "C++"
ms.assetid: 6c48902d-4259-4761-95d4-e421d69aa050
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# General Rules and Limitations
## Microsoft Specific  
  
-   If you declare a function or object without the **dllimport** or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> attribute, the function or object is not considered part of the DLL interface. Therefore, the definition of the function or object must be present in that module or in another module of the same program. To make the function or object part of the DLL interface, you must declare the definition of the function or object in the other module as <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. Otherwise, a linker error is generated.  
  
     If you declare a function or object with the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> attribute, its definition must appear in some module of the same program. Otherwise, a linker error is generated.  
  
-   If a single module in your program contains both **dllimport** and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> declarations for the same function or object, the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> attribute takes precedence over the **dllimport** attribute. However, a compiler warning is generated. For example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
-   In C++, you can initialize a globally declared or static local data pointer or with the address of a data object declared with the **dllimport** attribute, which generates an error in C. In addition, you can initialize a static local function pointer with the address of a function declared with the **dllimport** attribute. In C, such an assignment sets the pointer to the address of the DLL import thunk (a code stub that transfers control to the function) rather than the address of the function. In C++, it sets the pointer to the address of the function. For example:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
     However, because a program that includes the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> attribute in the declaration of an object must provide the definition for that object somewhere in the program, you can initialize a global or local static function pointer with the address of a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> function. Similarly, you can initialize a global or local static data pointer with the address of a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> data object. For example, the following code does not generate errors in C or C++:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
-   Because of a change in behavior introduce in Visual C++ .NET to make the application of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> more consistent between regular classes and specializations of class templates, if you apply <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> to a regular class that has a base class that is not marked as <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, the compiler will generate C4275.  
  
     The compiler generates the same warning if the base class is a specialization of a class template. To work around this, mark the base-class with <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. The problem with a specialization of a class template is where to place the **__declspec(dllexport)**; you are not allowed to mark the class template. Instead, explicitly instantiate the class template and mark this explicit instantiation with <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>. For example:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
     This workaround fails if the template argument is the deriving class. For example:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
     Because this is common pattern with templates, the compiler changed the semantics of <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> when it is applied to a class that has one or more base-classes and when one or more of the base classes is a specialization of a class template. In this case, the compiler implicitly applies <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> to the specializations of class templates. In Visual C++ .NET, a user can do the following and not get a warning:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
## END Microsoft Specific  
  
## See Also  
 [dllexport, dllimport](../vs140/dllexport--dllimport.md)