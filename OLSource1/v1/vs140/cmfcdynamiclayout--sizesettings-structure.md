---
title: "CMFCDynamicLayout::SizeSettings Structure"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
dev_langs: 
  - "C++"
ms.assetid: a5ce1a7a-6802-49d7-90f9-7fc6046e5f1d
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCDynamicLayout::SizeSettings Structure
Encapsulates size change data for controls in a dynamic layout.  
  
## Syntax  
  
```  
struct CMFCDynamicLayout::SizeSettings;  
```  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|`SizeSettings`|Constructs the object with zero default values.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[SizeSettings::IsHorizontal](../vs140/sizesettings--ishorizontal.md)|Checks if the resize data specifies a nonzero horizontal resizing.|  
|[SizeSettings::IsNone](../vs140/sizesettings--isnone.md)|Checks if the resize data specifies no resizing.|  
|[SizeSettings::IsVertical](../vs140/sizesettings--isvertical.md)|Checks if the resize data specifies a nonzero vertical resizing.|  
  
### Data Members  
  
|Name|Description|  
|----------|-----------------|  
|`m_nXRatio`|The amount to resize horizontally, as a percentage.|  
|`m_nYRatio`|The amount to resize vertically, as a percentage.|  
  
## Remarks  
 This is a nested class inside `CMFCDynamicLayout`.  
  
## Requirements  
 **Header:** afxlayout.h  
  
## See Also  
 [CMFCDynamicLayout Class](../vs140/cmfcdynamiclayout-class.md)   
 [CMFCDynamicLayout::MoveSettings Structure](../vs140/cmfcdynamiclayout--movesettings-structure.md)