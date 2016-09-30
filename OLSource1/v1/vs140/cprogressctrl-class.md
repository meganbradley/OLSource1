---
title: "CProgressCtrl Class"
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
  - "CProgressCtrl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CProgressCtrl class"
  - "progress controls [C++], CProgressCtrl class"
  - "Internet Explorer 4.0 common controls"
ms.assetid: 222630f4-1598-4026-8198-51649b1192ab
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CProgressCtrl Class
Provides the functionality of the Windows common progress bar control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CProgressCtrl::CProgressCtrl](#cprogressctrl__cprogressctrl)|Constructs a <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CProgressCtrl::Create](#cprogressctrl__create)|Creates a progress bar control and attaches it to a <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object.|  
|[CProgressCtrl::CreateEx](#cprogressctrl__createex)|Creates a progress control with the specified Windows extended styles and attaches it to a <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> object.|  
|[CProgressCtrl::GetBarColor](#cprogressctrl__getbarcolor)|Gets the color of the progress indicator bar for the current progress bar control.|  
|[CProgressCtrl::GetBkColor](#cprogressctrl__getbkcolor)|Gets the background color of the current progress bar.|  
|[CProgressCtrl::GetPos](#cprogressctrl__getpos)|Gets the current position of the progress bar.|  
|[CProgressCtrl::GetRange](#cprogressctrl__getrange)|Gets the lower and upper limits of the range of the progress bar control.|  
|[CProgressCtrl::GetState](#cprogressctrl__getstate)|Gets the state of the current progress bar control.|  
|[CProgressCtrl::GetStep](#cprogressctrl__getstep)|Retrieves the step increment for the progress bar of the current progress bar control.|  
|[CProgressCtrl::OffsetPos](#cprogressctrl__offsetpos)|Advances the current position of a progress bar control by a specified increment and redraws the bar to reflect the new position.|  
|[CProgressCtrl::SetBarColor](#cprogressctrl__setbarcolor)|Sets the color of the progress indicator bar in the current progress bar control.|  
|[CProgressCtrl::SetBkColor](#cprogressctrl__setbkcolor)|Sets the background color for the progress bar.|  
|[CProgressCtrl::SetMarquee](#cprogressctrl__setmarquee)|Turns marquee mode on or off for the current progress bar control.|  
|[CProgressCtrl::SetPos](#cprogressctrl__setpos)|Sets the current position for a progress bar control and redraws the bar to reflect the new position.|  
|[CProgressCtrl::SetRange](#cprogressctrl__setrange)|Sets the minimum and maximum ranges for a progress bar control and redraws the bar to reflect the new ranges.|  
|[CProgressCtrl::SetState](#cprogressctrl__setstate)|Sets the state of the current progress bar control.|  
|[CProgressCtrl::SetStep](#cprogressctrl__setstep)|Specifies the step increment for a progress bar control.|  
|[CProgressCtrl::StepIt](#cprogressctrl__stepit)|Advances the current position for a progress bar control by the step increment (see [SetStep](#cprogressctrl__setstep)) and redraws the bar to reflect the new position.|  
  
## Remarks  
 A progress bar control is a window that an application can use to indicate the progress of a lengthy operation. It consists of a rectangle that is gradually filled, from left to right, with the system highlight color as an operation progresses.  
  
 A progress bar control has a range and a current position. The range represents the total duration of the operation, and the current position represents the progress the application has made toward completing the operation. The window procedure uses the range and the current position to determine the percentage of the progress bar to fill with the highlight color. Because the range and current position values are expressed as signed integers, the possible range of current position values is from –2,147,483,648 to 2,147,483,647 inclusive.  
  
 For more information on using <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, see [Controls](../vs140/controls--mfc-.md) and [Using CProgressCtrl](../vs140/using-cprogressctrl.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxcmn.h  
  
##  \<a name="cprogressctrl__cprogressctrl">\</a>  CProgressCtrl::CProgressCtrl  
 Constructs a <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 After constructing the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> object, call <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> to create the progress bar control.  
  
### Example  
 [!code[NVC_MFC_CProgressCtrl#1](../vs140/codesnippet/CPP/cprogressctrl-class_1.cpp)]  
  
##  \<a name="cprogressctrl__create">\</a>  CProgressCtrl::Create  
 Creates a progress bar control and attaches it to a <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 Specifies the progress bar control's style. Apply any combination of window stylesdescribed in                                 [CreateWindow](http://msdn.microsoft.com/library/windows/desktop/ms632679) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)], in addition to the following progress bar control styles, to the control:  
  
-   <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> Displays progress information vertically, top to bottom. Without this flag, the progress bar control displays horizontally, left to right.  
  
-   <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> Displays gradual, smooth filling in the progress bar control. Without this flag, the control will fill with blocks.  
  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 Specifies the progress bar control's size and position. It can be either a [CRect](../vs140/crect-class.md) object or a                                 [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure. Because the control must be a child window, the specified coordinates are relative to the client area of the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 Specifies the progress bar control's parent window, usually a <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>. It must not be **NULL.**  
  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 Specifies the progress bar control's ID.  
  
### Return Value  
 **TRUE** if the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> object is successfully created; otherwise **FALSE**.  
  
### Remarks  
 You construct a <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> object in two steps. First, call the constructor, which creates the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> object, and then call **Create**, which creates the progress bar control.  
  
### Example  
 [!code[NVC_MFC_CProgressCtrl#2](../vs140/codesnippet/CPP/cprogressctrl-class_2.cpp)]  
  
##  \<a name="cprogressctrl__createex">\</a>  CProgressCtrl::CreateEx  
 Creates a control (a child window) and associates it with the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 Specifies the extended style of the control being created. For a list of extended Windows styles, see the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> parameter for                                 [CreateWindowEx](http://msdn.microsoft.com/library/windows/desktop/ms632680) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 Specifies the progress bar control's style. Apply any combination of window styles described in                                 [CreateWindow](http://msdn.microsoft.com/library/windows/desktop/ms632679) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 A reference to a                                 [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure describing the size and position of the window to be created, in client coordinates of <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 A pointer to the window that is the control's parent.  
  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 The control's child-window ID.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 Use <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> instead of [Create](#cprogressctrl__create) to apply extended Windows styles, specified by the Windows extended style preface **WS_EX_**.  
  
##  \<a name="cprogressctrl__getbarcolor">\</a>  CProgressCtrl::GetBarColor  
 Gets the color of the progress indicator bar for the current progress bar control.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 The color of the current progress bar, represented as a                         [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) value, or <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> if the progress indicator bar color is the default color.  
  
### Remarks  
 This method sends the                         [PBM_GETBARCOLOR](http://msdn.microsoft.com/library/windows/desktop/bb760826) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cprogressctrl__getbkcolor">\</a>  CProgressCtrl::GetBkColor  
 Gets the background color of the current progress bar.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 The background color of the current progress bar, represented as a                         [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) value.  
  
### Remarks  
 This method sends the                         [PBM_GETBKCOLOR](http://msdn.microsoft.com/library/windows/desktop/bb760828) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cprogressctrl__getpos">\</a>  CProgressCtrl::GetPos  
 Retrieves the current position of the progress bar.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 The position of the progress bar control.  
  
### Remarks  
 The position of the progress bar control is not the physical location on the screen, but rather is between the upper and lower range indicated in [SetRange](#cprogressctrl__setrange).  
  
### Example  
 [!code[NVC_MFC_CProgressCtrl#3](../vs140/codesnippet/CPP/cprogressctrl-class_3.cpp)]  
  
##  \<a name="cprogressctrl__getrange">\</a>  CProgressCtrl::GetRange  
 Gets the current lower and upper limits, or range, of the progress bar control.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
 A reference to an integer receiving the lower limit of the progress bar control.  
  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 A reference to an integer receiving the upper limit of the progress bar control.  
  
### Remarks  
 This function copies the values of the lower and upper limits to the integers referenced by <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>, respectively.  
  
### Example  
 [!code[NVC_MFC_CProgressCtrl#4](../vs140/codesnippet/CPP/cprogressctrl-class_4.cpp)]  
  
##  \<a name="cprogressctrl__getstate">\</a>  CProgressCtrl::GetState  
 Gets the state of the current progress bar control.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 The state of the current progress bar control, which is one of the following values:  
  
|Value|State|  
|-----------|-----------|  
|<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>|In progress|  
|<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>|Error|  
|<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>|Paused|  
  
### Remarks  
 This method sends the                         [PBM_GETSTATE](http://msdn.microsoft.com/library/windows/desktop/bb760834) message, which is described in the                        [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 The following code example defines the variable, <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>, that is used to programmatically access the progress bar control. This variable is used in the next example.  
  
 [!code[NVC_MFC_CProgressCtrl_s1#9](../vs140/codesnippet/CPP/cprogressctrl-class_5.h)]  
  
### Example  
 The following code example retrieves the state of the current progress bar control.  
  
 [!code[NVC_MFC_CProgressCtrl_s1#5](../vs140/codesnippet/CPP/cprogressctrl-class_6.cpp)]  
  
##  \<a name="cprogressctrl__getstep">\</a>  CProgressCtrl::GetStep  
 Retrieves the step increment for the progress bar of the current progress bar control.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 The step increment of the progress bar.  
  
### Remarks  
 The step increment is the amount by which a call to [CProgressCtrl::StepIt](#cprogressctrl__stepit) increases the current position of the progress bar.  
  
 This method sends the                         [PBM_GETSTEP](http://msdn.microsoft.com/library/windows/desktop/bb760836) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 The following code example defines the variable, <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>, that is used to programmatically access the progress bar control. This variable is used in the next example.  
  
 [!code[NVC_MFC_CProgressCtrl_s1#9](../vs140/codesnippet/CPP/cprogressctrl-class_5.h)]  
  
### Example  
 The following code example retrieves the step increment of the current progress bar control.  
  
 [!code[NVC_MFC_CProgressCtrl_s1#3](../vs140/codesnippet/CPP/cprogressctrl-class_7.cpp)]  
  
##  \<a name="cprogressctrl__offsetpos">\</a>  CProgressCtrl::OffsetPos  
 Advances the progress bar control's current position by the increment specified by <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> and redraws the bar to reflect the new position.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
 Amount to advance the position.  
  
### Return Value  
 The previous position of the progress bar control.  
  
### Example  
 [!code[NVC_MFC_CProgressCtrl#5](../vs140/codesnippet/CPP/cprogressctrl-class_8.cpp)]  
  
##  \<a name="cprogressctrl__setbarcolor">\</a>  CProgressCtrl::SetBarColor  
 Sets the color of the progress indicator bar in the current progress bar control.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>|A                                         [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) value that specifies the new color of the progress indicator bar. Specify <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> to cause the progress bar to use its default color.|  
  
### Return Value  
 The previous color of the progress indicator bar, represented as a                         [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) value, or <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> if the color of the progress indicator bar is the default color.  
  
### Remarks  
 The <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> method sets the progress bar color only if a [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)][theme](https://msdn.microsoft.com/en-us/library/windows/desktop/hh270423.aspx) is not in effect.  
  
 This method sends the                         [PBM_SETBARCOLOR](http://msdn.microsoft.com/library/windows/desktop/bb760838) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 The following code example defines the variable, <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>, that is used to programmatically access the progress bar control. This variable is used in the next example.  
  
 [!code[NVC_MFC_CProgressCtrl_s1#9](../vs140/codesnippet/CPP/cprogressctrl-class_5.h)]  
  
### Example  
 The following code example changes the color of the progress bar to red, green, blue, or the default.  
  
 [!code[NVC_MFC_CProgressCtrl_s1#1](../vs140/codesnippet/CPP/cprogressctrl-class_9.cpp)]  
  
##  \<a name="cprogressctrl__setbkcolor">\</a>  CProgressCtrl::SetBkColor  
 Sets the background color for the progress bar.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
 A **COLORREF** value that specifies the new background color. Specify the <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> value to use the default background color for the progress bar.  
  
### Return Value  
 The                         [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) value indicating the previous background color, or **CLR_DEFAULT** if the background color is the default color.  
  
### Example  
 [!code[NVC_MFC_CProgressCtrl#6](../vs140/codesnippet/CPP/cprogressctrl-class_10.cpp)]  
  
##  \<a name="cprogressctrl__setmarquee">\</a>  CProgressCtrl::SetMarquee  
 Turns marquee mode on or off for the current progress bar control.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>68\</CodeContentPlaceHolder> to turn marquee mode on, or <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> to turn marquee mode off.|  
|[in] <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>|Time in milliseconds between updates of the marquee animation.|  
  
### Return Value  
 This method always returns <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>.  
  
### Remarks  
 When marquee mode is turned on, the progress bar is animated and scrolls like a sign on a theater marquee.  
  
 This method sends the                         [PBM_SETMARQUEE](http://msdn.microsoft.com/library/windows/desktop/bb760842) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 The following code example defines the variable, <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>, that is used to programmatically access the progress bar control. This variable is used in the next example.  
  
 [!code[NVC_MFC_CProgressCtrl_s1#9](../vs140/codesnippet/CPP/cprogressctrl-class_5.h)]  
  
### Example  
 The following code example starts and stops the marquee scrolling animation.  
  
 [!code[NVC_MFC_CProgressCtrl_s1#2](../vs140/codesnippet/CPP/cprogressctrl-class_11.cpp)]  
  
##  \<a name="cprogressctrl__setpos">\</a>  CProgressCtrl::SetPos  
 Sets the progress bar control's current position as specified by <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> and redraws the bar to reflect the new position.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
 New position of the progress bar control.  
  
### Return Value  
 The previous position of the progress bar control.  
  
### Remarks  
 The position of the progress bar control is not the physical location on the screen, but rather is between the upper and lower range indicated in [SetRange](#cprogressctrl__setrange).  
  
### Example  
 [!code[NVC_MFC_CProgressCtrl#7](../vs140/codesnippet/CPP/cprogressctrl-class_12.cpp)]  
  
##  \<a name="cprogressctrl__setrange">\</a>  CProgressCtrl::SetRange  
 Sets the upper and lower limits of the progress bar control's range and redraws the bar to reflect the new ranges.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
 Specifies the lower limit of the range (default is zero).  
  
 <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
 Specifies the upper limit of the range (default is 100).  
  
### Remarks  
 The member function <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> sets the 32-bit range for the progress control.  
  
### Example  
 [!code[NVC_MFC_CProgressCtrl#8](../vs140/codesnippet/CPP/cprogressctrl-class_13.cpp)]  
  
##  \<a name="cprogressctrl__setstate">\</a>  CProgressCtrl::SetState  
 Sets the state of the current progress bar control.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>|The state to set the progress bar. Use one of the following values:\<br />\<br /> -   <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> - In progress\<br />-   <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> - Error\<br />-   <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> - Paused|  
  
### Return Value  
 The previous state of the current progress bar control.  
  
### Remarks  
 This method sends the                         [PBM_SETSTATE](http://msdn.microsoft.com/library/windows/desktop/bb760850) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 The following code example defines the variable, <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>, that is used to programmatically access the progress bar control. This variable is used in the next example.  
  
 [!code[NVC_MFC_CProgressCtrl_s1#9](../vs140/codesnippet/CPP/cprogressctrl-class_5.h)]  
  
### Example  
 The following code example sets the state of the current progress bar control to Paused or In Progress.  
  
 [!code[NVC_MFC_CProgressCtrl_s1#4](../vs140/codesnippet/CPP/cprogressctrl-class_14.cpp)]  
  
##  \<a name="cprogressctrl__setstep">\</a>  CProgressCtrl::SetStep  
 Specifies the step increment for a progress bar control.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 *nStep*  
 New step increment.  
  
### Return Value  
 The previous step increment.  
  
### Remarks  
 The step increment is the amount by which a call to <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> increases the progress bar's current position.  
  
 The default step increment is 10.  
  
### Example  
 [!code[NVC_MFC_CProgressCtrl#9](../vs140/codesnippet/CPP/cprogressctrl-class_15.cpp)]  
  
##  \<a name="cprogressctrl__stepit">\</a>  CProgressCtrl::StepIt  
 Advances the current position for a progress bar control by the step increment and redraws the bar to reflect the new position.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Return Value  
 The previous position of the progress bar control.  
  
### Remarks  
 The step increment is set by the <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> member function.  
  
### Example  
 [!code[NVC_MFC_CProgressCtrl#10](../vs140/codesnippet/CPP/cprogressctrl-class_16.cpp)]  
  
## See Also  
 [MFC Sample CMNCTRL2](../vs140/visual-c---samples.md)   
 [Base Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)