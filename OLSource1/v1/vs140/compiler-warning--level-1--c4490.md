---
title: "Compiler Warning (level 1) C4490"
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
  - "C4490"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4490"
ms.assetid: f9b03ecf-41a1-4f4d-a74c-2c1e88234ccc
caps.latest.revision: 7
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4490
'override' : incorrect use of override specifier; 'function' does not match a base ref class method  
  
 An override specifier was used incorrectly. For example, you do not override an interface function, you implement it.  
  
 For more information, see [Override Specifiers](../vs140/override-specifiers---c---component-extensions-.md).  
  
## Example  
 The following sample generates C4490.  
  
```  
// C4490.cpp  
// compile with: /clr /c /W1  
  
interface struct IFace {  
   void Test();  
};  
  
ref struct Class1 : public IFace {  
   virtual void Test() override {}   // C4490  
   // try the following line instead  
   // virtual void Test() {}  
};  
```