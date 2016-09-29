---
title: "CMFCRibbonCustomizeDialog Class"
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
  - "GetThisClass"
  - "CMFCRibbonCustomizeDialog"
  - "~CMFCRibbonCustomizeDialog"
  - "CMFCRibbonCustomizeDialog::GetThisClass"
  - "CMFCRibbonCustomizeDialog.~CMFCRibbonCustomizeDialog"
  - "CMFCRibbonCustomizeDialog.GetThisClass"
  - "CMFCRibbonCustomizeDialog::~CMFCRibbonCustomizeDialog"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCRibbonCustomizeDialog class"
  - "CMFCRibbonCustomizeDialog class, destructor"
  - "~CMFCRibbonCustomizeDialog destructor"
  - "GetThisClass method"
ms.assetid: ce67de7f-5eaa-4c75-9b94-f290f36df073
caps.latest.revision: 21
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonCustomizeDialog Class
Displays the ribbon **Customize** page.  
  
## Syntax  
  
```  
class CMFCRibbonCustomizeDialog : public CMFCPropertySheet  
```  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCRibbonCustomizeDialog::CMFCRibbonCustomizeDialog](#cmfcribboncustomizedialog__cmfcribboncustomizedialog)|Constructs a `CMFCRibbonCustomizeDialog` object.|  
|`CMFCRibbonCustomizeDialog::~CMFCRibbonCustomizeDialog`|Destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|`CMFCRibbonCustomizeDialog::GetThisClass`|Used by the framework to obtain a pointer to the [CRuntimeClass](../vs140/cruntimeclass-structure.md) object that is associated with this class type.|  
  
## Remarks  
 MFC instantiates this class automatically if you do not process the AFX_WM_ON_RIBBON_CUSTOMIZE message, or if you return 0 from the message handler.  
  
 If you want to use this class in your application to display the ribbon **Customize** dialog box, just instantiate it and call the `DoModal` method.  
  
 Because this class is derived from [CMFCPropertySheet Class](../vs140/cmfcpropertysheet-class.md), you can add custom pages by using the `CMFCPropertySheet` API.  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CPropertySheet](../vs140/cpropertysheet-class.md)  
  
 [CMFCPropertySheet](../vs140/cmfcpropertysheet-class.md)  
  
 [CMFCRibbonCustomizeDialog](../vs140/cmfcribboncustomizedialog-class.md)  
  
## Requirements  
 **Header:** afxribboncustomizedialog.h  
  
##  <a name="cmfcribboncustomizedialog__cmfcribboncustomizedialog"></a>  CMFCRibbonCustomizeDialog::CMFCRibbonCustomizeDialog  
 Constructs a `CMFCRibbonCustomizeDialog` object.  
  
```  
CMFCRibbonCustomizeDialog(  
   CWnd* pWndParent,  
   CMFCRibbonBar* pRibbon  
);  
```  
  
### Parameters  
 [in] `pWndParent`  
 A pointer to the parent window (usually the main frame).  
  
 [in] `pRibbon`  
 A pointer to the `CMFCRibbonBar` that is to be customized.  
  
### Example  
 The following example demonstrates how to construct a `CMFCRibbonCustomizeDialog` object.  
  
 [!code[NVC_MFC_RibbonApp#18](../vs140/codesnippet/CPP/cmfcribboncustomizedialog-class_1.cpp)]  
  
### Remarks  
 The constructor instantiates a [CMFCRibbonCustomizePropertyPage Class](../vs140/cmfcribboncustomizepropertypage-class.md) object and adds it to the collection of property sheet pages.  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)