---
title: "AtlHexValue"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - ATL.AtlHexValue
  - AtlHexValue
  - ATL::AtlHexValue
  - ATLUTIL/AtlHexValue
dev_langs: 
  - C++
helpviewer_keywords: 
  - AtlHexValue function
ms.assetid: 503446a2-a363-49f4-9fd6-f39071959cdd
caps.latest.revision: 14
translation.priority.ht: 
  - de-de
  - ja-jp
---
# AtlHexValue
Call this function to get the numeric value of a hexadecimal digit.  
  
## Syntax  
  
```  
  
      inline short AtlHexValue(  
   char chIn   
) throw( );  
```  
  
#### Parameters  
 `chIn`  
 The hexadecimal character '0'-'9', 'A'-'F', or 'a'-'f'.  
  
## Return Value  
 The numeric value of the input character interpreted as a hexadecimal digit. For example, an input of '0' returns a value of 0 and an input of 'A' returns a value of 10. If the input character is not a hexadecimal digit, this function returns -1.  
  
## Requirements  
 **Header:** atlutil.h  
  
## See Also  
 [ATL Concepts](../vs140/active-template-library--atl--concepts.md)   
 [ATL Reference](../vs140/atl-com-desktop-components.md)   
 [ATL Functions Alphabetical Reference](../vs140/atl-functions-alphabetical-reference.md)