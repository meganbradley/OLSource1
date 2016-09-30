---
title: "CMFCRibbonLinkCtrl Class"
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
  - "CMFCRibbonLinkCtrl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCRibbonLinkCtrl class"
ms.assetid: 77ae1941-e0ab-4a9d-911e-1752d34c079b
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonLinkCtrl Class
Implements a hyperlink that is positioned on a ribbon. The hyperlink opens a Web page when you click it.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCRibbonLinkCtrl::CMFCRibbonLinkCtrl](#cmfcribbonlinkctrl__cmfcribbonlinkctrl)|Constructs and initializes a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCRibbonLinkCtrl::CopyFrom](#cmfcribbonlinkctrl__copyfrom)|(Overrides <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.)|  
|[CMFCRibbonLinkCtrl::GetCompactSize](#cmfcribbonlinkctrl__getcompactsize)|(Overrides [CMFCRibbonButton::GetCompactSize](../vs140/cmfcribbonbutton-class.md#cmfcribbonbutton__getcompactsize).)|  
|[CMFCRibbonLinkCtrl::GetLink](#cmfcribbonlinkctrl__getlink)|Returns the value of the hyperlink.|  
|[CMFCRibbonLinkCtrl::GetRegularSize](#cmfcribbonlinkctrl__getregularsize)|(Overrides [CMFCRibbonButton::GetRegularSize](../vs140/cmfcribbonbutton-class.md#cmfcribbonbutton__getregularsize).)|  
|[CMFCRibbonLinkCtrl::GetToolTipText](#cmfcribbonlinkctrl__gettooltiptext)|(Overrides [CMFCRibbonButton::GetToolTipText](../vs140/cmfcribbonbutton-class.md#cmfcribbonbutton__gettooltiptext).)|  
|[CMFCRibbonLinkCtrl::IsDrawTooltipImage](#cmfcribbonlinkctrl__isdrawtooltipimage)|(Overrides <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.)|  
|[CMFCRibbonLinkCtrl::OnDraw](#cmfcribbonlinkctrl__ondraw)|(Overrides [CMFCRibbonButton::OnDraw](../vs140/cmfcribbonbutton-class.md#cmfcribbonbutton__ondraw).)|  
|[CMFCRibbonLinkCtrl::OnDrawMenuImage](#cmfcribbonlinkctrl__ondrawmenuimage)|(Overrides [CMFCRibbonBaseElement::OnDrawMenuImage](../vs140/cmfcribbonbaseelement-class.md#cmfcribbonbaseelement__ondrawmenuimage).)|  
|[CMFCRibbonLinkCtrl::OnMouseMove](#cmfcribbonlinkctrl__onmousemove)|(Overrides <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.)|  
|[CMFCRibbonLinkCtrl::OnSetIcon](#cmfcribbonlinkctrl__onseticon)||  
|[CMFCRibbonLinkCtrl::OpenLink](#cmfcribbonlinkctrl__openlink)|Opens the Web page specified in the hyperlink.|  
|[CMFCRibbonLinkCtrl::SetLink](#cmfcribbonlinkctrl__setlink)|Sets the value of the hyperlink.|  
  
## Remarks  
 After you create a hyperlink, add it to a panel by calling [CMFCRibbonPanel::Add](../vs140/cmfcribbonpanel-class.md#cmfcribbonpanel__add).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md) [CMFCRibbonBaseElement](../vs140/cmfcribbonbaseelement-class.md)  
  
 [CMFCRibbonButton](../vs140/cmfcribbonbutton-class.md) [CMFCRibbonLinkCtrl](../vs140/cmfcribbonlinkctrl-class.md)  
  
## Requirements  
 **Header:** afxRibbonLinkCtrl.h  
  
##  \<a name="cmfcribbonlinkctrl__cmfcribbonlinkctrl">\</a>  CMFCRibbonLinkCtrl::CMFCRibbonLinkCtrl  
 Constructs and initializes a [CMFCRibbonLinkCtrl](../vs140/cmfcribbonlinkctrl-class.md) object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 Specifies the command ID of the command that executes when the link control is clicked.  
  
 [in] <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 Specifies the label to display on the link control.  
  
 [in] <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 Specifies the hyperlink associated with the link control.  
  
### Example  
 The following example demonstrates how to use the constructor of the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> class. This code snippet is part of the [Ribbon Gadgets sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_RibbonGadgets#1](../vs140/codesnippet/CPP/cmfcribbonlinkctrl-class_1.cpp)]  
  
##  \<a name="cmfcribbonlinkctrl__copyfrom">\</a>  CMFCRibbonLinkCtrl::CopyFrom  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcribbonlinkctrl__getcompactsize">\</a>  CMFCRibbonLinkCtrl::GetCompactSize  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcribbonlinkctrl__getlink">\</a>  CMFCRibbonLinkCtrl::GetLink  
 Returns the value of the hyperlink.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 The current value of the hyperlink.  
  
### Remarks  
  
##  \<a name="cmfcribbonlinkctrl__getregularsize">\</a>  CMFCRibbonLinkCtrl::GetRegularSize  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcribbonlinkctrl__gettooltiptext">\</a>  CMFCRibbonLinkCtrl::GetToolTipText  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcribbonlinkctrl__ondrawmenuimage">\</a>  CMFCRibbonLinkCtrl::OnDrawMenuImage  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcribbonlinkctrl__isdrawtooltipimage">\</a>  CMFCRibbonLinkCtrl::IsDrawTooltipImage  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcribbonlinkctrl__ondraw">\</a>  CMFCRibbonLinkCtrl::OnDraw  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcribbonlinkctrl__onmousemove">\</a>  CMFCRibbonLinkCtrl::OnMouseMove  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcribbonlinkctrl__onseticon">\</a>  CMFCRibbonLinkCtrl::OnSetIcon  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmfcribbonlinkctrl__openlink">\</a>  CMFCRibbonLinkCtrl::OpenLink  
 Opens the Web page specified in the hyperlink.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> if the associated Web page was opened successfully; otherwise, <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>.  
  
### Remarks  
 Opens a web page using the hyperlink associated with the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> object.  
  
##  \<a name="cmfcribbonlinkctrl__setlink">\</a>  CMFCRibbonLinkCtrl::SetLink  
 Sets the value of the hyperlink.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 Specifies the hyperlink text.  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CMFCRibbonButton Class](../vs140/cmfcribbonbutton-class.md)