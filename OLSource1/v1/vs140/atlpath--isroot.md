---
title: "ATLPath::IsRoot"
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
  - ATLPATH/IsRoot
  - ATLPath.IsRoot
  - ATLPath::IsRoot
  - IsRoot
  - ATL.ATLPath.IsRoot
  - ATL::ATLPath::IsRoot
dev_langs: 
  - C++
helpviewer_keywords: 
  - IsRoot function
ms.assetid: b7346e99-3eac-4e2e-9f84-ddb6c45d0ed6
caps.latest.revision: 16
translation.priority.ht: 
  - de-de
  - ja-jp
---
# ATLPath::IsRoot
This function is an overloaded wrapper for [PathIsRoot](http://msdn.microsoft.com/library/windows/desktop/bb773674).  
  
## Syntax  
  
```  
  
      inline BOOL IsRoot(  
   const char* pszPath   
);  
inline BOOL IsRoot(  
   const wchar_t* pszPath   
);  
```  
  
## Remarks  
 See [PathIsRoot](http://msdn.microsoft.com/library/windows/desktop/bb773674) for details.  
  
## Requirements  
 **Header:** atlpath.h  
  
## See Also  
 [ATL Concepts](../vs140/active-template-library--atl--concepts.md)   
 [ATL Reference](../vs140/atl-com-desktop-components.md)   
 [ATL Functions Alphabetical Reference](../vs140/atl-functions-alphabetical-reference.md)   
 [PathIsRoot](http://msdn.microsoft.com/library/windows/desktop/bb773674)