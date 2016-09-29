---
title: "Compiler Warning (level 2) C4285"
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
  - "C4285"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4285"
ms.assetid: fa14de1f-fc19-4eec-8bea-81003636e12f
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 2) C4285
return type for 'identifier::operator –>' is recursive if applied using infix notation  
  
 The specified **operator–>()** function cannot return the type for which it is defined or a reference to the type for which it is defined.  
  
 The following sample generates C4285:  
  
```  
// C4285.cpp  
// compile with: /W2  
class C  
{  
public:  
    C operator->();   // C4285  
   // C& operator->();  C4285, also  
};  
  
int main()  
{  
}  
```