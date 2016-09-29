---
title: "ATLPath::BuildRoot"
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
  - "ATLPath.BuildRoot"
  - "BuildRoot"
  - "ATLPATH/BuildRoot"
  - "ATL::ATLPath::BuildRoot"
  - "ATLPath::BuildRoot"
  - "ATL.ATLPath.BuildRoot"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "BuildRoot function"
ms.assetid: b67c4664-b63f-4a26-b8c5-6ad09aae0081
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ATLPath::BuildRoot
This function is an overloaded wrapper for [PathBuildRoot](http://msdn.microsoft.com/library/windows/desktop/bb773567).  
  
## Syntax  
  
```  
  
      inline char* BuildRoot(  
   char* pszPath,  
   int iDrive   
);  
inline wchar_t* BuildRoot(  
   wchar_t* pszPath,  
   int iDrive   
);  
```  
  
## Remarks  
 See [PathBuildRoot](http://msdn.microsoft.com/library/windows/desktop/bb773567) for details.  
  
## Requirements  
 **Header:** atlpath.h  
  
## See Also  
 [ATL Concepts](../vs140/active-template-library--atl--concepts.md)   
 [ATL Reference](../vs140/atl-com-desktop-components.md)   
 [ATL Functions Alphabetical Reference](../vs140/atl-functions-alphabetical-reference.md)   
 [PathBuildRoot](http://msdn.microsoft.com/library/windows/desktop/bb773567)