---
title: "CMFCRibbonButton Class"
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
  - "CMFCRibbonButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCRibbonButton class"
ms.assetid: 732e941c-9504-4b83-a691-d18075965d53
caps.latest.revision: 41
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonButton Class
The <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> class implements buttons that you can position on ribbon bar elements such as panels, Quick Access Toolbars, and pop-up menus.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCRibbonButton::CBCGPRibbonButton](#cmfcribbonbutton__cmfcribbonbutton)|Constructs a ribbon button object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCRibbonButton::AddSubItem](#cmfcribbonbutton__addsubitem)|Adds a menu item to the pop-up menu that is associated with the button.|  
|[CMFCRibbonButton::CanBeStretched](#cmfcribbonbutton__canbestretched)|(Overrides [CMFCRibbonBaseElement::CanBeStretched](../vs140/cmfcribbonbaseelement-class.md#cmfcribbonbaseelement__canbestretched).)|  
|[CMFCRibbonButton::CleanUpSizes](#cmfcribbonbutton__cleanupsizes)|(Overrides [CMFCRibbonBaseElement::CleanUpSizes](../vs140/cmfcribbonbaseelement-class.md#cmfcribbonbaseelement__cleanupsizes).)|  
|[CMFCRibbonButton::ClosePopupMenu](#cmfcribbonbutton__closepopupmenu)|(Overrides [CMFCRibbonBaseElement::ClosePopupMenu](../vs140/cmfcribbonbaseelement-class.md#cmfcribbonbaseelement__closepopupmenu).)|  
|[CMFCRibbonButton::DrawBottomText](#cmfcribbonbutton__drawbottomtext)||  
|[CMFCRibbonButton::DrawImage](#cmfcribbonbutton__drawimage)|(Overrides [CMFCRibbonBaseElement::DrawImage](../vs140/cmfcribbonbaseelement-class.md#cmfcribbonbaseelement__drawimage).)|  
|[CMFCRibbonButton::DrawRibbonText](#cmfcribbonbutton__drawribbontext)||  
|[CMFCRibbonButton::FindSubItemIndexByID](#cmfcribbonbutton__findsubitemindexbyid)|Returns the index of a pop-up menu item that is associated with the specified command ID.|  
|[CMFCRibbonButton::GetCommandRect](#cmfcribbonbutton__getcommandrect)||  
|[CMFCRibbonButton::GetCompactSize](#cmfcribbonbutton__getcompactsize)|Returns the compact size of the ribbon element. (Overrides [CMFCRibbonBaseElement::GetCompactSize](../vs140/cmfcribbonbaseelement-class.md#cmfcribbonbaseelement__getcompactsize).)|  
|[CMFCRibbonButton::GetIcon](#cmfcribbonbutton__geticon)||  
|[CMFCRibbonButton::GetImageIndex](#cmfcribbonbutton__getimageindex)|Returns the index of the image that is associated with the button.|  
|[CMFCRibbonButton::GetImageSize](#cmfcribbonbutton__getimagesize)|Returns the image size of the ribbon element. (Overrides [CMFCRibbonBaseElement::GetImageSize](../vs140/cmfcribbonbaseelement-class.md#cmfcribbonbaseelement__getimagesize).)|  
|[CMFCRibbonButton::GetIntermediateSize](#cmfcribbonbutton__getintermediatesize)|Returns the size of the ribbon element in its intermediate state. (Overrides [CMFCRibbonBaseElement::GetIntermediateSize](../vs140/cmfcribbonbaseelement-class.md#cmfcribbonbaseelement__getintermediatesize).)|  
|[CMFCRibbonButton::GetMenu](#cmfcribbonbutton__getmenu)|Returns a handle to a Windows menu that is assigned to the ribbon button.|  
|[CMFCRibbonButton::GetMenuRect](#cmfcribbonbutton__getmenurect)||  
|[CMFCRibbonButton::GetRegularSize](#cmfcribbonbutton__getregularsize)|Returns the regular size of the ribbon element. (Overrides [CMFCRibbonBaseElement::GetRegularSize](../vs140/cmfcribbonbaseelement-class.md#cmfcribbonbaseelement__getregularsize).)|  
|[CMFCRibbonButton::GetSubItems](#cmfcribbonbutton__getsubitems)||  
|[CMFCRibbonButton::GetTextRowHeight](#cmfcribbonbutton__gettextrowheight)||  
|[CMFCRibbonButton::GetToolTipText](#cmfcribbonbutton__gettooltiptext)|Returns tooltip text of the ribbon element. (Overrides [CMFCRibbonBaseElement::GetToolTipText](../vs140/cmfcribbonbaseelement-class.md#cmfcribbonbaseelement__gettooltiptext).)|  
|[CMFCRibbonButton::HasCompactMode](#cmfcribbonbutton__hascompactmode)|Specifies whether the ribbon element has a compact mode. (Overrides [CMFCRibbonBaseElement::HasCompactMode](../vs140/cmfcribbonbaseelement-class.md#cmfcribbonbaseelement__hascompactmode).)|  
|[CMFCRibbonButton::HasIntermediateMode](#cmfcribbonbutton__hasintermediatemode)|Specifies whether the ribbon element has an intermediate mode. (Overrides [CMFCRibbonBaseElement::HasIntermediateMode](../vs140/cmfcribbonbaseelement-class.md#cmfcribbonbaseelement__hasintermediatemode).)|  
|[CMFCRibbonButton::HasLargeMode](#cmfcribbonbutton__haslargemode)|Determines whether the ribbon element has a large mode. (Overrides [CMFCRibbonBaseElement::HasLargeMode](../vs140/cmfcribbonbaseelement-class.md#cmfcribbonbaseelement__haslargemode).)|  
|[CMFCRibbonButton::HasMenu](#cmfcribbonbutton__hasmenu)|(Overrides [CMFCRibbonBaseElement::HasMenu](../vs140/cmfcribbonbaseelement-class.md#cmfcribbonbaseelement__hasmenu).)|  
|[CMFCRibbonButton::IsAlwaysDrawBorder](#cmfcribbonbutton__isalwaysdrawborder)||  
|[CMFCRibbonButton::IsAlwaysLargeImage](#cmfcribbonbutton__isalwayslargeimage)|(Overrides [CMFCRibbonBaseElement::IsAlwaysLargeImage](../vs140/cmfcribbonbaseelement-class.md#cmfcribbonbaseelement__isalwayslargeimage).)|  
|[CMFCRibbonButton::IsApplicationButton](#cmfcribbonbutton__isapplicationbutton)||  
|[CMFCRibbonButton::IsCommandAreaHighlighted](#cmfcribbonbutton__iscommandareahighlighted)||  
|[CMFCRibbonButton::IsDefaultCommand](#cmfcribbonbutton__isdefaultcommand)|Determines whether you have enabled the default command for a ribbon button.|  
|[CMFCRibbonButton::IsDefaultPanelButton](#cmfcribbonbutton__isdefaultpanelbutton)||  
|[CMFCRibbonButton::IsDrawTooltipImage](#cmfcribbonbutton__isdrawtooltipimage)||  
|[CMFCRibbonButton::IsLargeImage](#cmfcribbonbutton__islargeimage)||  
|[CMFCRibbonButton::IsMenuAreaHighlighted](#cmfcribbonbutton__ismenuareahighlighted)||  
|[CMFCRibbonButton::IsMenuOnBottom](#cmfcribbonbutton__ismenuonbottom)||  
|[CMFCRibbonButton::IsPopupDefaultMenuLook](#cmfcribbonbutton__ispopupdefaultmenulook)||  
|[CMFCRibbonButton::IsRightAlignMenu](#cmfcribbonbutton__isrightalignmenu)|Determines whether the menu is right-aligned.|  
|[CMFCRibbonButton::IsSingleLineText](#cmfcribbonbutton__issinglelinetext)||  
|[CMFCRibbonButton::OnCalcTextSize](#cmfcribbonbutton__oncalctextsize)|(Overrides [CMFCRibbonBaseElement::OnCalcTextSize](../vs140/cmfcribbonbaseelement-class.md#cmfcribbonbaseelement__oncalctextsize).)|  
|[CMFCRibbonButton::OnDrawBorder](#cmfcribbonbutton__ondrawborder)||  
|[CMFCRibbonButton::OnDraw](#cmfcribbonbutton__ondraw)|Called by the framework to draw the ribbon element. (Overrides [CMFCRibbonBaseElement::OnDraw](../vs140/cmfcribbonbaseelement-class.md#cmfcribbonbaseelement__ondraw).)|  
|[CMFCRibbonButton::OnFillBackground](#cmfcribbonbutton__onfillbackground)||  
|[CMFCRibbonButton::RemoveAllSubItems](#cmfcribbonbutton__removeallsubitems)|Removes all menu items from the pop-up menu.|  
|[CMFCRibbonButton::RemoveSubItem](#cmfcribbonbutton__removesubitem)|Removes a menu item from the pop-up menu.|  
|[CMFCRibbonButton::SetACCData](#cmfcribbonbutton__setaccdata)|(Overrides [CMFCRibbonBaseElement::SetACCData](../vs140/cmfcribbonbaseelement-class.md#cmfcribbonbaseelement__setaccdata).)|  
|[CMFCRibbonButton::SetAlwaysLargeImage](#cmfcribbonbutton__setalwayslargeimage)|Specifies whether the button displays a large or a small image when the user collapses the button.|  
|[CMFCRibbonButton::SetDefaultCommand](#cmfcribbonbutton__setdefaultcommand)|Enables the default command for the ribbon button.|  
|[CMFCRibbonButton::SetDescription](#cmfcribbonbutton__setdescription)|Sets the description for the ribbon element. (Overrides [CMFCRibbonBaseElement::SetDescription](../vs140/cmfcribbonbaseelement-class.md#cmfcribbonbaseelement__setdescription).)|  
|[CMFCRibbonButton::SetImageIndex](#cmfcribbonbutton__setimageindex)|Assigns an index to the image of the button.|  
|[CMFCRibbonButton::SetMenu](#cmfcribbonbutton__setmenu)|Assigns a pop-up menu to the ribbon button.|  
|[CMFCRibbonButton::SetParentCategory](#cmfcribbonbutton__setparentcategory)|(Overrides [CMFCRibbonBaseElement::SetParentCategory](../vs140/cmfcribbonbaseelement-class.md#cmfcribbonbaseelement__setparentcategory).)|  
|[CMFCRibbonButton::SetRightAlignMenu](#cmfcribbonbutton__setrightalignmenu)|Aligns the pop-up menu to the right of the button.|  
|[CMFCRibbonButton::SetText](#cmfcribbonbutton__settext)|Sets the text for the ribbon element. (Overrides [CMFCRibbonBaseElement::SetText](../vs140/cmfcribbonbaseelement-class.md#cmfcribbonbaseelement__settext).)|  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCRibbonButton::OnClick](#cmfcribbonbutton__onclick)|Called by the framework when the user clicks the button.|  
  
## Example  
 The following example demonstrates how to use the various methods in the <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> class. The example shows how to construct an object of the <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> class, assign a pop-up menu to the ribbon button, set the description of the button, remove a menu item from the pop-up menu, and right align the pop-up menu to the edge of the button.  
  
 [!code[NVC_MFC_RibbonApp#7](../vs140/codesnippet/CPP/cmfcribbonbutton-class_1.cpp)]  
  
## Remarks  
 To use a ribbon button in an application, construct the button object and add it to the appropriate ribbon [panel](../vs140/cmfcribbonpanel-class.md).  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CMFCRibbonBaseElement](../vs140/cmfcribbonbaseelement-class.md)  
  
 [CMFCRibbonButton](../vs140/cmfcribbonbutton-class.md)  
  
## Requirements  
 **Header:** afxribbonbutton.h  
  
##  \<a name="cmfcribbonbutton__addsubitem">\</a>  CMFCRibbonButton::AddSubItem  
 Adds a menu item to the pop-up menu that is associated with the button.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
 Specifies a pointer to the new element to add.  
  
 [in] <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
 Specifies the index at which to add the element to the array of menu items of the button; -1 to add the element at the end of the array of menu items.  
  
##  \<a name="cmfcribbonbutton__canbestretched">\</a>  CMFCRibbonButton::CanBeStretched  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcribbonbutton__cleanupsizes">\</a>  CMFCRibbonButton::CleanUpSizes  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmfcribbonbutton__closepopupmenu">\</a>  CMFCRibbonButton::ClosePopupMenu  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmfcribbonbutton__cmfcribbonbutton">\</a>  CMFCRibbonButton::CMFCRibbonButton  
 Constructs a ribbon button object.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
 Specifies the command ID of the button.  
  
 [in] <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
 Specifies the text label of the button.  
  
 [in] <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
 Specifies a zero-based index of the button's small image in the image list of the parent category.  
  
 [in] <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
 Specifies a zero-based index of the button's large image in the image list of the parent category.  
  
 [in] <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
 Specifies a handle to the icon that the application uses as the button's image.  
  
### Example  
 The following example demonstrates how to construct a <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> object.  
  
 [!code[NVC_MFC_RibbonApp#6](../vs140/codesnippet/CPP/cmfcribbonbutton-class_2.cpp)]  
  
##  \<a name="cmfcribbonbutton__drawbottomtext">\</a>  CMFCRibbonButton::DrawBottomText  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcribbonbutton__drawimage">\</a>  CMFCRibbonButton::DrawImage  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcribbonbutton__drawribbontext">\</a>  CMFCRibbonButton::DrawRibbonText  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcribbonbutton__findsubitemindexbyid">\</a>  CMFCRibbonButton::FindSubItemIndexByID  
 Returns the index of a pop-up menu item that is associated with the specified command ID.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
 Specifies the command ID of the pop-up menu item.  
  
### Return Value  
 The zero-based index of the sub-item that is associated with the <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>. -1 if there is no such sub-item.  
  
##  \<a name="cmfcribbonbutton__getcommandrect">\</a>  CMFCRibbonButton::GetCommandRect  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcribbonbutton__getcompactsize">\</a>  CMFCRibbonButton::GetCompactSize  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcribbonbutton__geticon">\</a>  CMFCRibbonButton::GetIcon  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcribbonbutton__getimageindex">\</a>  CMFCRibbonButton::GetImageIndex  
 Returns the index of the image that is associated with the button.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>, returns the image index in the image list that contains the large images; otherwise returns the image index in the image list that contains the small images.  
  
### Return Value  
 The index of the button's image in the associated image list.  
  
##  \<a name="cmfcribbonbutton__getimagesize">\</a>  CMFCRibbonButton::GetImageSize  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcribbonbutton__getintermediatesize">\</a>  CMFCRibbonButton::GetIntermediateSize  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcribbonbutton__getmenu">\</a>  CMFCRibbonButton::GetMenu  
 Returns a handle to a Windows menu that is assigned to the ribbon button.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Return Value  
 A handle to a Windows menu assigned to the button; <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> if there is no menu assigned.  
  
##  \<a name="cmfcribbonbutton__getmenurect">\</a>  CMFCRibbonButton::GetMenuRect  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcribbonbutton__getregularsize">\</a>  CMFCRibbonButton::GetRegularSize  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcribbonbutton__getsubitems">\</a>  CMFCRibbonButton::GetSubItems  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcribbonbutton__gettextrowheight">\</a>  CMFCRibbonButton::GetTextRowHeight  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcribbonbutton__gettooltiptext">\</a>  CMFCRibbonButton::GetToolTipText  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcribbonbutton__hascompactmode">\</a>  CMFCRibbonButton::HasCompactMode  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcribbonbutton__hasintermediatemode">\</a>  CMFCRibbonButton::HasIntermediateMode  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcribbonbutton__haslargemode">\</a>  CMFCRibbonButton::HasLargeMode  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcribbonbutton__hasmenu">\</a>  CMFCRibbonButton::HasMenu  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcribbonbutton__isalwaysdrawborder">\</a>  CMFCRibbonButton::IsAlwaysDrawBorder  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcribbonbutton__isalwayslargeimage">\</a>  CMFCRibbonButton::IsAlwaysLargeImage  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcribbonbutton__isapplicationbutton">\</a>  CMFCRibbonButton::IsApplicationButton  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcribbonbutton__iscommandareahighlighted">\</a>  CMFCRibbonButton::IsCommandAreaHighlighted  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcribbonbutton__isdefaultcommand">\</a>  CMFCRibbonButton::IsDefaultCommand  
 Specifies whether the default command for a ribbon button is enabled.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> if you have enabled the default command for a ribbon button; <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> otherwise.  
  
##  \<a name="cmfcribbonbutton__isdefaultpanelbutton">\</a>  CMFCRibbonButton::IsDefaultPanelButton  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcribbonbutton__isdrawtooltipimage">\</a>  CMFCRibbonButton::IsDrawTooltipImage  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcribbonbutton__islargeimage">\</a>  CMFCRibbonButton::IsLargeImage  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcribbonbutton__ismenuareahighlighted">\</a>  CMFCRibbonButton::IsMenuAreaHighlighted  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcribbonbutton__ismenuonbottom">\</a>  CMFCRibbonButton::IsMenuOnBottom  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcribbonbutton__ispopupdefaultmenulook">\</a>  CMFCRibbonButton::IsPopupDefaultMenuLook  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcribbonbutton__isrightalignmenu">\</a>  CMFCRibbonButton::IsRightAlignMenu  
 Specifies whether the menu is right-aligned.  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> if menu is right-aligned; otherwise <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcribbonbutton__issinglelinetext">\</a>  CMFCRibbonButton::IsSingleLineText  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcribbonbutton__oncalctextsize">\</a>  CMFCRibbonButton::OnCalcTextSize  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcribbonbutton__onclick">\</a>  CMFCRibbonButton::OnClick  
 Called by the framework when the user clicks the button.  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>  
 Specifies the position of the mouse click.  
  
### Remarks  
 Override this method in a derived class if you want to handle this event.  
  
##  \<a name="cmfcribbonbutton__ondraw">\</a>  CMFCRibbonButton::OnDraw  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcribbonbutton__ondrawborder">\</a>  CMFCRibbonButton::OnDrawBorder  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcribbonbutton__onfillbackground">\</a>  CMFCRibbonButton::OnFillBackground  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcribbonbutton__removeallsubitems">\</a>  CMFCRibbonButton::RemoveAllSubItems  
 Removes all menu items from the pop-up menu.  
  
<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
##  \<a name="cmfcribbonbutton__removesubitem">\</a>  CMFCRibbonButton::RemoveSubItem  
 Removes a menu item from the pop-up menu.  
  
<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>  
 Specifies the zero-based index of the menu item that you want to remove.  
  
### Return Value  
 <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> if the specified item has been removed successfully; otherwise <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> is negative or exceeds the number of menu items in the pop-up menu.  
  
##  \<a name="cmfcribbonbutton__setaccdata">\</a>  CMFCRibbonButton::SetACCData  
 Sets the accessibility data for the ribbon button.  
  
<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>  
 The parent window for the ribbon element.  
  
 <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>  
 The accessibility data for the ribbon element.  
  
### Return Value  
 Returns <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> if successful; otherwise FALSE.  
  
### Remarks  
  
##  \<a name="cmfcribbonbutton__setalwayslargeimage">\</a>  CMFCRibbonButton::SetAlwaysLargeImage  
 Specifies whether the button displays a large or a small image when the user collapses the button.  
  
<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>, the button displays a large image. Otherwise, the button displays a small image.  
  
##  \<a name="cmfcribbonbutton__setdefaultcommand">\</a>  CMFCRibbonButton::SetDefaultCommand  
 Enables the default command for the ribbon button.  
  
<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>, the button can execute its default command. If <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>, the button cannot execute its default command.  
  
### Remarks  
 <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> is relevant only when the button has a menu. If <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>, the button can execute its default command and the assigned pop-up menu appears only when a user clicks the arrow at the right edge of the button. Otherwise, the button cannot execute its default command, and the pop-up menu appears regardless of which area of the button the user clicks.  
  
##  \<a name="cmfcribbonbutton__setdescription">\</a>  CMFCRibbonButton::SetDescription  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcribbonbutton__setimageindex">\</a>  CMFCRibbonButton::SetImageIndex  
 Assigns an index to the image of the button.  
  
<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>  
 Specifies the image index.  
  
 [in] <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>, the specified index refers to the list of large images. Otherwise, the index refers to the list of the small images.  
  
##  \<a name="cmfcribbonbutton__setmenu">\</a>  CMFCRibbonButton::SetMenu  
 Assigns a pop-up menu to the ribbon button.  
  
<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>  
 A handle to a Windows menu.  
  
 <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>, the button can execute its default command; otherwise, the button displays a pop-up menu.  
  
 <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>, the menu is right-aligned. Otherwise, the menu is left-aligned.  
  
 <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>  
 A menu resource ID.  
  
### Remarks  
 When the application assigns the menu to the button, the button displays an arrow on its right side. If <CodeContentPlaceHolder>121\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>, the menu appears only when the user clicks the arrow. If the user clicks the button, its default command is executed. If <CodeContentPlaceHolder>123\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>, the menu appears by clicking anywhere on the button.  
  
##  \<a name="cmfcribbonbutton__setparentcategory">\</a>  CMFCRibbonButton::SetParentCategory  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>125\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcribbonbutton__setrightalignmenu">\</a>  CMFCRibbonButton::SetRightAlignMenu  
 Aligns the pop-up menu to the edge of the button.  
  
<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>127\</CodeContentPlaceHolder>, the menu is right-aligned. Otherwise, the menu is left-aligned  
  
##  \<a name="cmfcribbonbutton__settext">\</a>  CMFCRibbonButton::SetText  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>  
  
### Remarks  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)