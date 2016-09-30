---
title: "CMFCRibbonStatusBar Class"
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
  - "CMFCRibbonStatusBar"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCRibbonStatusBar class"
ms.assetid: 921eb57f-3b40-49fa-a38c-3f2fb6dc2893
caps.latest.revision: 36
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonStatusBar Class
The <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> class implements a status bar control that can display ribbon elements.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCRibbonStatusBar::AddDynamicElement](#cmfcribbonstatusbar__adddynamicelement)|Adds a dynamic element to the ribbon status bar.|  
|[CMFCRibbonStatusBar::AddElement](#cmfcribbonstatusbar__addelement)|Adds a new ribbon element to the ribbon status bar.|  
|[CMFCRibbonStatusBar::AddExtendedElement](#cmfcribbonstatusbar__addextendedelement)|Adds a ribbon element to the extended area of the ribbon status bar.|  
|[CMFCRibbonStatusBar::AddSeparator](#cmfcribbonstatusbar__addseparator)|Adds a separator to the ribbon status bar.|  
|[CMFCRibbonStatusBar::Create](#cmfcribbonstatusbar__create)|Creates a ribbon status bar.|  
|[CMFCRibbonStatusBar::CreateEx](#cmfcribbonstatusbar__createex)|Creates a ribbon status bar with an extended style.|  
|[CMFCRibbonStatusBar::FindByID](#cmfcribbonstatusbar__findbyid)||  
|[CMFCRibbonStatusBar::FindElement](#cmfcribbonstatusbar__findelement)|Returns a pointer to the element that has the specified command ID.|  
|[CMFCRibbonStatusBar::GetCount](#cmfcribbonstatusbar__getcount)|Returns the number of elements that are located in the main area of the ribbon status bar.|  
|[CMFCRibbonStatusBar::GetElement](#cmfcribbonstatusbar__getelement)|Returns a pointer to the element that is located at a specified index.|  
|[CMFCRibbonStatusBar::GetExCount](#cmfcribbonstatusbar__getexcount)|Returns the number of elements that are located in the extended area of the ribbon status bar.|  
|[CMFCRibbonStatusBar::GetExElement](#cmfcribbonstatusbar__getexelement)|Returns a pointer to the element that is located at a specified index in the extended area of the ribbon status bar.|  
|[CMFCRibbonStatusBar::GetExtendedArea](#cmfcribbonstatusbar__getextendedarea)||  
|[CMFCRibbonStatusBar::GetSpace](#cmfcribbonstatusbar__getspace)||  
|[CMFCRibbonStatusBar::IsBottomFrame](#cmfcribbonstatusbar__isbottomframe)||  
|[CMFCRibbonStatusBar::IsExtendedElement](#cmfcribbonstatusbar__isextendedelement)||  
|[CMFCRibbonStatusBar::IsInformationMode](#cmfcribbonstatusbar__isinformationmode)|Determines whether information mode is enabled for the ribbon status bar.|  
|[CMFCRibbonStatusBar::RecalcLayout](#cmfcribbonstatusbar__recalclayout)|(Overrides [CMFCRibbonBar::RecalcLayout](../vs140/cmfcribbonbar-class.md#cmfcribbonbar__recalclayout).)|  
|[CMFCRibbonStatusBar::RemoveAll](#cmfcribbonstatusbar__removeall)|Removes all elements from the ribbon status bar.|  
|[CMFCRibbonStatusBar::RemoveElement](#cmfcribbonstatusbar__removeelement)|Removes the element that has a specified command ID from the ribbon status bar.|  
|[CMFCRibbonStatusBar::SetInformation](#cmfcribbonstatusbar__setinformation)|Enables or disables the information mode for the ribbon status bar.|  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCRibbonStatusBar::OnDrawInformation](#cmfcribbonstatusbar__ondrawinformation)|Displays the information string that appears on the ribbon status bar when the information mode is enabled.|  
  
## Remarks  
 Users can change the visibility of ribbon elements on a ribbon status bar by using the built-in context menu for the ribbon status bar. You can add or remove elements dynamically.  
  
 A ribbon status bar has two areas: a main area and an extended area. The extended area is displayed on the right side of the ribbon status bar and appears in a different color than the main area does.  
  
 Typically, the main area of the status bar displays status notifications, and the extended area displays view controls. The extended area remains visible as long as possible when the user resizes the ribbon status bar.  
  
## Example  
 The following example demonstrates how to use various methods in the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> class. The example shows how to add a new ribbon element to the ribbon status bar, add a ribbon element to the extended area of the ribbon status bar, add a separator, and enable the regular mode for the ribbon status bar.  
  
 [!code[NVC_MFC_RibbonApp#15](../vs140/codesnippet/CPP/cmfcribbonstatusbar-class_1.cpp)]  
[!code[NVC_MFC_RibbonApp#16](../vs140/codesnippet/CPP/cmfcribbonstatusbar-class_2.cpp)]  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CBasePane](../vs140/cbasepane-class.md)  
  
 [CPane](../vs140/cpane-class.md)  
  
 [CMFCRibbonBar](../vs140/cmfcribbonbar-class.md)  
  
 [CMFCRibbonStatusBar](../vs140/cmfcribbonstatusbar-class.md)  
  
## Requirements  
 **Header:** afxribbonstatusbar.h  
  
##  \<a name="cmfcribbonstatusbar__adddynamicelement">\</a>  CMFCRibbonStatusBar::AddDynamicElement  
 Adds a dynamic element to the ribbon status bar.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 A pointer to a dynamic element.  
  
### Remarks  
 Unlike regular elements, dynamic elements are not customizable and the customize menu of the status bar does not display them.  
  
##  \<a name="cmfcribbonstatusbar__addelement">\</a>  CMFCRibbonStatusBar::AddElement  
 Adds a new ribbon element to the ribbon status bar.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 A pointer to the added element.  
  
 [in] <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 A text label of the element.  
  
 [in] <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> if you want to add the element as visible, <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> if you want to add the element as hidden.  
  
##  \<a name="cmfcribbonstatusbar__addextendedelement">\</a>  CMFCRibbonStatusBar::AddExtendedElement  
 Adds a ribbon element to the extended area of the ribbon status bar.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 A pointer to the added element.  
  
 [in] <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 The text label of the element.  
  
 [in] <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> if you want to add the element as visible, <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> if you want to add the element as hidden.  
  
### Remarks  
 The extended area is on the right side of the status bar control.  
  
##  \<a name="cmfcribbonstatusbar__addseparator">\</a>  CMFCRibbonStatusBar::AddSeparator  
 Adds a separator to the ribbon status bar.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
 The framework adds a separator after the method [AddElement](#cmfcribbonstatusbar__addelement). inserts the last element.  
  
##  \<a name="cmfcribbonstatusbar__create">\</a>  CMFCRibbonStatusBar::Create  
 Creates a ribbon status bar.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 A pointer to the parent window.  
  
 [in] <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 A logical OR combination of control styles.  
  
 [in] <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 The control ID of the status bar.  
  
### Return Value  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> if the status bar is created successfully, <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> otherwise.  
  
##  \<a name="cmfcribbonstatusbar__createex">\</a>  CMFCRibbonStatusBar::CreateEx  
 Creates a ribbon status bar that has an extended style.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 A pointer to the parent window.  
  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 A logical OR combination of additional styles for creating the status bar object.  
  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 The control style of the status bar.  
  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 The control ID of the status bar.  
  
### Return Value  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> if the status bar is created successfully, <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> otherwise.  
  
##  \<a name="cmfcribbonstatusbar__findbyid">\</a>  CMFCRibbonStatusBar::FindByID  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcribbonstatusbar__findelement">\</a>  CMFCRibbonStatusBar::FindElement  
 Returns a pointer to the element that has the specified command ID.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
 The ID of the element.  
  
### Return Value  
 A pointer to the element that has the specified command ID. <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> if there is no such element.  
  
##  \<a name="cmfcribbonstatusbar__getcount">\</a>  CMFCRibbonStatusBar::GetCount  
 Returns the number of elements that are located in the main area of the ribbon status bar.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 The number of elements that are located in the main area of the ribbon status bar.  
  
##  \<a name="cmfcribbonstatusbar__getelement">\</a>  CMFCRibbonStatusBar::GetElement  
 Returns a pointer to the element that is located at a specified index.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 Specifies a zero-based index of an element that is located in the main area of the status bar control.  
  
### Return Value  
 A pointer to the element that is located at the specified index. <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> if the index is negative or exceeds the number of elements in the status bar.  
  
### Remarks  
  
##  \<a name="cmfcribbonstatusbar__getexcount">\</a>  CMFCRibbonStatusBar::GetExCount  
 Returns the number of elements that are located in the extended area of the ribbon status bar.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 The number of elements that are located in the extended area of the ribbon status bar.  
  
##  \<a name="cmfcribbonstatusbar__getexelement">\</a>  CMFCRibbonStatusBar::GetExElement  
 Returns a pointer to the element that is located at a specified index in the extended area of the ribbon status bar. The extended area is on the right side of the status bar control.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 Specifies the zero-based index of an element that is located in the extended area of the status bar control.  
  
### Return Value  
 A pointer to the element that is located at a specified index in the extended area of the ribbon status bar. <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> is negative or exceeds the number of elements in the extended area of the ribbon status bar.  
  
### Remarks  
  
##  \<a name="cmfcribbonstatusbar__getextendedarea">\</a>  CMFCRibbonStatusBar::GetExtendedArea  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcribbonstatusbar__getspace">\</a>  CMFCRibbonStatusBar::GetSpace  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcribbonstatusbar__isbottomframe">\</a>  CMFCRibbonStatusBar::IsBottomFrame  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcribbonstatusbar__isextendedelement">\</a>  CMFCRibbonStatusBar::IsExtendedElement  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcribbonstatusbar__isinformationmode">\</a>  CMFCRibbonStatusBar::IsInformationMode  
 Determines whether information mode is enabled for the ribbon status bar.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> if the status bar can work in information mode; otherwise <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>.  
  
### Remarks  
 In information mode, the status bar hides all regular panes and displays a message string.  
  
##  \<a name="cmfcribbonstatusbar__ondrawinformation">\</a>  CMFCRibbonStatusBar::OnDrawInformation  
 Displays the string that appears on the ribbon status bar when the information mode is enabled.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
 The information string.  
  
 [in] <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
 The bounding rectangle.  
  
### Remarks  
 Override this method in a derived class if you want to customize the appearance of the information string on the status bar. Use the [SetInformation](#cmfcribbonstatusbar__setinformation) method to put the status bar in information mode. In this mode, the status bar hides all panes and displays the information string specified by <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcribbonstatusbar__recalclayout">\</a>  CMFCRibbonStatusBar::RecalcLayout  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmfcribbonstatusbar__removeall">\</a>  CMFCRibbonStatusBar::RemoveAll  
 Removes all elements from the ribbon status bar.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
##  \<a name="cmfcribbonstatusbar__removeelement">\</a>  CMFCRibbonStatusBar::RemoveElement  
 Removes the element that has a specified command ID from the ribbon status bar.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
 The ID of the element to remove from the status bar.  
  
### Return Value  
 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> if an element with the specified <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> is removed. <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> otherwise.  
  
##  \<a name="cmfcribbonstatusbar__setinformation">\</a>  CMFCRibbonStatusBar::SetInformation  
 Enables or disables the information mode for the ribbon status bar.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
 The information string.  
  
### Remarks  
 Use this method to put the status bar in the information mode. In this mode, the status bar hides all panes and displays the information string specified by <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>.  
  
 When lpszInfo is <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>, the status bar reverts to regular mode.  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CMFCRibbonBar](../vs140/cmfcribbonbar-class.md)   
 [CMFCBaseRibbonElement](../vs140/cmfcribbonbaseelement-class.md)   
 [CMFCRibbonBar](../vs140/cmfcribbonbar-class.md)