---
title: "ATLPath::Combine"
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
  - "ATLPath::Combine"
  - "ATLPath.Combine"
  - "ATL::ATLPath::Combine"
  - "ATL.ATLPath.Combine"
  - "Combine"
  - "ATLPATH/Combine"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Combine function"
ms.assetid: 607beb7e-a8e7-40e2-a8a4-af614ce0843f
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ATLPath::Combine
This function is an overloaded wrapper for [PathCombine](http://msdn.microsoft.com/library/windows/desktop/bb773571).  
  
## Syntax  
  
```  
  
      inline char* Combine(  
   char* pszDest,  
   const char* pszDir,  
   const char* pszFile   
);  
inline wchar_t* Combine(  
   wchar_t* pszDest,  
   const wchar_t* pszDir,  
   const wchar_t* pszFile   
);  
```  
  
## Remarks  
 See [PathCombine](http://msdn.microsoft.com/library/windows/desktop/bb773571) for details.  
  
## Requirements  
 **Header:** atlpath.h  
  
## See Also  
 [ATL Concepts](../vs140/active-template-library--atl--concepts.md)   
 [ATL Reference](../vs140/atl-com-desktop-components.md)   
 [ATL Functions Alphabetical Reference](../vs140/atl-functions-alphabetical-reference.md)   
 [PathCombine](http://msdn.microsoft.com/library/windows/desktop/bb773571)