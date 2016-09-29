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
  
-   [abstract](../VS_csharp/abstract---c---component-extensions-.md)  
  
-   [delegate](../VS_csharp/delegate---c---component-extensions-.md)  
  
-   [event](../VS_csharp/event---c---component-extensions-.md)  
  
-   [finally](../VS_csharp/finally.md)  
  
-   [for each, in](../VS_csharp/for-each--in.md)  
  
-   [initonly](../VS_csharp/initonly--c---cli-.md)  
  
-   `internal` (see [Member Visibility](../Topic/Member%20Visibility.md))  
  
-   [literal](../VS_csharp/literal--c---component-extensions-.md)  
  
-   [override](../VS_csharp/override---c---component-extensions-.md)  
  
-   [property](../VS_csharp/property---c---component-extensions-.md)  
  
-   [sealed](../VS_csharp/sealed---c---component-extensions-.md)  
  
-   `where` (part of [generics](../VS_csharp/generics---c---component-extensions-.md))  
  
 For readability purposes, you may want to limit your use of context-sensitive keywords as user–defined symbols.  
  
## [!INCLUDE[wrt](../VS_csharp/includes/wrt_md.md)]  
 **Remarks**  
  
 (There are no platform-specific remarks for this feature.)  
  
### Requirements  
 Compiler option: **/ZW**  
  
## [!INCLUDE[clr_for_headings](../VS_csharp/includes/clr_for_headings_md.md)]  
 **Remarks**  
  
 (There are no platform-specific remarks for this feature.)  
  
### Requirements  
 Compiler option: **/clr**  
  
### Examples  
 **Example**  
  
 The following code example shows that in the appropriate context, the `property` context-sensitive keyword can be used to define a property and a variable.  
  
```  
// context_sensitive_keywords.cpp  
// compile with: /clr  
public ref class C {  
   int MyInt;  
public:  
   C() : MyInt(99) {}  
  
   property int Property_Block {   // context-sensitive keyword  
      int get() { return MyInt; }  
   }  
};  
  
int main() {  
   int property = 0;               // variable name  
   C ^ MyC = gcnew C();  
   property = MyC->Property_Block;  
   System::Console::WriteLine(++property);  
}  
```  
  
 **Output**  
  
 **100**   
## See Also  
 [Language Extensions for Runtime Platforms](../VS_csharp/component-extensions-for-runtime-platforms.md)