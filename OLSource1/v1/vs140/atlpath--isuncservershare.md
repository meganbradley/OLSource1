---
title: "ATLPath::IsUNCServerShare"
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
  - ATLPATH/IsUNCServerShare
  - IsUNCServerShare
  - ATL::ATLPath::IsUNCServerShare
  - ATLPath::IsUNCServerShare
  - ATL.ATLPath.IsUNCServerShare
  - ATLPath.IsUNCServerShare
dev_langs: 
  - C++
helpviewer_keywords: 
  - IsUNCServerShare function
ms.assetid: 0731ac9b-8d0c-456a-bd6b-396115b30af1
caps.latest.revision: 16
translation.priority.ht: 
  - de-de
  - ja-jp
---
# ATLPath::IsUNCServerShare
This function is an overloaded wrapper for [PathIsUNCServerShare](http://msdn.microsoft.com/library/windows/desktop/bb773723).  
  
## Syntax  
  
```  
  
      inline BOOL IsUNCServerShare(  
   const char* pszPath   
);  
inline BOOL IsUNCServerShare(  
   const wchar_t* pszPath   
);  
```  
  
## Remarks  
 See [PathIsUNCServerShare](http://msdn.microsoft.com/library/windows/desktop/bb773723) for details.  
  
## Requirements  
 **Header:** atlpath.h  
  
## See Also  
 [ATL Concepts](../vs140/active-template-library--atl--concepts.md)   
 [ATL Reference](../vs140/atl-com-desktop-components.md)   
 [ATL Functions Alphabetical Reference](../vs140/atl-functions-alphabetical-reference.md)   
 [PathIsUNCServerShare](http://msdn.microsoft.com/library/windows/desktop/bb773723)