---
title: "Compiler Warning (levels 1 and 4) C4112"
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
  - C4112
dev_langs: 
  - C++
helpviewer_keywords: 
  - C4112
ms.assetid: aff64897-bb79-4a67-9b6f-902c6d44f3dc
caps.latest.revision: 14
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Warning (levels 1 and 4) C4112
\#line requires an integer between 1 and number  
  
 The [#line](../vs140/sharpline-directive--c-c---.md) directive specifies an integer parameter that is outside the allowable range.  
  
 If the specified parameter is less than 1, the line counter is reset to 1. If the specified parameter is greater than *number*, which is the compiler-defined limit, the line counter is unchanged. This is a level 1 warning under ANSI compatibility ([/Za](../vs140/-za---ze--disable-language-extensions-.md)) and a level 4 warning with Microsoft extensions ([/Ze](../vs140/-za---ze--disable-language-extensions-.md)).  
  
 The following sample generates C4112:  
  
```  
// C4112.cpp  
// compile with: /W4  
#line 0   // C4112, value must be between 1 and number  
  
int main() {  
}  
```