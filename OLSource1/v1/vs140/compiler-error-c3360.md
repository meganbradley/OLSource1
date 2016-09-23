---
title: "Compiler Error C3360"
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
  - C3360
dev_langs: 
  - C++
helpviewer_keywords: 
  - C3360
ms.assetid: 6acf983a-dbb6-422b-b045-a34bb4ba6761
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error C3360
'string': cannot create name  
  
 The value that was passed to the [uuid](../vs140/uuid--c---attributes-.md) attribute was not valid.  
  
 The following sample generates C3360:  
  
```  
// C3360.cpp  
[ uuid("1") ]  
// try this line instead  
// [ uuid("12341234-1234-1234-1234-123412341234") ]  
struct A   // C3360  
{  
};  
  
int main()  
{  
}  
```