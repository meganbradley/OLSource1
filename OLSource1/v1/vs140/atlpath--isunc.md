---
title: "ATLPath::IsUNC"
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
  - "ATL.ATLPath.IsUNC"
  - "ATLPATH/IsUNC"
  - "IsUNC"
  - "ATL::ATLPath::IsUNC"
  - "ATLPath.IsUNC"
  - "ATLPath::IsUNC"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsUNC function"
ms.assetid: 5addb2e4-0069-4f0e-8bc9-492e2e2f3269
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ATLPath::IsUNC
This function is an overloaded wrapper for [PathIsUNC](http://msdn.microsoft.com/library/windows/desktop/bb773712).  
  
## Syntax  
  
```  
  
      inline BOOL IsUNC(  
   const char* pszPath   
);  
inline BOOL IsUNC(  
   const wchar_t* pszPath   
);  
```  
  
## Remarks  
 See [PathIsUNC](http://msdn.microsoft.com/library/windows/desktop/bb773712) for details.  
  
## Requirements  
 **Header:** atlpath.h  
  
## See Also  
 [ATL Concepts](../vs140/active-template-library--atl--concepts.md)   
 [ATL Reference](../vs140/atl-com-desktop-components.md)   
 [ATL Functions Alphabetical Reference](../vs140/atl-functions-alphabetical-reference.md)   
 [PathIsUNC](http://msdn.microsoft.com/library/windows/desktop/bb773712)