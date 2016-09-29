---
title: "CMFCStandardColorsPropertyPage Class"
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
  - "CMFCStandardColorsPropertyPage"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCStandardColorsPropertyPage class"
ms.assetid: b84b7cfb-bb24-4c65-804a-5b642cb64400
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCStandardColorsPropertyPage Class
Represents a property page that users use to select standard colors in a color dialog box.  
  
## Syntax  
  
```  
class CMFCStandardColorsPropertyPage : public CPropertyPage  
```  
  
## Members  
  
### Public Constructors  
  
|||  
|-|-|  
|Name|Description|  
|`CMFCStandardColorsPropertyPage::CMFCStandardColorsPropertyPage`|Default constructor.|  
  
### Public Methods  
  
|||  
|-|-|  
|Name|Description|  
|`CMFCStandardColorsPropertyPage::CreateObject`|Used by the framework to create a dynamic instance of this class type.|  
|`CMFCStandardColorsPropertyPage::GetThisClass`|Used by the framework to obtain a pointer to the [CRuntimeClass](../vs140/cruntimeclass-structure.md) object that is associated with this class type.|  
  
### Remarks  
 The `CMFCColorDialog` class uses this class to display the standard color property page. For more information about `CMFCColorDialog`, see [CMFCColorDialog Class](../vs140/cmfccolordialog-class.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CDialog](../vs140/cdialog-class.md)  
  
 [CPropertyPage](../vs140/cpropertypage-class.md)  
  
 [CMFCStandardColorsPropertyPage](../vs140/cmfcstandardcolorspropertypage-class.md)  
  
## Requirements  
 **Header:** afxstandardcolorspropertypage.h  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CMFCColorDialog Class](../vs140/cmfccolordialog-class.md)   
 [CMFCCustomColorsPropertyPage Class](../vs140/cmfccustomcolorspropertypage-class.md)