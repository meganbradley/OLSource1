---
title: "Compiler Error C3121"
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
  - C3121
dev_langs: 
  - C++
helpviewer_keywords: 
  - C3121
ms.assetid: 1d3c7be4-d42d-4def-8d53-182c0c5cc237
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error C3121
cannot change GUID for class 'class_name'  
  
 You attempted to change the class ID with [__declspec(uuid)](../vs140/uuid--c---.md).  
  
 For example, the following code generates C3121:  
  
```  
// C3121.cpp  
[emitidl];  
[module(name="MyLibrary")];  
  
[coclass, uuid="00000000-0000-0000-0000-111111111111"]  
class __declspec(uuid("00000000-0000-0000-0000-111111111112")) A   // C3121  
{  
};  
int main()  
{  
}  
```