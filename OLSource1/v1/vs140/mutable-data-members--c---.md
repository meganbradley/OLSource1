---
title: "Mutable Data Members (C++)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "mutable_cpp"
  - "mutable"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "mutable keyword [C++]"
ms.assetid: ebe89746-3d36-43a8-8d69-f426af23f551
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Mutable Data Members (C++)
This keyword can only be applied to non-static and non-const data members of a class. If a data member is declared `mutable`, then it is legal to assign a value to this data member from a **const** member function.  
  
## Syntax  
  
```  
  
mutable member-variable-declaration;  
```  
  
## Remarks  
 For example, the following code will compile without error because `m_accessCount` has been declared to be `mutable`, and therefore can be modified by `GetFlag` even though `GetFlag` is a const member function.  
  
```  
// mutable.cpp  
class X  
{  
public:  
   bool GetFlag() const  
   {  
      m_accessCount++;  
      return m_flag;  
   }  
private:  
   bool m_flag;  
   mutable int m_accessCount;  
};  
  
int main()  
{  
}  
```  
  
## See Also  
 [Keywords](../vs140/keywords--c---.md)