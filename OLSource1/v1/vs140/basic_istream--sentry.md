---
title: "basic_istream::sentry"
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
  - "istream/std::basic_istream::sentry"
  - "basic_istream.sentry"
  - "std.basic_istream.sentry"
  - "std::basic_istream::sentry"
  - "sentry"
  - "basic_istream::sentry"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "sentry method"
ms.assetid: 762cdb42-4365-470f-8db8-4524eca40ba7
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_istream::sentry
The nested class describes an object whose declaration structures the formatted and unformatted input functions.  
  
## Syntax  
  
```  
class sentry {  
public:  
    explicit sentry(  
        basic_istream<Elem, Tr>& _Istr,  
        bool _Noskip = false  
    );  
    operator bool( ) const;  
};  
```  
  
## Remarks  
 If `_Istr``.`[good](../vs140/basic_ios--good.md) is true, the constructor:  
  
-   Calls `_Istr`.[tie](../vs140/basic_ios--tie.md) -> [flush](../vs140/basic_ostream--flush.md) if `_Istr`.`tie` is not a null pointer  
  
-   Effectively calls [ws](../vs140/ws.md)(`_Istr`) if `_Istr`.[flags](../vs140/ios_base--flags.md) **&** [skipws](../vs140/skipws.md) is nonzero  
  
 If, after any such preparation, `_Istr`.**good** is false, the constructor calls `_Istr`.[setstate](../vs140/basic_ios--setstate.md)(**failbit**). In any case, the constructor stores the value returned by `_Istr`.**good** in **status**. A later call to **operator bool** delivers this stored value.  
  
## Requirements  
 **Header:** \<istream>  
  
 **Namespace:** std  
  
## See Also  
 [basic_istream Class](../vs140/basic_istream-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)