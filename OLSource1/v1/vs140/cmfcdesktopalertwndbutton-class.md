---
title: "CMFCDesktopAlertWndButton Class"
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
  - "CMFCDesktopAlertWndButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCDesktopAlertWndButton class"
ms.assetid: df39a0c8-0c39-4ab0-8c64-78c5b2c4ecaf
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCDesktopAlertWndButton Class
Allows buttons to be added to a desktop alert dialog box.  
  
## Syntax  
  
```  
class CMFCDesktopAlertWndButton : public CMFCButton  
```  
  
## Members  
  
### Public Constructors  
  
|||  
|-|-|  
|Name|Description|  
|`CMFCDesktopAlertWndButton::CMFCDesktopAlertWndButton`|Default constructor.|  
|`CMFCDesktopAlertWndButton::~CMFCDesktopAlertWndButton`|Destructor.|  
  
### Public Methods  
  
|||  
|-|-|  
|Name|Description|  
|[CMFCDesktopAlertWndButton::IsCaptionButton](#cmfcdesktopalertwndbutton__iscaptionbutton)|Determines whether the button is displayed in the caption area of the alert dialog box.|  
|[CMFCDesktopAlertWndButton::IsCloseButton](#cmfcdesktopalertwndbutton__isclosebutton)|Determines whether the button closes the alert dialog box.|  
  
### Data Members  
  
|||  
|-|-|  
|Name|Description|  
|`CMFCDesktopAlertWndButton::m_bIsCaptionButton`|A Boolean value that specifies whether the button is displayed in the caption area of the alert dialog box.|  
|`CMFCDesktopAlertWndButton::m_bIsCloseButton`|A Boolean value that specifies whether the button closes the alert dialog box.|  
  
### Remarks  
 By default, the constructor sets the `m_bIsCaptionButton` and `m_bIsCloseButton` data members to `FALSE`. The parent `CMFCDesktopAlertDialog` object sets `m_bIsCaptionButton` to `TRUE` if the button is positioned in the caption area of the alert dialog box. The `CMFCDesktopAlertDialog` class creates a `CMFCDesktopAlertWndButton` object that serves as the button that closes the alert dialog box and sets `m_bIsCloseButton` to `TRUE`.  
  
 Add `CMFCDesktopAlertWndButton` objects to a `CMFCDesktopAlertDialog` object as you would add any button. For more information about `CMFCDesktopAlertDialog`, see [CMFCDesktopAlertDialog Class](../vs140/cmfcdesktopalertdialog-class.md).  
  
## Example  
 The following example demonstrates how to use the `SetImage` method in the `CMFCDesktopAlertWndButton` class. This code snippet is part of the [Desktop Alert Demo sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_DesktopAlertDemo#4](../vs140/codesnippet/CPP/cmfcdesktopalertwndbutton-class_1.h)]  
[!code[NVC_MFC_DesktopAlertDemo#5](../vs140/codesnippet/CPP/cmfcdesktopalertwndbutton-class_2.cpp)]  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CButton](../vs140/cbutton-class.md)  
  
 [CMFCButton](../vs140/cmfcbutton-class.md)  
  
 [CMFCDesktopAlertWndButton](../vs140/cmfcdesktopalertwndbutton-class.md)  
  
## Requirements  
 **Header:** afxdesktopalertwnd.h  
  
##  <a name="cmfcdesktopalertwndbutton__iscaptionbutton"></a>  CMFCDesktopAlertWndButton::IsCaptionButton  
 Determines whether the button is displayed in the caption area of the alert dialog box.  
  
```  
BOOL IsCaptionButton() const;  
```  
  
### Return Value  
 Nonzero if the button is displayed in the caption area of the alert dialog box; otherwise, 0.  
  
##  <a name="cmfcdesktopalertwndbutton__isclosebutton"></a>  CMFCDesktopAlertWndButton::IsCloseButton  
 Determines whether the button closes the alert dialog box.  
  
```  
BOOL IsCloseButton() const;  
```  
  
### Return Value  
 Nonzero if the button closes the alert dialog box; otherwise, 0.  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CMFCDesktopAlertDialog Class](../vs140/cmfcdesktopalertdialog-class.md)