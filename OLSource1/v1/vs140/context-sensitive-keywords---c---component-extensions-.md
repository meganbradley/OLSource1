---
title: "Context-Sensitive Keywords  (C++ Component Extensions)"
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
  - "internal_CPP"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "context-sensitive keywords"
ms.assetid: e33da089-f434-44e9-8cce-4668d05a8939
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Context-Sensitive Keywords  (C++ Component Extensions)
*Context-sensitive keywords* are language elements that are recognized only in specific contexts. Outside the specific context, a context-sensitive keyword can be a user-defined symbol.  
  
## All Runtimes  
 **Remarks**  
  
 The following is a list of context-sensitive keywords:  
  
-   [abstract](../vs140/abstract---c---component-extensions-.md)  
  
-   [delegate](../vs140/delegate---c---component-extensions-.md)  
  
-   [event](../vs140/event---c---component-extensions-.md)  
  
-   [finally](../vs140/finally.md)  
  
-   [for each, in](../vs140/for-each--in.md)  
  
-   [initonly](../vs140/initonly--c---cli-.md)  
  
-   <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> (see [Member Visibility](../vs140/member-visibility.md))  
  
-   [literal](../vs140/literal--c---component-extensions-.md)  
  
-   [override](../vs140/override---c---component-extensions-.md)  
  
-   [property](../vs140/property---c---component-extensions-.md)  
  
-   [sealed](../vs140/sealed---c---component-extensions-.md)  
  
-   <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> (part of [generics](../vs140/generics---c---component-extensions-.md))  
  
 For readability purposes, you may want to limit your use of context-sensitive keywords as user–defined symbols.  
  
## [!INCLUDE[wrt](../vs140/includes/wrt_md.md)]  
 **Remarks**  
  
 (There are no platform-specific remarks for this feature.)  
  
### Requirements  
 Compiler option: **/ZW**  
  
## [!INCLUDE[clr_for_headings](../vs140/includes/clr_for_headings_md.md)]  
 **Remarks**  
  
 (There are no platform-specific remarks for this feature.)  
  
### Requirements  
 Compiler option: **/clr**  
  
### Examples  
 **Example**  
  
 The following code example shows that in the appropriate context, the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> context-sensitive keyword can be used to define a property and a variable.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **Output**  
  
 **100**   
## See Also  
 [Language Extensions for Runtime Platforms](../vs140/component-extensions-for-runtime-platforms.md)