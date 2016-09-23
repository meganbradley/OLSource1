---
title: "Compiler Warning (level 3) C4637"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - C4637
dev_langs: 
  - C++
helpviewer_keywords: 
  - C4637
ms.assetid: 5fd347c1-2de9-408f-9136-1bf1ff273622
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Warning (level 3) C4637
XML document comment target: <include\> tag discarded.  reason  
  
 The syntax of an [<include\>](../vs140/-include---visual-c---.md) tag was not correct.  
  
 The following sample generates C4637:  
  
```  
// C4637.cpp  
// compile with: /clr /doc /LD /W3  
using namespace System;  
  
/// Text for class MyClass.  
public ref class MyClass {   
public:  
   /// <include file="c:\davedata\jtest\xml_include.doc"/>  
   // Try the following line instead:  
   // /// <include file='xml_include.doc' path='MyDocs/MyMembers/*' />  
   void MyMethod() {  
   }  
};   // C4637  
```