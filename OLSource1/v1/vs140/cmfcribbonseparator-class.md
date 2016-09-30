---
title: "CMFCRibbonSeparator Class"
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
  - "CMFCRibbonSeparator::GetThisClass"
  - "CMFCRibbonSeparator.CreateObject"
  - "CMFCRibbonSeparator::CreateObject"
  - "CMFCRibbonSeparator"
  - "CreateObject"
  - "CMFCRibbonSeparator.GetThisClass"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCRibbonSeparator class"
  - "GetThisClass method"
  - "CreateObject method"
ms.assetid: bedb1a53-cb07-4c3c-be12-698c5409e7cf
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonSeparator Class
Implements the ribbon separator.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|||  
|-|-|  
|Name|Description|  
|[CMFCRibbonSeparator::CMFCRibbonSeparator](#cmfcribbonseparator__cmfcribbonseparator)|Constructs a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|||  
|-|-|  
|Name|Description|  
|[CMFCRibbonSeparator::AddToListBox](#cmfcribbonseparator__addtolistbox)|Adds a separator to the **Commands** list in the **Customize** dialog box. (Overrides [CMFCRibbonBaseElement::AddToListBox](../vs140/cmfcribbonbaseelement-class.md#cmfcribbonbaseelement__addtolistbox).)|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Used by the framework to create a dynamic instance of this class type.|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|Used by the framework to obtain a pointer to the [CRuntimeClass](../vs140/cruntimeclass-structure.md) object that is associated with this class type.|  
  
### Protected Methods  
  
|||  
|-|-|  
|Name|Description|  
|[CMFCRibbonSeparator::CopyFrom](#cmfcribbonseparator__copyfrom)|A copy method that sets a separator's member variables from another object.|  
|[CMFCRibbonSeparator::GetRegularSize](#cmfcribbonseparator__getregularsize)|Returns the size of a separator.|  
|[CMFCRibbonSeparator::IsSeparator](#cmfcribbonseparator__isseparator)|Indicates whether this is a separator.|  
|[CMFCRibbonSeparator::IsTabStop](#cmfcribbonseparator__istabstop)|Indicates whether this is a tab stop.|  
|[CMFCRibbonSeparator::OnDraw](#cmfcribbonseparator__ondraw)|Called by the system to draw the separator on either the ribbon or the Quick Access Toolbar.|  
|[CMFCRibbonSeparator::OnDrawOnList](#cmfcribbonseparator__ondrawonlist)|Called by the system to draw the separator on the **Commands** list.|  
  
## Remarks  
 A ribbon separator is a vertical or horizontal line that logically separates ribbon elements. A separator can be drawn on the ribbon control, the main application menu, the ribbon status bar, and the Quick Access Toolbar.  
  
 To use a separator in your application, construct the new object and add it to the main application menu as shown here:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Call [CMFCRibbonPanel::AddSeparator](../vs140/cmfcribbonpanel-class.md#cmfcribbonpanel__addseparator) to add separators to ribbon panels. The separators are allocated and added internally by the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> method.  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CMFCRibbonBaseElement](../vs140/cmfcribbonbaseelement-class.md)  
  
 [CMFCRibbonSeparator](../vs140/cmfcribbonseparator-class.md)  
  
## Requirements  
 **Header:** afxbaseribbonelement.h  
  
##  \<a name="cmfcribbonseparator__addtolistbox">\</a>  CMFCRibbonSeparator::AddToListBox  
 Adds a separator to the **Commands** list in the **Customize** dialog box.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 A pointer to the **Commands** list where the separator is added.  
  
 [in] <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 Ignored.  
  
### Return Value  
 Zero-based index to the string in the list box specified by <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcribbonseparator__cmfcribbonseparator">\</a>  CMFCRibbonSeparator::CMFCRibbonSeparator  
 Constructs a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, the separator is horizontal; if <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, the separator is vertical.  
  
### Remarks  
 Horizontal separators are used in application menus. Vertical separators are used in toolbars.  
  
### Example  
 The following example demonstrates how to construct an object of the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> class.  
  
 [!code[NVC_MFC_RibbonApp#19](../vs140/codesnippet/CPP/cmfcribbonseparator-class_1.cpp)]  
  
##  \<a name="cmfcribbonseparator__copyfrom">\</a>  CMFCRibbonSeparator::CopyFrom  
 A copy method that sets a separator's member variables from another object.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 The source ribbon element to copy from.  
  
##  \<a name="cmfcribbonseparator__getregularsize">\</a>  CMFCRibbonSeparator::GetRegularSize  
 Returns the size of a separator.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 A pointer to a device content.  
  
### Return Value  
 The size of the separator on the given device context.  
  
##  \<a name="cmfcribbonseparator__isseparator">\</a>  CMFCRibbonSeparator::IsSeparator  
 Indicates whether this is a separator.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 Always <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> for this class.  
  
##  \<a name="cmfcribbonseparator__istabstop">\</a>  CMFCRibbonSeparator::IsTabStop  
 Indicates whether this is a tab stop.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 Always <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> for this class.  
  
### Remarks  
 A ribbon separator is not a tab stop.  
  
##  \<a name="cmfcribbonseparator__ondraw">\</a>  CMFCRibbonSeparator::OnDraw  
 Called by the system to draw the separator on either the ribbon or the Quick Access Toolbar.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
##  \<a name="cmfcribbonseparator__ondrawonlist">\</a>  CMFCRibbonSeparator::OnDrawOnList  
 Called by the system to draw the separator on the **Commands** list.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|A pointer to a device context.|  
|[in] <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|Text displayed on the list.|  
|[in] <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|Spacing between the text and the left side of the bounding rectangle.|  
|[in] <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|Specifies the bounding rectangle.|  
|[in] <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|Ignored.|  
|[in] <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|Ignored.|  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)