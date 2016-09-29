---
title: "ATLPath::MatchSpec"
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
  - "ATLPath::MatchSpec"
  - "ATLPATH/MatchSpec"
  - "ATL.ATLPath.MatchSpec"
  - "ATLPath.MatchSpec"
  - "MatchSpec"
  - "ATL::ATLPath::MatchSpec"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MatchSpec function"
ms.assetid: ad435b5b-5267-4718-94fa-88e5211edefd
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ATLPath::MatchSpec
This function is an overloaded wrapper for [PathMatchSpec](http://msdn.microsoft.com/library/windows/desktop/bb773727).  
  
## Syntax  
  
```  
  
      inline BOOL MatchSpec(  
   const char* pszPath,  
   const char* pszSpec   
);  
inline BOOL MatchSpec(  
   const wchar_t* pszPath,  
   const wchar_t* pszSpec   
);  
```  
  
## Remarks  
 See [PathMatchSpec](http://msdn.microsoft.com/library/windows/desktop/bb773727) for details.  
  
## Requirements  
 **Header:** atlpath.h  
  
## See Also  
 [ATL Concepts](../VS_csharp/active-template-library--atl--concepts.md)   
 [ATL Reference](../VS_csharp/atl-com-desktop-components.md)   
 [ATL Functions Alphabetical Reference](../VS_csharp/atl-functions-alphabetical-reference.md)   
 [PathMatchSpec](http://msdn.microsoft.com/library/windows/desktop/bb773727)