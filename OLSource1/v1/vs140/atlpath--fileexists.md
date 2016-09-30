---
title: "ATLPath::FileExists"
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
  - "ATLPath::FileExists"
  - "ATL.ATLPath.FileExists"
  - "ATL::ATLPath::FileExists"
  - "ATLPath.FileExists"
  - "ATLPATH/FileExists"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FileExists function"
ms.assetid: 18c377d1-2393-45ee-bdac-7076634af5cb
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ATLPath::FileExists
This function is an overloaded wrapper for [PathFileExists](http://msdn.microsoft.com/library/windows/desktop/bb773584).  
  
## Syntax  
  
```  
  
      inline BOOL FileExists(  
   const char* pszPath   
);  
inline BOOL FileExists(  
   const wchar_t* pszPath   
);  
```  
  
## Remarks  
 See [PathFileExists](http://msdn.microsoft.com/library/windows/desktop/bb773584) for details.  
  
## Requirements  
 **Header:** atlpath.h  
  
## See Also  
 [ATL Concepts](../vs140/active-template-library--atl--concepts.md)   
 [ATL Reference](../vs140/atl-com-desktop-components.md)   
 [ATL Functions Alphabetical Reference](../vs140/atl-functions-alphabetical-reference.md)   
 [PathFileExists](http://msdn.microsoft.com/library/windows/desktop/bb773584)