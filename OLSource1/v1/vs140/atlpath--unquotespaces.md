---
title: "ATLPath::UnquoteSpaces"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - ATLPath.UnquoteSpaces
  - ATLPATH/UnquoteSpaces
  - UnquoteSpaces
  - ATLPath::UnquoteSpaces
  - ATL::ATLPath::UnquoteSpaces
  - ATL.ATLPath.UnquoteSpaces
dev_langs: 
  - C++
helpviewer_keywords: 
  - UnquoteSpaces function
ms.assetid: 8c8b8bc6-4eaf-40f0-990b-4a9a7c610dd1
caps.latest.revision: 16
translation.priority.ht: 
  - de-de
  - ja-jp
---
# ATLPath::UnquoteSpaces
This function is an overloaded wrapper for [PathUnquoteSpaces](http://msdn.microsoft.com/library/windows/desktop/bb773763).  
  
## Syntax  
  
```  
  
      inline void UnquoteSpaces(  
   char* pszPath   
);  
inline void UnquoteSpaces(  
   wchar_t* pszPath   
);  
```  
  
## Remarks  
 See [PathUnquoteSpaces](http://msdn.microsoft.com/library/windows/desktop/bb773763) for details.  
  
## Requirements  
 **Header:** atlpath.h  
  
## See Also  
 [ATL Concepts](../vs140/active-template-library--atl--concepts.md)   
 [ATL Reference](../vs140/atl-com-desktop-components.md)   
 [ATL Functions Alphabetical Reference](../vs140/atl-functions-alphabetical-reference.md)   
 [PathUnquoteSpaces](http://msdn.microsoft.com/library/windows/desktop/bb773763)