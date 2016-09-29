---
title: "Compiler Warning (level 4) C4324"
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
  - "C4324"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4324"
ms.assetid: 420fa929-d9c0-40b4-8808-2d8ad3ca8090
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 4) C4324
'struct_name' : structure was padded due to __declspec(align())  
  
 Padding was added at the end of a structure because you specified a [__declspec(align)](../vs140/align--c---.md) value.  
  
 For example, the following code generates C4324:  
  
```  
// C4324.cpp  
// compile with: /W4  
struct __declspec(align(32)) A  
{  
   char a;  
};   // C4324  
  
int main()  
{  
}  
```