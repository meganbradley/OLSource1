---
title: "CMFCDynamicLayout::MoveSettings Structure"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
dev_langs: 
  - C++
ms.assetid: 48a9bd38-5067-4407-8751-eafb01b150a8
caps.latest.revision: 9
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCDynamicLayout::MoveSettings Structure
Encapsulates move data for controls in a dynamic layout.  
  
## Syntax  
  
```  
struct CMFCDynamicLayout::MoveSettings;  
```  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|`MoveSettings`|Constructs the object with zero default values.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[MoveSettings::IsHorizontal](../vs140/movesettings--ishorizontal.md)|Checks if the move data specifies a nonzero horizontal movement.|  
|[MoveSettings::IsNone](../vs140/movesettings--isnone.md)|Checks if the move data specifies no movement.|  
|[MoveSettings::IsVertical](../vs140/movesettings--isvertical.md)|Checks if the move data specifies a nonzero vertical movement.|  
  
### Data Members  
  
|Name|Description|  
|----------|-----------------|  
|`m_nXRatio`|The amount to move horizontally, as a percentage.|  
|`m_nYRatio`|The amount to move vertically, as a percentage.|  
  
## Remarks  
 This is a nested class inside `CMFCDynamicLayout`.  
  
## Requirements  
 **Header:** afxlayout.h  
  
## See Also  
 [CMFCDynamicLayout Class](../vs140/cmfcdynamiclayout-class.md)   
 [CMFCDynamicLayout::SizeSettings](../vs140/cmfcdynamiclayout--sizesettings-structure.md)