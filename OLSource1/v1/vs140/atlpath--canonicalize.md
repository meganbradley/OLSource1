---
title: "ATLPath::Canonicalize"
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
  - "ATL.ATLPath.Canonicalize"
  - "ATLPath.Canonicalize"
  - "Canonicalize"
  - "ATLPath::Canonicalize"
  - "ATL::ATLPath::Canonicalize"
  - "ATLPATH/Canonicalize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Canonicalize function"
ms.assetid: e3bf7785-f1d9-4299-83c0-6ede590e1ae6
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ATLPath::Canonicalize
This function is an overloaded wrapper for [PathCanonicalize](http://msdn.microsoft.com/library/windows/desktop/bb773569).  
  
## Syntax  
  
```  
  
      inline BOOL Canonicalize(  
   char* pszDest,  
   const char* pszSrc   
);  
inline BOOL Canonicalize(  
   wchar_t* pszDest,  
   const wchar_t* pszSrc   
);  
```  
  
## Remarks  
 See [PathCanonicalize](http://msdn.microsoft.com/library/windows/desktop/bb773569) for details.  
  
## Requirements  
 **Header:** atlpath.h  
  
## See Also  
 [ATL Concepts](../vs140/active-template-library--atl--concepts.md)   
 [ATL Reference](../vs140/atl-com-desktop-components.md)   
 [ATL Functions Alphabetical Reference](../vs140/atl-functions-alphabetical-reference.md)   
 [PathCanonicalize](http://msdn.microsoft.com/library/windows/desktop/bb773569)