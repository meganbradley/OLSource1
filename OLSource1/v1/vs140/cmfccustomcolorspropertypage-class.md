---
title: "CMFCCustomColorsPropertyPage Class"
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
  - CMFCCustomColorsPropertyPage
dev_langs: 
  - C++
helpviewer_keywords: 
  - CMFCCustomColorsPropertyPage class
ms.assetid: 46a45ba2-1fda-440d-8018-d4dcd44f5816
caps.latest.revision: 22
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCCustomColorsPropertyPage Class
Represents a property page that can select custom colors in a color dialog box.  
  
## Syntax  
  
```  
class CMFCCustomColorsPropertyPage : public CPropertyPage  
```  
  
## Members  
  
### Public Constructors  
  
|||  
|-|-|  
|Name|Description|  
|`CMFCCustomColorsPropertyPage::CMFCCustomColorsPropertyPage`|Default constructor.|  
  
### Public Methods  
  
|||  
|-|-|  
|Name|Description|  
|`CMFCCustomColorsPropertyPage::CreateObject`|Used by the framework to create a dynamic instance of this class type.|  
|`CMFCCustomColorsPropertyPage::GetThisClass`|Used by the framework to obtain a pointer to the [CRuntimeClass](../vs140/cruntimeclass-structure.md) object that is associated with this class type.|  
|[CMFCCustomColorsPropertyPage::Setup](#cmfccustomcolorspropertypage__setup)|Sets the color components of the property page.|  
  
### Remarks  
 The `CMFCColorDialog` class uses this class to display the custom color property page. For more information about `CMFCColorDialog`, see [CMFCColorDialog Class](../vs140/cmfccolordialog-class.md).  
  
## Example  
 The following example demonstrates how to construct a `CMFCCustomColorsPropertyPage` object and set the color components of the property page.  
  
 [!code[NVC_MFC_RibbonApp#35](../vs140/codesnippet/CPP/cmfccustomcolorspropertypage-class_1.cpp)]
  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CDialog](../vs140/cdialog-class.md)  
  
 [CPropertyPage](../vs140/cpropertypage-class.md)  
  
 [CMFCCustomColorsPropertyPage](../vs140/cmfccustomcolorspropertypage-class.md)  
  
## Requirements  
 **Header:** afxcustomcolorspropertypage.h  
  
##  <a name="cmfccustomcolorspropertypage__setup"></a>  CMFCCustomColorsPropertyPage::Setup  
 Sets the color components of the property page.  
  
```  
void Setup(  
   BYTE R,  
   BYTE G,  
   BYTE B  
);  
```  
  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] `R`|The red component of the RGB value.|  
|[in] `G`|The green component of the RGB value.|  
|[in] `B`|The blue component of the RGB value.|  
  
### Remarks  
 This method updates the current RGB and the associated HLS (hue, lightness, and saturation) color values of the property page. The [CMFCColorDialog::SetPageTwo](../vs140/cmfccolordialog-class.md#cmfccolordialog__setpagetwo) method calls this method when the framework initializes the color dialog box or the user presses the left mouse button. For more information about `CMFCColorDialog`, see [CMFCColorDialog Class](../vs140/cmfccolordialog-class.md).  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CMFCColorDialog Class](../vs140/cmfccolordialog-class.md)   
 [CMFCStandardColorsPropertyPage Class](../vs140/cmfcstandardcolorspropertypage-class.md)