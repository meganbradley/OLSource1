---
title: "Compiler Error C3110"
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
  - C3110
dev_langs: 
  - C++
helpviewer_keywords: 
  - C3110
ms.assetid: 821dc71f-896e-4b2d-af0e-aa9932934b7b
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error C3110
'function_name' : you cannot overload a COM interface method  
  
 An interface that is prefaced by an interface attribute, such as:  
  
-   [custom](../vs140/custom--c---.md)  
  
-   [dispinterface](../vs140/dispinterface.md)  
  
-   [dual](../vs140/dual.md)  
  
-   [object](../vs140/object--c---.md)  
  
 cannot be overloaded. For example:  
  
```  
// C3110.cpp  
#include <unknwn.h>  
[ object, uuid= "4F98A180-EF37-11D1-978D-0000F805D73B" ]  
__interface ITestInterface  
{  
   HRESULT mf1(void);  
   HRESULT mf1(BSTR); // C3110  
};  
  
int main()  
{  
}  
```