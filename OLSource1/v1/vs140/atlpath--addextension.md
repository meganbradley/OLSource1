---
title: "ATLPath::AddExtension"
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
  - "AddExtension"
  - "ATL.ATLPath.AddExtension"
  - "ATLPath::AddExtension"
  - "ATL::ATLPath::AddExtension"
  - "ATLPath.AddExtension"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddExtension function"
ms.assetid: 3bc95212-332f-458e-a841-0792b4805f46
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ATLPath::AddExtension
This function is an overloaded wrapper for [PathAddExtension](http://msdn.microsoft.com/library/windows/desktop/bb773563).  
  
## Syntax  
  
```  
  
      inline BOOL AddExtension(  
   char* pszPath,  
   const char* pszExtension   
);  
inline BOOL AddExtension(  
   wchar_t* pszPath,  
   const wchar_t* pszExtension   
);  
```  
  
## Remarks  
 See [PathAddExtension](http://msdn.microsoft.com/library/windows/desktop/bb773563) for details.  
  
## Requirements  
 **Header:** atlpath.h  
  
## See Also  
 [ATL Concepts](../vs140/active-template-library--atl--concepts.md)   
 [ATL Reference](../vs140/atl-com-desktop-components.md)   
 [ATL Functions Alphabetical Reference](../vs140/atl-functions-alphabetical-reference.md)   
 [PathAddExtension](http://msdn.microsoft.com/library/windows/desktop/bb773563)