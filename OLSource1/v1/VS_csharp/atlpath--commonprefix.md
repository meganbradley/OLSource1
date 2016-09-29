---
title: "ATLPath::CommonPrefix"
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
  - "ATLPath::CommonPrefix"
  - "CommonPrefix"
  - "ATLPath.CommonPrefix"
  - "ATL.ATLPath.CommonPrefix"
  - "ATL::ATLPath::CommonPrefix"
  - "ATLPATH/CommonPrefix"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CommonPrefix function"
ms.assetid: e5a89a44-9a54-43bc-8d77-77561a0d1453
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ATLPath::CommonPrefix
This function is an overloaded wrapper for [PathCommonPrefix](http://msdn.microsoft.com/library/windows/desktop/bb773574).  
  
## Syntax  
  
```  
  
      inline int CommonPrefix(  
   const char* pszFile1,  
   const char* pszFile2,  
   char* pszDest   
);  
inline int CommonPrefix(  
   const wchar_t* pszFile1,  
   const wchar_t* pszFile2,  
   wchar_t* pszDest   
);  
```  
  
## Remarks  
 See [PathCommonPrefix](http://msdn.microsoft.com/library/windows/desktop/bb773574) for details.  
  
## Requirements  
 **Header:** atlpath.h  
  
## See Also  
 [ATL Concepts](../VS_csharp/active-template-library--atl--concepts.md)   
 [ATL Reference](../VS_csharp/atl-com-desktop-components.md)   
 [ATL Functions Alphabetical Reference](../VS_csharp/atl-functions-alphabetical-reference.md)   
 [PathCommonPrefix](http://msdn.microsoft.com/library/windows/desktop/bb773574)