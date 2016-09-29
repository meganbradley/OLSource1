---
title: "Compiler Error C3340"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "C3340"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3340"
ms.assetid: 23b12298-b92a-4717-8380-f165c998cb8a
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3340
'interface': interface cannot be both 'restricted' and 'default' in coclass 'class'  
  
 The [restricted](../vs140/restricted.md) attribute and the [default](../vs140/default--c---.md) attribute are mutually exclusive.  
  
 The following sample generates C3340:  
  
```  
// C3340.cpp  
#include <windows.h>  
[module(name="MyModule")];  
  
[ object, uuid(373a1a4c-469b-11d3-a6b0-00c04f79ae8f) ]  
__interface IMyIface  
{  
   HRESULT f1();  
};  
  
[ coclass, uuid(373a1a4d-469b-11d3-a6b0-00c04f79ae8f),  
default(IMyIface),  
source(IMyIface),restricted(IMyIface) ]  
class CmyClass // C3340  
{  
};  
  
int main()  
{  
}  
```