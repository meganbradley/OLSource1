---
title: "deprecated (C++)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: language-reference
f1_keywords: 
  - deprecated
  - deprecated_cpp
dev_langs: 
  - C++
helpviewer_keywords: 
  - __declspec keyword [C++], deprecated
  - deprecated __declspec keyword
ms.assetid: beef1129-9434-4cb3-8392-f1eb29e04805
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# deprecated (C++)
(Microsoft specific) With the exceptions noted below, the **deprecated** declaration offers the same functionality as the [deprecated](../vs140/deprecated--c-c---.md) pragma:  
  
-   The **deprecated** declaration lets you specify particular forms of function overloads as deprecated, whereas the pragma form applies to all overloaded forms of a function name.  
  
-   The **deprecated** declaration lets you specify a message that will display at compile time. The text of the message can be from a macro.  
  
-   Macros can only be marked as deprecated with the **deprecated** pragma.  
  
 If the compiler encounters the use of a deprecated identifier, a [C4996](../vs140/compiler-warning--level-3--c4996.md) warning is thrown.  
  
## Example  
 The following sample shows how to mark functions as deprecated, and how to specify a message that will be displayed at compile time, when the deprecated function is used.  
  
```  
// deprecated.cpp  
// compile with: /W3  
#define MY_TEXT "function is deprecated"  
void func1(void) {}  
__declspec(deprecated) void func1(int) {}  
__declspec(deprecated("** this is a deprecated function **")) void func2(int) {}  
__declspec(deprecated(MY_TEXT)) void func3(int) {}  
  
int main() {  
   func1();  
   func1(1);   // C4996  
   func2(1);   // C4996  
   func3(1);   // C4996  
}  
```  
  
## Example  
 The following sample shows how to mark classes as deprecated, and how to specify a message that will be displayed at compile time, when the deprecated class is used.  
  
```  
// deprecate_class.cpp  
// compile with: /W3  
struct __declspec(deprecated) X {  
   void f(){}  
};  
  
struct __declspec(deprecated("** X2 is deprecated **")) X2 {  
   void f(){}  
};  
  
int main() {  
   X x;   // C4996  
   X2 x2;   // C4996  
}  
```  
  
## See Also  
 [__declspec](../vs140/__declspec.md)   
 [Keywords](../vs140/keywords--c---.md)