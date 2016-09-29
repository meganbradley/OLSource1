---
title: "Compiler Error C3277"
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
  - "C3277"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3277"
ms.assetid: 8ac5f476-e30c-4879-92c6-f03cdbd74045
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3277
cannot define an unmanaged enum 'enum' inside managed 'type'  
  
 An enumeration was defined incorrectly inside a managed type.  
  
 The following sample generates C3277:  
  
```  
// C3277a.cpp  
// compile with: /clr  
ref class A  
{  
   enum E {e1,e2};   // C3277  
   // try the following line instead  
   // enum class E {e1,e2};  
};  
  
int main()  
{  
}  
```  
  
 The following sample generates C3277:  
  
```  
// C3277b.cpp  
// compile with: /clr:oldSyntax  
#using <mscorlib.dll>  
__gc class A  
{  
   enum E {e1,e2};   // C3277  
   // try the following line instead  
   // __value enum E {e1,e2};  
};  
  
int main()  
{  
}  
```