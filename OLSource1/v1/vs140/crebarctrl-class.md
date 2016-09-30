---
title: "CReBarCtrl Class"
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
  - "CReBarCtrl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "rebar controls, control bar"
  - "rebar controls, CReBarCtrl class"
  - "CReBarCtrl class"
ms.assetid: 154570d7-e48c-425d-8c7e-c64542bcb4cc
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CReBarCtrl Class
Encapsulates the functionality of a rebar control, which is a container for a child window.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CReBarCtrl::CReBarCtrl](#crebarctrl__crebarctrl)|Constructs a <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CReBarCtrl::BeginDrag](#crebarctrl__begindrag)|Places the rebar control into drag-and-drop mode.|  
|[CReBarCtrl::Create](#crebarctrl__create)|Creates the rebar control and attaches it to the <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> object.|  
|[CReBarCtrl::CreateEx](#crebarctrl__createex)|Creates a rebar control with the specified Windows extended styles and attaches it to a <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> object.|  
|[CReBarCtrl::DeleteBand](#crebarctrl__deleteband)|Deletes a band from a rebar control.|  
|[CReBarCtrl::DragMove](#crebarctrl__dragmove)|Updates the drag position in the rebar control after a call to <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>.|  
|[CReBarCtrl::EndDrag](#crebarctrl__enddrag)|Terminates the rebar control's drag-and-drop operation.|  
|[CReBarCtrl::GetBandBorders](#crebarctrl__getbandborders)|Retrieves the borders of a band.|  
|[CReBarCtrl::GetBandCount](#crebarctrl__getbandcount)|Retrieves the count of bands currently in the rebar control.|  
|[CReBarCtrl::GetBandInfo](#crebarctrl__getbandinfo)|Retrieves information about a specified band in a rebar control.|  
|[CReBarCtrl::GetBandMargins](#crebarctrl__getbandmargins)|Retrieves the margins of a band.|  
|[CReBarCtrl::GetBarHeight](#crebarctrl__getbarheight)|Retrieves the height of the rebar control.|  
|[CReBarCtrl::GetBarInfo](#crebarctrl__getbarinfo)|Retrieves information about the rebar control and the image list it uses.|  
|[CReBarCtrl::GetBkColor](#crebarctrl__getbkcolor)|Retrieves a rebar control's default background color.|  
|[CReBarCtrl::GetColorScheme](#crebarctrl__getcolorscheme)|Retrieves the                                         [COLORSCHEME](http://msdn.microsoft.com/library/windows/desktop/bb775502) structure associated with the rebar control.|  
|[CReBarCtrl::GetDropTarget](#crebarctrl__getdroptarget)|Retrieves a rebar control's <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> interface pointer.|  
|[CReBarCtrl::GetExtendedStyle](#crebarctrl__getextendedstyle)|Gets the extended style of the current rebar control.|  
|[CReBarCtrl::GetImageList](#crebarctrl__getimagelist)|Retrieves the image list associated with a rebar control.|  
|[CReBarCtrl::GetPalette](#crebarctrl__getpalette)|Retrieves the rebar control's current palette.|  
|[CReBarCtrl::GetRect](#crebarctrl__getrect)|Retrieves the bounding rectangle for a given band in a rebar control.|  
|[CReBarCtrl::GetRowCount](#crebarctrl__getrowcount)|Retrieves the number of band rows in a rebar control.|  
|[CReBarCtrl::GetRowHeight](#crebarctrl__getrowheight)|Retrieves the height of a specified row in a rebar control.|  
|[CReBarCtrl::GetTextColor](#crebarctrl__gettextcolor)|Retrieves a rebar control's default text color.|  
|[CReBarCtrl::GetToolTips](#crebarctrl__gettooltips)|Retrieves the handle to any tool tip control associated with the rebar control.|  
|[CReBarCtrl::HitTest](#crebarctrl__hittest)|Determines which portion of a rebar band is at a given point on the screen, if a rebar band exists at that point.|  
|[CReBarCtrl::IDToIndex](#crebarctrl__idtoindex)|Converts a band identifier (ID) to a band index in a rebar control.|  
|[CReBarCtrl::InsertBand](#crebarctrl__insertband)|Inserts a new band in a rebar control.|  
|[CReBarCtrl::MaximizeBand](#crebarctrl__maximizeband)|Resizes a band in a rebar control to its largest size.|  
|[CReBarCtrl::MinimizeBand](#crebarctrl__minimizeband)|Resizes a band in a rebar control to its smallest size.|  
|[CReBarCtrl::MoveBand](#crebarctrl__moveband)|Moves a band from one index to another.|  
|[CReBarCtrl::PushChevron](#crebarctrl__pushchevron)|Programmatically pushes a chevron.|  
|[CReBarCtrl::RestoreBand](#crebarctrl__restoreband)|Resizes a band in a rebar control to its ideal size.|  
|[CReBarCtrl::SetBandInfo](#crebarctrl__setbandinfo)|Sets characteristics of an existing band in a rebar control.|  
|[CReBarCtrl::SetBandWidth](#crebarctrl__setbandwidth)|Sets the width of the specified docked band in the current rebar control.|  
|[CReBarCtrl::SetBarInfo](#crebarctrl__setbarinfo)|Sets the characteristics of a rebar control.|  
|[CReBarCtrl::SetBkColor](#crebarctrl__setbkcolor)|Sets a rebar control's default background color.|  
|[CReBarCtrl::SetColorScheme](#crebarctrl__setcolorscheme)|Sets the color scheme for the buttons on a rebar control.|  
|[CReBarCtrl::SetExtendedStyle](#crebarctrl__setextendedstyle)|Sets the extended styles for the current rebar control.|  
|[CReBarCtrl::SetImageList](#crebarctrl__setimagelist)|Sets a rebar control's image list.|  
|[CReBarCtrl::SetOwner](#crebarctrl__setowner)|Sets a rebar control's owner window.|  
|[CReBarCtrl::SetPalette](#crebarctrl__setpalette)|Sets the rebar control's current palette.|  
|[CReBarCtrl::SetTextColor](#crebarctrl__settextcolor)|Sets a rebar control's default text color.|  
|[CReBarCtrl::SetToolTips](#crebarctrl__settooltips)|Associates a tool tip control with the rebar control.|  
|[CReBarCtrl::SetWindowTheme](#crebarctrl__setwindowtheme)|Sets the visual style of the rebar control.|  
|[CReBarCtrl::ShowBand](#crebarctrl__showband)|Shows or hides a given band in a rebar control.|  
|[CReBarCtrl::SizeToRect](#crebarctrl__sizetorect)|Fits a rebar control to a specified rectangle.|  
  
## Remarks  
 The application in which the rebar control resides assigns the child window contained by the rebar control to the rebar band. The child window is usually another common control.  
  
 Rebar controls contain one or more bands. Each band can contain a combination of a gripper bar, a bitmap, a text label, and a child window. The band can contain only one of each of these items.  
  
 The rebar control can display the child window over a specified background bitmap. All rebar control bands can be resized, except those that use the **RBBS_FIXEDSIZE** style. As you reposition or resize a rebar control band, the rebar control manages the size and position of the child window assigned to that band. To resize or change the order of bands within the control, click and drag a band's gripper bar.  
  
 The following illustration shows a rebar control that has three bands:  
  
-   Band 0 contains a flat, transparent toolbar control.  
  
-   Band 1 contains both transparent standard and transparent dropdown buttons.  
  
-   Band 2 contains a combo box and four standard buttons.  
  
     ![Example of a Rebar menu](../vs140/media/vc4scc1.gif "vc4SCC1")  
  
## Rebar control  
 Rebar controls support:  
  
-   Image lists.  
  
-   Message-handling.  
  
-   Custom draw functionality.  
  
-   A variety of control styles in addition to standard window styles. For a list of these styles, see                                 [Rebar Control Styles](http://msdn.microsoft.com/library/windows/desktop/bb774377) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 For more information, see [Using CReBarCtrl](../vs140/using-crebarctrl.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxcmn.h  
  
##  \<a name="crebarctrl__begindrag">\</a>  CReBarCtrl::BeginDrag  
 Implements the behavior of the Win32 message                 [RB_BEGINDRAG](http://msdn.microsoft.com/library/windows/desktop/bb774429), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 Zero-based index of the band that the drag-and-drop operation will affect.  
  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> value that contains the starting mouse coordinates. The horizontal coordinate is contained in the LOWORD and the vertical coordinate is contained in the HIWORD. If you pass <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>, the rebar control will use the position of the mouse the last time the control's thread called **GetMessage** or **PeekMessage**.  
  
##  \<a name="crebarctrl__create">\</a>  CReBarCtrl::Create  
 Creates the rebar control and attaches it to the <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 Specifies the combination of rebar control styles applied to the control. See                                 [Rebar Control Styles](http://msdn.microsoft.com/library/windows/desktop/bb774377) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for a list of supported styles.  
  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
 A reference to a [CRect](../vs140/crect-class.md) object or                                 [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure, which is the position and size of the rebar control.  
  
 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
 A pointer to a [CWnd](../vs140/cwnd-class.md) object that is the parent window of the rebar control. It must not be **NULL**.  
  
 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
 Specifies the rebar control's control ID.  
  
### Return Value  
 Nonzero if the object was created successfully; otherwise 0.  
  
### Remarks  
 Create a rebar control in two steps:  
  
1.  Call [CReBarCtrl](#crebarctrl__crebarctrl) to construct a <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> object.  
  
2.  Call this member function, which creates the Windows rebar control and attaches it to the <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> object.  
  
 When you call **Create**, the common controls are initialized.  
  
### Example  
 [!code[NVC_MFC_CReBarCtrl#3](../vs140/codesnippet/CPP/crebarctrl-class_1.cpp)]  
  
##  \<a name="crebarctrl__createex">\</a>  CReBarCtrl::CreateEx  
 Creates a control (a child window) and associates it with the <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
 Specifies the extended style of the control being created. For a list of extended Windows styles, see the <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> parameter for                                 [CreateWindowEx](http://msdn.microsoft.com/library/windows/desktop/ms632680) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
 Specifies the combination of rebar control styles applied to the control. For a list of supported styles, see                                 [Rebar Control Styles](http://msdn.microsoft.com/library/windows/desktop/bb774377) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
 A reference to a                                 [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure describing the size and position of the window to be created, in client coordinates of <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
 A pointer to the window that is the control's parent.  
  
 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
 The control's child-window ID.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 Use <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> instead of [Create](#crebarctrl__create) to apply extended Windows styles, specified by the Windows extended style preface **WS_EX_**.  
  
##  \<a name="crebarctrl__crebarctrl">\</a>  CReBarCtrl::CReBarCtrl  
 Creates a <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Example  
  See the example for [CReBarCtrl::Create](#crebarctrl__create).  
  
##  \<a name="crebarctrl__deleteband">\</a>  CReBarCtrl::DeleteBand  
 Implements the behavior of the Win32 message                 [RB_DELETEBAND](http://msdn.microsoft.com/library/windows/desktop/bb774431), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
 Zero-based index of the band to be deleted.  
  
### Return Value  
 Nonzero if the band deleted successfully; otherwise zero.  
  
### Example  
 [!code[NVC_MFC_CReBarCtrl#4](../vs140/codesnippet/CPP/crebarctrl-class_2.cpp)]  
  
##  \<a name="crebarctrl__dragmove">\</a>  CReBarCtrl::DragMove  
 Implements the behavior of the Win32 message                 [RB_DRAGMOVE](https://msdn.microsoft.com/en-us/library/bb774433.aspx), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> value that contains the new mouse coordinates. The horizontal coordinate is contained in the LOWORD and the vertical coordinate is contained in the HIWORD. If you pass <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>, the rebar control will use the position of the mouse the last time the control's thread called **GetMessage** or **PeekMessage**.  
  
##  \<a name="crebarctrl__enddrag">\</a>  CReBarCtrl::EndDrag  
 Implements the behavior of the Win32 message                 [RB_ENDDRAG](http://msdn.microsoft.com/library/windows/desktop/bb774435), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
##  \<a name="crebarctrl__getbandborders">\</a>  CReBarCtrl::GetBandBorders  
 Implements the behavior of the Win32 message                 [RB_GETBANDBORDERS](http://msdn.microsoft.com/library/windows/desktop/bb774437), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
 Zero-based index of the band for which the borders will be retrieved.  
  
 <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
 A pointer to a                                 [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure that will receive the band borders. If the rebar control has the **RBS_BANDBORDERS** style, each member of this structure will receive the number of pixels, on the corresponding side of the band, that constitute the border. If the rebar control does not have the **RBS_BANDBORDERS** style, only the left member of this structure receives valid information. For a description of rebar control styles, see                                 [Rebar Control Styles](http://msdn.microsoft.com/library/windows/desktop/bb774377) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="crebarctrl__getbandcount">\</a>  CReBarCtrl::GetBandCount  
 Implements the behavior of the Win32 message                 [RB_GETBANDCOUNT](http://msdn.microsoft.com/library/windows/desktop/bb774439), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 The number of bands assigned to the control.  
  
##  \<a name="crebarctrl__getbandinfo">\</a>  CReBarCtrl::GetBandInfo  
 Implements the behavior of the Win32 message                 [RB_GETBANDINFO](http://msdn.microsoft.com/library/windows/desktop/bb774451) as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
 Zero-based index of the band for which the information will be retrieved.  
  
 <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
 A pointer to a                                 [REBARBANDINFO](http://msdn.microsoft.com/library/windows/desktop/bb774393) structure to receive the band information. You must set the <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> member of this structure to <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> and set the **fMask** member to the items you want to retrieve before sending this message.  
  
### Return Value  
 Nonzero if successful; otherwise zero.  
  
##  \<a name="crebarctrl__getbandmargins">\</a>  CReBarCtrl::GetBandMargins  
 Retrieves the margins of the band.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 *pMargins*  
 A pointer to a                                 [MARGINS](http://msdn.microsoft.com/library/windows/desktop/bb773244)structure that will receive the information.  
  
### Remarks  
 This member function emulates the functionality of the                         [RB_GETBANDMARGINS](http://msdn.microsoft.com/library/windows/desktop/bb774453) message, as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="crebarctrl__getbarheight">\</a>  CReBarCtrl::GetBarHeight  
 Retrieves the height of the rebar bar.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
 Value that represents the height, in pixels, of the control.  
  
##  \<a name="crebarctrl__getbarinfo">\</a>  CReBarCtrl::GetBarInfo  
 Implements the behavior of the Win32 message                 [RB_GETBARINFO](http://msdn.microsoft.com/library/windows/desktop/bb774457), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
 A pointer to a                                 [REBARINFO](http://msdn.microsoft.com/library/windows/desktop/bb774395) structure that will receive the rebar control information. You must set the <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> member of this structure to <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> before sending this message.  
  
### Return Value  
 Nonzero if successful; otherwise zero.  
  
##  \<a name="crebarctrl__getbkcolor">\</a>  CReBarCtrl::GetBkColor  
 Implements the behavior of the Win32 message                 [RB_GETBKCOLOR](http://msdn.microsoft.com/library/windows/desktop/bb774459), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Return Value  
 A **COLORREF** value that represent the current default background color.  
  
##  \<a name="crebarctrl__getcolorscheme">\</a>  CReBarCtrl::GetColorScheme  
 Retrieves the                 [COLORSCHEME](http://msdn.microsoft.com/library/windows/desktop/bb775502) structure for the rebar control.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  
 A pointer to a                                 [COLORSCHEME](http://msdn.microsoft.com/library/windows/desktop/bb775502) structure, as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Return Value  
 Nonzero if successful; otherwise zero.  
  
### Remarks  
 The **COLORSCHEME** structure includes the button highlight color and the button shadow color.  
  
##  \<a name="crebarctrl__getdroptarget">\</a>  CReBarCtrl::GetDropTarget  
 Implements the behavior of the Win32 message                 [RB_GETDROPTARGET](http://msdn.microsoft.com/library/windows/desktop/bb774463), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to an                         [IDropTarget](http://msdn.microsoft.com/library/windows/desktop/ms679679) interface.  
  
##  \<a name="crebarctrl__getextendedstyle">\</a>  CReBarCtrl::GetExtendedStyle  
 Gets the extended styles of the current rebar control.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Return Value  
 A bitwise combination (OR) of flags that indicate the extended styles. The possible flags are <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>. For more information, see the <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> parameter of the [CReBarCtrl::SetExtendedStyle](#crebarctrl__setextendedstyle) method.  
  
### Remarks  
 This method sends the                         [RB_GETEXTENDEDSTYLE](http://msdn.microsoft.com/library/windows/desktop/bb774433) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="crebarctrl__getimagelist">\</a>  CReBarCtrl::GetImageList  
 Gets the <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> object associated with a rebar control.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to a [CImageList](../vs140/cimagelist-class.md) object. Returns **NULL** if no image list is set for the control.  
  
### Remarks  
 This member function uses size and mask information stored in the                         [REBARINFO](http://msdn.microsoft.com/library/windows/desktop/bb774395) structure, as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="crebarctrl__getpalette">\</a>  CReBarCtrl::GetPalette  
 Retrieves the rebar control's current palette.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to a [CPalette](../vs140/cpalette-class.md) object specifying the rebar control's current palette.  
  
### Remarks  
 Note that this member function uses a <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> object as its return value, rather than an <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>.  
  
### Example  
 [!code[NVC_MFC_CReBarCtrl#5](../vs140/codesnippet/CPP/crebarctrl-class_3.cpp)]  
  
##  \<a name="crebarctrl__getrect">\</a>  CReBarCtrl::GetRect  
 Implements the behavior of the Win32 message                 [RB_GETRECT](http://msdn.microsoft.com/library/windows/desktop/bb774469), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>  
 Zero-based index of a band in the rebar control.  
  
 <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>  
 A pointer to a                                 [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure that will receive the bounds of the rebar band.  
  
### Return Value  
 Nonzero if successful; otherwise zero.  
  
### Example  
 [!code[NVC_MFC_CReBarCtrl#6](../vs140/codesnippet/CPP/crebarctrl-class_4.cpp)]  
  
##  \<a name="crebarctrl__getrowcount">\</a>  CReBarCtrl::GetRowCount  
 Implements the behavior of the Win32 message                 [RB_GETROWCOUNT](http://msdn.microsoft.com/library/windows/desktop/bb774471), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Return Value  
 A **UINT** value that represents the number of band rows in the control.  
  
### Example  
 [!code[NVC_MFC_CReBarCtrl#7](../vs140/codesnippet/CPP/crebarctrl-class_5.cpp)]  
  
##  \<a name="crebarctrl__getrowheight">\</a>  CReBarCtrl::GetRowHeight  
 Implements the behavior of the Win32 message                 [RB_GETROWHEIGHT](http://msdn.microsoft.com/library/windows/desktop/bb774473), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 *uRow*  
 Zero-based index of the band that will have its height retrieved.  
  
### Return Value  
 A **UINT** value that represents the row height, in pixels.  
  
### Example  
 [!code[NVC_MFC_CReBarCtrl#8](../vs140/codesnippet/CPP/crebarctrl-class_6.cpp)]  
  
##  \<a name="crebarctrl__gettextcolor">\</a>  CReBarCtrl::GetTextColor  
 Implements the behavior of the Win32 message                 [RB_GETTEXTCOLOR](http://msdn.microsoft.com/library/windows/desktop/bb774475), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Return Value  
 A **COLORREF** value that represent the current default text color.  
  
##  \<a name="crebarctrl__gettooltips">\</a>  CReBarCtrl::GetToolTips  
 Implements the behavior of the Win32 message                 [RB_GETTOOLTIPS](http://msdn.microsoft.com/library/windows/desktop/bb774477), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to a [CToolTipCtrl](../vs140/ctooltipctrl-class.md) object.  
  
### Remarks  
 Note that the MFC implementation of <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> returns a pointer to a <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>, rather than an <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>.  
  
##  \<a name="crebarctrl__hittest">\</a>  CReBarCtrl::HitTest  
 Implements the behavior of the Win32 message                 [RB_HITTEST](http://msdn.microsoft.com/library/windows/desktop/bb774494), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
 *prbht*  
 A pointer to a                                 [RBHITTESTINFO](http://msdn.microsoft.com/library/windows/desktop/bb774391) structure. Before sending the message, the **pt** member of this structure must be initialized to the point that will be tested, in client coordinates.  
  
### Return Value  
 The zero-based index of the band at the given point, or -1 if no rebar band was at the point.  
  
##  \<a name="crebarctrl__idtoindex">\</a>  CReBarCtrl::IDToIndex  
 Implements the behavior of the Win32 message                 [RB_IDTOINDEX](http://msdn.microsoft.com/library/windows/desktop/bb774496), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Parameters  
 *uBandID*  
 The application-defined identifier of the specified band, passed in the **wID** member of the                                 [REBARBANDINFO](http://msdn.microsoft.com/library/windows/desktop/bb774393) structure when the band is inserted.  
  
### Return Value  
 The zero-based band index if successful, or -1 otherwise. If duplicate band indices exist, the first one is returned.  
  
##  \<a name="crebarctrl__insertband">\</a>  CReBarCtrl::InsertBand  
 Implements the behavior of the Win32 message                 [RB_INSERTBAND](http://msdn.microsoft.com/library/windows/desktop/bb774498), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Parameters  
 *uIndex*  
 Zero-based index of the location where the band will be inserted. If you set this parameter to -1, the control will add the new band at the last location.  
  
 <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>  
 A pointer to a                                 [REBARBANDINFO](http://msdn.microsoft.com/library/windows/desktop/bb774393) structure that defines the band to be inserted. You must set the <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> member of this structure to <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> before calling this function.  
  
### Return Value  
 Nonzero if successful; otherwise zero.  
  
### Example  
 [!code[NVC_MFC_CReBarCtrl#9](../vs140/codesnippet/CPP/crebarctrl-class_7.cpp)]  
  
##  \<a name="crebarctrl__maximizeband">\</a>  CReBarCtrl::MaximizeBand  
 Resizes a band in a rebar control to its largest size.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>  
 Zero-based index of the band to be maximized.  
  
### Remarks  
 Implements the behavior of the Win32 message                         [RB_MAXIMIZEBAND](http://msdn.microsoft.com/library/windows/desktop/bb774500) with <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> set to 0, as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 [!code[NVC_MFC_CReBarCtrl#10](../vs140/codesnippet/CPP/crebarctrl-class_8.cpp)]  
  
##  \<a name="crebarctrl__minimizeband">\</a>  CReBarCtrl::MinimizeBand  
 Resizes a band in a rebar control to its smallest size.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>  
 Zero-based index of the band to be minimized.  
  
### Remarks  
 Implements the behavior of the Win32 message                         [RB_MINIMIZEBAND](http://msdn.microsoft.com/library/windows/desktop/bb774502), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 [!code[NVC_MFC_CReBarCtrl#11](../vs140/codesnippet/CPP/crebarctrl-class_9.cpp)]  
  
##  \<a name="crebarctrl__moveband">\</a>  CReBarCtrl::MoveBand  
 Implements the behavior of the Win32 message                 [RB_MOVEBAND](http://msdn.microsoft.com/library/windows/desktop/bb774504), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Parameters  
 *uFrom*  
 Zero-based index of the band to be moved.  
  
 *uTo*  
 Zero-based index of the new band position. This parameter value must never be greater than the number of bands minus one. To obtain the number of bands, call [GetBandCount](#crebarctrl__getbandcount).  
  
### Return Value  
 Nonzero if successful; otherwise zero.  
  
##  \<a name="crebarctrl__pushchevron">\</a>  CReBarCtrl::PushChevron  
 Implements the behavior of the Win32 message                 [RB_PUSHCHEVRON](http://msdn.microsoft.com/library/windows/desktop/bb774506), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>  
 Zero-based index of the band whose chevron is to be pushed.  
  
 <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>  
 An application defined 32-bit value. See <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> in                                 [RB_PUSHCHEVRON](http://msdn.microsoft.com/library/windows/desktop/bb774506) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="crebarctrl__restoreband">\</a>  CReBarCtrl::RestoreBand  
 Resizes a band in a rebar control to its ideal size.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>  
 Zero-based index of the band to be maximized.  
  
### Remarks  
 Implements the behavior of the Win32 message                         [RB_MAXIMIZEBAND](http://msdn.microsoft.com/library/windows/desktop/bb774500) with <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> set to 1, as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 [!code[NVC_MFC_CReBarCtrl#12](../vs140/codesnippet/CPP/crebarctrl-class_10.cpp)]  
  
##  \<a name="crebarctrl__setbandinfo">\</a>  CReBarCtrl::SetBandInfo  
 Implements the behavior of the Win32 message                 [RB_SETBANDINFO](http://msdn.microsoft.com/library/windows/desktop/bb774508), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>  
 Zero-based index of the band to receive the new settings.  
  
 <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>  
 Pointer to a                                 [REBARBANDINFO](http://msdn.microsoft.com/library/windows/desktop/bb774393) structure that defines the band to be inserted. You must set the <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> member of this structure to <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> before sending this message.  
  
### Return Value  
 Nonzero if successful; otherwise zero.  
  
### Example  
 [!code[NVC_MFC_CReBarCtrl#13](../vs140/codesnippet/CPP/crebarctrl-class_11.cpp)]  
  
##  \<a name="crebarctrl__setbandwidth">\</a>  CReBarCtrl::SetBandWidth  
 Sets the width of the specified docked band in the current rebar control.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>|Zero-based index of a rebar band.|  
|[in] <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>|New width of the rebar band, in pixels.|  
  
### Return Value  
 <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> if the method is successful; otherwise, <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method sends the                         [RB_SETBANDWIDTH](http://msdn.microsoft.com/library/windows/desktop/bb774511) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 The following code example defines the variable, <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>, that is used to access the current rebar control. This variable is used in the next example.  
  
 [!code[NVC_MFC_CReBarCtrl_s1#1](../vs140/codesnippet/CPP/crebarctrl-class_12.h)]  
  
### Example  
 The following code example sets each rebar band to be the same width.  
  
 [!code[NVC_MFC_CReBarCtrl_s1#2](../vs140/codesnippet/CPP/crebarctrl-class_13.cpp)]  
  
##  \<a name="crebarctrl__setbarinfo">\</a>  CReBarCtrl::SetBarInfo  
 Implements the behavior of the Win32 message                 [RB_SETBARINFO](http://msdn.microsoft.com/library/windows/desktop/bb774513), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>  
 A pointer to a                                 [REBARINFO](http://msdn.microsoft.com/library/windows/desktop/bb774395) structure that contains the information to be set. You must set the <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> member of this structure to <CodeContentPlaceHolder>121\</CodeContentPlaceHolder> before sending this message  
  
### Return Value  
 Nonzero if successful; otherwise zero.  
  
### Example  
 [!code[NVC_MFC_CReBarCtrl#14](../vs140/codesnippet/CPP/crebarctrl-class_14.cpp)]  
  
##  \<a name="crebarctrl__setbkcolor">\</a>  CReBarCtrl::SetBkColor  
 Implements the behavior of the Win32 message                 [RB_SETBKCOLOR](http://msdn.microsoft.com/library/windows/desktop/bb774515), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>  
 The **COLORREF** value that represents the new default background color.  
  
### Return Value  
 A                         [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) value that represents the previous default background color.  
  
### Remarks  
 See this topic for more information about when to set the background color, and how to set the default.  
  
##  \<a name="crebarctrl__setcolorscheme">\</a>  CReBarCtrl::SetColorScheme  
 Sets the color scheme for the buttons on a rebar control.  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>  
 A pointer to a                                 [COLORSCHEME](http://msdn.microsoft.com/library/windows/desktop/bb775502) structure, as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Remarks  
 The **COLORSCHEME** structure includes both the button highlight color and the button shadow color.  
  
##  \<a name="crebarctrl__setextendedstyle">\</a>  CReBarCtrl::SetExtendedStyle  
 Sets the extended styles for the current rebar control.  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>|A bitwise combination (OR) of flags that specify which flags in the <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> parameter apply. Use one or more of the following values:\<br />\<br /> RBS_EX_SPLITTER: By default, show the splitter on the bottom in horizontal mode, and to the right in vertical mode.\<br />\<br /> RBS_EX_TRANSPARENT: Forward the                                         [WM_ERASEBKGND](http://msdn.microsoft.com/library/windows/desktop/ms648055) message to the parent window.|  
|[in] <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>|A bitwise combination (OR) of flags that specify the styles to apply. To set a style, specify the same flag that is used in the <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> parameter. To reset a style, specify binary zero.|  
  
### Return Value  
 The previous extended style.  
  
### Remarks  
 This method sends the                         [RB_SETEXTENDEDSTYLE](http://msdn.microsoft.com/library/windows/desktop/bb774519) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="crebarctrl__setimagelist">\</a>  CReBarCtrl::SetImageList  
 Assigns an image list to a rebar control.  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>  
 A pointer to a [CImageList](../vs140/cimagelist-class.md) object containing the image list to be assigned to the rebar control.  
  
### Return Value  
 Nonzero if successful; otherwise zero.  
  
##  \<a name="crebarctrl__setowner">\</a>  CReBarCtrl::SetOwner  
 Implements the behavior of the Win32 message                 [RB_SETPARENT](http://msdn.microsoft.com/library/windows/desktop/bb774522), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>130\</CodeContentPlaceHolder> object to set as the owner of the rebar control.  
  
### Return Value  
 A pointer to a [CWnd](../vs140/cwnd-class.md) object that is the current owner of the rebar control.  
  
### Remarks  
 Note that this member function uses pointers to <CodeContentPlaceHolder>131\</CodeContentPlaceHolder> objects for both the current and selected owner of the rebar control, rather than handles to windows.  
  
> [!NOTE]
>  This member function does not change the actual parent that was set when the control was created; rather it sends notification messages to the window you specify.  
  
##  \<a name="crebarctrl__setpalette">\</a>  CReBarCtrl::SetPalette  
 Implements the behavior of the Win32 message                 [RB_SETPALETTE](http://msdn.microsoft.com/library/windows/desktop/bb774520), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
### Parameters  
 *hPal*  
 An <CodeContentPlaceHolder>132\</CodeContentPlaceHolder> that specifies the new palette that the rebar control will use.  
  
### Return Value  
 A pointer to a [CPalette](../vs140/cpalette-class.md) object specifying the rebar control's previous palette.  
  
### Remarks  
 Note that this member function uses a <CodeContentPlaceHolder>133\</CodeContentPlaceHolder> object as its return value, rather than an <CodeContentPlaceHolder>134\</CodeContentPlaceHolder>.  
  
##  \<a name="crebarctrl__settextcolor">\</a>  CReBarCtrl::SetTextColor  
 Implements the behavior of the Win32 message                 [RB_SETTEXTCOLOR](http://msdn.microsoft.com/library/windows/desktop/bb774524), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>135\</CodeContentPlaceHolder>  
 A **COLORREF** value that represents the new text color in the <CodeContentPlaceHolder>136\</CodeContentPlaceHolder> object.  
  
### Return Value  
 The                         [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) value representing the previous text color associated with the <CodeContentPlaceHolder>137\</CodeContentPlaceHolder> object.  
  
### Remarks  
 It is provided to support text color flexibility in a rebar control.  
  
##  \<a name="crebarctrl__settooltips">\</a>  CReBarCtrl::SetToolTips  
 Associates a tool tip control with a rebar control.  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
### Parameters  
 *pToolTip*  
 A pointer to a [CToolTipCtrl](../vs140/ctooltipctrl-class.md) object  
  
### Remarks  
 You must destroy the <CodeContentPlaceHolder>138\</CodeContentPlaceHolder> object when you are done with it.  
  
##  \<a name="crebarctrl__setwindowtheme">\</a>  CReBarCtrl::SetWindowTheme  
 Sets the visual style of the rebar control.  
  
<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>139\</CodeContentPlaceHolder>  
 A pointer to a Unicode string that contains the rebar visual style to set.  
  
### Return Value  
 The return value is not used.  
  
### Remarks  
 This member function emulates the functionality of the                         [RB_SETWINDOWTHEME](http://msdn.microsoft.com/library/windows/desktop/bb774530) message, as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="crebarctrl__showband">\</a>  CReBarCtrl::ShowBand  
 Implements the behavior of the Win32 message                 [RB_SHOWBAND](http://msdn.microsoft.com/library/windows/desktop/bb774532), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>  
 Zero-based index of a band in the rebar control.  
  
 *fShow*  
 Indicates if the band should be shown or hidden. If this value is **TRUE**, the band will be shown. Otherwise, the band will be hidden.  
  
### Return Value  
 Nonzero if successful; otherwise zero.  
  
##  \<a name="crebarctrl__sizetorect">\</a>  CReBarCtrl::SizeToRect  
 Implements the behavior of the Win32 message                 [RB_SIZETORECT](http://msdn.microsoft.com/library/windows/desktop/bb774534), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>141\</CodeContentPlaceHolder>  
 A reference to a [CRect](../vs140/crect-class.md) object that specifies the rectangle that the rebar control should be sized to.  
  
### Return Value  
 Nonzero if successful; otherwise zero.  
  
### Remarks  
 Note that this member function uses a <CodeContentPlaceHolder>142\</CodeContentPlaceHolder> object as a parameter, rather than a <CodeContentPlaceHolder>143\</CodeContentPlaceHolder> structure.  
  
## See Also  
 [Base Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)