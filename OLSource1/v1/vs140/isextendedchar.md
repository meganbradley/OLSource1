---
title: "IsExtendedChar"
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
  - "ATLENC/IsExtendedChar"
  - "IsExtendedChar"
  - "ATL.IsExtendedChar"
  - "ATL::IsExtendedChar"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsExtendedChar function"
ms.assetid: 9c6721f5-ddfb-478b-a976-fe015bdf2ec1
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IsExtendedChar
Call this function to find out if a given character is an extended character (less than 32, greater than 126, and not a tab, linefeed or carriage return)  
  
## Syntax  
  
```  
  
      inline int IsExtendedChar(  
   char ch   
) throw( );  
```  
  
#### Parameters  
 *ch*  
 The character to be tested  
  
## Return Value  
 **TRUE** if the character is extended, **FALSE** otherwise.  
  
## Requirements  
 **Header:** atlenc.h  
  
## See Also  
 [ATL Concepts](../vs140/active-template-library--atl--concepts.md)   
 [ATL Reference](../vs140/atl-com-desktop-components.md)   
 [ATL Functions Alphabetical Reference](../vs140/atl-functions-alphabetical-reference.md)