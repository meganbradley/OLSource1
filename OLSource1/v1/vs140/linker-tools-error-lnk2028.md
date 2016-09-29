---
title: "Linker Tools Error LNK2028"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "LNK2028"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LNK2028"
ms.assetid: e2b03293-6066-464d-a050-ce747bcf7f0e
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Linker Tools Error LNK2028
"exported_function" (decorated_name) referenced in function "function_containing_function_call" (decorated_name)  
  
 When attempting to import a native function into a pure image, remember that the implicit calling conventions differ between native and pure compilations.  
  
## Example  
 This code sample generates a component with an exported, native, function whose calling convention is implicitly [__cdecl](../vs140/__cdecl.md).  
  
```  
// LNK2028.cpp  
// compile with: /LD  
__declspec(dllexport) int func() {  
   return 3;  
}  
```  
  
## Example  
 The following sample creates a pure client that consumes the native function. However, the calling convention under **/clr:pure** is [__clrcall](../vs140/__clrcall.md). The following sample generates LNK2028.  
  
```  
// LNK2028_b.cpp  
// compile with: /clr:pure lnk2028.lib  
// LNK2028 expected  
int func();  
  
int main() {  
   return func();  
}  
```