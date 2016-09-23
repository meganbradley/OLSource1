---
title: "Compiler Error C3730"
ms.custom: na
ms.date: 09/21/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: error-reference
f1_keywords: 
  - C3730
dev_langs: 
  - C++
helpviewer_keywords: 
  - C3730
ms.assetid: 25b9b93d-179c-4ed8-9dbe-a0bda995db00
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error C3730
'event': an event must have both an add and a remove method  
  
 When creating user-defined add and remove methods for an event, both add and remove need to be present.  
  
 C3730 is only reachable using **/clr:oldSyntax**.  
  
 The following sample generates C3730:  
  
```  
// C3730.cpp  
// compile with: /clr:oldSyntax  
#using <mscorlib.dll>  
using namespace System;  
  
public __delegate void MyDel();  
  
__gc class EventSource  
{  
public:  
   MyDel *pE;  
  
   __event void add_E(MyDel* p)   // C3730, uncomment remove_E to resolve  
   {  
      pE = static_cast<MyDel*> (Delegate::Combine(pE, p));  
   }  
/*  
   __event void remove_E(MyDel* p)  
   {  
      pE = static_cast<MyDel*> (Delegate::Remove(pE, p));  
   }  
*/  
   __event void raise_E()  
   {  
      if (pE != 0)  pE->Invoke();  
   }  
};  
  
int main()  
{  
}  
```