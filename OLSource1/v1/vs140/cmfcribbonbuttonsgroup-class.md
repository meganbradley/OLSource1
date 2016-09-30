---
title: "CMFCRibbonButtonsGroup Class"
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
  - "CMFCRibbonButtonsGroup"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCRibbonButtonsGroup class"
ms.assetid: b993d93e-fc1a-472f-a87f-1d7b7b499845
caps.latest.revision: 33
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonButtonsGroup Class
The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> class allows you to organize a set of ribbon buttons into a group. All buttons in the group are directly adjacent to each other horizontally and enclosed in a border.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCRibbonButtonsGroup::CMFCRibbonButtonsGroup](#cmfcribbonbuttonsgroup__cmfcribbonbuttonsgroup)|Constructs a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCRibbonButtonsGroup::AddButton](#cmfcribbonbuttonsgroup__addbutton)|Adds a button to a group.|  
|[CMFCRibbonButtonsGroup::AddButtons](#cmfcribbonbuttonsgroup__addbuttons)|Adds a list of buttons to a group.|  
|[CMFCRibbonButtonsGroup::GetButton](#cmfcribbonbuttonsgroup__getbutton)|Returns a pointer to the button that is located at a specified index.|  
|[CMFCRibbonButtonsGroup::GetCount](#cmfcribbonbuttonsgroup__getcount)|Returns the number of buttons in the group.|  
|[CMFCRibbonButtonsGroup::GetImageSize](#cmfcribbonbuttonsgroup__getimagesize)|Returns the image size of the normal images in the ribbon group (overrides [CMFCRibbonBaseElement::GetImageSize](../vs140/cmfcribbonbaseelement-class.md#cmfcribbonbaseelement__getimagesize).)|  
|[CMFCRibbonButtonsGroup::GetRegularSize](#cmfcribbonbuttonsgroup__getregularsize)|Returns the regular size of the ribbon element (overrides [CMFCRibbonBaseElement::GetRegularSize](../vs140/cmfcribbonbaseelement-class.md#cmfcribbonbaseelement__getregularsize).)|  
|[CMFCRibbonButtonsGroup::HasImages](#cmfcribbonbuttonsgroup__hasimages)|Reports whether the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object contains toolbar images.|  
|[CMFCRibbonButtonsGroup::OnDrawImage](#cmfcribbonbuttonsgroup__ondrawimage)|Draws the appropriate image for a specified button, depending on whether the button is normal, highlighted or disabled.|  
|[CMFCRibbonButtonsGroup::RemoveAll](#cmfcribbonbuttonsgroup__removeall)|Removes all buttons from the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object.|  
|[CMFCRibbonButtonsGroup::SetImages](#cmfcribbonbuttonsgroup__setimages)|Assigns images to the group.|  
|[CMFCRibbonButtonsGroup::SetParentCategory](#cmfcribbonbuttonsgroup__setparentcategory)|Sets the parent <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> of the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object and all the buttons within it (overrides [CMFCRibbonBaseElement::SetParentCategory](../vs140/cmfcribbonbaseelement-class.md#cmfcribbonbaseelement__setparentcategory).)|  
  
## Remarks  
 The group is derived from [CMFCBaseRibbonElement](../vs140/cmfcribbonbaseelement-class.md) and can be manipulated as a single entity. You can position the group on any panel or popup menu.  
  
## Example  
 The following example demonstrates how to use various methods in the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> class. The example shows how to construct a <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object, assign images to the group of ribbon buttons, and add a button to the group of ribbon buttons. This code snippet is part of the [Draw Client sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_DrawClient#2](../vs140/codesnippet/CPP/cmfcribbonbuttonsgroup-class_1.cpp)]  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CMFCRibbonBaseElement](../vs140/cmfcribbonbaseelement-class.md)  
  
 [CMFCRibbonButtonsGroup](../vs140/cmfcribbonbuttonsgroup-class.md)  
  
## Requirements  
 **Header:** afxribbonbuttonsgroup.h  
  
##  \<a name="cmfcribbonbuttonsgroup__addbutton">\</a>  CMFCRibbonButtonsGroup::AddButton  
 Adds a button to a group.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 A pointer to a button to add.  
  
##  \<a name="cmfcribbonbuttonsgroup__addbuttons">\</a>  CMFCRibbonButtonsGroup::AddButtons  
 Adds a list of buttons to a group.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 A list of pointers to the buttons that you want to add.  
  
##  \<a name="cmfcribbonbuttonsgroup__cmfcribbonbuttonsgroup">\</a>  CMFCRibbonButtonsGroup::CMFCRibbonButtonsGroup  
 Constructs a <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 Specifies a button to add to the newly created <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> object.  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcribbonbuttonsgroup__getbutton">\</a>  CMFCRibbonButtonsGroup::GetButton  
 Returns a pointer to the button that is located at a specified index.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 A zero-based index of a button to return.  
  
### Return Value  
 A pointer to the button that is located at the specified index. <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> if the specified index is out of range.  
  
### Remarks  
  
##  \<a name="cmfcribbonbuttonsgroup__getcount">\</a>  CMFCRibbonButtonsGroup::GetCount  
 Returns the number of buttons in the group.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 The number of buttons in the group.  
  
##  \<a name="cmfcribbonbuttonsgroup__getimagesize">\</a>  CMFCRibbonButtonsGroup::GetImageSize  
 Retrieves the source image size of the protected <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> member <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 Returns the source image size of the toolbar images, if any are present, or a <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> of zero if not.  
  
### Remarks  
  
##  \<a name="cmfcribbonbuttonsgroup__getregularsize">\</a>  CMFCRibbonButtonsGroup::GetRegularSize  
 Retrieves the maximum possible size of the ribbon group element.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 Pointer to the device context of the ribbon group.  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcribbonbuttonsgroup__hasimages">\</a>  CMFCRibbonButtonsGroup::HasImages  
 Reports whether the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> object contains toolbar images.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 Returns TRUE if the protected <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> member <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> contains any images, or FALSE if not.  
  
### Remarks  
  
##  \<a name="cmfcribbonbuttonsgroup__ondrawimage">\</a>  CMFCRibbonButtonsGroup::OnDrawImage  
 Draws the appropriate image for a specified button, depending on whether the button is normal, highlighted or disabled.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 Pointer to the device context of the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> object.  
  
 [in] <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 The rectangle within which to draw the image.  
  
 [in] <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 The button for which to draw the image.  
  
 [in] <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 The index of the image to draw on the button (in one of the three image arrays for normal, highlighted or disabled buttons).  
  
### Remarks  
  
##  \<a name="cmfcribbonbuttonsgroup__removeall">\</a>  CMFCRibbonButtonsGroup::RemoveAll  
 Removes all buttons from the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmfcribbonbuttonsgroup__setimages">\</a>  CMFCRibbonButtonsGroup::SetImages  
 Assigns images to the group of ribbon buttons.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 Regular images.  
  
 [in] <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 Hot images.  
  
 [in] <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 Disabled images.  
  
### Remarks  
 Call <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> before you add buttons to a group. The number of images must be greater or equal to the number of buttons to be added to the group.  
  
> [!NOTE]
>  Hot images are images that are displayed when the user hovers over the button. Disabled images are images that are displayed when the button is disabled.  
  
##  \<a name="cmfcribbonbuttonsgroup__setparentcategory">\</a>  CMFCRibbonButtonsGroup::SetParentCategory  
 Sets the parent <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> of the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> object and all the buttons within it.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 Pointer to the parent category to set (the tabbed groups in ribbon controls are called categories).  
  
### Remarks  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)