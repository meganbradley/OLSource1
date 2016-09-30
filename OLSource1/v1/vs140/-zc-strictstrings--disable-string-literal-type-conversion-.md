---
title: "-Zc:strictStrings (Disable string literal type conversion)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/Zc:strictStrings (Disable string literal type conversion)"
f1_keywords: 
  - "/Zc:strictStrings"
  - "strictStrings"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "/Zc:strictStrings"
  - "-Zc compiler options (C++)"
  - "strictStrings"
  - "/Zc compiler options (C++)"
  - "Zc compiler options (C++)"
ms.assetid: b7eb3f3b-82c1-48a2-8e63-66bad7397b46
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -Zc:strictStrings (Disable string literal type conversion)
When specified, the compiler requires strict <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>-qualification conformance for pointers initialized by using string literals.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 If **/Zc:strictStrings** is specified, the compiler enforces the standard C++ <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> qualifications for string literals, as type 'array of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>' or 'array of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>', depending on the declaration. String literals are immutable, and an attempt to modify the contents of one results in an access violation error at run time. You must declare a string pointer as <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to initialize it by using a string literal, or use an explicit <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to initialize a non-<CodeContentPlaceHolder>9\</CodeContentPlaceHolder> pointer. By default, or if **/Zc:strictStrings-** is specified, the compiler does not enforce the standard C++ <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> qualifications for string pointers initialized by using string literals.  
  
 Use the **/Zc:strictStrings** option to prevent compilation of incorrect code. This example shows how a simple declaration error leads to a crash at run time:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 When **/Zc:strictStrings** is enabled, the same code reports an error in the declaration of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 If you use <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to declare a string pointer, the compiler creates the correct <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> pointer type declaration for you. An attempt to modify the contents of a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> pointer is reported by the compiler as an error.  
  
> [!NOTE]
>  The Standard C++ Library in [!INCLUDE[cpp_dev12_long](../vs140/includes/cpp_dev12_long_md.md)] does not support the **/Zc:strictStrings** compiler option in debug builds. If you see several [C2665](../vs140/compiler-error-c2665.md) errors in your build output, this may be the cause.  
  
 For more information about conformance issues in Visual C++, see [Nonstandard Behavior](../vs140/nonstandard-behavior.md).  
  
### To set this compiler option in the Visual Studio development environment  
  
1.  Open the project's **Property Pages** dialog box. For details, see [Working with Project Properties](../vs140/working-with-project-properties.md).  
  
2.  Select the **C/C++** folder.  
  
3.  Select the **Command Line** property page.  
  
4.  Modify the **Additional Options** property to include <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and then choose **OK**.  
  
## See Also  
 [/Zc (Conformance)](../vs140/-zc--conformance-.md)