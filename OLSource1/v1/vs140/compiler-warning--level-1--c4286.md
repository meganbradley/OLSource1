---
title: "Compiler Warning (level 1) C4286"
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
  - "C4286"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4286"
ms.assetid: 93eadd6c-6f36-413b-ba91-c9aa2314685a
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4286
'type1' : is caught by base class ('type2') on line number  
  
 The specified exception type is handled by a previous handler. The type for the second catch is derived from the type of the first. Exceptions for a base class catch exceptions for a derived class.  
  
## Example  
  
```  
//C4286.cpp  
// compile with: /W1  
#include <eh.h>  
class C {};  
class D : public  C {};  
int main()  
{  
    try  
    {  
        throw "ooops!";  
    }  
    catch( C ) {}  
    catch( D ) {}  // warning C4286, D is derived from C  
}  
```