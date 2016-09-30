---
title: "CMFCRibbonLabel Class"
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
  - "CMFCRibbonLabel"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCRibbonLabel class"
ms.assetid: 0346c891-83bf-4f20-b8a1-c84cf2aadced
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonLabel Class
Implements a non-clickable text label for a ribbon.  
  
## Syntax  
  
```  
class CMFCRibbonLabel : public CMFCRibbonButton  
```  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCRibbonLabel::CMFCRibbonLabel](#cmfcribbonlabel__cmfcribbonlabel)|Constructs and initializes a `CMFCRibbonLabel` object with the specified text string.|  
|`CMFCRibbonLabel::~CMFCRibbonLabel`|Destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|`CMFCRibbonLabel::CreateObject`|Used by the framework to create a dynamic instance of this class type.|  
|`CMFCRibbonLabel::GetThisClass`|Used by the framework to obtain a pointer to the [CRuntimeClass](../vs140/cruntimeclass-structure.md) object that is associated with this class type.|  
|[CMFCRibbonLabel::SetACCData](#cmfcribbonlabel__setaccdata)|Determines the accessibility data for the current ribbon label element. (Overrides [CMFCRibbonButton::SetACCData](../vs140/cmfcribbonbutton-class.md#cmfcribbonbutton__setaccdata).)|  
  
### Remarks  
 After you create a ribbon label, add it to a panel by calling [CMFCRibbonPanel::Add](../vs140/cmfcribbonpanel-class.md#cmfcribbonpanel__add).  
  
 You cannot add a ribbon label to the Quick Access Toolbar.  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CMFCRibbonBaseElement](../vs140/cmfcribbonbaseelement-class.md)  
  
 [CMFCRibbonButton](../vs140/cmfcribbonbutton-class.md)  
  
 [CMFCRibbonLabel](../vs140/cmfcribbonlabel-class.md)  
  
## Requirements  
 **Header:** afxRibbonLabel.h  
  
##  \<a name="cmfcribbonlabel__cmfcribbonlabel"></a>  CMFCRibbonLabel::CMFCRibbonLabel  
 Constructs and initializes a [CMFCRibbonLabel](../vs140/cmfcribbonlabel-class.md) object that displays the specified text string.  
  
```  
CMFCRibbonLabel(  
    LPCTSTR lpszText,  
    BOOL bIsMultiLine = FALSE  
);  
```  
  
### Parameters  
 [in] `lpszText`  
 The text to appear in the label.  
  
 [in] `bIsMultiLine`  
 `TRUE` to specify that the label is a multi-line label; otherwise, `FALSE`.  
  
##  \<a name="cmfcribbonlabel__setaccdata"></a>  CMFCRibbonLabel::SetACCData  
 Determines the accessibility data for the current ribbon label element.  
  
```  
virtual BOOL SetACCData(  
    CWnd* pParent,  
    CAccessibilityData& data  
);  
```  
  
### Parameters  
 [in] `pParent`  
 Represents the parent window of the current ribbon label.  
  
 [out] `data`  
 An object of type `CAccessibilityData` that is populated with the accessibility data of the current ribbon label.  
  
### Return Value  
 `TRUE` if the `data` parameter was successfully populated with the accessibility data of the current ribbon label; otherwise, `FALSE`.  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CMFCRibbonButton Class](../vs140/cmfcribbonbutton-class.md)