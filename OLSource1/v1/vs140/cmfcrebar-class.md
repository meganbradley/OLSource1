---
title: "CMFCReBar Class"
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
  - "CMFCReBar"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCReBar class"
ms.assetid: 02a60e29-6224-49c1-9e74-e0a7d9f8d023
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCReBar Class
A <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object is a control bar that provides layout, persistence, and state information for rebar controls.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCReBar::AddBar](#cmfcrebar__addbar)|Adds a band to a rebar.|  
|[CMFCReBar::CalcFixedLayout](#cmfcrebar__calcfixedlayout)|(Overrides [CBasePane::CalcFixedLayout](../vs140/cbasepane-class.md#cbasepane__calcfixedlayout).)|  
|[CMFCReBar::CanFloat](#cmfcrebar__canfloat)|(Overrides [CBasePane::CanFloat](../vs140/cbasepane-class.md#cbasepane__canfloat).)|  
|[CMFCReBar::Create](#cmfcrebar__create)|Creates the rebar control and attaches it to the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object.|  
|[CMFCReBar::EnableDocking](#cmfcrebar__enabledocking)|(Overrides [CBasePane::EnableDocking](../vs140/cbasepane-class.md#cbasepane__enabledocking).)|  
|[CMFCReBar::GetReBarBandInfoSize](#cmfcrebar__getrebarbandinfosize)||  
|[CMFCReBar::GetReBarCtrl](#cmfcrebar__getrebarctrl)|Provides direct access to the underlying [CReBarCtrl](../vs140/crebarctrl-class.md) common control.|  
|[CMFCReBar::OnShowControlBarMenu](#cmfcrebar__onshowcontrolbarmenu)|(Overrides [CPane::OnShowControlBarMenu](../vs140/cpane-class.md#cpane__onshowcontrolbarmenu).)|  
|[CMFCReBar::OnToolHitTest](#cmfcrebar__ontoolhittest)|(Overrides [CWnd::OnToolHitTest](../vs140/cwnd-class.md#cwnd__ontoolhittest).)|  
|[CMFCReBar::OnUpdateCmdUI](#cmfcrebar__onupdatecmdui)|(Overrides [CBasePane::OnUpdateCmdUI](assetId:///e139f06a-9793-4ee2-bc3d-517389368c77).)|  
|[CMFCReBar::SetPaneAlignment](#cmfcrebar__setpanealignment)|(Overrides [CBasePane::SetPaneAlignment](../vs140/cbasepane-class.md#cbasepane__setpanealignment).)|  
  
## Remarks  
 A <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object can contain a variety of child windows. This includes edit boxes, toolbars, and list boxes. You can resize the rebar programmatically, or the user can manually resize the rebar by dragging its gripper bar. You can also set the background of a rebar object to a bitmap of your choice.  
  
 A rebar object behaves similarly to a toolbar object. A rebar control can contain one or more bands, and each band can contain a gripper bar, a bitmap, a text label, and a child window.  
  
## Example  
 The following example demonstrates how to use various methods in the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> class. The example shows how to create a rebar control and add a band to it. The band functions as an internal toolbar. This code snippet is part of the [Rebar Test sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_RebarTest#1](../vs140/codesnippet/CPP/cmfcrebar-class_1.h)]  
[!code[NVC_MFC_RebarTest#2](../vs140/codesnippet/CPP/cmfcrebar-class_2.cpp)]  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md) [CCmdTarget](../vs140/ccmdtarget-class.md) [CWnd](../vs140/cwnd-class.md)  
  
 [CBasePane](../vs140/cbasepane-class.md) [CPane](../vs140/cpane-class.md) [CMFCReBar](../vs140/cmfcrebar-class.md)  
  
## Requirements  
 **Header:** afxRebar.h  
  
##  \<a name="cmfcrebar__addbar">\</a>  CMFCReBar::AddBar  
 Adds a band to a rebar.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 [in] [out] <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 A pointer to the child window that is to be inserted into the rebar. The referenced object must have the                                 **WS_CHILD** window style.  
  
 [in] <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 Specifies the text to appear on the rebar. The text is not part of the child window. Rather, it is displayed on the rebar itself.  
  
 [in] [out] <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 Specifies the bitmap to be displayed on the rebar background.  
  
 [in] <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 Contains the style to apply to the band. For a complete list of band styles, see the description for <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> in the                                 [REBARBANDINFO](http://msdn.microsoft.com/library/windows/desktop/bb774393) structure in the Windows SDK documentation.  
  
 [in] <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 Represents the foreground color of the rebar.  
  
 [in] <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 Represents the background color of the rebar.  
  
### Return Value  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> if the band was successfully added to the rebar; otherwise, <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcrebar__create">\</a>  CMFCReBar::Create  
 Creates the rebar control and attaches it to the [CMFCReBar](../vs140/cmfcrebar-class.md) object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 [in] [out] <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 A pointer to the parent window of this rebar control.  
  
 [in] <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 Specifies the style for the rebar control. The default style value is                                 **RBS_BANDBORDERS**, which displays narrow lines to separate adjacent bands on the rebar control. For a list of valid styles, see                                 [Rebar Control Styles](http://msdn.microsoft.com/library/windows/desktop/bb774377) in the Windows SDK documentation.  
  
 [in] <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 The window style of the rebar control. For a list of valid styles, see [Window Styles](../vs140/window-styles.md).  
  
 [in] <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 The rebar's child-window ID.  
  
### Return Value  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> if the rebar was created successfully; otherwise, <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfcrebar__getrebarctrl">\</a>  CMFCReBar::GetReBarCtrl  
 Provides direct access to <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> the underlying common control for <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> objects.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 A reference to the underlying <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> object.  
  
### Remarks  
 Call this method to take advantage of the Windows rebar common control functionality when customizing your rebar.  
  
##  \<a name="cmfcrebar__calcfixedlayout">\</a>  CMFCReBar::CalcFixedLayout  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcrebar__canfloat">\</a>  CMFCReBar::CanFloat  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcrebar__enabledocking">\</a>  CMFCReBar::EnableDocking  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcrebar__getrebarbandinfosize">\</a>  CMFCReBar::GetReBarBandInfoSize  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcrebar__onshowcontrolbarmenu">\</a>  CMFCReBar::OnShowControlBarMenu  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcrebar__ontoolhittest">\</a>  CMFCReBar::OnToolHitTest  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcrebar__onupdatecmdui">\</a>  CMFCReBar::OnUpdateCmdUI  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcrebar__setpanealignment">\</a>  CMFCReBar::SetPaneAlignment  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
  
### Remarks  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CReBarCtrl Class](../vs140/crebarctrl-class.md)   
 [CPane Class](../vs140/cpane-class.md)