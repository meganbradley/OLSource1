---
title: "ATLPath::IsSameRoot"
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
  - "ATL.ATLPath.IsSameRoot"
  - "ATLPath.IsSameRoot"
  - "IsSameRoot"
  - "ATLPath::IsSameRoot"
  - "ATLPATH/IsSameRoot"
  - "ATL::ATLPath::IsSameRoot"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsSameRoot function"
ms.assetid: dcdebc4e-eda2-45e4-af8d-5c5bb440481f
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ATLPath::IsSameRoot
This function is an overloaded wrapper for [PathIsSameRoot](http://msdn.microsoft.com/library/windows/desktop/bb773687).  
  
## Syntax  
  
```  
  
      inline BOOL IsSameRoot(  
   const char* pszPath1,  
   const char* pszPath2   
);  
inline BOOL IsSameRoot(  
   const wchar_t* pszPath1,  
   const wchar_t* pszPath2   
);  
```  
  
## Remarks  
 See [PathIsSameRoot](http://msdn.microsoft.com/library/windows/desktop/bb773687) for details.  
  
## Requirements  
 **Header:** atlpath.h  
  
## See Also  
 [ATL Concepts](../vs140/active-template-library--atl--concepts.md)   
 [ATL Reference](../vs140/atl-com-desktop-components.md)   
 [ATL Functions Alphabetical Reference](../vs140/atl-functions-alphabetical-reference.md)   
 [PathIsSameRoot](http://msdn.microsoft.com/library/windows/desktop/bb773687)