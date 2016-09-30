---
title: "Platform, default, and cli Namespaces  (C++ Component Extensions)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "lang"
  - "cli"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "lang namespace"
  - "cli namespace"
ms.assetid: 9d38bd1e-dc78-47d1-a84b-9b4683e52c9c
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Platform, default, and cli Namespaces  (C++ Component Extensions)
A namespace qualifies the names of language elements so the names do not conflict with otherwise identical names elsewhere in the source code. For example, a name collision might prevent the compiler from recognizing [Context-Sensitive Keywords](../vs140/context-sensitive-keywords---c---component-extensions-.md). Namespaces are used by the compiler but are not preserved in the compiled assembly.  
  
## All Runtimes  
 Visual C++ provides a default namespace for your project when you create the project. You can manually rename the namespace, although in [!INCLUDE[wrt](../vs140/includes/wrt_md.md)] the name of the .winmd file must match the name of the root namespace.  
  
## [!INCLUDE[wrt](../vs140/includes/wrt_md.md)]  
 For more information, see [Namespaces and type visibility (C++/CX)](http://msdn.microsoft.com/library/windows/apps/hh969551.aspx).  
  
### Requirements  
 Compiler option: **/ZW**  
  
## [!INCLUDE[clr_for_headings](../vs140/includes/clr_for_headings_md.md)]  
 **Syntax**  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **Remarks**  
  
 The [!INCLUDE[cppcli](../vs140/includes/cppcli_md.md)] supports the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> namespace. When compiling with **/clr**, the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> statement in the Syntax section is implied.  
  
 The following language features are in the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> namespace:  
  
-   [array](../vs140/arrays--c---component-extensions-.md)  
  
-   [interior_ptr](../vs140/interior_ptr--c---cli-.md)  
  
-   [pin_ptr](../vs140/pin_ptr--c---cli-.md)  
  
-   [safe_cast](../vs140/safe_cast--c---component-extensions-.md)  
  
### Requirements  
 Compiler option: **/clr**  
  
### Examples  
 **Example**  
  
 The following code example demonstrates that it is possible to use a symbol in the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> namespace as a user-defined symbol in your code.  However, once you have done so, you will have to explicitly or implicitly qualify your references to the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> language element of the same name.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Language Extensions for Runtime Platforms](../vs140/component-extensions-for-runtime-platforms.md)