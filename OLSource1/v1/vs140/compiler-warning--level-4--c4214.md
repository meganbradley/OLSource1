---
title: "Compiler Warning (level 4) C4214"
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
  - C4214
dev_langs: 
  - C++
helpviewer_keywords: 
  - C4214
ms.assetid: 9b8db279-1f12-4a6b-a923-2db22acd1947
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Warning (level 4) C4214
nonstandard extension used : bit field types other than int  
  
 With the default Microsoft extensions (/Ze), bitfield structure members can be of any integer type.  
  
## Example  
  
```  
// C4214.c  
// compile with: /W4  
struct bitfields  
{  
   unsigned short j:4;  // C4214  
};  
  
int main()  
{  
}  
```  
  
 Such bit fields are invalid under ANSI compatibility ([/Za](../vs140/-za---ze--disable-language-extensions-.md)).