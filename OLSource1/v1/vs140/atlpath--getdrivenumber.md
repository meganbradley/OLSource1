---
title: "ATLPath::GetDriveNumber"
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
  - "GetDriveNumber"
  - "ATLPATH/GetDriveNumber"
  - "ATLPath::GetDriveNumber"
  - "ATL.ATLPath.GetDriveNumber"
  - "ATL::ATLPath::GetDriveNumber"
  - "ATLPath.GetDriveNumber"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetDriveNumber function"
ms.assetid: 31f81f6f-c3cf-4f9f-9299-31d355b4631f
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ATLPath::GetDriveNumber
This function is an overloaded wrapper for [PathGetDriveNumber](http://msdn.microsoft.com/library/windows/desktop/bb773612).  
  
## Syntax  
  
```  
  
      inline int GetDriveNumber(  
   const char* pszPath   
);  
inline int GetDriveNumber(  
   const wchar_t* pszPath   
);  
```  
  
## Remarks  
 See [PathGetDriveNumber](http://msdn.microsoft.com/library/windows/desktop/bb773612) for details.  
  
## Requirements  
 **Header:** atlpath.h  
  
## See Also  
 [ATL Concepts](../vs140/active-template-library--atl--concepts.md)   
 [ATL Reference](../vs140/atl-com-desktop-components.md)   
 [ATL Functions Alphabetical Reference](../vs140/atl-functions-alphabetical-reference.md)   
 [PathGetDriveNumber](http://msdn.microsoft.com/library/windows/desktop/bb773612)