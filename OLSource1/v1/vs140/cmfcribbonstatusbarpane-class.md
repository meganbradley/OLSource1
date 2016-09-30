---
title: "CMFCRibbonStatusBarPane Class"
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
  - "CMFCRibbonStatusBarPane"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCRibbonStatusBarPane class"
ms.assetid: 5d034c3c-ecca-4267-b88c-0f55a2884dd0
caps.latest.revision: 30
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonStatusBarPane Class
The <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> class implements a ribbon element that you can add to a ribbon status bar.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCRibbonStatusBarPane::CMFCRibbonStatusBarPane](#cmfcribbonstatusbarpane__cmfcribbonstatusbarpane)|Constructs and initializes a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCRibbonStatusBarPane::GetAlmostLargeText](#cmfcribbonstatusbarpane__getalmostlargetext)|Returns the string that defines the longest text string that can be displayed in the pane without truncation.|  
|[CMFCRibbonStatusBarPane::GetTextAlign](#cmfcribbonstatusbarpane__gettextalign)|Returns the current setting of the text alignment.|  
|[CMFCRibbonStatusBarPane::IsAnimation](#cmfcribbonstatusbarpane__isanimation)|Determines whether the animation is in progress.|  
|[CMFCRibbonStatusBarPane::IsExtended](#cmfcribbonstatusbarpane__isextended)|Determines whether the pane is located in the extended area of the ribbon status bar.|  
|[CMFCRibbonStatusBarPane::OnDrawBorder](#cmfcribbonstatusbarpane__ondrawborder)|(Overrides [CMFCRibbonButton::OnDrawBorder](../vs140/cmfcribbonbutton-class.md#cmfcribbonbutton__ondrawborder).)|  
|[CMFCRibbonStatusBarPane::OnFillBackground](#cmfcribbonstatusbarpane__onfillbackground)|(Overrides [CMFCRibbonButton::OnFillBackground](../vs140/cmfcribbonbutton-class.md#cmfcribbonbutton__onfillbackground).)|  
|[CMFCRibbonStatusBarPane::SetAlmostLargeText](#cmfcribbonstatusbarpane__setalmostlargetext)|Defines the longest text string that can be displayed in the pane without truncation.|  
|[CMFCRibbonStatusBarPane::SetAnimationList](#cmfcribbonstatusbarpane__setanimationlist)|Assigns to the pane an image list that can be used for animation.|  
|[CMFCRibbonStatusBarPane::SetTextAlign](#cmfcribbonstatusbarpane__settextalign)|Sets the text alignment.|  
|[CMFCRibbonStatusBarPane::StartAnimation](#cmfcribbonstatusbarpane__startanimation)|Starts the animation that is assigned to the pane.|  
|[CMFCRibbonStatusBarPane::StopAnimation](#cmfcribbonstatusbarpane__stopanimation)|Stops the animation that is assigned to the pane. .|  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCRibbonStatusBarPane::OnFinishAnimation](#cmfcribbonstatusbarpane__onfinishanimation)|Called by the framework when the animation that is assigned to the pane stops.|  
  
## Example  
 The following example demonstrates how to use the various methods in the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> class. The example shows how to construct a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object, set the text alignment of the label of the status bar pane, define the longest text that can be displayed in the status bar pane without truncation, attach to the status bar pane an image list that can be used for animation, and start the animation.  
  
 [!code[NVC_MFC_RibbonApp#2](../vs140/codesnippet/CPP/cmfcribbonstatusbarpane-class_1.cpp)]  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CMFCRibbonBaseElement](../vs140/cmfcribbonbaseelement-class.md)  
  
 [CMFCRibbonButton](../vs140/cmfcribbonbutton-class.md)  
  
 [CMFCRibbonStatusBarPane](../vs140/cmfcribbonstatusbarpane-class.md)  
  
## Requirements  
 **Header:** afxribbonstatusbarpane.h  
  
##  \<a name="cmfcribbonstatusbarpane__cmfcribbonstatusbarpane">\</a>  CMFCRibbonStatusBarPane::CMFCRibbonStatusBarPane  
 Construct a pane object in the status bar.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 Specifies the command ID of the pane.  
  
 [in] <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 Specifies text string to be displayed on pane.  
  
 [in] <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, the status pane cannot be highlighted or selected by clicking it.  
  
 [in] <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 Specifies a handle to an icon to be displayed on the pane.  
  
 [in] <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 Specifies the longest text string that can be displayed by the pane.  
  
 [in] <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 Specifies a handle to an image list that is used for animation.  
  
 [in] <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 Specifies the width, in pixels, of the icon in the image list that is used for animation.  
  
 [in] <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 Specifies the transparent color of images in the image list that are used for animation.  
  
 [in] <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 Specifies a resource ID of an image list that is used for animation.  
  
##  \<a name="cmfcribbonstatusbarpane__getalmostlargetext">\</a>  CMFCRibbonStatusBarPane::GetAlmostLargeText  
 Gets the longest text string that the status bar pane can display.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 The longest text string that the status bar pane can display.  
  
##  \<a name="cmfcribbonstatusbarpane__gettextalign">\</a>  CMFCRibbonStatusBarPane::GetTextAlign  
 Gets the current setting of the text alignment of the label of the status bar pane.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 The current text alignment which can be one of the following:  
  
-   TA_LEFT  
  
-   TA_CENTER  
  
-   TA_RIGHT.  
  
##  \<a name="cmfcribbonstatusbarpane__isanimation">\</a>  CMFCRibbonStatusBarPane::IsAnimation  
 Determines whether the animation is in progress.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> if animation is in progress; <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> otherwise.  
  
##  \<a name="cmfcribbonstatusbarpane__isextended">\</a>  CMFCRibbonStatusBarPane::IsExtended  
 Determine whether the pane is located in the extended area of the ribbon status bar.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> if pane is on status bar extended area. <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> otherwise.  
  
##  \<a name="cmfcribbonstatusbarpane__ondrawborder">\</a>  CMFCRibbonStatusBarPane::OnDrawBorder  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcribbonstatusbarpane__onfillbackground">\</a>  CMFCRibbonStatusBarPane::OnFillBackground  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcribbonstatusbarpane__onfinishanimation">\</a>  CMFCRibbonStatusBarPane::OnFinishAnimation  
 Framework calls this method when the animation that is assigned to the pane ends.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Remarks  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> method calls the  <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> method, which you can use to clean up data when the animation ends.  
  
##  \<a name="cmfcribbonstatusbarpane__setalmostlargetext">\</a>  CMFCRibbonStatusBarPane::SetAlmostLargeText  
 Define the longest text that can be displayed in the status bar pane without truncation.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 Specifies the longest string that can be displayed on the status bar pane without truncation.  
  
### Remarks  
 The library calculates the size of text that <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> specifies and resizes the pane accordingly. The text will be truncated if it still does not fit in the pane.  
  
##  \<a name="cmfcribbonstatusbarpane__setanimationlist">\</a>  CMFCRibbonStatusBarPane::SetAnimationList  
 Attaches to the status bar pane an image list that can be used for animation.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 Specifies a handle to an image list.  
  
 [in] <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 Specifies the width, in pixels, of the frame in the image list.  
  
 [in] <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 Specifies the transparent color of the image list.  
  
 [in] <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 Specifies the resource ID of the image list.  
  
### Return Value  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> if the image list is successfully attached to the status bar pane; <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> otherwise.  
  
##  \<a name="cmfcribbonstatusbarpane__settextalign">\</a>  CMFCRibbonStatusBarPane::SetTextAlign  
 Sets the text alignment of the label of the status bar pane.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 Specifies the text alignment.  
  
### Remarks  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> can have one of the following values:  
  
-   <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>: left alignment  
  
-   <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> center alignment  
  
-   <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> right alignment  
  
##  \<a name="cmfcribbonstatusbarpane__startanimation">\</a>  CMFCRibbonStatusBarPane::StartAnimation  
 Starts the animation that you assign to the pane.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
 Specifies the animation frame rate, in milliseconds.  
  
 [in] <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 Specifies how long to play the animation, in milliseconds. Use -1 for an infinite loop.  
  
### Remarks  
 You must specify a handle to an image list before you call <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> by using <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcribbonstatusbarpane__stopanimation">\</a>  CMFCRibbonStatusBarPane::StopAnimation  
 Stops the animation that you assigned to the status bar pane.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CMFCRibbonButton](../vs140/cmfcribbonbutton-class.md)   
 [CMFCRibbonStatusBar](../vs140/cmfcribbonstatusbar-class.md)