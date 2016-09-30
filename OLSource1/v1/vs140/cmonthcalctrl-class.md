---
title: "CMonthCalCtrl Class"
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
  - "CMonthCalCtrl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "month calendar controls, CMonthCalCtrl class"
  - "common controls, Internet Explorer 4.0"
  - "CMonthCalCtrl class"
  - "Internet Explorer 4.0 common controls"
  - "month calendar controls"
ms.assetid: a42f6bd6-ab5c-4335-82f8-839982fc64a2
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMonthCalCtrl Class
Encapsulates the functionality of a month calendar control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CMonthCalCtrl::CMonthCalCtrl](#cmonthcalctrl__cmonthcalctrl)|Constructs a <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMonthCalCtrl::Create](#cmonthcalctrl__create)|Creates a month calendar control and attaches it to the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> object.|  
|[CMonthCalCtrl::GetCalendarBorder](#cmonthcalctrl__getcalendarborder)|Retrieves the width of the border of the current month calendar control.|  
|[CMonthCalCtrl::GetCalendarCount](#cmonthcalctrl__getcalendarcount)|Retrieves the number of calendars displayed in the current month calendar control.|  
|[CMonthCalCtrl::GetCalendarGridInfo](#cmonthcalctrl__getcalendargridinfo)|Retrieves information about the current month calendar control.|  
|[CMonthCalCtrl::GetCalID](#cmonthcalctrl__getcalid)|Retrieves the calendar identifier for the current month calendar control.|  
|[CMonthCalCtrl::GetColor](#cmonthcalctrl__getcolor)|Gets the color of a specified area of a month calendar control.|  
|[CMonthCalCtrl::GetCurrentView](#cmonthcalctrl__getcurrentview)|Retrieves the view that is currently displayed by the current month calendar control.|  
|[CMonthCalCtrl::GetCurSel](#cmonthcalctrl__getcursel)|Retrieves the system time as indicated by the currently-selected date.|  
|[CMonthCalCtrl::GetFirstDayOfWeek](#cmonthcalctrl__getfirstdayofweek)|Gets the first day of the week to be displayed in the leftmost column of the calendar.|  
|[CMonthCalCtrl::GetMaxSelCount](#cmonthcalctrl__getmaxselcount)|Retrieves the current maximum number of days that can be selected in a month calendar control.|  
|[CMonthCalCtrl::GetMaxTodayWidth](#cmonthcalctrl__getmaxtodaywidth)|Retrieves the maximum width of the "Today" string for the current month calendar control.|  
|[CMonthCalCtrl::GetMinReqRect](#cmonthcalctrl__getminreqrect)|Retrieves the minimum size required to show a full month in a month calendar control.|  
|[CMonthCalCtrl::GetMonthDelta](#cmonthcalctrl__getmonthdelta)|Retrieves the scroll rate for a month calendar control.|  
|[CMonthCalCtrl::GetMonthRange](#cmonthcalctrl__getmonthrange)|Retrieves date information representing the high and low limits of a month calendar control's display.|  
|[CMonthCalCtrl::GetRange](#cmonthcalctrl__getrange)|Retrieves the current minimum and maximum dates set in a month calendar control.|  
|[CMonthCalCtrl::GetSelRange](#cmonthcalctrl__getselrange)|Retrieves date information representing the upper and lower limits of the date range currently selected by the user.|  
|[CMonthCalCtrl::GetToday](#cmonthcalctrl__gettoday)|Retrieves the date information for the date specified as "today" for a month calendar control.|  
|[CMonthCalCtrl::HitTest](#cmonthcalctrl__hittest)|Determines which section of a month calendar control is at a given point on the screen.|  
|[CMonthCalCtrl::IsCenturyView](#cmonthcalctrl__iscenturyview)|Indicates whether the current view of the current month calendar control is the century view.|  
|[CMonthCalCtrl::IsDecadeView](#cmonthcalctrl__isdecadeview)|Indicates whether the current view of the current month calendar control is the decade view.|  
|[CMonthCalCtrl::IsMonthView](#cmonthcalctrl__ismonthview)|Indicates whether the current view of the current month calendar control is the month view.|  
|[CMonthCalCtrl::IsYearView](#cmonthcalctrl__isyearview)|Indicates whether the current view of the current month calendar control is the year view.|  
|[CMonthCalCtrl::SetCalendarBorder](#cmonthcalctrl__setcalendarborder)|Sets the width of the border of the current month calendar control.|  
|[CMonthCalCtrl::SetCalendarBorderDefault](#cmonthcalctrl__setcalendarborderdefault)|Sets the default width of the border of the current month calendar control.|  
|[CMonthCalCtrl::SetCalID](#cmonthcalctrl__setcalid)|Sets the calendar identifier for the current month calendar control.|  
|[CMonthCalCtrl::SetCenturyView](#cmonthcalctrl__setcenturyview)|Sets the current month calendar control to display the century view.|  
|[CMonthCalCtrl::SetColor](#cmonthcalctrl__setcolor)|Sets the color of a specified area of a month calendar control.|  
|[CMonthCalCtrl::SetCurrentView](#cmonthcalctrl__setcurrentview)|Sets the current month calendar control to display the specified view.|  
|[CMonthCalCtrl::SetCurSel](#cmonthcalctrl__setcursel)|Sets the currently selected date for a month calendar control.|  
|[CMonthCalCtrl::SetDayState](#cmonthcalctrl__setdaystate)|Sets the display for days in a month calendar control.|  
|[CMonthCalCtrl::SetDecadeView](#cmonthcalctrl__setdecadeview)|Sets the current month calendar control to the decade view.|  
|[CMonthCalCtrl::SetFirstDayOfWeek](#cmonthcalctrl__setfirstdayofweek)|Sets the day of week to be displayed in the leftmost column of the calendar.|  
|[CMonthCalCtrl::SetMaxSelCount](#cmonthcalctrl__setmaxselcount)|Sets the maximum number of days that can be selected in a month calendar control.|  
|[CMonthCalCtrl::SetMonthDelta](#cmonthcalctrl__setmonthdelta)|Sets the scroll rate for a month calendar control.|  
|[CMonthCalCtrl::SetMonthView](#cmonthcalctrl__setmonthview)|Sets the current month calendar control to display the month view.|  
|[CMonthCalCtrl::SetRange](#cmonthcalctrl__setrange)|Sets the minimum and maximum allowed dates for a month calendar control.|  
|[CMonthCalCtrl::SetSelRange](#cmonthcalctrl__setselrange)|Sets the selection for a month calendar control to a given date range.|  
|[CMonthCalCtrl::SetToday](#cmonthcalctrl__settoday)|Sets the calendar control for the current day.|  
|[CMonthCalCtrl::SetYearView](#cmonthcalctrl__setyearview)|Sets the current month calendar control to year view.|  
|[CMonthCalCtrl::SizeMinReq](#cmonthcalctrl__sizeminreq)|Repaints the month calendar control to its minimum, one-month size.|  
|[CMonthCalCtrl::SizeRectToMin](#cmonthcalctrl__sizerecttomin)|For the current month calendar control, calculates the smallest rectangle that can contain all the calendars that fit in a specified rectangle.|  
  
## Remarks  
 The month calendar control provides the user with a simple calendar interface, from which the user can select a date. The user can change the display by:  
  
-   Scrolling backward and forward, from month to month.  
  
-   Clicking the Today text to display the current day (if the **MCS_NOTODAY** style is not used).  
  
-   Picking a month or a year from a pop-up menu.  
  
 You can customize the month calendar control by applying a variety of styles to the object when you create it. These styles are described in                 [Month Calendar Control Styles](http://msdn.microsoft.com/library/windows/desktop/bb760919) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 The month calendar control can display more than one month, and it can indicate special days (such as holidays) by bolding the date.  
  
 For more information on using the month calendar control, see [Using CMonthCalCtrl](../vs140/using-cmonthcalctrl.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxdtctl.h  
  
##  \<a name="cmonthcalctrl__cmonthcalctrl">\</a>  CMonthCalCtrl::CMonthCalCtrl  
 Constructs a <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 You must call **Create** after you construct the object.  
  
##  \<a name="cmonthcalctrl__create">\</a>  CMonthCalCtrl::Create  
 Creates a month calendar control and attaches it to the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
 Specifies the combination of Windows styles applied to the month calendar control. See                                 [Month Calendar Control Styles](http://msdn.microsoft.com/library/windows/desktop/bb760919) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information about the styles.  
  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
 A reference to a                                 [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure. Contains the position and size of the month calendar control.  
  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 A reference to a                                 [POINT](http://msdn.microsoft.com/library/windows/desktop/dd162805) structure that identifies the location of the month calendar control.  
  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 A pointer to a [CWnd](../vs140/cwnd-class.md) object that is the parent window of the month calendar control. It must not be **NULL**.  
  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
 Specifies the month calendar control's control ID.  
  
### Return Value  
 Nonzero if initialization was successful; otherwise 0.  
  
### Remarks  
 Create a month calendar control in two steps:  
  
1.  Call [CMonthCalCtrl](../vs140/cmonthcalctrl-class.md) to construct a <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> object.  
  
2.  Call this member function, which creates a month calendar control and attaches it to the <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> object.  
  
 When you call **Create**, the common controls are initialized. The version of **Create** you call determines how it is sized:  
  
-   To have MFC automatically size the control to one month, call the override that uses the <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> parameter.  
  
-   To size the control yourself, call the override of this function that uses the <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> parameter.  
  
### Example  
 [!code[NVC_MFC_CMonthCalCtrl#1](../vs140/codesnippet/CPP/cmonthcalctrl-class_1.cpp)]  
  
##  \<a name="cmonthcalctrl__getcalendarborder">\</a>  CMonthCalCtrl::GetCalendarBorder  
 Retrieves the width of the border of the current month calendar control.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 The width of the control border, in pixels.  
  
### Remarks  
 This method sends the                         [MCM_GETCALENDARBORDER](http://msdn.microsoft.com/library/windows/desktop/bb760945) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cmonthcalctrl__getcalendarcount">\</a>  CMonthCalCtrl::GetCalendarCount  
 Retrieves the number of calendars displayed in the current month calendar control.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 The number of calendars currently displayed in the month calendar control. The maximum allowed number of calendars is 12.  
  
### Remarks  
 This method sends the                         [MCM_GETCALENDARCOUNT](http://msdn.microsoft.com/library/windows/desktop/bb760947) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cmonthcalctrl__getcalendargridinfo">\</a>  CMonthCalCtrl::GetCalendarGridInfo  
 Retrieves information about the current month calendar control.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[out] <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>|Pointer to a                                         [MCGRIDINFO](http://msdn.microsoft.com/library/windows/desktop/bb760925) structure that receives information about the current month calendar control. The caller is responsible for allocating and initializing this structure.|  
  
### Return Value  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> if this method is successful; otherwise, <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method sends the                         [MCM_GETCALENDARGRIDINFO](http://msdn.microsoft.com/library/windows/desktop/bb760949) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 The following code example defines the variable, <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>, that is used to programmatically access the month calendar control. This variable is used in the next example.  
  
 [!code[NVC_MFC_CMonthCalCtrl_s1#9](../vs140/codesnippet/CPP/cmonthcalctrl-class_2.h)]  
  
### Example  
 The following code example uses the <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> method to retrieve the calendar date that the current month calendar control displays.  
  
 [!code[NVC_MFC_CMonthCalCtrl_s1#3](../vs140/codesnippet/CPP/cmonthcalctrl-class_3.cpp)]  
  
##  \<a name="cmonthcalctrl__getcalid">\</a>  CMonthCalCtrl::GetCalID  
 Retrieves the calendar identifier for the current month calendar control.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 One of the                         [calendar identifier](http://msdn.microsoft.com/library/windows/desktop/dd317732) constants.  
  
### Remarks  
 A calendar identifier denotes a region-specific calendar, such as the Gregorian (localized), Japanese, or Hijri calendars. Your application can use a calendar identifier that has various language support functions.  
  
 This method sends the                         [MCM_GETCALID](http://msdn.microsoft.com/library/windows/desktop/bb760951) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cmonthcalctrl__getcolor">\</a>  CMonthCalCtrl::GetColor  
 Retrieves the color of an area of the month calendar control specified by <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
 The region of the month calendar control from which the color is retrieved. For a list of values, see the <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> parameter of [SetColor](#cmonthcalctrl__setcolor).  
  
### Return Value  
 A                         [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) value specifying the color associated with the portion of the month calendar control, if successful. Otherwise, this member function returns -1.  
  
##  \<a name="cmonthcalctrl__getcurrentview">\</a>  CMonthCalCtrl::GetCurrentView  
 Retrieves the view that is currently displayed by the current month calendar control.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 The current view, which is indicated by one of the following values:  
  
|Value|Meaning|  
|-----------|-------------|  
|<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>|Monthly view|  
|<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>|Annual view|  
|<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>|Decade view|  
|<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>|Century view|  
  
### Remarks  
 This method sends the                         [MCM_GETCURRENTVIEW](http://msdn.microsoft.com/library/windows/desktop/bb760955) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 The following code example defines the variable, <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>, that is used to programmatically access the month calendar control. This variable is used in the next example.  
  
 [!code[NVC_MFC_CMonthCalCtrl_s1#9](../vs140/codesnippet/CPP/cmonthcalctrl-class_2.h)]  
  
### Example  
 The following code example reports which view the month calendar control currently displays.  
  
 [!code[NVC_MFC_CMonthCalCtrl_s1#7](../vs140/codesnippet/CPP/cmonthcalctrl-class_4.cpp)]  
  
##  \<a name="cmonthcalctrl__getcursel">\</a>  CMonthCalCtrl::GetCurSel  
 Retrieves the system time as indicated by the currently-selected date.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
 A reference to a [COleDateTime](../vs140/coledatetime-class.md) object or a [CTime](../vs140/ctime-class.md) object. Receives the current time.  
  
 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
 A pointer to a                                 [SYSTEMTIME](http://msdn.microsoft.com/library/windows/desktop/ms724950) structure that will receive the currently-selected date information. This parameter must be a valid address and cannot be **NULL**.  
  
### Return Value  
 Nonzero if successful; otherwize 0.  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [MCM_GETCURSEL](http://msdn.microsoft.com/library/windows/desktop/bb760957), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
> [!NOTE]
>  This member function fails if the style **MCS_MULTISELECT** is set.  
  
 In MFC's implementation of <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>, you can specify a <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> usage, a <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> usage, or a <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> structure usage.  
  
##  \<a name="cmonthcalctrl__getfirstdayofweek">\</a>  CMonthCalCtrl::GetFirstDayOfWeek  
 Gets the first day of the week to be displayed in the leftmost column of the calendar.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 *pbLocal*  
 A pointer to a **BOOL** value. If the value is non-zero, the control's setting does not match the setting in the control panel.  
  
### Return Value  
 An integer value that represents the first day of the week. See **Remarks** for more information on what these integers represent.  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [MCM_GETFIRSTDAYOFWEEK](http://msdn.microsoft.com/library/windows/desktop/bb760958), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. The days of the week are represented as integers, as follows.  
  
|Value|Day of the week|  
|-----------|---------------------|  
|0|Monday|  
|1|Tuesday|  
|2|Wednesday|  
|3|Thursday|  
|4|Friday|  
|5|Saturday|  
|6|Sunday|  
  
### Example  
  See the example for [CMonthCalCtrl::SetFirstDayOfWeek](#cmonthcalctrl__setfirstdayofweek).  
  
##  \<a name="cmonthcalctrl__getmaxselcount">\</a>  CMonthCalCtrl::GetMaxSelCount  
 Retrieves the current maximum number of days that can be selected in a month calendar control.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 An integer value that represents the total number of days that can be selected for the control.  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [MCM_GETMAXSELCOUNT](http://msdn.microsoft.com/library/windows/desktop/bb760960), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. Use this member function for controls with the **MCS_MULTISELECT** style set.  
  
### Example  
  See the example for [CMonthCalCtrl::SetMaxSelCount](#cmonthcalctrl__setmaxselcount).  
  
##  \<a name="cmonthcalctrl__getmaxtodaywidth">\</a>  CMonthCalCtrl::GetMaxTodayWidth  
 Retrieves the maximum width of the "Today" string for the current month calendar control.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
 The width of the "Today" string, in pixels.  
  
### Example  
 The following code example defines the variable, <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>, that is used to programmatically access the month calendar control. This variable is used in the next example.  
  
 [!code[NVC_MFC_CMonthCalCtrl_s1#9](../vs140/codesnippet/CPP/cmonthcalctrl-class_2.h)]  
  
### Example  
 The following code example demonstrates the <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> method.  
  
 [!code[NVC_MFC_CMonthCalCtrl_s1#1](../vs140/codesnippet/CPP/cmonthcalctrl-class_5.cpp)]  
  
### Remarks  
 The user can return to the current date by clicking the "Today" string, which is displayed at the bottom of the month calendar control. The "Today" string includes label text and date text.  
  
 This method sends the                         [MCM_GETMAXTODAYWIDTH](http://msdn.microsoft.com/library/windows/desktop/bb760962) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cmonthcalctrl__getminreqrect">\</a>  CMonthCalCtrl::GetMinReqRect  
 Retrieves the minimum size required to show a full month in a month calendar control.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
 A pointer to a                                 [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure that will receive bounding rectangle information. This parameter must be a valid address and cannot be **NULL**.  
  
### Return Value  
 If successful, this member function returns nonzero and <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> receives the applicable bounding information. If unsuccessful, the member function returns 0.  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [MCM_GETMINREQRECT](http://msdn.microsoft.com/library/windows/desktop/bb760978), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cmonthcalctrl__getmonthdelta">\</a>  CMonthCalCtrl::GetMonthDelta  
 Retrieves the scroll rate for a month calendar control.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Return Value  
 The scroll rate for the month calendar control. The scroll rate is the number of months that the control moves its display when the user clicks a scroll button once.  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [MCM_GETMONTHDELTA](http://msdn.microsoft.com/library/windows/desktop/bb760980), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cmonthcalctrl__getmonthrange">\</a>  CMonthCalCtrl::GetMonthRange  
 Retrieves date information representing the high and low limits of a month calendar control's display.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
 A reference to a [COleDateTime](../vs140/coledatetime-class.md) or [CTime](../vs140/ctime-class.md) object containing the minimum date allowed.  
  
 <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
 A reference to a <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> object containing the maximum date allowed.  
  
 <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
 A pointer to a                                 [SYSTEMTIME](http://msdn.microsoft.com/library/windows/desktop/ms724950) structure containing the date at the lowest end of the range.  
  
 <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> structure containing the date at the highest end of the range.  
  
 <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  
 Value specifying the scope of the range limits to be retrieved. This value must be one of the following.  
  
|Value|Meaning|  
|-----------|-------------|  
|GMR_DAYSTATE|Include preceding and trailing months of visible range that are only partially displayed.|  
|GMR_VISIBLE|Include only those months that are entirely displayed.|  
  
### Return Value  
 An integer that represents the range, in months, spanned by the two limits indicated by <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> in the first and second versions, or <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> in the third version.  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [MCM_GETMONTHRANGE](http://msdn.microsoft.com/library/windows/desktop/bb760981), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. In MFC's implementation of <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>, you can specify <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> usage, a <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> usage, or a <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> structure usage.  
  
### Example  
  See the example for [CMonthCalCtrl::SetDayState](#cmonthcalctrl__setdaystate).  
  
##  \<a name="cmonthcalctrl__getrange">\</a>  CMonthCalCtrl::GetRange  
 Retrieves the current minimum and maximum dates set in a month calendar control.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> object, a <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> object, or                                 [SYSTEMTIME](http://msdn.microsoft.com/library/windows/desktop/ms724950) structure containing the date at the lowest end of the range.  
  
 <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> object, a <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> object, or                                 [SYSTEMTIME](http://msdn.microsoft.com/library/windows/desktop/ms724950) structure containing the date at the highest end of the range.  
  
### Return Value  
 A <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> that can be zero (no limits are set) or a combination of the following values that specify limit information.  
  
|Value|Meaning|  
|-----------|-------------|  
|GDTR_MAX|A maximum limit is set for the control; <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> is valid and contains the applicable date information.|  
|GDTR_MIN|A minimum limit is set for the control; <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> is valid and contains the applicable date information.|  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [MCM_GETRANGE](http://msdn.microsoft.com/library/windows/desktop/bb760983), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. In MFC's implementation of <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>, you can specify a <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> usage, a <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> usage, or a <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> structure usage.  
  
### Example  
 [!code[NVC_MFC_CMonthCalCtrl#2](../vs140/codesnippet/CPP/cmonthcalctrl-class_6.cpp)]  
  
##  \<a name="cmonthcalctrl__getselrange">\</a>  CMonthCalCtrl::GetSelRange  
 Retrieves date information representing the upper and lower limits of the date range currently selected by the user.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>  
 A reference to a [COleDateTime](../vs140/coledatetime-class.md) or [CTime](../vs140/ctime-class.md) object containing the minimum date allowed.  
  
 <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>  
 A reference to a <CodeContentPlaceHolder>111\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> object containing the maximum date allowed.  
  
 <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>  
 A pointer to a                                 [SYSTEMTIME](http://msdn.microsoft.com/library/windows/desktop/ms724950) structure containing the date at the lowest end of the range.  
  
 <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> structure containing the date at the highest end of the range.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [MCM_GETSELRANGE](http://msdn.microsoft.com/library/windows/desktop/bb760985), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> will fail if applied to a month calendar control that does not use the **MCS_MULTISELECT** style.  
  
 In MFC's implementation of <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>, you can specify <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> usage, a <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> usage, or a <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> structure usage.  
  
##  \<a name="cmonthcalctrl__gettoday">\</a>  CMonthCalCtrl::GetToday  
 Retrieves the date information for the date specified as "today" for a month calendar control.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>  
 A reference to a [COleDateTime](../vs140/coledatetime-class.md) or [CTime](../vs140/ctime-class.md) object indicating the current day.  
  
 <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>  
 A pointer to a                                 [SYSTEMTIME](http://msdn.microsoft.com/library/windows/desktop/ms724950) structure that will receive the date information. This parameter must be a valid address and cannot be **NULL**.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [MCM_GETTODAY](http://msdn.microsoft.com/library/windows/desktop/bb760987), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. In MFC's implementation of <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>, you can specify a <CodeContentPlaceHolder>124\</CodeContentPlaceHolder> usage, a <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> usage, or a <CodeContentPlaceHolder>126\</CodeContentPlaceHolder> structure usage.  
  
### Example  
 [!code[NVC_MFC_CMonthCalCtrl#3](../vs140/codesnippet/CPP/cmonthcalctrl-class_7.cpp)]  
  
##  \<a name="cmonthcalctrl__hittest">\</a>  CMonthCalCtrl::HitTest  
 Determines which month calendar control, if any, is at a specified position.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 *pMCHitTest*  
 A pointer to a                                 [MCHITTESTINFO](http://msdn.microsoft.com/library/windows/desktop/bb760927) structure containing hit testing points for the month calendar control.  
  
### Return Value  
 A <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> value. Equal to the **uHit** member of the **MCHITTESTINFO** structure.  
  
### Remarks  
 <CodeContentPlaceHolder>128\</CodeContentPlaceHolder> uses the **MCHITTESTINFO** structure, which contains information about the hit test.  
  
##  \<a name="cmonthcalctrl__iscenturyview">\</a>  CMonthCalCtrl::IsCenturyView  
 Indicates whether the current view of the current month calendar control is the century view.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>129\</CodeContentPlaceHolder> if the current view is the century view; otherwise, <CodeContentPlaceHolder>130\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method sends the                         [MCM_GETCURRENTVIEW](http://msdn.microsoft.com/library/windows/desktop/bb760955) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. If that message returns <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>, this method returns <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>.  
  
##  \<a name="cmonthcalctrl__isdecadeview">\</a>  CMonthCalCtrl::IsDecadeView  
 Indicates whether the current view of the current month calendar control is the decade view.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>133\</CodeContentPlaceHolder> if the current view is the decade view; otherwise, <CodeContentPlaceHolder>134\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method sends the                         [MCM_GETCURRENTVIEW](http://msdn.microsoft.com/library/windows/desktop/bb760955) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. If that message returns <CodeContentPlaceHolder>135\</CodeContentPlaceHolder>, this method returns <CodeContentPlaceHolder>136\</CodeContentPlaceHolder>.  
  
##  \<a name="cmonthcalctrl__ismonthview">\</a>  CMonthCalCtrl::IsMonthView  
 Indicates whether the current view of the current month calendar control is the month view.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>137\</CodeContentPlaceHolder> if the current view is the month view; otherwise, <CodeContentPlaceHolder>138\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method sends the                         [MCM_GETCURRENTVIEW](http://msdn.microsoft.com/library/windows/desktop/bb760955) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. If that message returns <CodeContentPlaceHolder>139\</CodeContentPlaceHolder>, this method returns <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>.  
  
##  \<a name="cmonthcalctrl__isyearview">\</a>  CMonthCalCtrl::IsYearView  
 Indicates whether the current view of the current month calendar control is the year view.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>141\</CodeContentPlaceHolder> if the current view is the year view; otherwise, <CodeContentPlaceHolder>142\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method sends the                         [MCM_GETCURRENTVIEW](http://msdn.microsoft.com/library/windows/desktop/bb760955) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. If that message returns <CodeContentPlaceHolder>143\</CodeContentPlaceHolder>, this method returns <CodeContentPlaceHolder>144\</CodeContentPlaceHolder>.  
  
##  \<a name="cmonthcalctrl__setcalendarborder">\</a>  CMonthCalCtrl::SetCalendarBorder  
 Sets the width of the border of the current month calendar control.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>145\</CodeContentPlaceHolder>|The width of the border, in pixels.|  
  
### Remarks  
 If this method succeeds, the border width is set to the <CodeContentPlaceHolder>146\</CodeContentPlaceHolder> parameter. Otherwise, the border width is reset to the default value that is specified by the current [theme](https://msdn.microsoft.com/en-us/library/windows/desktop/hh270423.aspx), or zero if themes are not used.  
  
 This method sends the                         [MCM_SETCALENDARBORDER](http://msdn.microsoft.com/library/windows/desktop/bb760993) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 The following code example defines the variable, <CodeContentPlaceHolder>147\</CodeContentPlaceHolder>, that is used to programmatically access the month calendar control. This variable is used in the next example.  
  
 [!code[NVC_MFC_CMonthCalCtrl_s1#9](../vs140/codesnippet/CPP/cmonthcalctrl-class_2.h)]  
  
### Example  
 The following code example sets the border width of the month calendar control to eight pixels. Use the [CMonthCalCtrl::GetCalendarBorder](#cmonthcalctrl__getcalendarborder) method to determine whether this method succeeded.  
  
 [!code[NVC_MFC_CMonthCalCtrl_s1#6](../vs140/codesnippet/CPP/cmonthcalctrl-class_8.cpp)]  
  
##  \<a name="cmonthcalctrl__setcalendarborderdefault">\</a>  CMonthCalCtrl::SetCalendarBorderDefault  
 Sets the default width of the border of the current month calendar control.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Remarks  
 The border width is set to the default value specified by the current [theme](https://msdn.microsoft.com/en-us/library/windows/desktop/hh270423.aspx), or zero if themes are not used.  
  
 This method sends the                         [MCM_SETCALENDARBORDER](http://msdn.microsoft.com/library/windows/desktop/bb760993) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cmonthcalctrl__setcalid">\</a>  CMonthCalCtrl::SetCalID  
 Sets the calendar identifier for the current month calendar control.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>148\</CodeContentPlaceHolder>|One of the                                         [calendar identifier](http://msdn.microsoft.com/library/windows/desktop/dd317732) constants.|  
  
### Return Value  
 <CodeContentPlaceHolder>149\</CodeContentPlaceHolder> if this method is successful; otherwise, <CodeContentPlaceHolder>150\</CodeContentPlaceHolder>.  
  
### Remarks  
 A calendar identifier specifies a region-specific calendar, such as the Gregorian (localized), Japanese, or Hijri calendars. Use the <CodeContentPlaceHolder>151\</CodeContentPlaceHolder> method to display a calendar that is specified by the <CodeContentPlaceHolder>152\</CodeContentPlaceHolder> parameter if the locale that contains the calendar is installed on your computer.  
  
 This method sends the                         [MCM_SETCALID](http://msdn.microsoft.com/library/windows/desktop/bb760995) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 The following code example defines the variable, <CodeContentPlaceHolder>153\</CodeContentPlaceHolder>, that is used to programmatically access the month calendar control. This variable is used in the next example.  
  
 [!code[NVC_MFC_CMonthCalCtrl_s1#9](../vs140/codesnippet/CPP/cmonthcalctrl-class_2.h)]  
  
### Example  
 The following code example sets the month calendar control to display the Japanese Emperor Era calendar. The <CodeContentPlaceHolder>154\</CodeContentPlaceHolder> method succeeds only if that calendar is installed on your computer.  
  
 [!code[NVC_MFC_CMonthCalCtrl_s1#4](../vs140/codesnippet/CPP/cmonthcalctrl-class_9.cpp)]  
  
##  \<a name="cmonthcalctrl__setcenturyview">\</a>  CMonthCalCtrl::SetCenturyView  
 Sets the current month calendar control to display the century view.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>155\</CodeContentPlaceHolder> if this method is successful; otherwise, <CodeContentPlaceHolder>156\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method uses the [CMonthCalCtrl::SetCurrentView](#cmonthcalctrl__setcurrentview) method to set the view to <CodeContentPlaceHolder>157\</CodeContentPlaceHolder>, which represents the century view.  
  
##  \<a name="cmonthcalctrl__setcolor">\</a>  CMonthCalCtrl::SetColor  
 Sets the color of a specified area of a month calendar control.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>158\</CodeContentPlaceHolder>  
 An integer value specifying which month calendar color to set. This value can be one of the following.  
  
|Value|Meaning|  
|-----------|-------------|  
|MCSC_BACKGROUND|The background color displayed between months.|  
|MCSC_MONTHBK|The background color displayed within the month.|  
|MCSC_TEXT|The color used to display text within a month.|  
|MCSC_TITLEBK|The background color displayed in the calendar's title.|  
|MCSC_TITLETEXT|The color used to display text within the calendar's title.|  
|MCSC_TRAILINGTEXT|The color used to display header and trailing-day text. Header and trailing days are the days from the previous and following months that appear on the current calendar.|  
  
 <CodeContentPlaceHolder>159\</CodeContentPlaceHolder>  
 A **COLORREF** value for the new color setting for the specified portion of the month calendar control.  
  
### Return Value  
 A **COLORREF** value that represents the previous color setting for the specified portion of the month calendar control, if successful. Otherwise this message returns -1.  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [MCM_SETCOLOR](http://msdn.microsoft.com/library/windows/desktop/bb760997), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 [!code[NVC_MFC_CMonthCalCtrl#4](../vs140/codesnippet/CPP/cmonthcalctrl-class_10.cpp)]  
  
##  \<a name="cmonthcalctrl__setcurrentview">\</a>  CMonthCalCtrl::SetCurrentView  
 Sets the current month calendar control to display the specified view.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>160\</CodeContentPlaceHolder>|One of the following values that specifies a monthly, annual, decade, or century view.\<br />\<br /> MCMV_MONTH: Monthly view\<br />\<br /> MCMV_YEAR: Annual view\<br />\<br /> MCMV_DECADE: Decade view\<br />\<br /> MCMV_CENTURY: Century view|  
  
### Return Value  
 <CodeContentPlaceHolder>161\</CodeContentPlaceHolder> if this method is successful; otherwise, <CodeContentPlaceHolder>162\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method sends the                         [MCM_SETCURRENTVIEW](http://msdn.microsoft.com/library/windows/desktop/bb760998) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cmonthcalctrl__setcursel">\</a>  CMonthCalCtrl::SetCurSel  
 Sets the currently selected date for a month calendar control.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>163\</CodeContentPlaceHolder>  
 A reference to a [COleDateTime](../vs140/coledatetime-class.md) or [CTime](../vs140/ctime-class.md) object indicating the currently-selected month calendar control.  
  
 <CodeContentPlaceHolder>164\</CodeContentPlaceHolder>  
 Pointer to a                                 [SYSTEMTIME](http://msdn.microsoft.com/library/windows/desktop/ms724950) structure that contains the date to be set as the current selection.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [MCM_SETCURSEL](http://msdn.microsoft.com/library/windows/desktop/bb761002), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. In MFC's implementation of <CodeContentPlaceHolder>165\</CodeContentPlaceHolder>, you can specify a <CodeContentPlaceHolder>166\</CodeContentPlaceHolder> usage, a <CodeContentPlaceHolder>167\</CodeContentPlaceHolder> usage, or a <CodeContentPlaceHolder>168\</CodeContentPlaceHolder> structure usage.  
  
### Example  
 [!code[NVC_MFC_CMonthCalCtrl#5](../vs140/codesnippet/CPP/cmonthcalctrl-class_11.cpp)]  
  
##  \<a name="cmonthcalctrl__setdaystate">\</a>  CMonthCalCtrl::SetDayState  
 Sets the display for days in a month calendar control.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Parameters  
 *nMonths*  
 Value indicating how many elements are in the array that <CodeContentPlaceHolder>169\</CodeContentPlaceHolder> points to.  
  
 <CodeContentPlaceHolder>170\</CodeContentPlaceHolder>  
 A pointer to a                                 [MONTHDAYSTATE](http://msdn.microsoft.com/library/windows/desktop/bb760915) array of values that define how the month calendar control will draw each day in its display. The **MONTHDAYSTATE** data type is a bit field, where each bit (1 through 31) represents the state of a day in a month. If a bit is on, the corresponding day will be displayed in bold; otherwise it will be displayed with no emphasis.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [MCM_SETDAYSTATE](http://msdn.microsoft.com/library/windows/desktop/bb761004), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 [!code[NVC_MFC_CMonthCalCtrl#6](../vs140/codesnippet/CPP/cmonthcalctrl-class_12.cpp)]  
  
##  \<a name="cmonthcalctrl__setdecadeview">\</a>  CMonthCalCtrl::SetDecadeView  
 Sets the current month calendar control to the decade view.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>171\</CodeContentPlaceHolder> if this method is successful; otherwise, <CodeContentPlaceHolder>172\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method uses the [CMonthCalCtrl::SetCurrentView](#cmonthcalctrl__setcurrentview) method to set the view to <CodeContentPlaceHolder>173\</CodeContentPlaceHolder>, which represents the decade view.  
  
##  \<a name="cmonthcalctrl__setfirstdayofweek">\</a>  CMonthCalCtrl::SetFirstDayOfWeek  
 Sets the day of week to be displayed in the leftmost column of the calendar.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Parameters  
 *iDay*  
 An integer value representing which day is to be set as the first day of the week. This value must be one of the day numbers. See [GetFirstDayOfWeek](#cmonthcalctrl__getfirstdayofweek) for a description of the day numbers.  
  
 *lpnOld*  
 A pointer to an integer indicating the first day of the week previously set.  
  
### Return Value  
 Nonzero if the previous first day of the week is set to a value other than that of **LOCALE_IFIRSTDAYOFWEEK**, which is the day indicated in the control panel setting. Otherwise, this function returns 0.  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [MCM_SETFIRSTDAYOFWEEK](http://msdn.microsoft.com/library/windows/desktop/bb761006), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 [!code[NVC_MFC_CMonthCalCtrl#7](../vs140/codesnippet/CPP/cmonthcalctrl-class_13.cpp)]  
  
##  \<a name="cmonthcalctrl__setmaxselcount">\</a>  CMonthCalCtrl::SetMaxSelCount  
 Sets the maximum number of days that can be selected in a month calendar control.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>174\</CodeContentPlaceHolder>  
 The value that will be set to represent the maximum number of selectable days.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [MCM_SETMAXSELCOUNT](http://msdn.microsoft.com/library/windows/desktop/bb761008), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 [!code[NVC_MFC_CMonthCalCtrl#8](../vs140/codesnippet/CPP/cmonthcalctrl-class_14.cpp)]  
  
##  \<a name="cmonthcalctrl__setmonthdelta">\</a>  CMonthCalCtrl::SetMonthDelta  
 Sets the scroll rate for a month calendar control.  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Parameters  
 *iDelta*  
 The number of months to be set as the control's scroll rate. If this value is zero, the month delta is reset to the default, which is the number of months displayed in the control.  
  
### Return Value  
 The previous scroll rate. If the scroll rate has not been previously set, the return value is 0.  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [MCM_SETMONTHDELTA](http://msdn.microsoft.com/library/windows/desktop/bb761010), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cmonthcalctrl__setmonthview">\</a>  CMonthCalCtrl::SetMonthView  
 Sets the current month calendar control to display the month view.  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>175\</CodeContentPlaceHolder> if this method is successful; otherwise, <CodeContentPlaceHolder>176\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method uses the [CMonthCalCtrl::SetCurrentView](#cmonthcalctrl__setcurrentview) method to set the view to <CodeContentPlaceHolder>177\</CodeContentPlaceHolder>, which represents the month view.  
  
### Example  
 The following code example defines the variable, <CodeContentPlaceHolder>178\</CodeContentPlaceHolder>, that is used to programmatically access the month calendar control. This variable is used in the next example.  
  
 [!code[NVC_MFC_CMonthCalCtrl_s1#9](../vs140/codesnippet/CPP/cmonthcalctrl-class_2.h)]  
  
### Example  
 The following code example sets the month calendar control to display the month, year, decade, and century views.  
  
 [!code[NVC_MFC_CMonthCalCtrl_s1#2](../vs140/codesnippet/CPP/cmonthcalctrl-class_15.cpp)]  
  
##  \<a name="cmonthcalctrl__setrange">\</a>  CMonthCalCtrl::SetRange  
 Sets the minimum and maximum allowable dates for a month calendar control.  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>179\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>180\</CodeContentPlaceHolder> object, a <CodeContentPlaceHolder>181\</CodeContentPlaceHolder> object, or                                 [SYSTEMTIME](http://msdn.microsoft.com/library/windows/desktop/ms724950) structure containing the date at the lowest end of the range.  
  
 <CodeContentPlaceHolder>182\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>183\</CodeContentPlaceHolder> object, a <CodeContentPlaceHolder>184\</CodeContentPlaceHolder> object, or <CodeContentPlaceHolder>185\</CodeContentPlaceHolder> structure containing the date at the highest end of the range.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [MCM_SETRANGE](http://msdn.microsoft.com/library/windows/desktop/bb761012), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. In MFC's implementation of <CodeContentPlaceHolder>186\</CodeContentPlaceHolder>, you can specify <CodeContentPlaceHolder>187\</CodeContentPlaceHolder> usage, a <CodeContentPlaceHolder>188\</CodeContentPlaceHolder> usage, or a <CodeContentPlaceHolder>189\</CodeContentPlaceHolder> structure usage.  
  
### Example  
  See the example for [CMonthCalCtrl::GetRange](#cmonthcalctrl__getrange).  
  
##  \<a name="cmonthcalctrl__setselrange">\</a>  CMonthCalCtrl::SetSelRange  
 Sets the selection for a month calendar control to a given date range.  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>190\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>191\</CodeContentPlaceHolder> object, a <CodeContentPlaceHolder>192\</CodeContentPlaceHolder> object, or                                 [SYSTEMTIME](http://msdn.microsoft.com/library/windows/desktop/ms724950) structure containing the date at the lowest end of the range.  
  
 <CodeContentPlaceHolder>193\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>194\</CodeContentPlaceHolder> object, a <CodeContentPlaceHolder>195\</CodeContentPlaceHolder> object, or <CodeContentPlaceHolder>196\</CodeContentPlaceHolder> structure containing the date at the highest end of the range.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [MCM_SETSELRANGE](http://msdn.microsoft.com/library/windows/desktop/bb761014), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. In MFC's implementation of <CodeContentPlaceHolder>197\</CodeContentPlaceHolder>, you can specify <CodeContentPlaceHolder>198\</CodeContentPlaceHolder> usage, a <CodeContentPlaceHolder>199\</CodeContentPlaceHolder> usage, or a <CodeContentPlaceHolder>200\</CodeContentPlaceHolder> structure usage.  
  
##  \<a name="cmonthcalctrl__settoday">\</a>  CMonthCalCtrl::SetToday  
 Sets the calendar control for the current day.  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>201\</CodeContentPlaceHolder>  
 A reference to a [COleDateTime](../vs140/coledatetime-class.md) object that contains the current date.  
  
 <CodeContentPlaceHolder>202\</CodeContentPlaceHolder>  
 In the second version, a pointer to a [CTime](../vs140/ctime-class.md) object containing the current date information. In the third version, a pointer to a                                 [SYSTEMTIME](http://msdn.microsoft.com/library/windows/desktop/ms724950) structure that contains the current date information.  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [MCM_SETTODAY](http://msdn.microsoft.com/library/windows/desktop/bb761016), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
  See the example for [CMonthCalCtrl::GetToday](#cmonthcalctrl__gettoday).  
  
##  \<a name="cmonthcalctrl__setyearview">\</a>  CMonthCalCtrl::SetYearView  
 Sets the current month calendar control to year view.  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>203\</CodeContentPlaceHolder> if this method is successful; otherwise, <CodeContentPlaceHolder>204\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method uses the [CMonthCalCtrl::SetCurrentView](#cmonthcalctrl__setcurrentview) method to set the view to <CodeContentPlaceHolder>205\</CodeContentPlaceHolder>, which represents the annual view.  
  
##  \<a name="cmonthcalctrl__sizeminreq">\</a>  CMonthCalCtrl::SizeMinReq  
 Displays the month calendar control to the minimum size that displays one month.  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>206\</CodeContentPlaceHolder>  
 Specifies whether the control is to be repainted. By default, **TRUE**. If **FALSE**, no repainting occurs.  
  
### Return Value  
 Nonzero if the month calendar control is sized to its minimum; otherwise 0.  
  
### Remarks  
 Calling <CodeContentPlaceHolder>207\</CodeContentPlaceHolder> successfully displays the entire month calendar control for one month's calendar.  
  
##  \<a name="cmonthcalctrl__sizerecttomin">\</a>  CMonthCalCtrl::SizeRectToMin  
 For the current month calendar control, calculates the smallest rectangle that can contain all the calendars that fit in a specified rectangle.  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>208\</CodeContentPlaceHolder>|Pointer to a                                         [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure that defines a rectangle that contains the desired number of calendars.|  
  
### Return Value  
 Pointer to a                         [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure that defines a rectangle whose size is less than or equal to the rectangle defined by the <CodeContentPlaceHolder>209\</CodeContentPlaceHolder> parameter.  
  
### Remarks  
 This method calculates how many calendars can fit in the rectangle specified by the <CodeContentPlaceHolder>210\</CodeContentPlaceHolder> parameter, and then returns the smallest rectangle that can contain that number of calendars. In effect, this method shrinks the specified rectangle to exactly fit the desired number of calendars.  
  
 This method sends the                         [MCM_SIZERECTTOMIN](http://msdn.microsoft.com/library/windows/desktop/bb761020) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## See Also  
 [MFC Sample CMNCTRL1](../vs140/visual-c---samples.md)   
 [Base Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDateTimeCtrl](../vs140/cdatetimectrl-class.md)