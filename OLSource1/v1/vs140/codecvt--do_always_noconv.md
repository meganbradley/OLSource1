---
title: "codecvt::do_always_noconv"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "std.codecvt.do_always_noconv"
  - "codecvt.do_always_noconv"
  - "xlocale/std::codecvt::do_always_noconv"
  - "codecvt::do_always_noconv"
  - "do_always_noconv"
  - "std::codecvt::do_always_noconv"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "do_always_noconv method"
ms.assetid: 936f48d2-ea39-4e03-9082-de5ee63356f6
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# codecvt::do_always_noconv
A virtual function called to test whether no conversions need be done.  
  
## Syntax  
  
```  
virtual bool do_always_noconv( ) const throw( );  
```  
  
## Return Value  
 The protected virtual member function returns **true** only if every call to [do_in](../vs140/codecvt--do_in.md) or [do_out](../vs140/codecvt--do_out.md) returns **noconv**.  
  
 The template version always returns **true**.  
  
## Example  
 See the example for [always_noconv](../vs140/codecvt--always_noconv.md), which calls `do_always_noconv`.  
  
## Requirements  
 **Header:** <locale\>  
  
 **Namespace:** std  
  
## See Also  
 [codecvt Class](../vs140/codecvt-class.md)