---
title: "Compiler Error C3296"
ms.custom: na
ms.date: "09/23/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "C3296"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3296"
ms.assetid: fc4c9dcd-16cf-4eee-a1ac-c43e7c29e443
caps.latest.revision: 9
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3296
'property' : a property with this name already exists  
  
 The compiler encountered more than one property with the same name. Each property in a type must have a unique name.  
  
 For more information, see [property](../vs140/property---c---component-extensions-.md).  
  
## Example  
 The following sample generates C3296.  
  
```  
// C3296.cpp  
// compile with: /clr /c  
using namespace System;  
  
ref class R {  
public:  
   property int MyProp[int] { int get(int); }  
  
   property String^ MyProp[int] { void set(int, String^); }   // C3296  
};  
```