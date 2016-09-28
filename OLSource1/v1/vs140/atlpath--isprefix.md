---
title: "ATLPath::IsPrefix"
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
  - "ATLPath::IsPrefix"
  - "ATL::ATLPath::IsPrefix"
  - "ATLPATH/IsPrefix"
  - "ATL.ATLPath.IsPrefix"
  - "ATLPath.IsPrefix"
  - "IsPrefix"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsPrefix function"
ms.assetid: 2fd8d100-66b3-4ef5-b149-a961ed1df553
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ATLPath::IsPrefix
This function is an overloaded wrapper for [PathIsPrefix](http://msdn.microsoft.com/library/windows/desktop/bb773650).  
  
## Syntax  
  
```  
  
      inline BOOL IsPrefix(  
   const char* pszPrefix,  
   const char* pszPath   
);  
inline BOOL IsPrefix(  
   const wchar_t* pszPrefix,  
   const wchar_t* pszPath   
);  
```  
  
## Remarks  
 See [PathIsPrefix](http://msdn.microsoft.com/library/windows/desktop/bb773650) for details.  
  
## Requirements  
 **Header:** atlpath.h  
  
## See Also  
 [ATL Concepts](../vs140/active-template-library--atl--concepts.md)   
 [ATL Reference](../vs140/atl-com-desktop-components.md)   
 [ATL Functions Alphabetical Reference](../vs140/atl-functions-alphabetical-reference.md)   
 [PathIsPrefix](http://msdn.microsoft.com/library/windows/desktop/bb773650)