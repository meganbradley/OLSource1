---
title: "ATLPath::IsRelative"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "ATLPath.IsRelative"
  - "ATLPATH/IsRelative"
  - "ATL::ATLPath::IsRelative"
  - "IsRelative"
  - "ATLPath::IsRelative"
  - "ATL.ATLPath.IsRelative"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsRelative function"
ms.assetid: 639b792a-1692-4cc5-8abf-07cf0fe0d46b
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ATLPath::IsRelative
This function is an overloaded wrapper for [PathIsRelative](http://msdn.microsoft.com/library/windows/desktop/bb773660).  
  
## Syntax  
  
```  
  
      inline BOOL IsRelative(  
   const char* pszPath   
);  
inline BOOL IsRelative(  
   const wchar_t* pszPath   
);  
```  
  
## Remarks  
 See [PathIsRelative](http://msdn.microsoft.com/library/windows/desktop/bb773660) for details.  
  
## Requirements  
 **Header:** atlpath.h  
  
## See Also  
 [ATL Concepts](../vs140/active-template-library--atl--concepts.md)   
 [ATL Reference](../vs140/atl-com-desktop-components.md)   
 [ATL Functions Alphabetical Reference](../vs140/atl-functions-alphabetical-reference.md)   
 [PathIsRelative](http://msdn.microsoft.com/library/windows/desktop/bb773660)