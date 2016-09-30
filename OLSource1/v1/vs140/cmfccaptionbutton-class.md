---
title: "CMFCCaptionButton Class"
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
  - "CMFCCaptionButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCCaptionButton class"
ms.assetid: c5774b38-c0dd-414a-9ede-3b2f78f233ec
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCCaptionButton Class
The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> class implements a button that is displayed on the caption bar for a docking pane or a mini-frame window. Typically, the framework creates caption buttons automatically.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCCaptionButton::CMFCCaptionButton](#cmfccaptionbutton__cmfccaptionbutton)|Constructs a CMFCCaptionButton object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[GetHit](#cmfccaptionbutton__gethit)|Returns the command represented by the button.|  
|[GetIconID](#cmfccaptionbutton__geticonid)|Returns the image ID associated with the button.|  
|[GetRect](#cmfccaptionbutton__getrect)|Returns the rectangle occupied by the button.|  
|[GetSize](#cmfccaptionbutton__getsize)|Returns the width and height of the button.|  
|[IsMiniFrameButton](#cmfccaptionbutton__isminiframebutton)|Indicates whether the title bar height is set to mini size.|  
|[Move](#cmfccaptionbutton__move)|Sets the button draw location and window show state.|  
|[OnDraw](#cmfccaptionbutton__ondraw)|Draws the caption button.|  
|[SetMiniFrameButton](#cmfccaptionbutton__setminiframebutton)|Sets the mini size of the title bar.|  
  
## Remarks  
 You can derive a class from [CPaneFrameWnd](../vs140/cpaneframewnd-class.md) and use the protected method, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, to add caption buttons to a mini frame window.  
  
 CPaneFrameWnd.h defines command IDs for two types of caption buttons:  
  
-   <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, which displays a pin button when the docking pane supports auto-hide mode.  
  
-   <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, which displays a **Close** button when the pane can be closed or hidden.  
  
## Example  
 The following example demonstrates how to construct a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object and set the mini size of the title bar.  
  
 [!code[NVC_MFC_RibbonApp#43](../vs140/codesnippet/CPP/cmfccaptionbutton-class_1.cpp)]  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CMFCCaptionButton](../vs140/cmfccaptionbutton-class.md)  
  
## Requirements  
 **Header:** afxcaptionbutton.h  
  
##  \<a name="cmfccaptionbutton__cmfccaptionbutton">\</a>  CMFCCaptionButton::CMFCCaptionButton  
 Constructs a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 The command associated with the button.  
  
 [in] <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 Specifies whether the button is aligned to the left.  
  
 The following table lists possible values for the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> parameter.  
  
|Value|Command|  
|-----------|-------------|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|Close button.|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|Minimize button.|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|Maximize button.|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|Left arrow button.|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|Right arrow button.|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|Down arrow menu button.|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|The default value; represents no command.|  
  
### Remarks  
 By default, caption buttons are not associated with a command.  
  
 Caption buttons are aligned either on the right or left.  
  
##  \<a name="cmfccaptionbutton__gethit">\</a>  CMFCCaptionButton::GetHit  
 Returns the command represented by the button.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 The command represented by the button.  
  
 The following table lists possible return values.  
  
|Value|Command|  
|-----------|-------------|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|Close button.|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|Minimize button.|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|Maximize button.|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|Left arrow button.|  
|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|Right arrow button.|  
|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|Down arrow menu button.|  
|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|The default value; represents no command.|  
  
##  \<a name="cmfccaptionbutton__geticonid">\</a>  CMFCCaptionButton::GetIconID  
 Returns the image ID associated with the button.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> for left or right arrow image IDs; <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> for up or down arrow image IDs.  
  
 [in] <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> for a maximize image ID; <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> for a minimize image ID.  
  
### Return Value  
 The image ID.  
  
### Remarks  
 The parameters specify image IDs for minimize or maximize caption buttons.  
  
##  \<a name="cmfccaptionbutton__getrect">\</a>  CMFCCaptionButton::GetRect  
 Returns the rectangle occupied by the button.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 The rectangle that represents the location of the button.  
  
### Remarks  
 If you cannot see the button, the size returned is 0.  
  
##  \<a name="cmfccaptionbutton__getsize">\</a>  CMFCCaptionButton::GetSize  
 Returns the width and height of the button.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 The outer dimensions of the button.  
  
### Remarks  
 The size returned includes button margin and border.  
  
##  \<a name="cmfccaptionbutton__isminiframebutton">\</a>  CMFCCaptionButton::IsMiniFrameButton  
 Indicates whether the title bar height is set to mini size.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> if the caption is set to mini size; otherwise <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfccaptionbutton__move">\</a>  CMFCCaptionButton::Move  
 Sets the button draw location and window show state.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 The new location.  
  
 [in] <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 Whether to show the button.  
  
##  \<a name="cmfccaptionbutton__ondraw">\</a>  CMFCCaptionButton::OnDraw  
 Draws the caption button.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 Pointer to a device context for the button.  
  
 [in] <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 Whether to draw an active button image.  
  
 [in] <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 Reserved for use in a derived class.  
  
 [in] <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 Whether to draw a maximized button image.  
  
 [in] <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 Whether to draw an enabled button image.  
  
### Remarks  
 The <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> parameter is used when the button is a maximize or minimize button.  
  
##  \<a name="cmfccaptionbutton__setminiframebutton">\</a>  CMFCCaptionButton::SetMiniFrameButton  
 Sets the mini size of the title bar.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> for mini title bar height; <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> for default title bar height.  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CPaneFrameWnd](../vs140/cpaneframewnd-class.md)   
 [CMFCDockablePane](../vs140/cdockablepane-class.md)