---
title: "ws"
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
  - "std.ws"
  - "istream/std::ws"
  - "ws"
  - "std::ws"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ws"
  - "ws function"
ms.assetid: b8948f8a-f516-4db4-b24a-28a066a93c15
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# ws
Skips white space in the stream.  
  
## Syntax  
  
```  
  
      template class<Elem, Tr>  
   basic_istream<Elem, Tr>& ws(  
   basic_istream<Elem, Tr>& _Istr  
);  
```  
  
#### Parameters  
 `_Istr`  
 A stream.  
  
## Return Value  
 The stream.  
  
## Remarks  
 The manipulator extracts and discards any elements `ch` for which [use_facet](../vs140/basic_filebuf--open.md)< **ctype**<**Elem**> >([getloc](../vs140/ios_base--getloc.md)). **is**(**ctype**<**Elem**>::**space**, **ch**) is true.  
  
 The function calls [setstate](../vs140/basic_ios--setstate.md)(**eofbit**) if it encounters end of file while extracting elements. It returns `_Istr`.  
  
## Example  
 See [operator>>](../vs140/operator-----istream--.md) for an example of using `ws`.  
  
## Requirements  
 **Header:** \<istream>  
  
 **Namespace:** std  
  
## See Also  
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)