---
title: "CMFCVisualManagerVS2005 Class"
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
  - "CMFCVisualManagerVS2005"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCVisualManagerVS2005 class"
ms.assetid: ea39b9ae-327e-4a51-bce7-dc84c78f005b
caps.latest.revision: 29
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManagerVS2005 Class
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder> gives an application a Microsoft Visual Studio 2005 appearance.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCVisualManagerVS2005::GetDockingTabsBordersSize](#cmfcvisualmanagervs2005__getdockingtabsborderssize)|The framework calls this method when it draws a pane that is docked and tabbed. (Overrides [CMFCVisualManager::GetDockingTabsBordersSize](../vs140/cmfcvisualmanager-class.md#cmfcvisualmanager__getdockingtabsborderssize).)|  
|[CMFCVisualManagerVS2005::GetMDITabsBordersSize](#cmfcvisualmanagervs2005__getmditabsborderssize)|The framework calls this method to determine the border size of a MDITabs window before it draws the window. (Overrides [CMFCVisualManager::GetMDITabsBordersSize](../vs140/cmfcvisualmanager-class.md#cmfcvisualmanager__getmditabsborderssize).)|  
|[CMFCVisualManagerVS2005::GetPropertyGridGroupColor](#cmfcvisualmanagervs2005__getpropertygridgroupcolor)|(Overrides [CMFCVisualManagerOffice2003::GetPropertyGridGroupColor](../vs140/cmfcvisualmanageroffice2003-class.md#cmfcvisualmanageroffice2003__getpropertygridgroupcolor).)|  
|[CMFCVisualManagerVS2005::GetTabFrameColors](#cmfcvisualmanagervs2005__gettabframecolors)|(Overrides [CMFCVisualManagerOffice2003::GetTabFrameColors](../vs140/cmfcvisualmanageroffice2003-class.md#cmfcvisualmanageroffice2003__gettabframecolors).)|  
|[CMFCVisualManagerVS2005::HasOverlappedAutoHideButtons](#cmfcvisualmanagervs2005__hasoverlappedautohidebuttons)|Returns whether auto-hide buttons overlap in the current visual manager. (Overrides [CMFCVisualManager::HasOverlappedAutoHideButtons](../vs140/cmfcvisualmanager-class.md#cmfcvisualmanager__hasoverlappedautohidebuttons).)|  
|[CMFCVisualManagerVS2005::OnDrawAutoHideButtonBorder](#cmfcvisualmanagervs2005__ondrawautohidebuttonborder)|(Overrides [CMFCVisualManagerOffice2003::OnDrawAutoHideButtonBorder](../vs140/cmfcvisualmanageroffice2003-class.md#cmfcvisualmanageroffice2003__ondrawautohidebuttonborder).)|  
|[CMFCVisualManagerVS2005::OnDrawCaptionButton](#cmfcvisualmanagervs2005__ondrawcaptionbutton)|(Overrides <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.)|  
|[CMFCVisualManagerVS2005::OnDrawPaneCaption](#cmfcvisualmanagervs2005__ondrawpanecaption)|(Overrides [CMFCVisualManagerOffice2003::OnDrawPaneCaption](../vs140/cmfcvisualmanageroffice2003-class.md#cmfcvisualmanageroffice2003__ondrawpanecaption).)|  
|[CMFCVisualManagerVS2005::OnDrawSeparator](#cmfcvisualmanagervs2005__ondrawseparator)|(Overrides [CMFCVisualManagerOffice2003::OnDrawSeparator](../vs140/cmfcvisualmanageroffice2003-class.md#cmfcvisualmanageroffice2003__ondrawseparator).)|  
|[CMFCVisualManagerVS2005::OnDrawTab](#cmfcvisualmanagervs2005__ondrawtab)|(Overrides [CMFCVisualManagerOffice2003::OnDrawTab](../vs140/cmfcvisualmanageroffice2003-class.md#cmfcvisualmanageroffice2003__ondrawtab).)|  
|[CMFCVisualManagerVS2005::OnDrawToolBoxFrame](#cmfcvisualmanagervs2005__ondrawtoolboxframe)|(Overrides [CMFCVisualManager::OnDrawToolBoxFrame](../vs140/cmfcvisualmanager-class.md#cmfcvisualmanager__ondrawtoolboxframe).)|  
|[CMFCVisualManagerVS2005::OnEraseTabsArea](#cmfcvisualmanagervs2005__onerasetabsarea)|(Overrides [CMFCVisualManagerOffice2003::OnEraseTabsArea](../vs140/cmfcvisualmanageroffice2003-class.md#cmfcvisualmanageroffice2003__onerasetabsarea).)|  
|[CMFCVisualManagerVS2005::OnFillAutoHideButtonBackground](#cmfcvisualmanagervs2005__onfillautohidebuttonbackground)|(Overrides [CMFCVisualManagerOffice2003::OnFillAutoHideButtonBackground](../vs140/cmfcvisualmanageroffice2003-class.md#cmfcvisualmanageroffice2003__onfillautohidebuttonbackground).)|  
|[CMFCVisualManagerVS2005::OnFillHighlightedArea](#cmfcvisualmanagervs2005__onfillhighlightedarea)|(Overrides [CMFCVisualManagerOffice2003::OnFillHighlightedArea](../vs140/cmfcvisualmanageroffice2003-class.md#cmfcvisualmanageroffice2003__onfillhighlightedarea).)|  
|[CMFCVisualManagerVS2005::OnFillMiniFrameCaption](#cmfcvisualmanagervs2005__onfillminiframecaption)|(Overrides <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.)|  
|[CMFCVisualManagerVS2005::OnUpdateSystemColors](#cmfcvisualmanagervs2005__onupdatesystemcolors)|(Overrides [CMFCVisualManagerOffice2003::OnUpdateSystemColors](../vs140/cmfcvisualmanageroffice2003-class.md#cmfcvisualmanageroffice2003__onupdatesystemcolors).)|  
  
## Remarks  
 You use the CMFCVisualManagerVS2005 class to change the visual appearance of your application to resemble that of the [!INCLUDE[vsprvsext](../vs140/includes/vsprvsext_md.md)].  
  
 All of the members of this class are virtual functions that are derived from the ancestor of this class, [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md).  
  
## Example  
 The following example demonstrates how to use the visual manager VS 2005. This code snippet is part of the [Desktop Alert Demo sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_DesktopAlertDemo#9](../vs140/codesnippet/CPP/cmfcvisualmanagervs2005-class_1.cpp)]  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CMFCBaseVisualManager](../vs140/cmfcbasevisualmanager-class.md)  
  
 [CMFCVisualManager](../vs140/cmfcvisualmanager-class.md)  
  
 [CMFCVisualManagerOfficeXP](../vs140/cmfcvisualmanagerofficexp-class.md)  
  
 [CMFCVisualManagerOffice2003](../vs140/cmfcvisualmanageroffice2003-class.md)  
  
 [CMFCVisualManagerVS2005](../vs140/cmfcvisualmanagervs2005-class.md)  
  
## Requirements  
 **Header:** afxvisualmanagervs2005.h  
  
##  \<a name="cmfcvisualmanagervs2005__getdockingtabsborderssize">\</a>  CMFCVisualManagerVS2005::GetDockingTabsBordersSize  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagervs2005__getmditabsborderssize">\</a>  CMFCVisualManagerVS2005::GetMDITabsBordersSize  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagervs2005__getpropertygridgroupcolor">\</a>  CMFCVisualManagerVS2005::GetPropertyGridGroupColor  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagervs2005__gettabframecolors">\</a>  CMFCVisualManagerVS2005::GetTabFrameColors  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagervs2005__hasoverlappedautohidebuttons">\</a>  CMFCVisualManagerVS2005::HasOverlappedAutoHideButtons  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagervs2005__ondrawautohidebuttonborder">\</a>  CMFCVisualManagerVS2005::OnDrawAutoHideButtonBorder  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagervs2005__ondrawcaptionbutton">\</a>  CMFCVisualManagerVS2005::OnDrawCaptionButton  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagervs2005__ondrawpanecaption">\</a>  CMFCVisualManagerVS2005::OnDrawPaneCaption  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagervs2005__ondrawseparator">\</a>  CMFCVisualManagerVS2005::OnDrawSeparator  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagervs2005__ondrawtab">\</a>  CMFCVisualManagerVS2005::OnDrawTab  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagervs2005__ondrawtoolboxframe">\</a>  CMFCVisualManagerVS2005::OnDrawToolBoxFrame  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagervs2005__onerasetabsarea">\</a>  CMFCVisualManagerVS2005::OnEraseTabsArea  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagervs2005__onfillautohidebuttonbackground">\</a>  CMFCVisualManagerVS2005::OnFillAutoHideButtonBackground  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagervs2005__onfillhighlightedarea">\</a>  CMFCVisualManagerVS2005::OnFillHighlightedArea  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagervs2005__onfillminiframecaption">\</a>  CMFCVisualManagerVS2005::OnFillMiniFrameCaption  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagervs2005__onupdatesystemcolors">\</a>  CMFCVisualManagerVS2005::OnUpdateSystemColors  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Remarks  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [CMFCVisualManagerOfficeXP Class](../vs140/cmfcvisualmanagerofficexp-class.md)   
 [CMFCVisualManagerWindows Class](../vs140/cmfcvisualmanagerwindows-class.md)   
 [CMFCVisualManagerOffice2003 Class](../vs140/cmfcvisualmanageroffice2003-class.md)   
 [CMFCVisualManager::SetDefaultManager](../vs140/cmfcvisualmanager-class.md#cmfcvisualmanager__setdefaultmanager)