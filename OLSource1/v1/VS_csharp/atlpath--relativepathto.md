---
title: "ATLPath::RelativePathTo"
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
  - "ATL::ATLPath::RelativePathTo"
  - "ATL.ATLPath.RelativePathTo"
  - "ATLPath.RelativePathTo"
  - "RelativePathTo"
  - "ATLPATH/RelativePathTo"
  - "ATLPath::RelativePathTo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RelativePathTo function"
ms.assetid: b0814493-1c01-4544-a957-d3d050507801
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ATLPath::RelativePathTo
This function is an overloaded wrapper for [PathRelativePathTo](http://msdn.microsoft.com/library/windows/desktop/bb773740).  
  
## Syntax  
  
```  
  
      inline BOOL RelativePathTo(  
   char* pszPath,  
   const char* pszFrom,  
   DWORD dwAttrFrom,  
   const char* pszTo,  
   DWORD dwAttrTo   
);  
inline BOOL RelativePathTo(  
   wchar_t* pszPath,  
   const wchar_t* pszFrom,  
   DWORD dwAttrFrom,  
   const wchar_t* pszTo,  
   DWORD dwAttrTo   
);  
```  
  
## Remarks  
 See [PathRelativePathTo](http://msdn.microsoft.com/library/windows/desktop/bb773740) for details.  
  
## Requirements  
 **Header:** atlpath.h  
  
## See Also  
 [ATL Concepts](../VS_csharp/active-template-library--atl--concepts.md)   
 [ATL Reference](../VS_csharp/atl-com-desktop-components.md)   
 [ATL Functions Alphabetical Reference](../VS_csharp/atl-functions-alphabetical-reference.md)   
 [PathRelativePathTo](http://msdn.microsoft.com/library/windows/desktop/bb773740)