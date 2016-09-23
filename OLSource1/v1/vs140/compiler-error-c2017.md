---
title: "Compiler Error C2017"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: error-reference
f1_keywords: 
  - C2017
dev_langs: 
  - C++
helpviewer_keywords: 
  - C2017
ms.assetid: 1083eed9-9906-4a97-883c-54e52d7e82cd
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error C2017
illegal escape sequence  
  
 An escape sequence, such as \t, appears outside of a character or string constant.  
  
 The following sample generates C2017:  
  
```  
// C2017.cpp  
int main() {  
   char test1='a'\n;   // C2017  
   char test2='a\n';   // ok  
}  
```  
  
 C2017 can occur when the stringize operator is used with strings that include escape sequences.  
  
 The following sample generates C2017:  
  
```  
// C2017b.cpp  
#define TestDfn(x) AfxMessageBox(#x)  
TestDfn(CString("\\") + CString(".h\"\n\n"));   // C2017  
```