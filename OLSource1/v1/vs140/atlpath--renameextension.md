---
title: "ATLPath::RenameExtension"
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
  - "RenameExtension"
  - "ATLPath.RenameExtension"
  - "ATL.ATLPath.RenameExtension"
  - "ATL::ATLPath::RenameExtension"
  - "ATLPath::RenameExtension"
  - "ATLPATH/RenameExtension"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RenameExtension function"
ms.assetid: bc6f1e98-e247-4ecf-9e28-f5c2c51b2e93
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ATLPath::RenameExtension
This function is an overloaded wrapper for [PathRenameExtension](http://msdn.microsoft.com/library/windows/desktop/bb773749).  
  
## Syntax  
  
```  
  
      inline BOOL RenameExtension(  
   char* pszPath,  
   const char* pszExt   
);  
inline BOOL RenameExtension(  
   wchar_t* pszPath,  
   const wchar_t* pszExt   
);  
```  
  
## Remarks  
 See [PathRenameExtension](http://msdn.microsoft.com/library/windows/desktop/bb773749) for details.  
  
## Requirements  
 **Header:** atlpath.h  
  
## See Also  
 [ATL Concepts](../vs140/active-template-library--atl--concepts.md)   
 [ATL Reference](../vs140/atl-com-desktop-components.md)   
 [ATL Functions Alphabetical Reference](../vs140/atl-functions-alphabetical-reference.md)   
 [PathRenameExtension](http://msdn.microsoft.com/library/windows/desktop/bb773749)