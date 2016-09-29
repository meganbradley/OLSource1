---
title: "ATLPath::IsUNCServer"
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
  - "ATLPath.IsUNCServer"
  - "ATLPath::IsUNCServer"
  - "IsUNCServer"
  - "ATL::ATLPath::IsUNCServer"
  - "ATLPATH/IsUNCServer"
  - "ATL.ATLPath.IsUNCServer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsUNCServer function"
ms.assetid: f0f2763d-6918-4610-a66d-04996d2efeaf
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ATLPath::IsUNCServer
This function is an overloaded wrapper for [PathIsUNCServer](http://msdn.microsoft.com/library/windows/desktop/bb773722).  
  
## Syntax  
  
```  
  
      inline BOOL IsUNCServer(  
   const char* pszPath   
);  
inline BOOL IsUNCServer(  
   const wchar_t* pszPath   
);  
```  
  
## Remarks  
 See [PathIsUNCServer](http://msdn.microsoft.com/library/windows/desktop/bb773722) for details.  
  
## Requirements  
 **Header:** atlpath.h  
  
## See Also  
 [ATL Concepts](../VS_csharp/active-template-library--atl--concepts.md)   
 [ATL Reference](../VS_csharp/atl-com-desktop-components.md)   
 [ATL Functions Alphabetical Reference](../VS_csharp/atl-functions-alphabetical-reference.md)   
 [PathIsUNCServer](http://msdn.microsoft.com/library/windows/desktop/bb773722)