---
title: "CMFCAutoHideButton Class"
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
  - "CMFCAutoHideButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCAutoHideButton class"
ms.assetid: c80e6b8b-25ca-4d12-9d27-457731028ab0
caps.latest.revision: 32
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCAutoHideButton Class
A button that displays or hides a [CDockablePane Class](../vs140/cdockablepane-class.md) that is configured to hide.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCAutoHideButton::BringToTop](#cmfcautohidebutton__bringtotop)||  
|[CMFCAutoHideButton::Create](#cmfcautohidebutton__create)|Creates and initializes the auto-hide button.|  
|[CMFCAutoHideButton::GetAlignment](#cmfcautohidebutton__getalignment)|Retrieves the alignment of the auto-hide button.|  
|[CMFCAutoHideButton::GetAutoHideWindow](#cmfcautohidebutton__getautohidewindow)|Returns the [CDockablePane](../vs140/cdockablepane-class.md) object associated with the auto-hide button.|  
|[CMFCAutoHideButton::GetParentToolBar](#cmfcautohidebutton__getparenttoolbar)||  
|[CMFCAutoHideButton::GetRect](#cmfcautohidebutton__getrect)||  
|[CMFCAutoHideButton::GetSize](#cmfcautohidebutton__getsize)|Determines the size of the auto-hide button.|  
|[CMFCAutoHideButton::GetTextSize](#cmfcautohidebutton__gettextsize)|Returns the size of the text label for the auto-hide button.|  
|[CMFCAutoHideButton::HighlightButton](#cmfcautohidebutton__highlightbutton)|Highlights auto hide button.|  
|[CMFCAutoHideButton::IsActive](#cmfcautohidebutton__isactive)|Indicates whether the auto-hide button is active.|  
|[CMFCAutoHideButton::IsHighlighted](#cmfcautohidebutton__ishighlighted)|Returns highlight state of auto hide button.|  
|[CMFCAutoHideButton::IsHorizontal](#cmfcautohidebutton__ishorizontal)|Determines whether the auto-hide button is horizontal or vertical.|  
|[CMFCAutoHideButton::IsTop](#cmfcautohidebutton__istop)||  
|[CMFCAutoHideButton::IsVisible](#cmfcautohidebutton__isvisible)|Indicates whether the button is visible.|  
|[CMFCAutoHideButton::Move](#cmfcautohidebutton__move)||  
|[CMFCAutoHideButton::OnDraw](#cmfcautohidebutton__ondraw)|The framework calls this method when it draws the auto-hide button.|  
|[CMFCAutoHideButton::OnDrawBorder](#cmfcautohidebutton__ondrawborder)|The framework calls this method when it draws the border of an auto-hide button.|  
|[CMFCAutoHideButton::OnFillBackground](#cmfcautohidebutton__onfillbackground)|The framework calls this method when it fills the background of an auto-hide button.|  
|[CMFCAutoHideButton::ReplacePane](#cmfcautohidebutton__replacepane)||  
|[CMFCAutoHideButton::ShowAttachedWindow](#cmfcautohidebutton__showattachedwindow)|Shows or hides the associated [CDockablePane Class](../vs140/cdockablepane-class.md).|  
|[CMFCAutoHideButton::ShowButton](#cmfcautohidebutton__showbutton)|Shows or hides the auto-hide button.|  
|[CMFCAutoHideButton::UnSetAutoHideMode](#cmfcautohidebutton__unsetautohidemode)||  
  
## Remarks  
 On creation, the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> object is attached to a [CDockablePane Class](../vs140/cdockablepane-class.md). The <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> object is hidden or displayed as the user interacts with the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> object.  
  
 By default, the framework automatically creates a <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> when the user turns on auto-hide. The framework can create an element of a custom UI class instead of the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> class. To specify which custom UI class the framework should use, set the static member variable <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> equal to the custom UI class. By default, this variable is set to <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.  
  
## Example  
 The following example demonstrates how to construct a <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> object and use various methods in the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> class. The example shows how to initialize a <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> object by using its <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> method, show the associated <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> class, and show the auto-hide button.  
  
 [!code[NVC_MFC_RibbonApp#32](../vs140/codesnippet/CPP/cmfcautohidebutton-class_1.cpp)]  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CMFCAutoHideButton](../vs140/cmfcautohidebutton-class.md)  
  
## Requirements  
 **Header:** afxautohidebutton.h  
  
##  \<a name="cmfcautohidebutton__bringtotop">\</a>  CMFCAutoHideButton::BringToTop  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmfcautohidebutton__create">\</a>  CMFCAutoHideButton::Create  
 Creates and initializes an auto-hide button.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 A pointer to the parent toolbar.  
  
 [in] <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 A pointer to a [CDockablePane](../vs140/cdockablepane-class.md) object. This auto-hide button hides and shows that <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 A value that specifies the alignment of the button with the main frame window.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 When you create a [CMFCAutoHideButton](../vs140/cmfcautohidebutton-class.md) object, you must associate the auto-hide button with a specific <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>. The user can use the auto-hide button to hide and show the associated <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>.  
  
 The <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> parameter indicates where the auto-hide button resides in the application. The parameter can be any one of the following values:  
  
-   <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
  
##  \<a name="cmfcautohidebutton__getalignment">\</a>  CMFCAutoHideButton::GetAlignment  
 Retrieves the alignment of the auto-hide button.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 A <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> value that contains the current alignment of the auto-hide button.  
  
### Remarks  
 The alignment of the auto-hide button indicates where the button resides on the application. It can be any one of the following values:  
  
-   <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
  
##  \<a name="cmfcautohidebutton__getautohidewindow">\</a>  CMFCAutoHideButton::GetAutoHideWindow  
 Returns the [CDockablePane](../vs140/cdockablepane-class.md) object associated with the auto-hide button.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the associated <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> object.  
  
### Remarks  
 To associate an auto-hide button with a <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>, pass the <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> as a parameter to the [CMFCAutoHideButton::Create](#cmfcautohidebutton__create) method.  
  
##  \<a name="cmfcautohidebutton__getparenttoolbar">\</a>  CMFCAutoHideButton::GetParentToolBar  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcautohidebutton__getrect">\</a>  CMFCAutoHideButton::GetRect  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcautohidebutton__getsize">\</a>  CMFCAutoHideButton::GetSize  
 Determines the size of the auto-hide button.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 A <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> object that contains the button size.  
  
### Remarks  
 The calculated size includes the size of the border of the auto-hide button.  
  
##  \<a name="cmfcautohidebutton__gettextsize">\</a>  CMFCAutoHideButton::GetTextSize  
 Returns the size of the text label for the auto-hide button.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 A [CSize](../vs140/csize-class.md) object that contains the size of the text for the auto-hide button.  
  
##  \<a name="cmfcautohidebutton__isactive">\</a>  CMFCAutoHideButton::IsActive  
 Indicates whether the auto-hide button is active.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> if the auto-hide button is active; <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> otherwise.  
  
### Remarks  
 An auto-hide button is active when the associated [CDockablePane Class](../vs140/cdockablepane-class.md) window is shown.  
  
##  \<a name="cmfcautohidebutton__ishorizontal">\</a>  CMFCAutoHideButton::IsHorizontal  
 Determines whether the auto-hide button is horizontal or vertical.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the button is horizontal; 0 otherwise.  
  
### Remarks  
 The framework sets the orientation of a [CMFCAutoHideButton](../vs140/cmfcautohidebutton-class.md) object when you create it.  You can control the orientation by using the <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> parameter in the [CMFCAutoHideButton::Create](#cmfcautohidebutton__create) method.  
  
##  \<a name="cmfcautohidebutton__istop">\</a>  CMFCAutoHideButton::IsTop  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcautohidebutton__isvisible">\</a>  CMFCAutoHideButton::IsVisible  
 Indicates whether the auto-hide button is visible.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> if the button is visible; <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> otherwise.  
  
##  \<a name="cmfcautohidebutton__ondraw">\</a>  CMFCAutoHideButton::OnDraw  
 The framework calls this method when it draws the auto-hide button.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
### Remarks  
 If you want to customize the appearance of auto-hide buttons in your application, create a new class derived from the [CMFCAutoHideButton Class](../vs140/cmfcautohidebutton-class.md). In your derived class, override this method.  
  
##  \<a name="cmfcautohidebutton__ondrawborder">\</a>  CMFCAutoHideButton::OnDrawBorder  
 The framework calls this method when it draws the border of an auto-hide button.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
 The bounding rectangle of the auto-hide button.  
  
 [in] <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
 The border thickness for each side of the auto-hide button.  
  
### Remarks  
 If you want to customize the border of each auto-hide button in your application, create a new class derived from the [CMFCAutoHideButton Class](../vs140/cmfcautohidebutton-class.md). In your derived class, override this method.  
  
##  \<a name="cmfcautohidebutton__onfillbackground">\</a>  CMFCAutoHideButton::OnFillBackground  
 The framework calls this method when it fills the background of an auto-hide button.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
 The bounding rectangle of the auto-hide button.  
  
### Remarks  
 If you want to customize the background for auto-hide buttons in your application, create a new class derived from the [CMFCAutoHideButton Class](../vs140/cmfcautohidebutton-class.md). In your derived class, override this method.  
  
##  \<a name="cmfcautohidebutton__showattachedwindow">\</a>  CMFCAutoHideButton::ShowAttachedWindow  
 Shows or hides the associated [CDockablePane Class](../vs140/cdockablepane-class.md).  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
 A Boolean that specifies whether this method shows the attached <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcautohidebutton__showbutton">\</a>  CMFCAutoHideButton::ShowButton  
 Shows or hides the auto-hide button.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
 A Boolean that specifies whether to show the auto-hide button.  
  
##  \<a name="cmfcautohidebutton__move">\</a>  CMFCAutoHideButton::Move  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcautohidebutton__replacepane">\</a>  CMFCAutoHideButton::ReplacePane  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcautohidebutton__unsetautohidemode">\</a>  CMFCAutoHideButton::UnSetAutoHideMode  
 Disable auto-hide mode.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
 A pointer to the first bar in the group.  
  
### Remarks  
  
##  \<a name="cmfcautohidebutton__highlightbutton">\</a>  CMFCAutoHideButton::HighlightButton  
 Highlights the auto hide button.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
 Specifies the new auto hide button state. <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> indicates the button is highlighted, <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> indicates the button is not highlighted.  
  
### Remarks  
  
##  \<a name="cmfcautohidebutton__ishighlighted">\</a>  CMFCAutoHideButton::IsHighlighted  
 Returns the highlight state of the auto hide button.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Return Value  
 Returns <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> if the auto hide button is highlighted; otherwise <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>.  
  
### Remarks  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CMFCAutoHideBar Class](../vs140/cmfcautohidebar-class.md)   
 [CAutoHideDockSite Class](../vs140/cautohidedocksite-class.md)