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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCRibbonLabel::CMFCRibbonLabel](#cmfcribbonlabel__cmfcribbonlabel)|Constructs and initializes a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object with the specified text string.|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Used by the framework to create a dynamic instance of this class type.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Used by the framework to obtain a pointer to the [CRuntimeClass](../vs140/cruntimeclass-structure.md) object that is associated with this class type.|  
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
  
##  \<a name="cmfcribbonlabel__cmfcribbonlabel">\</a>  CMFCRibbonLabel::CMFCRibbonLabel  
 Constructs and initializes a [CMFCRibbonLabel](../vs140/cmfcribbonlabel-class.md) object that displays the specified text string.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The text to appear in the label.  
  
 [in] <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to specify that the label is a multi-line label; otherwise, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcribbonlabel__setaccdata">\</a>  CMFCRibbonLabel::SetACCData  
 Determines the accessibility data for the current ribbon label element.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 Represents the parent window of the current ribbon label.  
  
 [out] <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> that is populated with the accessibility data of the current ribbon label.  
  
### Return Value  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> if the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> parameter was successfully populated with the accessibility data of the current ribbon label; otherwise, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CMFCRibbonButton Class](../vs140/cmfcribbonbutton-class.md)