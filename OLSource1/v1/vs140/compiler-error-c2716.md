---
title: "Compiler Error C2716"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "C2716"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2716"
ms.assetid: 6a99a5ae-3a16-47bd-9f24-1e5c939fa304
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2716
'operator new' allocates value types on the C++ heap; use '__nogc new type'  
  
 The syntax of an object instantiation was incorrect.  
  
 C2716 is only reachable using **/clr:oldSyntax**.  
  
 The following sample generates C2716:  
  
```  
// C2716.cpp  
// compile with: /clr:oldSyntax  
#using <mscorlib.dll>  
__value struct V {};  
  
int main() {  
   V *pV = new V;   // C2716  
   V *pV1 = __nogc new V;   // OK  
}  
```