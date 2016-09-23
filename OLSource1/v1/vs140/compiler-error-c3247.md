---
title: "Compiler Error C3247"
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
  - C3247
dev_langs: 
  - C++
helpviewer_keywords: 
  - C3247
ms.assetid: f9a2bbb5-3fce-40bf-9fd3-835a5f164dbb
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error C3247
'class1' : a coclass cannot inherit from another coclass 'class2'  
  
 A class marked with the [coclass](../vs140/coclass.md) attribute cannot inherit from another class marked with the `coclass` attribute.  
  
 The following sample generates C3247:  
  
```  
// C3247.cpp  
[module(name="MyLib")];  
[coclass]  
class a {  
};  
  
[coclass]  
class b : public a {   // C3247  
};  
int main() {  
}  
```