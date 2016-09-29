---
title: "ATLPath::IsFileSpec"
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
  - "ATLPath.IsFileSpec"
  - "ATL::ATLPath::IsFileSpec"
  - "IsFileSpec"
  - "ATLPath::IsFileSpec"
  - "ATLPATH/IsFileSpec"
  - "ATL.ATLPath.IsFileSpec"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsFileSpec function"
ms.assetid: 1bba8dcf-9ee8-4178-b638-b2fafb7bd144
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ATLPath::IsFileSpec
This function is an overloaded wrapper for [PathIsFileSpec](http://msdn.microsoft.com/library/windows/desktop/bb773627).  
  
## Syntax  
  
```  
  
      inline BOOL IsFileSpec(  
   const char* pszPath   
);  
inline BOOL IsFileSpec(  
   const wchar_t* pszPath   
);  
```  
  
## Remarks  
 See [PathIsFileSpec](http://msdn.microsoft.com/library/windows/desktop/bb773627) for details.  
  
## Requirements  
 **Header:** atlpath.h  
  
## See Also  
 [ATL Concepts](../VS_csharp/active-template-library--atl--concepts.md)   
 [ATL Reference](../VS_csharp/atl-com-desktop-components.md)   
 [ATL Functions Alphabetical Reference](../VS_csharp/atl-functions-alphabetical-reference.md)   
 [PathIsFileSpec](http://msdn.microsoft.com/library/windows/desktop/bb773627)