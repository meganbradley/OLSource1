---
title: "ATLPath::IsDirectory"
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
  - "ATLPATH/IsDirectory"
  - "ATL.ATLPath.IsDirectory"
  - "ATLPath::IsDirectory"
  - "ATLPath.IsDirectory"
  - "ATL::ATLPath::IsDirectory"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsDirectory function"
ms.assetid: d196d0dd-20c2-46d0-9cbe-b2ed211cafcc
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ATLPath::IsDirectory
This function is an overloaded wrapper for [PathIsDirectory](http://msdn.microsoft.com/library/windows/desktop/bb773621).  
  
## Syntax  
  
```  
  
      inline BOOL IsDirectory(  
   const char* pszPath   
);  
inline BOOL IsDirectory(  
   const wchar_t* pszPath   
);  
```  
  
## Remarks  
 See [PathIsDirectory](http://msdn.microsoft.com/library/windows/desktop/bb773621) for details.  
  
## Requirements  
 **Header:** atlpath.h  
  
## See Also  
 [ATL Concepts](../VS_csharp/active-template-library--atl--concepts.md)   
 [ATL Reference](../VS_csharp/atl-com-desktop-components.md)   
 [ATL Functions Alphabetical Reference](../VS_csharp/atl-functions-alphabetical-reference.md)   
 [PathIsDirectory](http://msdn.microsoft.com/library/windows/desktop/bb773621)