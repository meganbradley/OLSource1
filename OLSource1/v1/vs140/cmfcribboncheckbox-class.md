---
title: "CMFCRibbonCheckBox Class"
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
  - "CMFCRibbonCheckBox"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCRibbonCheckBox class"
ms.assetid: 3a6c3891-c8d1-4af0-b954-7b9ab048782a
caps.latest.revision: 29
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonCheckBox Class
The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> class implements a check box that you can add to a ribbon panel, Quick Access Toolbar, or popup menu.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCRibbonCheckBox::CMFCRibbonCheckBox](#cmfcribboncheckbox__cmfcribboncheckbox)|The constructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCRibbonCheckBox::GetCompactSize](#cmfcribboncheckbox__getcompactsize)|(Overrides [CMFCRibbonButton::GetCompactSize](../vs140/cmfcribbonbutton-class.md#cmfcribbonbutton__getcompactsize).)|  
|[CMFCRibbonCheckBox::GetIntermediateSize](#cmfcribboncheckbox__getintermediatesize)|(Overrides [CMFCRibbonButton::GetIntermediateSize](../vs140/cmfcribbonbutton-class.md#cmfcribbonbutton__getintermediatesize).)|  
|[CMFCRibbonCheckBox::GetRegularSize](#cmfcribboncheckbox__getregularsize)|(Overrides [CMFCRibbonButton::GetRegularSize](../vs140/cmfcribbonbutton-class.md#cmfcribbonbutton__getregularsize).)|  
|[CMFCRibbonCheckBox::IsDrawTooltipImage](#cmfcribboncheckbox__isdrawtooltipimage)|(Overrides <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.)|  
|[CMFCRibbonCheckBox::OnDraw](#cmfcribboncheckbox__ondraw)|(Overrides [CMFCRibbonButton::OnDraw](../vs140/cmfcribbonbutton-class.md#cmfcribbonbutton__ondraw).)|  
|[CMFCRibbonCheckBox::OnDrawMenuImage](#cmfcribboncheckbox__ondrawmenuimage)|(Overrides [CMFCRibbonBaseElement::OnDrawMenuImage](../vs140/cmfcribbonbaseelement-class.md#cmfcribbonbaseelement__ondrawmenuimage).)|  
|[CMFCRibbonCheckBox::OnDrawOnList](#cmfcribboncheckbox__ondrawonlist)|(Overrides <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.)|  
|[CMFCRibbonCheckBox::SetACCData](#cmfcribboncheckbox__setaccdata)|(Overrides [CMFCRibbonButton::SetACCData](../vs140/cmfcribbonbutton-class.md#cmfcribbonbutton__setaccdata).)|  
  
## Remarks  
 To use a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> in your application, add the following constructor to your code:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 where <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is the check box command ID and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is the text label of the check box.  
  
 You can add a check box to a ribbon panel by using [CMFCRibbonPanel::Add](../vs140/cmfcribbonpanel-class.md#cmfcribbonpanel__add).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CMFCRibbonBaseElement](../vs140/cmfcribbonbaseelement-class.md)  
  
 [CMFCRibbonButton](../vs140/cmfcribbonbutton-class.md)  
  
 [CMFCRibbonCheckBox](../vs140/cmfcribboncheckbox-class.md)  
  
## Requirements  
 **Header:** afxribboncheckbox.h  
  
##  \<a name="cmfcribboncheckbox__cmfcribboncheckbox">\</a>  CMFCRibbonCheckBox::CMFCRibbonCheckBox  
 Constructor of a ribbon check box object  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 [in]  <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 Specifies command ID.  
  
 [in]  <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 Specifies text label.  
  
### Return Value  
 Constructs a ribbon check box object.  
  
### Example  
 The following example demonstrates how to construct an object of the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> class.  
  
 [!code[NVC_MFC_RibbonApp#17](../vs140/codesnippet/CPP/cmfcribboncheckbox-class_1.cpp)]  
  
##  \<a name="cmfcribboncheckbox__getcompactsize">\</a>  CMFCRibbonCheckBox::GetCompactSize  
 When overridden, gets the compact size of the checkbox.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 Pointer to the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> associated with the checkbox.  
  
### Return Value  
 Returns a <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> object that contains the compact size of the checkbox.  
  
### Remarks  
 If not overridden, returns the intermediate size of the checkbox.  
  
##  \<a name="cmfcribboncheckbox__getintermediatesize">\</a>  CMFCRibbonCheckBox::GetIntermediateSize  
 Gets the intermediate size of the checkbox.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 Pointer to the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> associated with this checkbox.  
  
### Return Value  
 A <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> object containing the intermediate size of the checkbox.  
  
### Remarks  
 If not overridden, calculates the intermediate size as the default checkbox size ( <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>) plus the text size, plus margins.  
  
##  \<a name="cmfcribboncheckbox__getregularsize">\</a>  CMFCRibbonCheckBox::GetRegularSize  
 Gets the regular size of the checkbox.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 Pointer to the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> object associated with this checkbox.  
  
### Return Value  
 Returns a <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> object that contains the regular size of the checkbox.  
  
### Remarks  
 If not overridden, returns the intermediate size of the checkbox.  
  
##  \<a name="cmfcribboncheckbox__isdrawtooltipimage">\</a>  CMFCRibbonCheckBox::IsDrawTooltipImage  
 Indicates whether there is a tooltip image associated with the checkbox.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 Returns <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> if there is a tooltip image associated with the checkbox, or <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> if not.  
  
### Remarks  
  
##  \<a name="cmfcribboncheckbox__ondraw">\</a>  CMFCRibbonCheckBox::OnDraw  
 Called by the framework to draw the checkbox using a specified device context.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 Pointer to the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> in which to draw the checkbox.  
  
### Remarks  
  
##  \<a name="cmfcribboncheckbox__ondrawmenuimage">\</a>  CMFCRibbonCheckBox::OnDrawMenuImage  
 Called by the framework to draw a menu image for the checkbox.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 Pointer to the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> associated with the checkbox.  
  
 [in] <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> object specifying the rectangle in which to draw the menu image.  
  
### Return Value  
 Returns <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> if the image was drawn, or <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> if not.  
  
### Remarks  
 If not overridden, returns <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcribboncheckbox__ondrawonlist">\</a>  CMFCRibbonCheckBox::OnDrawOnList  
 Called by the framework to draw the checkbox in a commands list box.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 Pointer to the device context in which to draw the checkbox.  
  
 [in] <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 The display text.  
  
 [in] <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 The distance, in pixels, from the left side of the list box to the display text.  
  
 [in] <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 The display rectangle for the checkbox.  
  
 [in] <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> if the checkbox is selected, or <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> if not.  
  
 [in] <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> if the checkbox is highlighted, or <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> if not.  
  
### Remarks  
  
##  \<a name="cmfcribboncheckbox__setaccdata">\</a>  CMFCRibbonCheckBox::SetACCData  
 Sets the accessibility data for the checkbox.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 The parent window of the checkbox.  
  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
 The accessibility data for the checkbox.  
  
### Return Value  
 Always returns <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>.  
  
### Remarks  
 By default this method sets the accessibility data for the checkbox and always returns <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>. Override this method to set the accessibility data and return a value that indicates success or failure.  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CMFCRibbonPanel](../vs140/cmfcribbonpanel-class.md)