---
title: "Compiler Error C2605"
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
  - "C2605"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2605"
ms.assetid: a0e6f132-5acf-4e19-b277-ddf196d182bf
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2605
'name' : this method is reserved within a managed or WinRT class  
  
 Certain names are reserved by the compiler for internal functions.  For more information, see [Destructors and Finalizers](../vs140/how-to--define-and-consume-classes-and-structs--c---cli-.md#BKMK_Destructors_and_finalizers).  
  
## Example  
 The following sample generates C2605.  
  
```  
// C2605.cpp  
// compile with: /clr /c  
ref class R {  
protected:  
   void Finalize() {}   // C2605  
};  
```